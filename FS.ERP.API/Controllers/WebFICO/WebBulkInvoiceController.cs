using CST.CCL.Helper;
using CST.CCL.Helper.Common;
using CST.CRY;
using FS.CAPI.BAL;
using FS.ERP.API.Models;
using FS.ERP.Models.Custom;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Cors;

namespace FS.ERP.API.Controllers
{
    [Authorize]
    [EnableCors("*", "*", "*")]
    public class WebBulkInvoiceController : ApiController
    {
        public string ConStr { get; set; }
        protected JsonMediaTypeFormatter formatter;

        protected override void Initialize(HttpControllerContext controllerContext)
        {
            string _connStr = controllerContext.Request.GetFirstHeaderValueOrDefault<string>("x-conn", x => "",
                Convert.ToString);
            if (string.IsNullOrEmpty(_connStr))
                throw new UnauthorizedAccessException(
                    "You are not authorized to access this link. Please contact administrator");

            ConStr = Encryptor.Decrypt(AppSettings.PrivateKey, _connStr);
            formatter = new JsonMediaTypeFormatter
            {
                SerializerSettings = { ReferenceLoopHandling = ReferenceLoopHandling.Ignore }
            };
            base.Initialize(controllerContext);
        }

        #region Convert & Generate Invoice

        [HttpPost]
        [Route("~/Api/BulkInvoice/ConvertOrGenerateInvoice")]
        public HttpResponseMessage ConvertOrGenerateInvoice(ConvertAndGenerateInvoice obj)
        {
            try
            {
                DataTable getModel = new DataTable();

                int? companyCode = null;
                var generateFolio = "";

                if (obj.GenerateAndConvert == true)
                {
                    companyCode = GetOppositeCompanyToInvoiceID(obj.ID);
                    generateFolio = GenerateFolioNo(null, 158, "-1", companyCode);
                }

                SpData data = new SpData
                {
                    SpName = "[FICO].CORNConvertOrGenerateInvoice",
                    Parameters = new Dictionary<string, object>
                                  { { "ID", obj.ID },
                                    { "userId", obj.UserId },
                                    { "Folio", generateFolio },
                                    { "companyCode", companyCode },
                                    { "GenerateAndConvert", obj.GenerateAndConvert }
                    }
                };

                getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);

                if (getModel == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                { IsSuccess = true, Message = "Success", Data = getModel }, formatter);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }

        public int GetOppositeCompanyToInvoiceID(long ID)
        {
            int referenceCode = 0;
            try
            {
                SpData data = new SpData
                {
                    SpName = "[FICO].CORNGetOppositeCompanyByInvoiceId",
                    Parameters = new Dictionary<string, object>
                                  { { "ID", ID } }
                };

                var folioDataTable = new CommonRepository(ConStr).ExecStoreProcedure(data);
                if (folioDataTable != null && folioDataTable.Rows.Count > 0)
                {
                    var row = folioDataTable.Rows[0];
                    var columnVal = row["CompanyCode"];

                    if (columnVal != null)
                    {
                        referenceCode = Convert.ToInt32(columnVal);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return referenceCode;
        }

        #endregion

        #region Invoice Report SP

        [HttpGet]
        [Route("~/Api/BulkInvoice/InvoiceRpt")]
        public HttpResponseMessage InvoiceRpt(string invoiceIds, int userID)
        {
            try
            {
                DataTable getModel = new DataTable();

                var invoicesData = GetInvoiceData(invoiceIds, userID);

                if (getModel == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                { IsSuccess = true, Message = "Success", Data = invoicesData }, formatter);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }

        public List<InvoiceMaster> GetInvoiceData(string invoiceIds, int userID)
        {
            List<InvoiceMaster> InvoiceData = new List<InvoiceMaster>();
            try
            {
                    SpData data = new SpData
                    {
                        SpName = "[FICO].[CORNRptSaleInvoiceByIds]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "invoiceIds", invoiceIds },
                            { "userId", userID }
                        }
                    };

                var result = new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<DownloadInvoice>();

                var distinctInvoices = result.GroupBy(x => new { x.TransactionCode }).Select(x => x.FirstOrDefault()).ToList();

                foreach (var item in distinctInvoices)
                {  
                    var master = new InvoiceMaster();
                    master.TransactionCode = item.TransactionCode;
                    master.TransactionDate = item.TransactionDate;
                    master.Address = item.Address;
                    master.Center = item.Center;
                    master.Company = item.Company;
                    master.CompanyAddress = item.CompanyAddress;
                    master.CompanyPhone = item.CompanyPhone;
                    master.ContactPerson = item.ContactPerson;
                    master.Currency = item.Currency;
                    master.Customer = item.Customer;
                    master.ExchangeRate = item.ExchangeRate;
                    master.GST_No = item.GST_No;
                    master.InvoiceGSTAmount = item.InvoiceGSTAmount;
                    master.InvoiceNetAmount = item.InvoiceNetAmount;
                    master.NTN = item.NTN;
                    master.NTN_No = item.NTN_No;
                    master.OfficialPhoneNo = item.OfficialPhoneNo;
                    master.PODate = item.PODate;
                    master.PONumber = item.PONumber;
                    master.Remarks = item.Remarks;
                    master.STRN = item.STRN;
                    master.TaxCode = item.TaxCode;
                    
                    var details = result.Where(x => x.TransactionCode == item.TransactionCode).ToList();

                    master.InvoiceDetails = new List<InvoiceDetail>();
                    foreach (var itm in details)
                    {

                       var detail = new InvoiceDetail();
                        detail.Item = itm.Item;
                        detail.Discount = itm.Discount;
                        detail.Description = itm.Description;
                        detail.GrossAmount = itm.GrossAmount;
                        detail.ItemGSTTax = itm.ItemGSTTax;
                        detail.ItemNetAmount = itm.ItemNetAmount;
                        detail.Qty = itm.Qty;
                        detail.SalePrice = itm.SalePrice;
                        detail.TaxPercentage = itm.TaxPercentage;

                        master.InvoiceDetails.Add(detail);
                    }

                    InvoiceData.Add(master);
                }

                return InvoiceData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region SALE RETURN Report SP

        [HttpGet]
        [Route("~/Api/BulkInvoice/SaleReturnRpt")]
        public HttpResponseMessage SaleReturnRpt(string invoiceIds, int userID)
        {
            try
            {
                DataTable getModel = new DataTable();

                var invoicesData = GetSaleReturnData(invoiceIds, userID);

                if (getModel == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                { IsSuccess = true, Message = "Success", Data = invoicesData }, formatter);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }

        public List<InvoiceMaster> GetSaleReturnData(string invoiceIds, int userID)
        {
            List<InvoiceMaster> InvoiceData = new List<InvoiceMaster>();
            try
            {
                SpData data = new SpData
                {
                    SpName = "[FICO].[CORNRptSaleReturnByIds]",
                    Parameters = new Dictionary<string, object>
                        {
                            { "invoiceIds", invoiceIds },
                            { "userId", userID }
                        }
                };

                var result = new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<DownloadInvoice>();

                var distinctInvoices = result.GroupBy(x => new { x.TransactionCode }).Select(x => x.FirstOrDefault()).ToList();

                foreach (var item in distinctInvoices)
                {
                    var master = new InvoiceMaster();
                    master.TransactionCode = item.TransactionCode;
                    master.TransactionDate = item.TransactionDate;
                    master.Address = item.Address;
                    master.Center = item.Center;
                    master.Company = item.Company;
                    master.CompanyAddress = item.CompanyAddress;
                    master.CompanyPhone = item.CompanyPhone;
                    master.ContactPerson = item.ContactPerson;
                    master.Currency = item.Currency;
                    master.Customer = item.Customer;
                    master.ExchangeRate = item.ExchangeRate;
                    master.GST_No = item.GST_No;
                    master.InvoiceGSTAmount = item.InvoiceGSTAmount;
                    master.InvoiceNetAmount = item.InvoiceNetAmount;
                    master.NTN = item.NTN;
                    master.NTN_No = item.NTN_No;
                    master.OfficialPhoneNo = item.OfficialPhoneNo;
                    master.PODate = item.PODate;
                    master.PONumber = item.PONumber;
                    master.Remarks = item.Remarks;
                    master.STRN = item.STRN;
                    master.TaxCode = item.TaxCode;

                    var details = result.Where(x => x.TransactionCode == item.TransactionCode).ToList();

                    master.InvoiceDetails = new List<InvoiceDetail>();
                    foreach (var itm in details)
                    {

                        var detail = new InvoiceDetail();
                        detail.Item = itm.Item;
                        detail.Discount = itm.Discount;
                        detail.Description = itm.Description;
                        detail.GrossAmount = itm.GrossAmount;
                        detail.ItemGSTTax = itm.ItemGSTTax;
                        detail.ItemNetAmount = itm.ItemNetAmount;
                        detail.Qty = itm.Qty;
                        detail.SalePrice = itm.SalePrice;
                        detail.TaxPercentage = itm.TaxPercentage;

                        master.InvoiceDetails.Add(detail);
                    }

                    InvoiceData.Add(master);
                }

                return InvoiceData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Update Subscription Date

        [HttpPost]
        [Route("~/Api/BulkInvoice/UpdateSubscriptionDates")]
        public HttpResponseMessage UpdateSubscriptionDates(List<BulkInvoiceModel> model, bool autoDateWise = false)
        {
            try
            {
                DataTable getModel = new DataTable();

                getModel = UpdateSubscriptionDate(model, autoDateWise);

                if (getModel == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                { IsSuccess = true, Message = "Record updated successfully", Data = getModel }, formatter);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }

        public DataTable UpdateSubscriptionDate(List<BulkInvoiceModel> model, bool autoDateWise = false)
        {
            try
            {
                var getModel = new DataTable();
                foreach (var item in model)
                {
                    if (autoDateWise)
                    {
                        if (item.RenewalDate != null && item.SubscriptionStartDate != null)
                        {
                            var difference = (item.RenewalDate - item.SubscriptionStartDate).Value.TotalDays;
                            item.RenewalDate = item.RenewalDate.Value.AddDays(difference);
                            item.SubscriptionStartDate = item.SubscriptionStartDate.Value.AddDays(difference);
                        }
                    }

                    SpData data = new SpData
                    {
                        SpName = "[FICO].[CORNUpdateSubscriptionDate]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "ID", item.ID },
                            { "SubscriptionStartDate", item.SubscriptionStartDate },
                            { "RenewalDate", item.RenewalDate },
                            { "UserCode", item.UserCode }
                        }
                    };

                    getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                }

                return getModel;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Generate Invoice
        [HttpPost]
        [Route("~/Api/BulkInvoice/GenerateInvoice")]
        public HttpResponseMessage GenerateInvoice(List<InvoiceModel> obj)
        {
            DataTable getModel = new DataTable();
            var IdsList = new List<long>();

            var billOrInvoice = obj.GroupBy(x => new { x.CustomerCode }).Select(x => x.FirstOrDefault()).ToList();
            var allItemsDetail = obj.ToList();

            var taxGroupList = billOrInvoice.Select(x => x.IMMTaxGroupDetailCode).Distinct().ToList();

            bool taxNotAssignedToCompany = true;
            foreach (var item in taxGroupList)
            {
                if (item != null && item.HasValue)
                taxNotAssignedToCompany = TaxAssignedToCompany(item.Value, obj.FirstOrDefault().CompanyCode);
            }

            if (taxNotAssignedToCompany == false)
            {
                return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                  { IsAlert = true, Message = "Selected Tax Rates are not assigned to company" }, formatter);
            }



            foreach (var item in billOrInvoice)
            {
                var invDetail = allItemsDetail.Where(x => x.CustomerCode == item.CustomerCode 
                && x.PCorCCCode == item.PCorCCCode).ToList();
                var alreadyCreatedInvoices = GetAlreadyCreatedInvoices(item.CustomerCode);

                var alreadyCreatedItemProfiles = new List<InvoiceModel>();

                foreach (var dup in invDetail)
                {
                    dup.TransactionDate = dup.TransactionDate == null ? DateTime.Now :
                        dup.TransactionDate;

                    alreadyCreatedItemProfiles = alreadyCreatedInvoices.
                        Where(x => x.ItemProfileCode == dup.ItemProfileCode &&
                    x.TransactionDate.Date == DateTime.Now.Date).ToList();

                    if (alreadyCreatedItemProfiles.Count > 0)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                        { IsAlert = true, Message = dup.ItemProfileName + " already exist against Customer " +
                        dup.CustomerName
                        }, formatter);
                    }
                }
            }

            foreach (var item in billOrInvoice)
            {
                obj = allItemsDetail.Where(x => x.CustomerCode == item.CustomerCode
                && x.PCorCCCode == item.PCorCCCode).ToList();

                decimal? totalTax = 0;
                decimal? totalgrossAmount = 0;
                foreach (var itm in obj)
                {
                    decimal taxPercent = 0;
                    if (itm.IMMTaxGroupDetailCode != null && itm.IMMTaxGroupDetailCode > 0)
                    {
                       taxPercent = GetTaxPercentByTaxDetailCode(itm.IMMTaxGroupDetailCode);
                    }

                    var grossAmount = (itm.UnitRate * itm.Qty);
                    totalgrossAmount += grossAmount;
                    var taxAmount = (totalgrossAmount * taxPercent) / 100;
                    totalTax += taxAmount;
                }

                if (item.PCorCCCode > 0)
                {
                    var companyCode = GetCompanyByProfitCenter(item.PCorCCCode);

                    if (companyCode > 0)
                        item.CompanyCode = companyCode;
                }

                var generateFolio = GenerateFolioNo(null, 158, "-1", item.CompanyCode);
                var fiscalYearCode = GetFiscalYearCodeByCompany(item.CompanyCode);
                

                try
                {
                    SpData data = new SpData
                    {
                        SpName = "[FICO].[CreateOrUpdateSaleInvoiceMaster]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "GSTAmount", totalTax },
                            //{ "IMMTaxGroupDetailCode", item.IMMTaxGroupDetailCode },
                            { "BillOrInvoiceAmount", obj.Sum(x=> x.NetAmount) },
                            { "TransactionDate", item.TransactionDate },
                            { "PODate", item.ReminderDate },
                            { "PCorCCCode", item.PCorCCCode },
                            { "CompanyCode", item.CompanyCode },
                            { "PONumber", item.ValueDefinition },
                            { "CurrencyCode", item.CurrencyCode },
                            { "ExchangeRate", item.ExchangeRate },
                            { "RefNo", item.URLPath },
                            { "TransactionCode", generateFolio },
                            { "CustomerPartyCode", item.CustomerCode },
                            { "FiscalYearCode", fiscalYearCode },
                            { "BaseCode", 0 },
                            { "ID", 0 },
                            { "CreatedByCode", item.UserCode }
                        }
                    };

                    getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                    var savedID = Convert.ToInt64(getModel.Rows[0]["ID"].ToString());
                    IdsList.Add(savedID);

                    foreach (var itm in obj)
                    {
                        SpData data1 = new SpData
                        {
                            SpName = "[FICO].[CreateOrUpdateSaleInvoiceDetail]",
                            Parameters = new Dictionary<string, object>
                        {
                            { "URLPath", itm.URLPath },
                            { "Description", itm.Remarks },
                            { "SubscriptionFrom", itm.SubscriptionStartDate },
                            { "SubscriptionTo", itm.RenewalDate },
                            { "CompanyCode", item.CompanyCode },
                            { "SalePrice", itm.UnitRate },
                            { "Qty", itm.Qty },
                            { "ItemProfileCode", itm.ItemProfileCode },
                            { "ID", 0 },
                            { "BaseCode", 0 },
                            { "BillOrInvoiceMasterCode",  savedID },
                            { "SaleAmount", itm.NetAmount},
                            { "CurrencyCode", item.CurrencyCode },
                            { "ExchangeRate", item.ExchangeRate },
                            { "CreatedByCode", item.UserCode },
                            { "IMMTaxGroupDetailCode", itm.IMMTaxGroupDetailCode },
                        }
                        };

                       new CommonRepository(ConStr).ExecStoreProcedure(data1);
                    }
                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
                }

            }

            var result = string.Join(",", IdsList);

            return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
            { IsSuccess = true, Message = "Invoices Created Successfully", Data = result }, formatter);

        }

        public bool TaxAssignedToCompany(long IMMTaxGroupDetailCode, int companyCode)
        {
            try
            {

                var isDuplicate = true;
                SpData data = new SpData
                {
                    SpName = "[FICO].[CORNAssignedTaxToCompany]",
                    Parameters = new Dictionary<string, object>
                        {
                            { "IMMTaxGroupDetailCode", IMMTaxGroupDetailCode },
                            { "CompanyCode", companyCode }
                        }
                };

                var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                isDuplicate = Convert.ToBoolean(getModel.Rows[0]["Assigned"].ToString());

                return isDuplicate;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<InvoiceModel> GetAlreadyCreatedInvoices(long customerCode)
        {
            try
            {
                SpData data = new SpData { SpName = "[SRM].[CusomerInvoiceItemProfiles]", Parameters = new Dictionary<string, object> { { "CustomerCode", customerCode } } };
                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<InvoiceModel>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string GenerateFolioNo(string baseCode, int? selectedMenuCode = null, string voucherTypeCode = "-1",
            int? selectedCompanyCode = null)
        {
            string referenceCode = "";
            try
            {
                SpData data = new SpData
                {
                    SpName = "getNewFolioNo",
                    Parameters = new Dictionary<string, object>
                                  { { "menuCode", selectedMenuCode }, { "tableName", "tbl_BillOrInvoiceMaster" },
                        { "colName", "TransactionCode" }, { "baseCode", baseCode },
                                  { "companyCode", selectedCompanyCode }, { "voucherTypeCode", voucherTypeCode } }
                };

                var folioDataTable = new CommonRepository(ConStr).ExecStoreProcedure(data);
                if (folioDataTable != null && folioDataTable.Rows.Count > 0)
                {
                    var row = folioDataTable.Rows[0];
                    var columnVal = row["Folio"];

                    if (columnVal != null)
                    {
                        referenceCode = columnVal + "";
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return referenceCode;
        }

        public decimal GetTaxPercentByTaxDetailCode(long? taxGroupDetailCode)
        {
            decimal referenceCode = 0;
            try
            {
                SpData data = new SpData
                {
                    SpName = "[FICO].GetTaxPercentByTaxCode",
                    Parameters = new Dictionary<string, object>
                                  { { "ID", taxGroupDetailCode } }
                };

                var folioDataTable = new CommonRepository(ConStr).ExecStoreProcedure(data);
                if (folioDataTable != null && folioDataTable.Rows.Count > 0)
                {
                    var row = folioDataTable.Rows[0];
                    var columnVal = row["TaxPercentage"];

                    if (columnVal != null)
                    {
                        referenceCode = Convert.ToDecimal(columnVal);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return referenceCode;
        }


        public Int16 GetFiscalYearCodeByCompany(int CompanyCode)
        {
            Int16 referenceCode = 0;
            try
            {
                SpData data = new SpData
                {
                    SpName = "[FICO].GetFiscalYearCodeByCompany",
                    Parameters = new Dictionary<string, object>
                                  { { "CompanyCode", CompanyCode } }
                };

                var folioDataTable = new CommonRepository(ConStr).ExecStoreProcedure(data);
                if (folioDataTable != null && folioDataTable.Rows.Count > 0)
                {
                    var row = folioDataTable.Rows[0];
                    var columnVal = row["ID"];

                    if (columnVal != null)
                    {
                        referenceCode = Convert.ToInt16(columnVal);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return referenceCode;
        }

        public int GetCompanyByProfitCenter(int profitCenterCode)
        {
            int referenceCode = 0;
            try
            {
                SpData data = new SpData
                {
                    SpName = "[FICO].GetCompanyByProfitCenter",
                    Parameters = new Dictionary<string, object>
                                  { { "ProfitCenterCode", profitCenterCode } }
                };

                var folioDataTable = new CommonRepository(ConStr).ExecStoreProcedure(data);
                if (folioDataTable != null && folioDataTable.Rows.Count > 0)
                {
                    var row = folioDataTable.Rows[0];
                    var columnVal = row["ParentCode"];

                    if (columnVal != null)
                    {
                        referenceCode = Convert.ToInt32(columnVal);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return referenceCode;
        }
        #endregion

    }
    public class BulkInvoiceModel
    {
        public long ID { get; set; }
        public DateTime? SubscriptionStartDate { get; set; }
        public DateTime? RenewalDate { get; set; }
        public int UserCode { get; set; }
    }
    public class InvoiceModel
    {
        public long ItemProfileCode { get; set; }
        public long CustomerCode { get; set; }
        public decimal Qty { get; set; }
        public decimal UnitRate { get; set; }
        public Int16 CurrencyCode { get; set; }
        public decimal ExchangeRate { get; set; }
        public string URLPath { get; set; }
        public DateTime? ReminderDate { get; set; }
        public DateTime TransactionDate { get; set; }
        public int PCorCCCode { get; set; }
        public long? IMMTaxGroupDetailCode { get; set; }
        public decimal NetAmount { get; set; }
        public int CompanyCode { get; set; }
        public int UserCode { get; set; }
        public string ItemProfileName { get; set; }
        public string CustomerName { get; set; }
        public string ValueDefinition { get; set; }
        public string Remarks { get; set; }
        public DateTime? SubscriptionStartDate { get; set; }
        public DateTime? RenewalDate { get; set; }
    }
    public class DownloadInvoice
    {
        public string TransactionCode { get; set; }
        public string TransactionDate { get; set; }
        public string Company { get; set; }
        public string Center { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyPhone { get; set; }
        public string Customer { get; set; }
        public string Address { get; set; }
        public string OfficialPhoneNo { get; set; }
        public string NTN_No { get; set; }
        public string GST_No { get; set; }
        public string TaxCode { get; set; }
        public string NTN { get; set; }
        public string STRN { get; set; }
        public decimal InvoiceNetAmount { get; set; }
        public decimal InvoiceGSTAmount { get; set; }
        public string Currency { get; set; }
        public decimal ExchangeRate { get; set; }
        public string ContactPerson { get; set; }
        public string PODate { get; set; }
        public string PONumber { get; set; }
        public string Remarks { get; set; }
        public string Item { get; set; }
        public decimal Qty { get; set; }
        public decimal SalePrice { get; set; }
        public decimal Discount { get; set; }
        public string Description { get; set; }
        public decimal TaxPercentage { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal ItemGSTTax { get; set; }
        public decimal ItemNetAmount { get; set; }
    }
    public class InvoiceMaster {
        public string TransactionCode { get; set; }
        public string TransactionDate { get; set; }
        public string Company { get; set; }
        public string Center { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyPhone { get; set; }
        public string Customer { get; set; }
        public string Address { get; set; }
        public string OfficialPhoneNo { get; set; }
        public string NTN_No { get; set; }
        public string GST_No { get; set; }
        public string TaxCode { get; set; }
        public string NTN { get; set; }
        public string STRN { get; set; }
        public decimal InvoiceNetAmount { get; set; }
        public decimal InvoiceGSTAmount { get; set; }
        public string Currency { get; set; }
        public decimal ExchangeRate { get; set; }
        public string ContactPerson { get; set; }
        public string PODate { get; set; }
        public string PONumber { get; set; }
        public string Remarks { get; set; }
        public List<InvoiceDetail> InvoiceDetails { get; set; }
        public EmailTemplateForDownload InvoiceTemplate { get; set; }        
    }
    public class InvoiceDetail
    {
        public string Item { get; set; }
        public decimal Qty { get; set; }
        public decimal SalePrice { get; set; }
        public decimal Discount { get; set; }
        public string Description { get; set; }
        public decimal TaxPercentage { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal ItemGSTTax { get; set; }
        public decimal ItemNetAmount { get; set; }
    }
    public class ConvertAndGenerateInvoice
    {
        public long ID { get; set; }
        public bool GenerateAndConvert { get; set; }
        public int UserId { get; set; }
    }
    public class EmailTemplateForDownload
    {
        public long ID { get; set; }
        public string EmailTemplate { get; set; }
        public string HTML { get; set; }
        public string CSS { get; set; }
        public string Body { get; set; }
        public string Footer { get; set; }
        public string Header { get; set; }
        public string TemplateCategory { get; set; }
        public bool IsRepeatTemp { get; set; }
        public string APIKey { get; set; }
        public string APIURL { get; set; }
    }
}

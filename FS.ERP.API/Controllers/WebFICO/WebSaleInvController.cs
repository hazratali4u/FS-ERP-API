using CST.CCL.Helper;
using CST.CCL.Helper.Common;
using CST.CRY;
using FS.CAPI.BAL;
using FS.ERP.API.Models;

using FS.ERP.Business.IdentityManager;
using FS.ERP.EF.IdentityStore;
using FS.ERP.Models.Custom;
using FS.ERP.Models.IdentityModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Cors;

namespace FS.ERP.API.Controllers
{
    [EnableCors("*", "*", "*")]
    public class WebSaleInvController : ApiController
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

        [HttpGet]
        [Route("~/api/saleinv/download")]
        public HttpResponseMessage SaleInvoiceDownload(string invoiceIds)
        {
            try
            {
                DataTable getModel = new DataTable();

                var invoicesData = GetInvoiceData(invoiceIds, 23);

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

                //get email template now
                data = new SpData
                {
                    SpName = "[CRM].[CORNPrintingTemplate]",
                    Parameters = new Dictionary<string, object>
                        {
                            { "Category", "Sales"},
                            { "CompanyCode", "17" }
                        }
                };

                var templateRes = new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<EmailTemplateForDownload>();

                //set response object data now
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

                    //add template now
                    master.InvoiceTemplate = templateRes.Where(p => p.ID == 10).ToList()[0];

                    InvoiceData.Add(master);
                }
                
                return InvoiceData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

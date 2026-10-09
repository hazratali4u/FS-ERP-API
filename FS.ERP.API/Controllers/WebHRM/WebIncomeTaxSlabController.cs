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
    public class WebIncomeTaxSlabController : ApiController
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


        #region Income Tax Slab

        [HttpGet]
        [Route("~/Api/TaxSlab/GetIncomeTaxSlabDetails")]
        public HttpResponseMessage GetIncomeTaxSlabDetails(int id)
        {
            try
            {
                var details = GetSlabDetailsByID(id);
                if (details == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }
                else
                {
                    if (details.Count == 0)
                    {
                        details = new List<VM_IncomeTaxSlab>();
                        details.Add(new VM_IncomeTaxSlab { });
                    }

                    details.FirstOrDefault().IncomeTaxSlabDetails = GetIncomeTaxSlabDetailsBySlabCode(id);

                    return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                    { IsSuccess = true, Message = "Success", Data = details }, formatter);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }

        public List<VM_IncomeTaxSlab> GetSlabDetailsByID(int id)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].GetTaxSlabDetailByID",
                    Parameters = new Dictionary<string, object>
                    {
                        { "ID ", id }
                    }
                };
                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<VM_IncomeTaxSlab>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<VM_IncomeTaxSlabDetail> GetIncomeTaxSlabDetailsBySlabCode(int slabCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].GetTaxSlabDetailsBySlabCode",
                    Parameters = new Dictionary<string, object>
                    {
                        { "TaxSlabCode ", slabCode }
                    }
                };
                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<VM_IncomeTaxSlabDetail>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("~/Api/TaxSlab/SaveOrUpdateTaxSlab")]
        public HttpResponseMessage SaveOrUpdateTaxSlab(VM_IncomeTaxSlab model)
        {
            try
            {
                DataTable getModel = new DataTable();

                //Check Duplicates
                var isDuplicate = CheckForDuplicates(model);

                if (isDuplicate)
                    return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                    { IsSuccess = false, Message = "Duplicate Record" }, formatter);

                getModel = SaveTaxSlab(model);

                if (getModel == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                { IsSuccess = true, Message = "Data Saved", Data = getModel }, formatter);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }
        public DataTable SaveTaxSlab(VM_IncomeTaxSlab model)
        {
            var getModel = new DataTable();

            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].[WebCreateOrUpdateTaxSlab]",
                    Parameters = new Dictionary<string, object>
                        {
                            { "BenchmarkRate", model.BenchmarkRate },
                            { "BenchmarkRateLoanAmount", model.BenchmarkRateLoanAmount },
                            { "EffectiveFrom", model.EffectiveFrom },
                            { "EmployerPFLimit", model.EmployerPFLimit },
                            { "FiscalYearCode", model.FiscalYearCode },
                            { "CompanyCode", model.CompanyCode },
                            { "CreatedByCode", model.CreatedByCode },
                            { "ID", model.ID },
                            { "SlabDescription", model.SlabDescription },
                            { "TaxRebateFemale", model.TaxRebateFemale },
                            { "TaxRebateMale", model.TaxRebateMale },
                            { "TaxRebateMinSlab", model.TaxRebateMinSlab },
                            { "TaxSlabName", model.TaxSlabName }
                        }
                };

                getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);

                if (getModel.Rows.Count > 0)
                {

                    int savedID = int.Parse(getModel.Rows[0]["ID"].ToString());

                    foreach (var item in model.IncomeTaxSlabDetails)
                    {
                        data = new SpData
                        {
                            SpName = "[HRM].[WebCreateOrUpdateTaxSlabDetail]",
                            Parameters = new Dictionary<string, object>
                        {
                            { "TaxSlabCode", savedID },
                            { "IncomeFrom", item.IncomeFrom },
                            { "IncomeTo", item.IncomeTo },
                            { "RateOfTax", item.RateOfTax },
                            { "Addition", item.Addition },
                            { "CompanyCode", model.CompanyCode },
                            { "CreatedByCode", model.CreatedByCode },
                            { "ID", item.ID },
                            { "IsDeleted", item.IsDeleted }
                        }
                        };

                       new CommonRepository(ConStr).ExecStoreProcedure(data);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return getModel;
        }
        public bool CheckForDuplicates(VM_IncomeTaxSlab model)
        {
            try
            {
                var isDuplicate = false;
                SpData data = new SpData
                {
                    SpName = "[HRM].[WebCheckDuplicateIncomeTaxSlab]",
                    Parameters = new Dictionary<string, object>
                        {
                            { "FiscalYearCode", model.FiscalYearCode },
                            { "TaxSlabName", model.TaxSlabName },
                            { "CompanyCode", model.CompanyCode },
                            { "ID", model.ID }
                        }
                };

                var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                isDuplicate = Convert.ToBoolean(getModel.Rows[0]["Duplicate"].ToString());

                if (isDuplicate == true)
                    return isDuplicate;

                return isDuplicate;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
    public class VM_IncomeTaxSlab
    {
        public int ID { get; set; }
        public string TaxSlabName { get; set; }
        public short FiscalYearCode { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public string SlabDescription { get; set; }
        public decimal? TaxRebateMale { get; set; }
        public int CreatedByCode { get; set; }
        public int CompanyCode { get; set; }
        public decimal? TaxRebateFemale { get; set; }
        public decimal TaxRebateMinSlab { get; set; }
        public decimal? EmployerPFLimit { get; set; }
        public decimal BenchmarkRate { get; set; }
        public decimal BenchmarkRateLoanAmount { get; set; }
        public List<VM_IncomeTaxSlabDetail> IncomeTaxSlabDetails { get; set; }
    }
    public class VM_IncomeTaxSlabDetail
    {
        public int ID { get; set; }
        public int TaxSlabCode { get; set; }
        public decimal IncomeFrom { get; set; }
        public decimal IncomeTo { get; set; }
        public decimal RateOfTax { get; set; }
        public decimal Addition { get; set; }
        public bool IsDeleted { get; set; }
    }
}

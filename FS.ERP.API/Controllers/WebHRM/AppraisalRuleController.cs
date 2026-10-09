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
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Cors;

namespace FS.ERP.API.Controllers
{
    [EnableCors("*", "*", "*")]
    public class AppraisalRuleController : ApiController
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


        #region Appraisal Rules

        [HttpGet]
        [Route("~/Api/AppRule/GetAppRuleDetails")]
        public HttpResponseMessage GetAppRuleDetails(long ID)
        {
            try
            {
                var details = GetAppRuleDetailsByID(ID);
                if (details == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                    { IsSuccess = true, Message = "Success", Data = details }, formatter);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }

        public List<VM_AppraisalRule> GetAppRuleDetailsByID(long ID)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].GetAppraisalRuleByID",
                    Parameters = new Dictionary<string, object>
                    {
                        { "ID", ID }
                    }
                };
                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<VM_AppraisalRule>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("~/Api/AppRule/SaveOrUpdateAppRule")]
        public HttpResponseMessage SaveOrUpdateEOBI(VM_AppraisalRule model)
        {
            try
            {
                DataTable getModel = new DataTable();

                //Check Duplicates
                var isDuplicate = CheckForDuplicates(model);

                if (isDuplicate)
                    return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                    { IsSuccess = false, Message = "Duplicate Record" }, formatter);

                getModel = SaveAppRule(model);

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
        public DataTable SaveAppRule(VM_AppraisalRule model)
        {
            var getModel = new DataTable();

            try
            {
                var deptCodeList = model.DeptCodeStr.Split(',');
                foreach (var item in deptCodeList)
                {
                    SpData data = new SpData
                    {
                        SpName = "[HRM].[WebCreateOrUpdateAppraisalRule]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "CompanyID", model.CompanyID },
                            { "DeptCode", item },
                            { "FiscalYearCode", model.FiscalYearCode },
                            { "IncrementDecrementTypeCode", model.IncrementDecrementTypeCode },
                            { "IsMaxIncrementAmount", model.IsMaxIncrementAmount },
                            { "CompanyCode", model.CompanyCode },
                            { "CreatedByCode", model.CreatedByCode },
                            { "ID", model.ID },
                            { "IsMaxIncrementRatio", model.IsMaxIncrementRatio },
                            { "IsMinIncrementAmount", model.IsMinIncrementAmount },
                            { "IsMinIncrementRatio", model.IsMinIncrementRatio },
                            { "MaxIncrementAmount", model.MaxIncrementAmount },
                            { "MaxIncrementRatio", model.MaxIncrementRatio },
                            { "MinIncrementAmount", model.MinIncrementAmount },
                            { "MinIncrementRatio", model.MinIncrementRatio },
                            { "OverallIncrementAmount", model.OverallIncrementAmount },
                            { "OverallIncrementShouldBe", model.OverallIncrementShouldBe }
                        }
                    };

                    getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return getModel;
        }
        public bool CheckForDuplicates(VM_AppraisalRule model)
        {
            try
            {
                var isDuplicate = false;

                var deptCodeList = model.DeptCodeStr.Split(',');
                foreach (var item in deptCodeList)
                {

                    SpData data = new SpData
                    {
                        SpName = "[HRM].[WebCheckDuplicateAppraisalRule]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "DeptCode", item },
                            { "FiscalYearCode", model.FiscalYearCode },
                            { "CompanyID", model.CompanyID },
                            { "ID", model.ID }
                        }
                    };

                    var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                    isDuplicate = Convert.ToBoolean(getModel.Rows[0]["Duplicate"].ToString());

                    if (isDuplicate == true)
                        return isDuplicate;
                }

                return isDuplicate;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
    public class VM_AppraisalRule
    {
        public long ID { get; set; }
        public int CompanyID { get; set; }
        public short? FiscalYearCode { get; set; }
        public long IncrementDecrementTypeCode { get; set; }
        public int DeptCode { get; set; }
        public string DeptCodeStr { get; set; }
        public bool? OverallIncrementShouldBe { get; set; }
        public int CreatedByCode { get; set; }
        public int CompanyCode { get; set; }
        public decimal? OverallIncrementAmount { get; set; }
        public bool? IsMaxIncrementRatio { get; set; }
        public decimal? MaxIncrementRatio { get; set; }
        public bool? IsMinIncrementRatio { get; set; }
        public decimal? MinIncrementRatio { get; set; }
        public bool? IsMaxIncrementAmount { get; set; }
        public decimal? MaxIncrementAmount { get; set; }
        public bool? IsMinIncrementAmount { get; set; }
        public decimal? MinIncrementAmount { get; set; }
    }
}

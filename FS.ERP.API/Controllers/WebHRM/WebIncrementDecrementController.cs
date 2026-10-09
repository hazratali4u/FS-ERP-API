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
    [Authorize]
    [EnableCors("*", "*", "*")]
    public class WebIncrementDecrementController : ApiController
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


        #region Increment / Decrement

        [HttpGet]
        [Route("~/Api/Increment/GetIncrementDetails")]
        public HttpResponseMessage GetEOBIDetails(long ID, int CompanyCode)
        {
            try
            {
                var details = GetIncrementDetailsByID(ID, CompanyCode);
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

        public List<VM_IncrementDecrement> GetIncrementDetailsByID(long ID, int CompanyCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].GetIncrementDetailsByID",
                    Parameters = new Dictionary<string, object>
                    {
                        { "ID ", ID },
                        { "CompanyCode", CompanyCode }
                    }
                };
                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<VM_IncrementDecrement>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("~/Api/Increment/SaveOrUpdateIncrement")]
        public HttpResponseMessage SaveOrUpdateIncrement(List<VM_IncrementDecrement> model)
        {
            try
            {
                DataTable getModel = new DataTable();

                //Check Duplicates
                //var isDuplicate = CheckForDuplicates(model);

                //if (isDuplicate)
                //    return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                //    { IsSuccess = false, Message = "Duplicate Record" }, formatter);

                getModel = SaveIncrement(model);

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
        public DataTable SaveIncrement(List<VM_IncrementDecrement> model)
        {
            var getModel = new DataTable();

            try
            {
                foreach (var item in model)
                {
                    SpData data = new SpData
                    {
                        SpName = "[HRM].[WebCreateOrUpdateIncrementDecrement]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "BasicPayAfterIncrement", item.BasicPayAfterIncrement },
                            { "EffectiveFrom", item.EffectiveFrom },
                            { "EmpCode", item.EmpCode },
                            { "CompanyCode", item.CompanyCode },
                            { "CreatedByCode", item.CreatedByCode },
                            { "ID", item.ID },
                            { "IsDeleted", item.IsDeleted },
                            { "IncrementAmount", item.IncrementAmount },
                            { "IncrementDecrementTypeCode", item.IncrementDecrementTypeCode },
                            { "IncrementRatio", item.IncrementRatio },
                            { "SalaryBeforeIncrement", item.SalaryBeforeIncrement },
                        }
                    };

                    new CommonRepository(ConStr).ExecStoreProcedure(data);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return getModel;
        }
        //public bool CheckForDuplicates(VM_EOBI model)
        //{
        //    try
        //    {
        //        var isDuplicate = false;
        //        SpData data = new SpData
        //        {
        //            SpName = "[HRM].[WebCheckDuplicateEOBI]",
        //            Parameters = new Dictionary<string, object>
        //                {
        //                    { "EmployeeTypeCode", model.EmployeeTypeCode },
        //                    { "PayGradeCode", model.PayGradeCode },
        //                    { "CompanyCode", model.CompanyCode },
        //                    { "ID", model.ID }
        //                }
        //        };

        //        var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
        //        isDuplicate = Convert.ToBoolean(getModel.Rows[0]["Duplicate"].ToString());

        //        if (isDuplicate == true)
        //            return isDuplicate;

        //        return isDuplicate;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        #endregion

    }
    public class VM_IncrementDecrement
    {
        public long ID { get; set; }
        public long EmpCode { get; set; }
        public long IncrementDecrementTypeCode { get; set; }
        public DateTime? EffectiveFrom { get; set; }
        public decimal? IncrementRatio { get; set; }
        public decimal? IncrementAmount { get; set; }
        public int CreatedByCode { get; set; }
        public int CompanyCode { get; set; }
        public decimal? SalaryBeforeIncrement { get; set; }
        public decimal? BasicPayAfterIncrement { get; set; }
        public string Employee { get; set; }
        public string Grade { get; set; }
        public string EmpCodeStr { get; set; }
        public bool IsDeleted { get; set; }
    }
}

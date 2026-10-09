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
    public class ClearanceCheckListController : ApiController
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


        #region Clearance CheckList Setup

        [HttpGet]
        [Route("~/Api/CheckListSetup/GetCheckListDetails")]
        public HttpResponseMessage GetCheckListDetails(int? DeptCode)
        {
            try
            {
                var details = GetCheckListDetailsByDeptCode(DeptCode);
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

        public List<VM_ClearanceCheckListSetup> GetCheckListDetailsByDeptCode(int? DeptCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].WebGetCheckListSetupByDeptCode",
                    Parameters = new Dictionary<string, object>
                    {
                        { "DeptCode ", DeptCode }
                    }
                };
                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<VM_ClearanceCheckListSetup>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [HttpPost]
        [Route("~/Api/CheckListSetup/SaveOrUpdateCheckListSetup")]
        public HttpResponseMessage SaveOrUpdateCheckListSetup(List<VM_ClearanceCheckListSetup> model)
        {
            try
            {
                DataTable getModel = new DataTable();

                //Check Duplicates
                //var isDuplicate = CheckForDuplicates(model);

                //if (isDuplicate)
                //    return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                //    { IsSuccess = false, Message = "Duplicate Record" }, formatter);

                getModel = SaveCheckListSetup(model);

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
        public DataTable SaveCheckListSetup(List<VM_ClearanceCheckListSetup> model)
        {
            var getModel = new DataTable();

            try
            {
                foreach (var item in model)
                {
                    SpData data = new SpData
                    {
                        SpName = "[HRM].[WebCreateOrUpdateCheckListSetup]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "DeptCode", item.DeptCode },
                            { "Description", item.Description },
                            { "IsActive", item.IsActive },
                            { "SpecificEmployeeCode", item.SpecificEmployeeCode },
                            { "SpecificEmployeeCode1", item.SpecificEmployeeCode1 },
                            { "CompanyCode", item.CompanyCode },
                            { "CreatedByCode", item.CreatedByCode },
                            { "ID", item.ID },
                            { "IsDeleted", item.IsDeleted }
                        }
                    };

                    getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                    int savedID = int.Parse(getModel.Rows[0]["ID"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return getModel;
        }
        public bool CheckForDuplicates(VM_EOBI model)
        {
            try
            {
                var isDuplicate = false;
                SpData data = new SpData
                {
                    SpName = "[HRM].[WebCheckDuplicateEOBI]",
                    Parameters = new Dictionary<string, object>
                        {
                            { "EmployeeTypeCode", model.EmployeeTypeCode },
                            { "PayGradeCode", model.PayGradeCode },
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
    public class VM_ClearanceCheckListSetup
    {
        public int ID { get; set; }
        public int? DeptCode { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public long? SpecificEmployeeCode { get; set; }
        public long? SpecificEmployeeCode1 { get; set; }
        public int CreatedByCode { get; set; }
        public int CompanyCode { get; set; }
        public bool IsDeleted { get; set; }
        public string Department { get; set; }
        public string SpecificEmployee { get; set; }
        public string SpecificEmployee1 { get; set; }
    }
}

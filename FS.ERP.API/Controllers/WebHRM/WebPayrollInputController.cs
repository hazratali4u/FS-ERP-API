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
    public class WebPayrollInputController : ApiController
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


        #region Payroll Input

        [HttpGet]
        [Route("~/Api/PayrollInput/GetEditPayrollInputDetails")]
        public HttpResponseMessage GetPayrollInputDetails(int ID)
        {
            try
            {
                var details = GetPayrollInputDetailsByID(ID);
                if (details == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                { IsSuccess = true, Message = "Success", Data = details }, formatter);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }

        public List<VM_PayrollInput> GetPayrollInputDetailsByID(int ID)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].GetEditPayrollInputDetails",
                    Parameters = new Dictionary<string, object> { { "ID", ID } }
                };
                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<VM_PayrollInput>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("~/Api/PayrollInput/SaveOrUpdatePayrollInput")]
        public HttpResponseMessage SaveOrUpdatePayrollInput(List<VM_PayrollInput> model)
        {
            try
            {
                DataTable getModel = new DataTable();

                //Check Duplicates
                var isDuplicate = CheckForDuplicates(model);

                if (isDuplicate)
                    return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                    { IsAlert = true, IsSuccess = false, Message = "Duplicate Record" }, formatter);

                getModel = SavePayrollInput(model);

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
        public DataTable SavePayrollInput(List<VM_PayrollInput> model)
        {
            var getModel = new DataTable();

            try
            {
                foreach (var item in model)
                {
                    SpData data = new SpData
                    {
                        SpName = "[HRM].[WebCreateOrUpdatePayrollInput]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "EmpCode", item.EmpCode },
                            { "AllowanceOrBenefitTypeCode", item.AllowanceOrBenefitTypeCode },
                            { "AllowanceOrBenefitAmount", item.AllowanceOrBenefitAmount },
                            { "DateFrom", item.DateFrom },
                            { "DateTo", item.DateTo },
                            { "Remarks", item.Remarks },
                            { "CompanyCode", item.CompanyCode },
                            { "CreatedByCode", item.CreatedByCode },
                            { "ID", item.ID },
                            { "IsDeleted", item.IsDeleted }
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
        public bool CheckForDuplicates(List<VM_PayrollInput> model)
        {
            try
            {
                var isDuplicate = false;
                foreach (var item in model)
                {
                    SpData data = new SpData
                    {
                        SpName = "[HRM].[WebCheckDuplicateForPayrollInput]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "EmpCode", item.EmpCode },
                            { "DateFrom", item.DateFrom },
                            { "DateTo", item.DateTo },
                            { "AllowanceOrBenefitTypeCode", item.AllowanceOrBenefitTypeCode },
                            { "ID", item.ID }
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

        [HttpPost]
        [Route("~/Api/PayrollInput/UploadBulkAll")]
        public HttpResponseMessage SaveOrUpdatePayrollInput(BulkPayrollInputAll model)
        {
            try
            {
                DataTable getModel = new DataTable();

                getModel = SavePayrollInputAll(model);

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

        public DataTable SavePayrollInputAll(BulkPayrollInputAll model)
        {
            var getModel = new DataTable();

            try
            {
                foreach (var emp in model.EmployeeList)
                {
                    foreach (var data in emp.Data)
                    {
                        SpData dataSp = new SpData
                        {
                            SpName = "[HRM].[WebPayrollInputBulkSave]",
                            Parameters = new Dictionary<string, object>
                            {
                                { "EmpCode", emp.EmpCode },
                                { "AllowanceName", data.Name },
                                { "AllowanceAmount", data.Val },
                                { "DateFrom", model.FromDate },
                                { "DateTo", model.ToDate },                                
                                { "CompanyCode", model.CompanyCode },
                                { "UserId", model.UserId }
                            }
                        };

                        getModel = new CommonRepository(ConStr).ExecStoreProcedure(dataSp);
                    }

                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return getModel;
        }
        #endregion

    }
    public class VM_PayrollInput
    {
        public int ID { get; set; }
        public long EmpCode { get; set; }
        public int AllowanceOrBenefitTypeCode { get; set; }
        public decimal AllowanceOrBenefitAmount { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string Remarks { get; set; }
        public bool IsLocked { get; set; }
        public int CompanyCode { get; set; }
        public int CreatedByCode { get; set; }
        public bool IsDeleted { get; set; }
        public string Department { get; set; }
        public int DeptCode { get; set; }
        public string AllowanceOrBenefitType { get; set; }
        public string AllowanceOrDeduction { get; set; }
        public long PayrollGroupCode { get; set; }
        public string PayrollGroupName { get; set; }
    }

    public class BulkPayrollInputAll
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public List<BulkPayrollInputEmp> EmployeeList { get; set; }
        public int CompanyCode { get; set; }
        public int UserId { get; set; }

    }
    public class BulkPayrollInputEmp
    {
        public string EmpCode { get; set; }
        public List<NameVal> Data { get; set; }
    }
    public class NameVal
    {
        public string Name { get; set; }
        public string Val { get; set; }
    }
}

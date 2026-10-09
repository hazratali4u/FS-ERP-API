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
    public class CPREntryController : ApiController
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


        #region CPR Entry

        [HttpGet]
        [Route("~/Api/CPR/GetEditCPREntryDetails")]
        public HttpResponseMessage GetEditCPREntryDetails(int ID)
        {
            try
            {
                var details = GetCPREntryDetailsByID(ID);
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

        public List<VM_CPREntry> GetCPREntryDetailsByID(int ID)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].GetEditCPREntryDetails",
                    Parameters = new Dictionary<string, object> { { "ID", ID } }
                };
                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<VM_CPREntry>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("~/Api/CPR/SaveOrUpdateCPREntry")]
        public HttpResponseMessage SaveOrUpdateCPREntry(List<VM_CPREntry> model)
        {
            try
            {
                DataTable getModel = new DataTable();

                //Check Duplicates
                var isDuplicate = CheckForDuplicates(model);

                if (isDuplicate)
                    return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                    { IsSuccess = false, Message = "Duplicate Record" }, formatter);

                getModel = SaveCPREntry(model);

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
        public DataTable SaveCPREntry(List<VM_CPREntry> model)
        {
            var getModel = new DataTable();

            try
            {
                foreach (var item in model)
                {
                    SpData data = new SpData
                    {
                        SpName = "[HRM].[WebCreateOrUpdateCPREntry]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "EmpCode", item.EmpCode },
                            { "EmpSalaryCode", item.EmpSalaryCode },
                            { "CostOrProfitCenterCode", item.CostOrProfitCenterCode },
                            { "TaxSubmissionDate", item.TaxSubmissionDate },
                            { "TaxReferenceNo", item.TaxReferenceNo },
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
        public bool CheckForDuplicates(List<VM_CPREntry> model)
        {
            try
            {
                var isDuplicate = false;
                foreach (var item in model)
                {
                    SpData data = new SpData
                    {
                        SpName = "[HRM].[WebCheckDuplicateCPREntry]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "EmpCode", item.EmpCode },
                            { "EmpSalaryCode", item.EmpSalaryCode },
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
        #endregion

        #region Loan Installment
        [HttpPost]
        [Route("~/Api/Loan/SaveOrUpdateLoanInstallment")]
        public HttpResponseMessage SaveOrUpdateLoanInstallment(List<VM_InsertUpdateLoanInstallment> model)
        {
            try
            {
                DataTable getModel = new DataTable();

                //Check Duplicates
                //var isDuplicate = CheckForDuplicates(model);

                //if (isDuplicate)
                //    return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                //    { IsSuccess = false, Message = "Duplicate Record" }, formatter);

                getModel = SaveLoanInstallment(model);

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
        public DataTable SaveLoanInstallment(List<VM_InsertUpdateLoanInstallment> model)
        {
            var getModel = new DataTable();

            try
            {
                foreach (var item in model)
                {
                    SpData data = new SpData
                    {
                        SpName = "[HRM].[WebUpdateLoanInstallment]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "EmployeeLoanCode", item.EmployeeLoanCode },
                            { "InstallmentNo", item.InstallmentNo },
                            { "InstallmentDueOn", item.InstallmentDueOn },
                            { "InstallmentAmount", item.InstallmentAmount },
                            { "IsReceived", item.IsReceived },
                            { "ReceivedOn", item.ReceivedOn },
                            { "ReceivedAmount", item.ReceivedAmount },
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
        #endregion

    }
    public class VM_CPREntry
    {
        public long ID { get; set; }
        public long EmpCode { get; set; }
        public long EmpSalaryCode { get; set; }
        public int? CostOrProfitCenterCode { get; set; }
        public DateTime? TaxSubmissionDate { get; set; }
        public string TaxReferenceNo { get; set; }
        public int CreatedByCode { get; set; }
        public int CompanyCode { get; set; }
        public bool IsDeleted { get; set; }
        public decimal? Salary { get; set; }
        public string Employee { get; set; }
        public decimal? MonthlyTax { get; set; }
    }
    public class VM_InsertUpdateLoanInstallment
    {
        public long ID { get; set; }
        public long EmployeeLoanCode { get; set; }
        public short? InstallmentNo { get; set; }
        public DateTime? InstallmentDueOn { get; set; }
        public decimal? InstallmentAmount { get; set; }
        public bool? IsReceived { get; set; }
        public DateTime? ReceivedOn { get; set; }
        public decimal? ReceivedAmount { get; set; }
        public string Remarks { get; set; }
        public int CompanyCode { get; set; }
        public int CreatedByCode { get; set; }
        public bool IsDeleted { get; set; }
    }
}

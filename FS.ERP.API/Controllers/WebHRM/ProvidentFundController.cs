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
    public class ProvidentFundController : ApiController
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


        #region Provident Fund

        [HttpGet]
        [Route("~/Api/PF/GetPFDetails")]
        public HttpResponseMessage GetPFDetails(int payGradeCode, int employeeTypeCode, int companyCode)
        {
            try
            {
                var details = GetPFDetailsByID(payGradeCode, employeeTypeCode, companyCode);
                if (details == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }
                else
                {
                    if (details.Count == 0)
                    {
                        details = new List<VM_Provident>();
                        details.Add(new VM_Provident { });
                    }

                    //if (details.FirstOrDefault() != null && details.FirstOrDefault().PayGradeCode > 0)
                    //{
                    details.FirstOrDefault().PFDetails = GetPFAllowanceDetailsByPFCode(payGradeCode, employeeTypeCode, companyCode);

                    if (details.FirstOrDefault().IsYearly == true)
                    {
                        details.FirstOrDefault().YearlyDetails = GetPFYearlyDetailsByPFCode(details.FirstOrDefault().ID);
                    }
                    else
                    {
                        details.FirstOrDefault().YearlyDetails = null;
                    }
                    //}

                    return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                    { IsSuccess = true, Message = "Success", Data = details }, formatter);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }

        public List<VM_Provident> GetPFDetailsByID(int payGradeCode, int employeeTypeCode, int companyCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].GetPFDetailsByID",
                    Parameters = new Dictionary<string, object>
                    {
                        { "PaygradeCode ", payGradeCode },
                        { "EmployeeTypeCode ", employeeTypeCode },
                        { "CompanyCode ", companyCode }
                    }
                };
                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<VM_Provident>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<VM_PFDetails> GetPFAllowanceDetailsByPFCode(int payGradeCode, int employeeTypeCode, int companyCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].GetPFAllowanceDetailsByPFCode",
                    Parameters = new Dictionary<string, object>
                    {
                        { "PaygradeCode ", payGradeCode },
                        { "EmployeeTypeCode ", employeeTypeCode },
                        { "CompanyCode ", companyCode }
                    }
                };
                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<VM_PFDetails>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<VM_YrDetails> GetPFYearlyDetailsByPFCode(int PFCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].GetPFYearlyDetailsByPFCode",
                    Parameters = new Dictionary<string, object>
                    {
                        { "PFCode", PFCode }
                    }
                };
                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<VM_YrDetails>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        [Route("~/Api/PF/SaveOrUpdatePF")]
        public HttpResponseMessage SaveOrUpdatePF(VM_Provident model)
        {
            try
            {
                DataTable getModel = new DataTable();

                //Check Duplicates
                var isDuplicate = CheckForDuplicates(model);

                if (isDuplicate)
                    return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                    { IsSuccess = false, Message = "Duplicate Record" }, formatter);

                getModel = SavePF(model);

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
        public DataTable SavePF(VM_Provident model)
        {
            var getModel = new DataTable();

            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].[WebCreateOrUpdateProvidentFund]",
                    Parameters = new Dictionary<string, object>
                        {
                            { "PayGradeCode", model.PayGradeCode },
                            { "EmployeeTypeCode", model.EmployeeTypeCode },
                            { "EmployeeContribution", model.EmployeeContribution },
                            { "EmployerContribution", model.EmployerContribution },
                            { "IsTaxDeduction", model.IsTaxDeduction },
                            { "CompanyCode", model.CompanyCode },
                            { "CreatedByCode", model.CreatedByCode },
                            { "ID", model.ID },
                            { "ZakatDeduction", model.ZakatDeduction },
                            { "Description", model.Description },
                            { "MaxWithdrawlPFNumber", model.MaxWithdrawlPFNumber },
                            { "MaxWithdrawlPFAmount", model.MaxWithdrawlPFAmount },
                            { "IsCalculatePFFromEffectiveDate", model.IsCalculatePFFromEffectiveDate },
                            { "IsPFRuleEmployeeContribution", model.IsPFRuleEmployeeContribution },
                            { "IsPFRuleEmployerContribution", model.IsPFRuleEmployerContribution },
                            { "IsPFRuleEmployeeProfit", model.IsPFRuleEmployeeProfit },
                            { "IsPFRuleEmployerProfit", model.IsPFRuleEmployerProfit },
                            { "EmployeeMaxContributionLimit", model.EmployeeMaxContributionLimit },
                            { "EmployerMaxContributionLimit", model.EmployerMaxContributionLimit },
                            { "IsYearly", model.IsYearly },
                        }
                };

                getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);

                if (getModel.Rows.Count > 0)
                {

                    int savedID = int.Parse(getModel.Rows[0]["ID"].ToString());

                    if (model.PFDetails != null)
                    {
                        foreach (var item in model.PFDetails)
                        {
                            data = new SpData
                            {
                                SpName = "[HRM].[WebCreateOrUpdatePFAllowance]",
                                Parameters = new Dictionary<string, object>
                                {
                                    { "PFCode", savedID },
                                    { "AllowanceOrBenefitCode", item.AllowanceOrBenefitCode },
                                    { "Description", item.Description },
                                    { "CompanyCode", model.CompanyCode },
                                    { "CreatedByCode", model.CreatedByCode },
                                    { "ID", item.ID },
                                    { "IsDeleted", item.IsDeleted }
                                }
                            };

                            new CommonRepository(ConStr).ExecStoreProcedure(data);
                        }
                    }

                    if (model.YearlyDetails != null)
                    {
                        foreach (var item in model.YearlyDetails)
                        {
                            data = new SpData
                            {
                                SpName = "[HRM].[WebCreateOrUpdatePFYearly]",
                                Parameters = new Dictionary<string, object>
                                {
                                    { "PFCode", savedID },
                                    { "EmployeeContribution", item.EmployeeContribution },
                                    { "EmployerContribution", item.EmployerContribution },
                                    { "YearCompleted", item.YearCompleted },
                                    { "CompanyCode", model.CompanyCode },
                                    { "userId", model.CreatedByCode },
                                    { "ID", item.ID },
                                    { "IsDeleted", item.IsDeleted }
                                }
                            };

                            new CommonRepository(ConStr).ExecStoreProcedure(data);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return getModel;
        }
        public bool CheckForDuplicates(VM_Provident model)
        {
            try
            {
                var isDuplicate = false;
                SpData data = new SpData
                {
                    SpName = "[HRM].[WebCheckDuplicatePF]",
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
    public class VM_Provident
    {
        public int ID { get; set; }
        public short PayGradeCode { get; set; }
        public byte EmployeeTypeCode { get; set; }
        public decimal EmployeeContribution { get; set; }
        public decimal EmployerContribution { get; set; }
        public bool? IsTaxDeduction { get; set; }
        public int CreatedByCode { get; set; }
        public int CompanyCode { get; set; }
        public decimal? ZakatDeduction { get; set; }
        public string Description { get; set; }
        public decimal? MaxWithdrawlPFNumber { get; set; }
        public decimal? MaxWithdrawlPFAmount { get; set; }
        public bool? IsCalculatePFFromEffectiveDate { get; set; }
        public bool? IsPFRuleEmployeeContribution { get; set; }
        public bool? IsPFRuleEmployerContribution { get; set; }
        public bool? IsPFRuleEmployeeProfit { get; set; }
        public bool? IsPFRuleEmployerProfit { get; set; }
        public decimal? EmployeeMaxContributionLimit { get; set; }
        public decimal? EmployerMaxContributionLimit { get; set; }
        public bool? IsYearly { get; set; }
        public List<VM_PFDetails> PFDetails { get; set; }
        public List<VM_YrDetails> YearlyDetails { get; set; }
    }
    public class VM_PFDetails
    {
        public int ID { get; set; }
        public int PFCode { get; set; }
        public short AllowanceOrBenefitCode { get; set; }
        public string AllowanceOrBenefit { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class VM_YrDetails
    {
        public int ID { get; set; }
        public long PFCode { get; set; }
        public decimal EmployeeContribution { get; set; }
        public decimal EmployerContribution { get; set; }
        public int YearCompleted { get; set; }
        public bool IsDeleted { get; set; }
    }
}

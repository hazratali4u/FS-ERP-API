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
    public class SocialSecurityController : ApiController
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
        [Route("~/Api/SocialSecurity/GetSocialSecurityDetails")]
        public HttpResponseMessage GetSocialSecurityDetails(int payGradeCode, int employeeTypeCode, int companyCode)
        {
            try
            {
                var details = GetSocialSecurityDetailsByID(payGradeCode, employeeTypeCode, companyCode);
                if (details == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }
                else
                {
                    if (details.Count == 0)
                    {
                        details = new List<VM_SocialSecurity>();
                        details.Add(new VM_SocialSecurity { });
                    }

                    details.FirstOrDefault().SocialSecurityDetails = GetSocialSecurityAllowanceDetailsBySocialSecurityCode(payGradeCode, employeeTypeCode, companyCode);

                    return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                    { IsSuccess = true, Message = "Success", Data = details }, formatter);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }

        public List<VM_SocialSecurity> GetSocialSecurityDetailsByID(int payGradeCode, int employeeTypeCode, int companyCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].GetSocialSecurityDetailsByID",
                    Parameters = new Dictionary<string, object>
                    {
                        { "PaygradeCode ", payGradeCode },
                        { "EmployeeTypeCode ", employeeTypeCode },
                        { "CompanyCode ", companyCode }
                    }
                };
                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<VM_SocialSecurity>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<VM_SocialSecurityDetails> GetSocialSecurityAllowanceDetailsBySocialSecurityCode(int payGradeCode, int employeeTypeCode, int companyCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].GetSocialSecurityAllowanceDetailsBySocialSecurityCode",
                    Parameters = new Dictionary<string, object>
                    {
                        { "PaygradeCode ", payGradeCode },
                        { "EmployeeTypeCode ", employeeTypeCode },
                        { "CompanyCode ", companyCode }
                    }
                };
                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<VM_SocialSecurityDetails>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("~/Api/SocialSecurity/SaveOrUpdateSocialSecurity")]
        public HttpResponseMessage SaveOrUpdateSocialSecurity(VM_SocialSecurity model)
        {
            try
            {
                DataTable getModel = new DataTable();

                //Check Duplicates
                var isDuplicate = CheckForDuplicates(model);

                if (isDuplicate)
                    return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                    { IsSuccess = false, Message = "Duplicate Record" }, formatter);

                getModel = SaveSocialSecurity(model);

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
        public DataTable SaveSocialSecurity(VM_SocialSecurity model)
        {
            var getModel = new DataTable();

            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].[WebCreateOrUpdateSocialSecurity]",
                    Parameters = new Dictionary<string, object>
                        {
                            { "PayGradeCode", model.PayGradeCode },
                            { "EmployeeTypeCode", model.EmployeeTypeCode },
                            { "EmployeeContribution", model.EmployeeContribution },
                            { "EmployerContribution", model.EmployerContribution },
                            { "SocialSecurityGrossAmount", model.SocialSecurityGrossAmount },
                            { "CompanyCode", model.CompanyCode },
                            { "CreatedByCode", model.CreatedByCode },
                            { "ID", model.ID },
                            { "SocialSecurityRuleEmployeeContribution", model.SocialSecurityRuleEmployeeContribution },
                            { "Description", model.Description },
                            { "SocialSecurityRuleEmployerContribution", model.SocialSecurityRuleEmployerContribution }
                        }
                };

                getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);

                if (getModel.Rows.Count > 0)
                {

                    int savedID = int.Parse(getModel.Rows[0]["ID"].ToString());

                    foreach (var item in model.SocialSecurityDetails)
                    {
                        data = new SpData
                        {
                            SpName = "[HRM].[WebCreateOrUpdateSocialSecurityAllowance]",
                            Parameters = new Dictionary<string, object>
                        {
                            { "SocialSecurityCode", savedID },
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
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return getModel;
        }
        public bool CheckForDuplicates(VM_SocialSecurity model)
        {
            try
            {
                var isDuplicate = false;
                SpData data = new SpData
                {
                    SpName = "[HRM].[WebCheckDuplicateSocialSecurity]",
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
    public class VM_SocialSecurity
    {
        public int ID { get; set; }
        public short PayGradeCode { get; set; }
        public byte EmployeeTypeCode { get; set; }
        public decimal EmployeeContribution { get; set; }
        public decimal? EmployerContribution { get; set; }
        public decimal SocialSecurityGrossAmount { get; set; }
        public int CreatedByCode { get; set; }
        public int CompanyCode { get; set; }
        public decimal SocialSecurityRuleEmployeeContribution { get; set; }
        public string Description { get; set; }
        public decimal SocialSecurityRuleEmployerContribution { get; set; }
        public List<VM_SocialSecurityDetails> SocialSecurityDetails { get; set; }
    }
    public class VM_SocialSecurityDetails
    {
        public int ID { get; set; }
        public int SocialSecurityCode { get; set; }
        public short AllowanceOrBenefitCode { get; set; }
        public string AllowanceOrBenefit { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
    }
}

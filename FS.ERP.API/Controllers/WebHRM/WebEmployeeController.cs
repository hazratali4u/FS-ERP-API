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
    public class WebEmployeeController : ApiController
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
        [Route("~/api/EmployeeInfo/GetEmployeeDDLs")]
        public HttpResponseMessage GetEmployeeDDLs(int companyCode)
        {
            try
            {
                var getModel = new FS.CAPI.BAL.HRM.EmployeeInfoRepositiry(ConStr).GetEmployeeDDLs(companyCode);
                if (getModel == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK, getModel, new JsonMediaTypeFormatter());
            }
            catch (Exception ex)
            {
                //LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetUserMenu", "tbl_Menu", "dbo.ProcGetUserMenu", ex, false, false);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, new JsonMediaTypeFormatter());
            }
        }
        #region Job
        [HttpPost]
        [Route("~/api/ProfileData/SaveEmployeeAllownceAndDeductions")]
        public HttpResponseMessage SaveEmployeeAllownceAndDeductions(AllowancesAndDeductions allowancesDeductions)
        {
            try
            {
                var getModel = new DataTable();
                foreach (var det in allowancesDeductions.EmployeeAllowancesAndDeductions)
                {
                    //if (det.AllowanceOrBenefitAmount > 0 || det.AllowanceOrBenefitRatio > 0)
                    //{
                    SpData data = new SpData
                    {
                        SpName = "[HRM].[WebSaveOrUpdateAllowancesOrDeductions]",
                        Parameters = new Dictionary<string, object>
                            {
                                { "EmpCode", det.EmpCode },
                                { "AllowanceOrBenefitAmount", det.AllowanceOrBenefitAmount },
                                { "AllowanceOrBenefitRatio", det.AllowanceOrBenefitRatio },
                                { "AllowanceOrBenefitTypeCode", det.AllowanceOrBenefitTypeCode },
                                { "ID", det.ID },
                                { "CreatedByCode", det.CreatedByCode },
                                { "CompanyCode", det.CompanyCode },
                                { "SalaryTransferMode", allowancesDeductions.SalaryTransferMode },
                                { "PayGradeCode", allowancesDeductions.PayGradeCode },
                                { "GrossSalary", allowancesDeductions.GrossSalary }
                            }
                    };

                    getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                    if (getModel == null)
                    {
                        return Request.CreateResponse(HttpStatusCode.NotFound);
                    }
                    //}
                }

                return Request.CreateResponse(HttpStatusCode.OK, getModel, new JsonMediaTypeFormatter());
            }

            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, new JsonMediaTypeFormatter());
            }
        }
        [HttpGet]
        [Route("~/api/ProfileData/GetEmployeeAllownceAndDeductions")]
        public HttpResponseMessage GetEmployeeAllownceAndDeductions(long empCode)
        {
            try
            {
                AllowancesAndDeductions allowancesDeductions = new AllowancesAndDeductions();

                var employeeDataSet = GetEmployeeByID(empCode);

                if (employeeDataSet != null && employeeDataSet.Tables.Count > 0)
                {
                    var employee = employeeDataSet.Tables[0];
                    if (employee != null && employee.Rows.Count > 0)
                    {
                        allowancesDeductions.PayGradeCode = Convert.ToInt16(employee.Rows[0]["PayGradeCode"].ToString());
                        allowancesDeductions.SalaryTransferMode = Convert.ToInt16(employee.Rows[0]["SalaryTransferMode"].ToString());
                        allowancesDeductions.CompanyCode = Convert.ToInt16(employee.Rows[0]["CompanyCode"].ToString());
                        allowancesDeductions.GrossSalary = Convert.ToDecimal(employee.Rows[0]["GrossSalary"].ToString());

                        var salaryData = employeeDataSet.Tables[1];
                        allowancesDeductions.SalaryFrom = salaryData.Rows[0]["SalaryFrom"].ToString();
                        allowancesDeductions.SalaryTo = salaryData.Rows[0]["SalaryTo"].ToString();

                        allowancesDeductions.EmployeeAllowancesAndDeductions = GetEmployeeAllownceAndDeductions(allowancesDeductions.CompanyCode,
                        empCode, allowancesDeductions.PayGradeCode);
                    }
                    if (employee == null)
                    {
                        return Request.CreateResponse(HttpStatusCode.NotFound);
                    }
                }

                return Request.CreateResponse(HttpStatusCode.OK, allowancesDeductions, new JsonMediaTypeFormatter());
            }

            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, new JsonMediaTypeFormatter());
            }
        }
        public List<EmployeeAllowanceOrDeductions> GetEmployeeAllownceAndDeductions(int companyCode, long empCode, short? payGradeCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].[ProcGetEmpEarnDedAndPayGradeEarnDedsAll]",
                    Parameters = new Dictionary<string, object> { { "EmpCode", empCode },
                    { "PayGradeCode", payGradeCode },
                    { "CompanyCode", companyCode }
                    }
                };

                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<EmployeeAllowanceOrDeductions>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetEmployeeByID(long empCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].[getEmployeeDetailsByID]",
                    Parameters = new Dictionary<string, object> { { "empCode", empCode } }
                };

                return new CommonRepository(ConStr).ExecStoreProcedureForAllDataSets(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Qualification

        [HttpGet]
        [Route("~/Api/Employee/GetQualificationDetails")]
        public HttpResponseMessage GetQualificationDetails(long empCode)
        {
            try
            {
                var details = GetQualificationDetailsByEmpCode(empCode);
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

        public List<QualificationModel> GetQualificationDetailsByEmpCode(long empCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].GetQualificationDetailsByEmpCode",
                    Parameters = new Dictionary<string, object> { { "empCode", empCode } }
                };
                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<QualificationModel>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("~/Api/Employee/SaveOrUpdateEmpQualification")]
        public HttpResponseMessage SaveOrUpdateEmployeeQualification(List<QualificationModel> model)
        {
            try
            {
                DataTable getModel = new DataTable();

                //Check Duplicates
                var isDuplicate = CheckForDuplicates(model);

                if (isDuplicate)
                    return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                    { IsAlert = true, IsSuccess = false, Message = "Duplicate Record" }, formatter);

                getModel = SaveQualification(model);

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
        public DataTable SaveQualification(List<QualificationModel> model)
        {
            var getModel = new DataTable();

            try
            {
                foreach (var item in model)
                {
                    SpData data = new SpData
                    {
                        SpName = "[HRM].[WebCreateOrUpdateQualification]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "EmpCode", item.EmpCode },
                            { "DegreeCode", item.DegreeCode },
                            { "DegreeInstituteCode", item.DegreeInstituteCode },
                            { "SpecializationOrSubject", item.SpecializationOrSubject },
                            { "StartFrom", item.StartFrom },
                            { "EndTo", item.EndTo },
                            { "PassingYear", item.PassingYear },
                            { "GradeOrDivision", item.GradeOrDivision },
                            { "CGPA", item.CGPA },
                            { "Marks", item.Marks },
                            { "MajorSubjects", item.MajorSubjects },
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
        public bool CheckForDuplicates(List<QualificationModel> model)
        {
            try
            {
                var isDuplicate = false;
                foreach (var item in model)
                {
                    SpData data = new SpData
                    {
                        SpName = "[HRM].[WebCheckDuplicateForQualification]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "EmpCode", item.EmpCode },
                            { "DegreeCode", item.DegreeCode },
                            { "CompanyCode", item.CompanyCode },
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

        #region Employment History
        [HttpGet]
        [Route("~/Api/Employee/GetEmploymentDetails")]
        public List<EmployementHistoryModel> GetEmploymentDetailsByEmpCode(long empCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].GetEmploymentDetailsByEmpCode",
                    Parameters = new Dictionary<string, object> { { "empCode", empCode } }
                };
                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<EmployementHistoryModel>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("~/Api/Employee/SaveOrUpdateEmploymentHistory")]
        public HttpResponseMessage SaveOrUpdateEmploymentHistory(List<EmployementHistoryModel> model)
        {
            try
            {
                DataTable getModel = new DataTable();

                //Check Duplicates
                var isDuplicate = CheckForDuplicateEmploymentHistory(model);

                if (isDuplicate)
                    return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                    { IsAlert = true, IsSuccess = false, Message = "Duplicate Record" }, formatter);

                getModel = SaveEmployment(model);

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
        public DataTable SaveEmployment(List<EmployementHistoryModel> model)
        {
            var getModel = new DataTable();

            try
            {
                foreach (var item in model)
                {
                    SpData data = new SpData
                    {
                        SpName = "[HRM].[WebCreateOrUpdateEmployment]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "EmpCode", item.EmpCode },
                            { "OrganizationName", item.OrganizationName.Trim() },
                            { "PositionOrTitle", item.PositionOrTitle },
                            { "BasicPay", item.BasicPay },
                            { "StartFrom", item.StartFrom },
                            { "EndTo", item.EndTo },
                            { "Phone", item.Phone },
                            { "Email", item.Email },
                            { "URL", item.URL },
                            { "Address", item.Address },
                            { "EntitledBenifits", item.EntitledBenifits },
                            { "KeyResponsibilities", item.KeyResponsibilities },
                            { "ReasonforLeaving", item.ReasonforLeaving },
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

        public bool CheckForDuplicateEmploymentHistory(List<EmployementHistoryModel> model)
        {
            try
            {
                var isDuplicate = false;
                foreach (var item in model)
                {
                    SpData data = new SpData
                    {
                        SpName = "[HRM].[WebCheckDuplicateForEmployment]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "EmpCode", item.EmpCode },
                            { "OrganizationName", item.OrganizationName != null ? item.OrganizationName.Trim() : item.OrganizationName },
                            { "CompanyCode", item.CompanyCode },
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

        #region Family
        [HttpGet]
        [Route("~/Api/Employee/GetEmployeeFamilyInfo")]
        public List<FamilyModel> GetEmployeeFamilyInfo(long empCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].GetFamilyInfoByEmpCode",
                    Parameters = new Dictionary<string, object> { { "empCode", empCode } }
                };

                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<FamilyModel>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        [Route("~/Api/Employee/SaveOrUpdateFamilyInfo")]
        public HttpResponseMessage SaveOrUpdateFamilyInfo(List<FamilyModel> model)
        {
            try
            {
                DataTable getModel = new DataTable();

                //Check Duplicates
                var isDuplicate = CheckForDuplicateFamily(model);

                if (isDuplicate)
                    return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                    { IsAlert = true, IsSuccess = false, Message = "Duplicate Record" }, formatter);

                getModel = SaveFamily(model);

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
        public DataTable SaveFamily(List<FamilyModel> model)
        {
            var getModel = new DataTable();

            try
            {
                foreach (var item in model)
                {
                    SpData data = new SpData
                    {
                        SpName = "[HRM].[WebCreateOrEmpFamily]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "EmpCode", item.EmpCode },
                            { "FamilyPersonName", item.FamilyPersonName.Trim() },
                            { "RelationCode", item.RelationCode },
                            { "Occupation", item.Occupation },
                            { "DOB", item.DOB },
                            { "DOM", item.DOM },
                            { "Age", item.Age },
                            { "PhoneNo", item.PhoneNo },
                            { "CNICNo", item.CNICNo },
                            { "BloodGroup", item.BloodGroup },
                            { "PassportNo", item.PassportNo },
                            { "PassportExpiryDate", item.PassportExpiryDate },
                            { "VisaSponsorshipExpiryDate", item.VisaSponsorshipExpiryDate },
                            { "IsNominee", item.IsNominee },
                            { "IsDependent", item.IsDependent },
                            { "IsCoveredUnderMedicalPolicy", item.IsCoveredUnderMedicalPolicy },
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
        public bool CheckForDuplicateFamily(List<FamilyModel> model)
        {
            try
            {
                var isDuplicate = false;
                foreach (var item in model)
                {
                    SpData data = new SpData
                    {
                        SpName = "[HRM].[WebCheckDuplicateForEmpFamily]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "EmpCode", item.EmpCode },
                            { "CNICNo", item.CNICNo != null ? item.CNICNo.Trim() : item.CNICNo },
                            { "FamilyPersonName", item.FamilyPersonName != null ? item.FamilyPersonName.Trim() : item.FamilyPersonName },
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

        #region Geo Restriction
        [HttpGet]
        [Route("~/Api/Employee/GetGeoRestrictionDetails")]
        public List<GeoRestrictionModel> GetGeoRestrictionDetails(long empCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].GetGeoRestrictionByEmpCode",
                    Parameters = new Dictionary<string, object> { { "empCode", empCode } }
                };

                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<GeoRestrictionModel>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        [Route("~/Api/Employee/SaveOrUpdateGeoRestriction")]
        public HttpResponseMessage SaveOrUpdateGeoRestriction(List<GeoRestrictionModel> model)
        {
            try
            {
                DataTable getModel = new DataTable();
                getModel = SaveGeoRestriction(model);

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
        public DataTable SaveGeoRestriction(List<GeoRestrictionModel> model)
        {
            var getModel = new DataTable();

            try
            {
                foreach (var item in model)
                {
                    SpData data = new SpData
                    {
                        SpName = "[HRM].[WebCreateOrUpdateGeoRestriction]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "EmpCode", item.EmpCode },
                            { "CanMarkAttendance", item.CanMarkAttendance },
                            { "Logitude", item.Logitude },
                            { "Latitude", item.Latitude },
                            { "Radius", item.Radius },
                            { "IMEINo", item.IMEINo },
                            { "Remarks", item.Remarks },
                            { "AllLocationsAllowed", item.AllLocationsAllowed },
                            { "CompanyCode", item.CompanyCode },
                            { "CreatedByCode", item.CreatedByCode },
                            { "ID", item.ID },
                            { "IsDeleted", item.IsDeleted },
                            { "IPAddress", item.IPAddress }
                            
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

        #region Award
        [HttpGet]
        [Route("~/Api/Employee/GetAwardsDetail")]
        public List<AwardModel> GetAwardsDetail(long empCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].GetAwardDetailsByEmpCode",
                    Parameters = new Dictionary<string, object> { { "empCode", empCode } }
                };

                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<AwardModel>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        [Route("~/Api/Employee/SaveOrUpdateAward")]
        public HttpResponseMessage SaveOrUpdateAward(List<AwardModel> model)
        {
            try
            {
                DataTable getModel = new DataTable();

                //Check Duplicates
                var isDuplicate = CheckForDuplicateAward(model);

                if (isDuplicate)
                    return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                    { IsAlert = true, IsSuccess = false, Message = "Duplicate Record" }, formatter);

                getModel = SaveAward(model);

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
        public DataTable SaveAward(List<AwardModel> model)
        {
            var getModel = new DataTable();

            try
            {
                foreach (var item in model)
                {
                    SpData data = new SpData
                    {
                        SpName = "[HRM].[WebCreateOrUpdateAward]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "EmpCode", item.EmpCode },
                            { "AwardName", item.AwardName.Trim() },
                            { "AwardDate", item.AwardDate },
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
        public bool CheckForDuplicateAward(List<AwardModel> model)
        {
            try
            {
                var isDuplicate = false;
                foreach (var item in model)
                {
                    SpData data = new SpData
                    {
                        SpName = "[HRM].[WebCheckDuplicateForEmpAward]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "EmpCode", item.EmpCode },
                            { "AwardName", item.AwardName != null ? item.AwardName.Trim() : item.AwardName },
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

        #region Relative
        [HttpGet]
        [Route("~/Api/Employee/GetRelativeDetails")]
        public List<RelativeModel> GetRelativeDetails(long empCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].GetRelativeDetailsByEmpCode",
                    Parameters = new Dictionary<string, object> { { "empCode", empCode } }
                };

                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<RelativeModel>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        [Route("~/Api/Employee/SaveOrUpdateRelative")]
        public HttpResponseMessage SaveOrUpdateRelative(List<RelativeModel> model)
        {
            try
            {
                DataTable getModel = new DataTable();

                //Check Duplicates
                var isDuplicate = CheckForDuplicateRelative(model);

                if (isDuplicate)
                    return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                    { IsAlert = true, IsSuccess = false, Message = "Duplicate Record" }, formatter);

                getModel = SaveRelative(model);

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
        public DataTable SaveRelative(List<RelativeModel> model)
        {
            var getModel = new DataTable();

            try
            {
                foreach (var item in model)
                {
                    SpData data = new SpData
                    {
                        SpName = "[HRM].[WebCreateOrUpdateRelative]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "EmpCode", item.EmpCode },
                            { "RelativeEmpCode", item.RelativeEmpCode },
                            { "RelationCode", item.RelationCode },
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
        public bool CheckForDuplicateRelative(List<RelativeModel> model)
        {
            try
            {
                var isDuplicate = false;
                foreach (var item in model)
                {
                    SpData data = new SpData
                    {
                        SpName = "[HRM].[WebCheckDuplicateForEmpRelative]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "EmpCode", item.EmpCode },
                            { "RelativeEmpCode", item.RelativeEmpCode },
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

        #region Incident
        [HttpGet]
        [Route("~/Api/Employee/GetIncidentDetails")]
        public List<IncidentModel> GetIncidentDetails(long empCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].GetIncidentDetailsByEmpCode",
                    Parameters = new Dictionary<string, object> { { "empCode", empCode } }
                };

                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<IncidentModel>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        [Route("~/Api/Employee/SaveOrUpdateIncident")]
        public HttpResponseMessage SaveOrUpdateIncident(List<IncidentModel> model)
        {
            try
            {
                DataTable getModel = new DataTable();

                //Check Duplicates
                var isDuplicate = CheckForDuplicateIncident(model);

                if (isDuplicate)
                    return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                    { IsAlert = true, IsSuccess = false, Message = "Duplicate Record" }, formatter);

                getModel = SaveIncident(model);

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
        public DataTable SaveIncident(List<IncidentModel> model)
        {
            var getModel = new DataTable();

            try
            {
                foreach (var item in model)
                {
                    SpData data = new SpData
                    {
                        SpName = "[HRM].[WebCreateOrUpdateIncident]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "EmpCode", item.EmpCode },
                            { "IncidentCode", item.IncidentCode },
                            { "IncidentDate", item.IncidentDate },
                            { "IncidentCause", item.IncidentCause },
                            { "ActionTaken", item.ActionTaken },
                            { "ActionDate", item.ActionDate },
                            { "IsWarningIssued", item.IsWarningIssued },
                            { "IncidentDetails", item.IncidentDetails },
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
        public bool CheckForDuplicateIncident(List<IncidentModel> model)
        {
            try
            {
                var isDuplicate = false;
                foreach (var item in model)
                {
                    SpData data = new SpData
                    {
                        SpName = "[HRM].[WebCheckDuplicateForEmpIncident]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "EmpCode", item.EmpCode },
                            { "IncidentCode", item.IncidentCode },
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

        #region Reference
        [HttpGet]
        [Route("~/Api/Employee/GetReferenceDetails")]
        public List<ReferenceModel> GetReferenceDetails(long empCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].GetReferenceDetailsByEmpCode",
                    Parameters = new Dictionary<string, object> { { "empCode", empCode } }
                };

                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<ReferenceModel>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        [Route("~/Api/Employee/SaveOrUpdateReference")]
        public HttpResponseMessage SaveOrUpdateReference(List<ReferenceModel> model)
        {
            try
            {
                DataTable getModel = new DataTable();

                //Check Duplicates
                var isDuplicate = CheckForDuplicateReference(model);

                if (isDuplicate)
                    return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                    { IsAlert = true, IsSuccess = false, Message = "Duplicate Record" }, formatter);

                getModel = SaveReference(model);

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
        public DataTable SaveReference(List<ReferenceModel> model)
        {
            var getModel = new DataTable();

            try
            {
                foreach (var item in model)
                {
                    SpData data = new SpData
                    {
                        SpName = "[HRM].[WebCreateOrUpdateReference]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "EmpCode", item.EmpCode },
                            { "EmployeeRelationCode", item.EmployeeRelationCode },
                            { "PersonName", item.PersonName.Trim() },
                            { "Mobile", item.Mobile },
                            { "OrganizationName", item.OrganizationName.Trim() },
                            { "Address", item.Address },
                            { "Phone", item.Phone },
                            { "Email", item.Email },
                            { "URL", item.URL },
                            { "PositionOrTitle", item.PositionOrTitle },
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
        public bool CheckForDuplicateReference(List<ReferenceModel> model)
        {
            try
            {
                var isDuplicate = false;
                foreach (var item in model)
                {
                    SpData data = new SpData
                    {
                        SpName = "[HRM].[WebCheckDuplicateForEmpReference]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "EmpCode", item.EmpCode },
                            { "PersonName", item.PersonName != null ? item.PersonName.Trim() : item.PersonName },
                            { "PositionOrTitle", item.PositionOrTitle != null ? item.PositionOrTitle.Trim() : item.PositionOrTitle },
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

        #region Attribute
        [HttpGet]
        [Route("~/Api/Employee/GetEmpAttributeDetails")]
        public List<EmployeeAttributeModel> GetEmpAttributeDetails(long empCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].GetAttributeDetailsByEmpCode",
                    Parameters = new Dictionary<string, object> { { "empCode", empCode } }
                };

                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<EmployeeAttributeModel>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        [Route("~/Api/Employee/SaveOrUpdateEmpAttribute")]
        public HttpResponseMessage SaveOrUpdateEmpAttribute(List<EmployeeAttributeModel> model)
        {
            try
            {
                DataTable getModel = new DataTable();

                //Check Duplicates
                var isDuplicate = CheckForDuplicateEmpAttribute(model);

                if (isDuplicate)
                    return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                    { IsAlert = true, IsSuccess = false, Message = "Duplicate Record" }, formatter);

                getModel = SaveEmpAttrubute(model);

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
        public DataTable SaveEmpAttrubute(List<EmployeeAttributeModel> model)
        {
            var getModel = new DataTable();

            try
            {
                foreach (var item in model)
                {
                    SpData data = new SpData
                    {
                        SpName = "[HRM].[WebCreateOrUpdateEmpAttribute]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "EmpCode", item.EmpCode },
                            { "AttributeType", item.AttributeType },
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
        public bool CheckForDuplicateEmpAttribute(List<EmployeeAttributeModel> model)
        {
            try
            {
                var isDuplicate = false;
                foreach (var item in model)
                {
                    SpData data = new SpData
                    {
                        SpName = "[HRM].[WebCheckDuplicateForEmpAttribute]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "EmpCode", item.EmpCode },
                            { "AttributeType", item.AttributeType },
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

        #region Management Remarks
        [HttpGet]
        [Route("~/Api/Employee/GetManagementRemarks")]
        public List<ManageRemarksModel> GetManagementRemarks(long empCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].GetManagementRemarksByEmpCode",
                    Parameters = new Dictionary<string, object> { { "empCode", empCode } }
                };

                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<ManageRemarksModel>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        [Route("~/Api/Employee/SaveOrUpdateManagRemarks")]
        public HttpResponseMessage SaveOrUpdateManagRemarks(List<ManageRemarksModel> model)
        {
            try
            {
                DataTable getModel = new DataTable();
                getModel = SaveManagRemarks(model);

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
        public DataTable SaveManagRemarks(List<ManageRemarksModel> model)
        {
            var getModel = new DataTable();

            try
            {
                foreach (var item in model)
                {
                    SpData data = new SpData
                    {
                        SpName = "[HRM].[WebCreateOrUpdateManagRemarks]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "EmpCode", item.EmpCode },
                            { "RemarksDate", item.RemarksDate },
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
    public class ManageRemarksModel
    {
        public long ID { get; set; }
        public long EmpCode { get; set; }
        public DateTime RemarksDate { get; set; }
        public string Remarks { get; set; }
        public int CompanyCode { get; set; }
        public int CreatedByCode { get; set; }
        public bool IsDeleted { get; set; }
    }
    public class EmployeeAttributeModel
    {
        public long ID { get; set; }
        public long EmpCode { get; set; }
        public string AttributeType { get; set; }
        public string Remarks { get; set; }
        public int CompanyCode { get; set; }
        public int CreatedByCode { get; set; }
        public bool IsDeleted { get; set; }
    }
    public class ReferenceModel
    {
        public long ID { get; set; }
        public long EmpCode { get; set; }
        public long EmployeeRelationCode { get; set; }
        public string PersonName { get; set; }
        public string Mobile { get; set; }
        public string OrganizationName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Remarks { get; set; }
        public string URL { get; set; }
        public string PositionOrTitle { get; set; }
        public int CompanyCode { get; set; }
        public int CreatedByCode { get; set; }
        public string IncidentName { get; set; }
        public string Relation { get; set; }
        public bool IsDeleted { get; set; }
    }
    public class IncidentModel
    {
        public long ID { get; set; }
        public long EmpCode { get; set; }
        public long IncidentCode { get; set; }
        public DateTime IncidentDate { get; set; }
        public string IncidentCause { get; set; }
        public string ActionTaken { get; set; }
        public DateTime? ActionDate { get; set; }
        public bool? IsWarningIssued { get; set; }
        public string IncidentDetails { get; set; }
        public string Remarks { get; set; }
        public int CompanyCode { get; set; }
        public int CreatedByCode { get; set; }
        public string IncidentName { get; set; }
        public bool IsDeleted { get; set; }
    }
    public class RelativeModel
    {
        public long ID { get; set; }
        public long EmpCode { get; set; }
        public long RelativeEmpCode { get; set; }
        public byte RelationCode { get; set; }
        public int CompanyCode { get; set; }
        public int CreatedByCode { get; set; }
        public DateTime? DoJ { get; set; }
        public string Status { get; set; }
        public string Relation { get; set; }
        public string RelativeEmpName { get; set; }
        public bool IsDeleted { get; set; }
    }
    public class AwardModel
    {
        public long ID { get; set; }
        public long EmpCode { get; set; }
        public string AwardName { get; set; }
        public DateTime AwardDate { get; set; }
        public string Remarks { get; set; }
        public int CompanyCode { get; set; }
        public int CreatedByCode { get; set; }
        public bool IsDeleted { get; set; }
    }
    public class GeoRestrictionModel
    {
        public long ID { get; set; }
        public long EmpCode { get; set; }
        public int CanMarkAttendance { get; set; }
        public string Logitude { get; set; }
        public string Latitude { get; set; }
        public string Radius { get; set; }
        public string Remarks { get; set; }
        public string IMEINo { get; set; }
        public string IPAddress { get; set; }
        public bool? AllLocationsAllowed { get; set; }
        public int CompanyCode { get; set; }
        public int CreatedByCode { get; set; }
        public bool IsDeleted { get; set; }
    }
    public class QualificationModel {
        public long ID { get; set; }
        public long EmpCode { get; set; }
        public int DegreeCode { get; set; }
        public int? DegreeInstituteCode { get; set; }
        public string SpecializationOrSubject { get; set; }
        public DateTime? StartFrom { get; set; }
        public DateTime? EndTo { get; set; }
        public DateTime? PassingYear { get; set; }
        public string GradeOrDivision { get; set; }
        public string CGPA { get; set; }
        public string Marks { get; set; }
        public string MajorSubjects { get; set; }
        public string Remarks { get; set; }
        public int CompanyCode { get; set; }
        public int CreatedByCode { get; set; }
        public string Degree { get; set; }
        public string DegreeInstitute { get; set; }
        public bool IsDeleted { get; set; }
    }
    public class EmployementHistoryModel
    {
        public long ID { get; set; }
        public long EmpCode { get; set; }
        public string OrganizationName { get; set; }
        public string PositionOrTitle { get; set; }
        public decimal BasicPay { get; set; }
        public DateTime? StartFrom { get; set; }
        public DateTime? EndTo { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string URL { get; set; }
        public string Address { get; set; }
        public string EntitledBenifits { get; set; }
        public string KeyResponsibilities { get; set; }
        public string ReasonforLeaving { get; set; }
        public int CompanyCode { get; set; }
        public int CreatedByCode { get; set; }
        public bool IsDeleted { get; set; }
    }
    public class FamilyModel
    {
        public long ID { get; set; }
        public long EmpCode { get; set; }
        public string FamilyPersonName { get; set; }
        public byte RelationCode { get; set; }
        public string Occupation { get; set; }
        public DateTime? DOB { get; set; }
        public DateTime? DOM { get; set; }
        public decimal? Age { get; set; }
        public string PhoneNo { get; set; }
        public string CNICNo { get; set; }
        public string BloodGroup { get; set; }
        public string PassportNo { get; set; }
        public DateTime? PassportExpiryDate { get; set; }
        public DateTime? VisaSponsorshipExpiryDate { get; set; }
        public bool? IsNominee { get; set; }
        public bool? IsDependent { get; set; }
        public bool? IsCoveredUnderMedicalPolicy { get; set; }
        public string Remarks { get; set; }
        public int CompanyCode { get; set; }
        public int CreatedByCode { get; set; }
        public string Relation { get; set; }
        public bool IsDeleted { get; set; }
    }
    public class AllowancesAndDeductions
    {
        public int? SalaryTransferMode { get; set; }
        public short? PayGradeCode { get; set; }
        public int CompanyCode { get; set; }
        public string SalaryFrom { get; set; }
        public string SalaryTo { get; set; }
        public decimal GrossSalary { get; set; }
        public List<EmployeeAllowanceOrDeductions> EmployeeAllowancesAndDeductions { get; set; }
    }
    public class EmployeeAllowanceOrDeductions
    {
        public long EmpCode { get; set; }
        public decimal AllowanceOrBenefitAmount { get; set; }
        public decimal AllowanceOrBenefitRatio { get; set; }
        public int AllowanceOrBenefitTypeCode { get; set; }
        public string FullName { get; set; }
        public long BaseCode { get; set; }
        public bool IsMandatoryAllowance { get; set; }
        public bool IsAllowance { get; set; }
        public int CompanyCode { get; set; }
        public int CreatedByCode { get; set; }
        public int ID { get; set; }
    }
}

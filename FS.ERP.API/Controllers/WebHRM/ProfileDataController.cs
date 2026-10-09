using CST.CCL.Helper;
using CST.CCL.Helper.Common;
using CST.CRY;
using FS.CAPI.BAL;
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
    public class ProfileDataController : ApiController
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

        [HttpPost]
        [Route("~/api/ProfileData/Grade")]
        //[CacheFilter(TimeDuration = 60)]
        public HttpResponseMessage Grade(GradeModel gradeData)
        {
            try
             {
                if (gradeData != null)
                {
                    // save order 1st

                    SpData data = new SpData
                    {
                        SpName = "[HRM].[WebGradeSave]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "ID", gradeData.ID },
                            { "FullName", gradeData.FullName },
                            { "DisplayName", gradeData.DisplayName },
                            { "SalaryFrom", gradeData.SalaryFrom },
                            { "SalaryTo", gradeData.SalaryTo },
                            { "IsExceedingAllowed", gradeData.IsExceedingAllowed },
                            { "ApprovalWorkFlow", gradeData.ApprovalWorkFlow },
                            { "NotificationEmailIds", gradeData.NotificationEmailIds },
                            { "PayrollGroupCode", gradeData.PayrollGroupCode },
                            { "PayrollGroupDesc", gradeData.PayrollGroupDesc },
                            { "UserCode", gradeData.UserCode },
                            { "CompanyCode", gradeData.CompanyCode },
                            { "Description", gradeData.Description }
                        }
                    };

                    var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                    var ordModel = getModel;
                    if (getModel == null)
                    {
                        return Request.CreateResponse(HttpStatusCode.NotFound);
                    }
                    else
                    {
                        long gradeCode = 0; // get from above model getModel

                        foreach (DataRow row in getModel.Rows)
                        {
                            gradeCode = Convert.ToInt64(row[1].ToString());
                        }

                        foreach (var det in gradeData.GradeBenefits)
                        {
                            data = new SpData
                            {
                                SpName = "[HRM].[WebGradeBenefitSave]",
                                Parameters = new Dictionary<string, object>
                                {
                                    { "ID", det.ID },
                                    { "PayGradeCode", gradeCode },
                                    { "AllowanceOrBenefitCode", det.AllowanceOrBenefitCode },
                                    { "AllowanceOrBenefitAmount", det.AllowanceOrBenefitAmount },
                                    { "AllowanceOrBenefitRatio", det.AllowanceOrBenefitRatio },
                                    { "Description", det.Description },
                                    { "CompanyCode", gradeData.CompanyCode },
                                    { "UserCode", gradeData.UserCode },
                                    { "IsDeleted", det.IsDeleted }
                                }
                            };

                            getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                            if (getModel == null)
                            {
                                return Request.CreateResponse(HttpStatusCode.NotFound);
                            }
                        }
                        //Deductions
                        foreach (var det in gradeData.GradeDeductions)
                        {
                            data = new SpData
                            {
                                SpName = "[HRM].[WebGradeDeductionSave]",
                                Parameters = new Dictionary<string, object>
                                {
                                    { "ID", det.ID },
                                    { "PayGradeCode", gradeCode },
                                    { "DeductionTypeCode", det.DeductionTypeCode },
                                    { "DeductionAmount", det.DeductionAmount },
                                    { "DeductionRatio", det.DeductionRatio },
                                    { "Description", det.Description },
                                    { "CompanyCode", gradeData.CompanyCode },
                                    { "UserCode", gradeData.UserCode },
                                    { "IsDeleted", det.IsDeleted }
                                }
                            };

                            getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                            if (getModel == null)
                            {
                                return Request.CreateResponse(HttpStatusCode.NotFound);
                            }
                        }
                        //Bonus
                        foreach (var det in gradeData.Bonuses)
                        {
                            data = new SpData
                            {
                                SpName = "[HRM].[WebGradeBonusSave]",
                                Parameters = new Dictionary<string, object>
                                {
                                    { "ID", det.ID },
                                    { "PayGradeCode", gradeCode },
                                    { "BonusTypeCode", det.BonusTypeCode },
                                    { "Description", det.Description },
                                    { "CompanyCode", gradeData.CompanyCode },
                                    { "UserCode", gradeData.UserCode },
                                    { "IsDeleted", det.IsDeleted }
                                }
                            };

                            getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                            if (getModel == null)
                            {
                                return Request.CreateResponse(HttpStatusCode.NotFound);
                            }
                        }
                        //Asset Type Allocation
                        foreach (var det in gradeData.Assets)
                        {
                            data = new SpData
                            {
                                SpName = "[HRM].[WebGradeAssetSave]",
                                Parameters = new Dictionary<string, object>
                                {
                                    { "ID", det.ID },
                                    { "PayGradeCode", gradeCode },
                                    { "AssetTypeCode", det.AssetTypeCode },
                                    { "AssetAmountLimit", det.AssetAmountLimit },
                                    { "Description", det.Description },
                                    { "CompanyCode", gradeData.CompanyCode },
                                    { "UserCode", gradeData.UserCode },
                                    { "IsDeleted", det.IsDeleted }
                                }
                            };

                            getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                            if (getModel == null)
                            {
                                return Request.CreateResponse(HttpStatusCode.NotFound);
                            }
                        }
                        //Document Checklist
                        foreach (var det in gradeData.DocumentCheckList)
                        {
                            data = new SpData
                            {
                                SpName = "[HRM].[WebGradeDocumentCheckListSave]",
                                Parameters = new Dictionary<string, object>
                                {
                                    { "ID", det.ID },
                                    { "PayGradeCode", gradeCode },
                                    { "DocCode", det.DocCode },
                                    { "Compulsory", det.Compulsory },
                                    { "Description", det.Description },
                                    { "CompanyCode", gradeData.CompanyCode },
                                    { "UserCode", gradeData.UserCode },
                                    { "IsDeleted", det.IsDeleted }
                                }
                            };

                            getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                            if (getModel == null)
                            {
                                return Request.CreateResponse(HttpStatusCode.NotFound);
                            }
                        }
                        //Expense Limit
                        foreach (var det in gradeData.ExpenseLimit)
                        {
                            data = new SpData
                            {
                                SpName = "[HRM].[WebGradeExpenseLimitSave]",
                                Parameters = new Dictionary<string, object>
                                {
                                    { "ID", det.ID },
                                    { "PayGradeCode", gradeCode },
                                    { "ExpenseTypeCode", det.ExpenseTypeCode },
                                    { "CalculationCriteria", det.CalculationCriteria },
                                    { "ExpenseLimit", det.ExpenseLimit },
                                    { "Description", det.Description },
                                    { "CompanyCode", gradeData.CompanyCode },
                                    { "UserCode", gradeData.UserCode },
                                    { "IsDeleted", det.IsDeleted }
                                }
                            };

                            getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                            if (getModel == null)
                            {
                                return Request.CreateResponse(HttpStatusCode.NotFound);
                            }
                        }
                    }


                    return Request.CreateResponse(HttpStatusCode.OK, ordModel, new JsonMediaTypeFormatter());
                }
                //var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);

                return Request.CreateResponse(HttpStatusCode.InternalServerError, new JsonMediaTypeFormatter());
            }
            catch (Exception ex)
            {
                //LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetUserMenu", "tbl_Menu", "dbo.ProcGetUserMenu", ex, false, false);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, new JsonMediaTypeFormatter());
            }
        }

        [HttpGet]
        [Route("~/api/ProfileData/GetGradeDetails")]
        //[CacheFilter(TimeDuration = 60)]
        public HttpResponseMessage GetGradeDetails(int gradeCode, int companyCode)
        {
            try
            {
                GradeModel model = new GradeModel();
                DataTable getModel = new DataTable();

                if (gradeCode == 0)
                {
                    model.GradeBenefits = GetGradeBenefits(gradeCode, companyCode);
                    model.GradeDeductions = GetGradeDeductions(gradeCode, companyCode);
                    model.Bonuses = GetGradeBonuses(gradeCode, companyCode);
                    model.Assets = GetGradeAssets(gradeCode, companyCode);
                    model.DocumentCheckList = GetGradeDocumentCheckList(gradeCode, companyCode);
                    model.ExpenseLimit = GetGradeExpenseLimit(gradeCode, companyCode);

                    return Request.CreateResponse(HttpStatusCode.OK, model, formatter);
                }
                else
                {
                    var gradeData = GetGrade(gradeCode);

                    if (gradeData != null && gradeData.Count > 0)
                    {
                        model.ID = gradeData[0].ID;
                        model.FullName = gradeData[0].FullName;
                        model.DisplayName = gradeData[0].DisplayName;
                        model.SalaryFrom = gradeData[0].SalaryFrom;
                        model.SalaryTo = gradeData[0].SalaryTo;
                        model.Description = gradeData[0].Description;
                        model.IsExceedingAllowed = gradeData[0].IsExceedingAllowed;
                        model.ApprovalWorkFlow = gradeData[0].ApprovalWorkFlow;
                        model.NotificationEmailIds = gradeData[0].NotificationEmailIds;
                        model.CompanyCode = gradeData[0].CompanyCode;

                        var payGradePayrollGroup = GetPayGradePayrollGroup(gradeData[0].ID);
                        if (payGradePayrollGroup != null && payGradePayrollGroup.Rows.Count > 0)
                        {
                            model.PayrollGroupCode = Convert.ToInt64(payGradePayrollGroup.Rows[0]["PayrollGroupCode"].ToString());
                            model.PayrollGroupDesc = payGradePayrollGroup.Rows[0]["Description"].ToString();
                        }

                        model.GradeBenefits = GetGradeBenefits(gradeCode, companyCode);
                        model.GradeDeductions = GetGradeDeductions(gradeCode, companyCode);
                        model.Bonuses = GetGradeBonuses(gradeCode, companyCode);
                        model.Assets = GetGradeAssets(gradeCode, companyCode);
                        model.DocumentCheckList = GetGradeDocumentCheckList(gradeCode, companyCode);
                        model.ExpenseLimit = GetGradeExpenseLimit(gradeCode, companyCode);
                    }
                    else
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "");
                    }

                    return Request.CreateResponse(HttpStatusCode.OK, model, formatter);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }
        public List<GradeModel> GetGrade(int paygradeCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].WebGetPayGradeByID",
                    Parameters = new Dictionary<string, object> { { "paygradeCode", paygradeCode } }
                };
                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<GradeModel>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetPayGradePayrollGroup(int paygradeCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].WebGetPayrollGroupByPayGradeCode",
                    Parameters = new Dictionary<string, object> { { "paygradeCode", paygradeCode } }
                };
                return new CommonRepository(ConStr).ExecStoreProcedure(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<GradeBenefitModel> GetGradeBenefits(int paygradeCode, int companyCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].WebGetBenefitsByPayGradeCode",
                    Parameters = new Dictionary<string, object> { { "paygradeCode", paygradeCode },
                    { "companyCode", companyCode } }
                };
                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<GradeBenefitModel>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<GradeDeductionModel> GetGradeDeductions(int paygradeCode, int companyCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].WebGetDeductionsByPayGradeCode",
                    Parameters = new Dictionary<string, object> { { "paygradeCode", paygradeCode },
                    { "companyCode", companyCode } }
                };
                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<GradeDeductionModel>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<BonusModel> GetGradeBonuses(int paygradeCode, int companyCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].WebGetBonusesByPayGradeCode",
                    Parameters = new Dictionary<string, object> { { "paygradeCode", paygradeCode },
                    { "companyCode", companyCode } }
                };
                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<BonusModel>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<AssetAllocationModel> GetGradeAssets(int paygradeCode, int companyCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].WebGetAssetsByPayGradeCode",
                    Parameters = new Dictionary<string, object> { { "paygradeCode", paygradeCode },
                    { "companyCode", companyCode } }
                };
                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<AssetAllocationModel>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<DocumentCheckListModel> GetGradeDocumentCheckList(int paygradeCode, int companyCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].WebGetDocumentCheckListByPayGradeCode",
                    Parameters = new Dictionary<string, object> { { "paygradeCode", paygradeCode },
                    { "companyCode", companyCode }}
                };
                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<DocumentCheckListModel>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ExpenseLimitModel> GetGradeExpenseLimit(int paygradeCode, int companyCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].WebGetExpenseLimitByPayGradeCode",
                    Parameters = new Dictionary<string, object> { { "paygradeCode", paygradeCode },
                    { "companyCode", companyCode } }
                };
                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<ExpenseLimitModel>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    public class GradeModel
    {
        public short ID { get; set; }
        public string FullName { get; set; }
        public string DisplayName { get; set; }
        public decimal SalaryFrom { get; set; }
        public decimal SalaryTo { get; set; }
        public string Description { get; set; }
        public int CompanyCode { get; set; }
        public int UserCode { get; set; }
        public bool? IsExceedingAllowed { get; set; } 
        public short? ApprovalWorkFlow { get; set; } 
        public string NotificationEmailIds { get; set; }
        public long PayrollGroupCode { get; set; }
        public string PayrollGroupDesc { get; set; }
        //public int RecordStatusCode { get; set; }
        public List<GradeBenefitModel>  GradeBenefits { get; set; }
        public List<GradeDeductionModel>  GradeDeductions { get; set; }
        public List<BonusModel> Bonuses { get; set; }
        public List<AssetAllocationModel> Assets { get; set; }
        public List<DocumentCheckListModel> DocumentCheckList { get; set; }
        public List<ExpenseLimitModel> ExpenseLimit { get; set; }
    }

    public class GradeBenefitModel
    {
        public long ID { get; set; }
        public short PayGradeCode { get; set; }
        public string AllowanceOrBenefit { get; set; }
        public int AllowanceOrBenefitCode { get; set; }
        public decimal AllowanceOrBenefitAmount { get; set; }
        public decimal AllowanceOrBenefitRatio { get; set; }
        public string Description { get; set; }
        public bool IsMandatoryAllowance { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class GradeDeductionModel
    {
        public long ID { get; set; }
        public short PayGradeCode { get; set; }
        public int DeductionTypeCode { get; set; }
        public string DeductionType { get; set; }
        public decimal DeductionAmount { get; set; }
        public decimal DeductionRatio { get; set; }
        public string Description { get; set; }
        public bool IsMandatoryAllowance { get; set; }
        public bool IsDeleted { get; set; }
    }
    public class BonusModel
    {
        public long ID { get; set; }
        public short PayGradeCode { get; set; }
        public int BonusTypeCode { get; set; }
        public string BonusType { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class AssetAllocationModel
    {
        public long ID { get; set; }
        public short PayGradeCode { get; set; }
        public int AssetTypeCode { get; set; }
        public string AssetType { get; set; }
        public decimal? AssetAmountLimit { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class DocumentCheckListModel
    {
        public long ID { get; set; }
        public int PayGradeCode { get; set; }
        public int DocCode { get; set; }
        public string Document { get; set; }
        public bool? Compulsory { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class ExpenseLimitModel
    {
        public long ID { get; set; }
        public int PayGradeCode { get; set; }
        public int ExpenseTypeCode { get; set; }
        public string ExpenseType { get; set; }
        public bool? CalculationCriteria { get; set; }
        public string ExpenseLimit { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
    }
}

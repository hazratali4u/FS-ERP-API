using CST.CCL.Helper;
using CST.CCL.Helper.Common;
using CST.CRY;
using FS.CAPI.BAL;
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
    public class LeaveController : ApiController
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
        [Route("~/api/Leave/YearEnd")]
        //[CacheFilter(TimeDuration = 60)]
        public HttpResponseMessage YearEnd(LeaveBalanceModel model)
        {
            //try
            try
            {

                DataTable getModel = null;
                SpData data = null;
                var msglist = new List<CustomMsg>();

                data = new SpData
                {
                    SpName = "[dbo].[LeaveYearEndProcess]",
                    Parameters = new Dictionary<string, object>
                    {
                        { "CompanyCode", model.CompanyCode },
                        { "CenterCode", model.CenterCode },
                        { "FiscalYearCode", model.FiscalYearCode }
                    }
                };

                var yearEndDataTable = new CommonRepository(ConStr).ExecStoreProcedure(data);

                List<LeaveBalance> yearEndList = new List<LeaveBalance>();

                foreach (DataRow row in yearEndDataTable.Rows)
                {
                    yearEndList.Add(new LeaveBalance
                    {
                        ID = Convert.ToInt64(row["ID"].ToString()),
                        CompanyCode = Convert.ToInt32(row["CompanyCode"].ToString()),
                        EmpCode = Convert.ToInt64(row["EmpCode"].ToString()),
                        FiscalYearCode = Convert.ToInt16(row["FiscalYearCode"].ToString()),
                        IsYearlyOpeningBalance = true,//Convert.ToBoolean(row["FiscalYearCode"].ToString()),
                        LeaveTypeCode = Convert.ToInt32(row["LeaveTypeCode"].ToString()),
                        NoOfLeaves = Convert.ToDecimal(row["NoOfLeaves"].ToString()),
                        Remarks = null,
                        Status = row["Status"].ToString(),
                        UserCode = model.UserCode

                    });

                    //if (DBNull.Value == row["ParentID"])
                    //{
                    //  style.ParentID = null;
                    //}

                }

                //return Request.CreateResponse(HttpStatusCode.OK, yearEndList, new JsonMediaTypeFormatter());

                var result = yearEndList.Where(x => x.Status == "Existing").ToList();
                if (result.Count > 0)
                {
                    msglist.Add(new CustomMsg
                    {
                        TotalRows = 0,
                        Msg = "Process Already Executed."
                    });

                    return Request.CreateResponse(HttpStatusCode.OK, msglist, new JsonMediaTypeFormatter());
                }
                else
                {
                    foreach (var item in yearEndList)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            if (i == 1)
                            {
                                item.IsYearlyOpeningBalance = false;
                            }

                            data = new SpData
                            {
                                SpName = "[HRM].[WebLeaveYearEndProcessSave]",
                                Parameters = new Dictionary<string, object>
                                {
                                    { "ID", 0 },
                                    { "CompanyCode", item.CompanyCode },
                                    { "UserCode", item.UserCode },
                                    { "EmpCode", item.EmpCode },
                                    { "IsYearlyOpeningBalance", item.IsYearlyOpeningBalance },
                                    { "NoOfLeaves", item.NoOfLeaves },
                                    { "FiscalYearCode", item.FiscalYearCode },
                                    { "LeaveTypeCode", item.LeaveTypeCode },
                                    { "Remarks", item.Remarks }
                                }
                            };

                            getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                        }
                    }

                    return Request.CreateResponse(HttpStatusCode.OK, getModel, new JsonMediaTypeFormatter());

                }
            }
            catch (Exception ex)
            {
                //LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetUserMenu", "tbl_Menu", "dbo.ProcGetUserMenu", ex, false, false);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, new JsonMediaTypeFormatter());
            }
        }

        [HttpGet]
        [Route("~/api/Leave/Policy")]
        public HttpResponseMessage LeavePolicy(int leavePolicyCode)
        {
            try
            {
                LeavePolicyModel model = new LeavePolicyModel();

                model.LeavePolicy = GetLeavePolicy(leavePolicyCode);


                if (model.LeavePolicy != null)
                {
                    model.PolicyDetails = GetPolicyDetails(leavePolicyCode);

                    model.PolicyRules = GetPolicyRules(leavePolicyCode);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "");
                }

                return Request.CreateResponse(HttpStatusCode.OK, model, formatter);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }
        public LeavePolicy GetLeavePolicy(int leavePolicyCode)
        {
            try
            {
                LeavePolicy model = new LeavePolicy();
                SpData data = new SpData
                {
                    SpName = "[HRM].[WebGetLeavePolicy]",
                    Parameters = new Dictionary<string, object>
                        {
                            { "LeavePolicyCode", leavePolicyCode }
                        }
                };

                var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                if (getModel == null)
                {
                    return null;
                }
                else
                {

                    List<LeavePolicy> list = getModel.DataTableToList<LeavePolicy>();
                    if (list != null && list.Count > 0)
                    {
                        model = list[0];
                    }
                    //foreach (datarow row in getmodel.rows)
                    //{
                    //    model.id = convert.toint16(row["id"].tostring());
                    //    model.policyname = row["policyname"].tostring();
                    //    model.description = !string.isnullorempty(row["description"].tostring())? row["description"].tostring() : null;
                    //    model.isactive = row["empcode"].tostring().equals("1") ? true : false;
                    //    model.



                    //    //if (dbnull.value == row["parentid"])
                    //    //{
                    //    //  style.parentid = null;
                    //    //}

                    //}
                }

                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<LeavePolicyDetail> GetPolicyDetails(int leavePolicyCode)
        {
            try
            {
                List<LeavePolicyDetail> model = new List<LeavePolicyDetail>();
                SpData data = new SpData
                {
                    SpName = "[HRM].[WebGetLeavePolicyDetails]",
                    Parameters = new Dictionary<string, object>
                        {
                            { "LeavePolicyCode", leavePolicyCode }
                        }
                };

                var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                if (getModel == null)
                {
                    return null;
                }
                else
                {
                    model = getModel.DataTableToList<LeavePolicyDetail>();
                }

                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public LeavePolicyRule GetPolicyRules(int leavePolicyCode)
        {
            try
            {
                LeavePolicyRule model = new LeavePolicyRule();
                SpData data = new SpData
                {
                    SpName = "[HRM].[WebGetLeavePolicyRules]",
                    Parameters = new Dictionary<string, object>
                        {
                            { "LeavePolicyCode", leavePolicyCode }
                        }
                };

                var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                if (getModel == null)
                {
                    return null;
                }
                else
                {
                    model.LeavePolicyCode = (short)leavePolicyCode;
                    foreach (DataRow row in getModel.Rows)
                    {
                        if (Convert.ToInt16(row["DeductionPriority"].ToString()) == 1)
                        {
                            model.FirstID = Convert.ToInt32(row["ID"].ToString());
                            model.FirstPriority = Convert.ToInt32(row["LeaveTypeCode"].ToString());

                        }
                        else if (Convert.ToInt16(row["DeductionPriority"].ToString()) == 2)
                        {
                            model.SecondID = Convert.ToInt32(row["ID"].ToString());
                            model.SecondPriority = Convert.ToInt32(row["LeaveTypeCode"].ToString());
                        }
                        else if (Convert.ToInt16(row["DeductionPriority"].ToString()) == 3)
                        {
                            model.ThirdID = Convert.ToInt32(row["ID"].ToString());
                            model.ThirdPriority = Convert.ToInt32(row["LeaveTypeCode"].ToString());
                        }
                        else if (Convert.ToInt16(row["DeductionPriority"].ToString()) == 4)
                        {
                            model.FourthID = Convert.ToInt32(row["ID"].ToString());
                            model.FourthPriority = Convert.ToInt32(row["LeaveTypeCode"].ToString());
                        }
                    }
                }

                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("~/api/Leave/Policy")]
        public HttpResponseMessage LeavePolicy(LeavePolicyModel model)
        {
            try
            {
                DataTable getModel = new DataTable();
                if (model.LeavePolicy != null && model.PolicyDetails != null && model.PolicyDetails.Count > 0)
                {
                    if (model.LeavePolicy.ID == 0)
                    {
                        model.LeavePolicy.IsActive = true;
                    }

                    getModel = SaveLeavePolicy(model.LeavePolicy, model.CompanyCode, model.UserCode);
                    var savedID = getModel.Rows[0]["ID"].ToString();

                    if (!string.IsNullOrEmpty(savedID))
                    {
                        SavePolicyDetails(model.PolicyDetails, Convert.ToInt16(savedID), model.CompanyCode, model.UserCode);

                        if (model.PolicyRules != null)
                        {
                            SavePolicyRules(model.PolicyRules, Convert.ToInt16(savedID), model.CompanyCode, model.UserCode);
                        }
                    }
                    else
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, savedID);
                    }

                    return Request.CreateResponse(HttpStatusCode.OK, getModel, formatter);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, new CustomMsg { Msg = "No policy or details found to save", TotalRows = 0 }, formatter);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }
        public DataTable SaveLeavePolicy(LeavePolicy leavePolicy, int CompanyCode, int UserCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].[WebLeavePolicySave]",
                    Parameters = new Dictionary<string, object>
                        {
                            { "ID", leavePolicy.ID },
                            { "PolicyName", leavePolicy.PolicyName },
                            { "Description", leavePolicy.Description },
                            { "IsActive", leavePolicy.IsActive },
                            { "IsMaintainBalanceHistory", leavePolicy.IsMaintainBalanceHistory },
                            { "ProcessDaysBeforeNextYear", leavePolicy.ProcessDaysBeforeNextYear },
                            { "IsMarkHoliday", leavePolicy.IsMarkHoliday },
                            { "IsEncashmentBasedOnGrossSalary", leavePolicy.IsEncashmentBasedOnGrossSalary },
                            { "IsIncludeHolidaySandwich", leavePolicy.IsIncludeHolidaySandwich },
                            { "IsIncludeOffDaySandwich", leavePolicy.IsIncludeOffDaySandwich },
                            { "IsMarkAbsent", leavePolicy.IsMarkAbsent },
                            { "EnableDisableSandwichPolicy", leavePolicy.EnableDisableSandwichPolicy},
                            { "CompanyCode", CompanyCode },
                            { "UserCode", UserCode }
                        }
                };

                var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                return getModel;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void SavePolicyDetails(List<LeavePolicyDetail> policyDetails, short leavePolicyCode, int CompanyCode, int UserCode)
        {
            try
            {
                string ids = "";
                foreach (var item in policyDetails)
                {
                    if (item.ID > 0)
                    {
                        ids = ids + "," + item.ID;
                    }
                }

                if (!string.IsNullOrEmpty(ids))
                {
                    ids = ids.Substring(1);

                    SpData data = new SpData
                    {
                        SpName = "[HRM].[WebLeavePolicyDetailDelete]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "IdsNotToDelete", ids },
                            { "LeavePolicyCode", leavePolicyCode },
                            { "UserCode", UserCode }
                        }
                    };
                    var gModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                }

                foreach (var item in policyDetails)
                {
                    if (item.ID == 0)
                    {
                        item.IsActive = true;
                    }
                    SpData data = new SpData
                    {
                        SpName = "[HRM].[WebLeavePolicyDetailSave]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "ID", item.ID },
                            { "LeavePolicyCode", leavePolicyCode },
                            { "LeaveTypeCode", item.LeaveTypeCode },
                            { "CalculationCriteria", item.CalculationCriteria },
                            { "TotalDays", item.TotalDays },
                            { "MinimumDays", item.MinimumDays },
                            { "MaximumDays", item.MaximumDays },
                            { "IsActive", item.IsActive },
                            { "BalanceAccumulationLimit", item.BalanceAccumulationLimit },
                            { "BalanceMaxYear", item.BalanceMaxYear },
                            { "ApplicableForPermanentEmployees", item.ApplicableForPermanentEmployees },
                            { "ApplicableForContractualEmployees", item.ApplicableForContractualEmployees },
                            { "ApplicableForProbationaryEmployees", item.ApplicableForProbationaryEmployees },
                            { "ApplicableForResignedEmployees", item.ApplicableForResignedEmployees },
                            { "IsLaps", item.IsLaps },
                            { "IsSandwich", item.IsSandwich },
                            { "IsEncashable", item.IsEncashable },
                            { "IsUnPaid", item.IsUnPaid },
                            { "ServiceInYear", item.ServiceInYear },
                            { "CompanyCode", CompanyCode },
                            { "UserCode", UserCode },
                            { "AllowedPerMonth", item.AllowedPerMonth },
                            { "IsOffDaysIncluded", item.IsOffDaysIncluded },
                            { "IsHolidaysIncluded", item.IsHolidaysIncluded }
                        }
                    };

                    var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void SavePolicyRules(LeavePolicyRule policyRules, short leavePolicyCode, int CompanyCode, int UserCode)
        {
            try
            {
                if (policyRules.FirstID.HasValue || policyRules.SecondID.HasValue ||
                    policyRules.ThirdID.HasValue || policyRules.FourthID.HasValue )
                    //!string.IsNullOrEmpty(policyRules.FirstPriorityStr) ||
                    //!string.IsNullOrEmpty(policyRules.SecondPriorityStr) ||
                    //!string.IsNullOrEmpty(policyRules.ThirdPriorityStr) ||
                    //!string.IsNullOrEmpty(policyRules.FourthPriorityStr))
                {

                    SpData data = null;
                    int leaveTypeCode;
                    bool? IsDeductFromSalary;
                    for (int i = 1; i <= 4; i++)
                    {
                        if (i == 1)
                        {
                            if (policyRules.FirstID.HasValue)
                            {
                                if (!string.IsNullOrEmpty(policyRules.FirstPriorityStr) && policyRules.FirstPriority >= 0)
                                {
                                    if (policyRules.FirstPriorityStr.Equals("From Salary"))
                                    {
                                        leaveTypeCode = 0;
                                        IsDeductFromSalary = true;
                                    }
                                    else if (policyRules.FirstPriorityStr.Equals("N/A"))
                                    {
                                        leaveTypeCode = 0;
                                        IsDeductFromSalary = null;
                                    }
                                    else
                                    {
                                        leaveTypeCode = policyRules.FirstPriority.Value;
                                        IsDeductFromSalary = false;
                                    }

                                    data = new SpData
                                    {
                                        SpName = "[HRM].[WebLeavePolicyRuleSave]",
                                        Parameters = new Dictionary<string, object>
                                        {
                                            { "ID", policyRules.FirstID },
                                            { "LeavePolicyCode", leavePolicyCode },
                                            { "IsDeductFromSalary", IsDeductFromSalary },
                                            { "DeductionPriority", 1 },
                                            { "LeaveTypeCode", leaveTypeCode },
                                            { "CompanyCode", CompanyCode },
                                            { "UserCode", UserCode }
                                        }
                                    };
                                }
                                else
                                {
                                    data = new SpData
                                    {
                                        SpName = "[HRM].[WebLeavePolicyRuleSave]",
                                        Parameters = new Dictionary<string, object>
                                        {
                                            { "ID", policyRules.FirstID },
                                            { "LeavePolicyCode", leavePolicyCode },
                                            { "IsDeductFromSalary", null },
                                            { "DeductionPriority", 1 },
                                            { "LeaveTypeCode", 0 },
                                            { "CompanyCode", CompanyCode },
                                            { "UserCode", UserCode },
                                            { "IsDelete", true }
                                        }
                                    };
                                }

                                var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                            }
                        }
                        else if (i == 2)
                        {
                            if (policyRules.SecondID.HasValue)
                            {
                                if (!string.IsNullOrEmpty(policyRules.SecondPriorityStr) && policyRules.SecondPriority >= 0)
                                {
                                    if (policyRules.SecondPriorityStr.Equals("From Salary"))
                                    {
                                        leaveTypeCode = 0;
                                        IsDeductFromSalary = true;
                                    }
                                    else if (policyRules.SecondPriorityStr.Equals("N/A"))
                                    {
                                        leaveTypeCode = 0;
                                        IsDeductFromSalary = null;
                                    }
                                    else
                                    {
                                        leaveTypeCode = policyRules.SecondPriority.Value;
                                        IsDeductFromSalary = false;
                                    }

                                    data = new SpData
                                    {
                                        SpName = "[HRM].[WebLeavePolicyRuleSave]",
                                        Parameters = new Dictionary<string, object>
                                        {
                                            { "ID", policyRules.SecondID },
                                            { "LeavePolicyCode", leavePolicyCode },
                                            { "IsDeductFromSalary", IsDeductFromSalary },
                                            { "DeductionPriority", 2 },
                                            { "LeaveTypeCode", leaveTypeCode },
                                            { "CompanyCode", CompanyCode },
                                            { "UserCode", UserCode }
                                        }
                                    };
                                }
                                else
                                {
                                    data = new SpData
                                    {
                                        SpName = "[HRM].[WebLeavePolicyRuleSave]",
                                        Parameters = new Dictionary<string, object>
                                        {
                                            { "ID", policyRules.SecondID },
                                            { "LeavePolicyCode", leavePolicyCode },
                                            { "IsDeductFromSalary", null },
                                            { "DeductionPriority", 2 },
                                            { "LeaveTypeCode", 0 },
                                            { "CompanyCode", CompanyCode },
                                            { "UserCode", UserCode },
                                            { "IsDelete", true }
                                        }
                                    };
                                }

                                var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                            }
                        }
                        else if (i == 3)
                        {
                            if (policyRules.ThirdID.HasValue)
                            {
                                if (!string.IsNullOrEmpty(policyRules.ThirdPriorityStr) && policyRules.ThirdPriority >= 0)
                                {
                                    if (policyRules.ThirdPriorityStr.Equals("From Salary"))
                                    {
                                        leaveTypeCode = 0;
                                        IsDeductFromSalary = true;
                                    }
                                    else if (policyRules.ThirdPriorityStr.Equals("N/A"))
                                    {
                                        leaveTypeCode = 0;
                                        IsDeductFromSalary = null;
                                    }
                                    else
                                    {
                                        leaveTypeCode = policyRules.ThirdPriority.Value;
                                        IsDeductFromSalary = false;
                                    }

                                    data = new SpData
                                    {
                                        SpName = "[HRM].[WebLeavePolicyRuleSave]",
                                        Parameters = new Dictionary<string, object>
                                        {
                                            { "ID", policyRules.ThirdID },
                                            { "LeavePolicyCode", leavePolicyCode },
                                            { "IsDeductFromSalary", IsDeductFromSalary },
                                            { "DeductionPriority", 3 },
                                            { "LeaveTypeCode", leaveTypeCode },
                                            { "CompanyCode", CompanyCode },
                                            { "UserCode", UserCode }
                                        }
                                    };
                                }
                                else
                                {
                                    data = new SpData
                                    {
                                        SpName = "[HRM].[WebLeavePolicyRuleSave]",
                                        Parameters = new Dictionary<string, object>
                                        {
                                            { "ID", policyRules.ThirdID },
                                            { "LeavePolicyCode", leavePolicyCode },
                                            { "IsDeductFromSalary", null },
                                            { "DeductionPriority", 3 },
                                            { "LeaveTypeCode", 0 },
                                            { "CompanyCode", CompanyCode },
                                            { "UserCode", UserCode },
                                            { "IsDelete", true }
                                        }
                                    };
                                }

                                var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                            }
                        }
                        else if (i == 4)
                        {
                            if (policyRules.FourthID.HasValue)
                            {
                                if (!string.IsNullOrEmpty(policyRules.FourthPriorityStr) && policyRules.FourthPriority >= 0)
                                {
                                    if (policyRules.FourthPriorityStr.Equals("From Salary"))
                                    {
                                        leaveTypeCode = 0;
                                        IsDeductFromSalary = true;
                                    }
                                    else if (policyRules.FourthPriorityStr.Equals("N/A"))
                                    {
                                        leaveTypeCode = 0;
                                        IsDeductFromSalary = null;
                                    }
                                    else
                                    {
                                        leaveTypeCode = policyRules.FourthPriority.Value;
                                        IsDeductFromSalary = false;
                                    }

                                    data = new SpData
                                    {
                                        SpName = "[HRM].[WebLeavePolicyRuleSave]",
                                        Parameters = new Dictionary<string, object>
                                        {
                                            { "ID", policyRules.FourthID },
                                            { "LeavePolicyCode", leavePolicyCode },
                                            { "IsDeductFromSalary", IsDeductFromSalary },
                                            { "DeductionPriority", 4 },
                                            { "LeaveTypeCode", leaveTypeCode },
                                            { "CompanyCode", CompanyCode },
                                            { "UserCode", UserCode }
                                        }
                                    };
                                }
                                else
                                {
                                    data = new SpData
                                    {
                                        SpName = "[HRM].[WebLeavePolicyRuleSave]",
                                        Parameters = new Dictionary<string, object>
                                        {
                                            { "ID", policyRules.FourthID },
                                            { "LeavePolicyCode", leavePolicyCode },
                                            { "IsDeductFromSalary", null },
                                            { "DeductionPriority", 4 },
                                            { "LeaveTypeCode", 0 },
                                            { "CompanyCode", CompanyCode },
                                            { "UserCode", UserCode },
                                            { "IsDelete", true }
                                        }
                                    };
                                }
                                var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("~/api/Leave/GetEncashmentById")]
        public HttpResponseMessage GetEncashment(int Id)
        {
            try
            {
                var data = GetEncashmentById(Id);

                return Request.CreateResponse(HttpStatusCode.OK, data, formatter);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }
        public LeaveEncashmentModel GetEncashmentById(int Id)
        {
            LeaveEncashmentModel model = new LeaveEncashmentModel();
            var empList = new List<VM_LeaveEncashment>();

            SpData data2 = new SpData
            {
                SpName = "[HRM].[WebGetLeaveEncashmentById]",
                Parameters = new Dictionary<string, object>
                {
                    { "ID", Id}
                }
            };

            var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data2);
            if (getModel == null)
            {
                return null;
            }
            else
            {
                int leaveTypeCode = Convert.ToInt32(getModel.Rows[0]["LeaveTypeCode"].ToString());
                int fiscalYearCode = Convert.ToInt32(getModel.Rows[0]["FiscalYearCode"].ToString());
                DateTime processingMonth = Convert.ToDateTime(getModel.Rows[0]["ProcessingMonth"].ToString());

                model.LeaveTypeCode = leaveTypeCode;
                model.FiscalYearCode = fiscalYearCode;
                model.PayrollMonth = processingMonth;

                var empEncashmentEditList = GetEncashmentData(leaveTypeCode, fiscalYearCode);

                data2 = new SpData
                {
                    SpName = "[HRM].[WebGetEncashmentEmpIds]",
                    Parameters = new Dictionary<string, object>
                    {
                        { "leaveTypeCode", leaveTypeCode },
                        { "fiscalYearCode", fiscalYearCode },
                        { "ProcessingMonth", processingMonth },
                    }
                };

                var getModel2 = new CommonRepository(ConStr).ExecStoreProcedure(data2);
                if (getModel2 == null)
                {
                    return null;
                }
                else
                {
                    long empcode = 0;
                    foreach (DataRow row in getModel2.Rows)
                    {
                        empcode = Convert.ToInt64(row["EmpCode"].ToString());
                        foreach (var item in empEncashmentEditList)
                        {
                            if (item.EmpCode == empcode)
                            {
                                item.IsSelected = true;
                                item.RemainingLeaves = Convert.ToDecimal(row["DaysToEncash"].ToString());
                                break;
                            }
                        }
                    }

                    model.LeaveEncashments = empEncashmentEditList;

                }

                return model;
            }
        }

        [HttpGet]
        [Route("~/api/Leave/Encashment")]
        public HttpResponseMessage LeaveEncashment(int leaveTypeCode, int fiscalYearCode)
        {
            try
            {

                var data = GetEncashmentData(leaveTypeCode, fiscalYearCode);

                return Request.CreateResponse(HttpStatusCode.OK, data, formatter);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }
        public List<VM_LeaveEncashment> GetEncashmentData(int leaveTypeCode, int fiscalYearCode)
        {
            var empList = new List<VM_LeaveEncashment>();

            SpData data2 = new SpData
            {
                SpName = "[HRM].[getEncashmentEmployees]",
                Parameters = new Dictionary<string, object>
                {
                    { "leaveTypeCode", leaveTypeCode },
                    { "fiscalYearCode", fiscalYearCode },
                }
            };

            var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data2);
            if (getModel == null)
            {
                return null;
            }
            else
            {
                var data = getModel.DataTableToList<VM_LeaveEncashment>();

                var empCodeList = data.GroupBy(x => x.EmpCode).Select(x => x.FirstOrDefault()).ToList();

                foreach (var item in empCodeList)
                {
                    var leaveData = data.Where(x => x.EmpCode == item.EmpCode).ToList();
                    var totalLeaves = leaveData.Where(x => x.IsYearlyOpeningBalance == false).Sum(x => x.NoOfLeaves);
                    var remainingLeaves = leaveData.Where(x => x.IsYearlyOpeningBalance == true).Sum(x => x.NoOfLeaves);
                    var availedLeaves = totalLeaves - remainingLeaves;
                    item.TotalLeaves = totalLeaves;
                    item.AvailedLeaves = availedLeaves;

                    item.LeaveHoursDeduction = Math.Round(item.LeaveHoursDeduction, 2);

                    remainingLeaves = remainingLeaves - item.LeaveHoursDeduction;
                    item.RemainingLeaves = remainingLeaves;

                    empList.Add(item);
                }
            }

            return empList;
        }

        [HttpPost]
        [Route("~/api/Leave/Encashment")]
        public HttpResponseMessage LeaveEncashment(LeaveEncashmentModel model)
        {
            try
            {
                DataTable getModel = new DataTable();
                if (model.LeaveEncashments != null && model.LeaveEncashments.Count > 0)
                {
                    foreach (var item in model.LeaveEncashments)
                    {
                        if (item.RemainingLeaves > 0)
                        {
                            getModel = SaveLeaveEncashment(item, model.LeaveTypeCode, model.FiscalYearCode, model.PayrollMonth, model.CompanyCode, model.UserCode);
                        }
                    }

                    var savedID = getModel.Rows[0]["ID"].ToString();

                    if (!string.IsNullOrEmpty(savedID))
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, getModel, formatter);
                    }
                    else
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, savedID);
                    }
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, new CustomMsg { Msg = "No encashment details found to save", TotalRows = 0 }, formatter);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }
        public DataTable SaveLeaveEncashment(VM_LeaveEncashment model, int leaveTypeCode, int fiscalYearCode, DateTime payrollMonth, int companyCode, int userCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].[WebLeaveEncashmentSave]",
                    Parameters = new Dictionary<string, object>
                    {
                        { "LeaveTypeCode", leaveTypeCode },
                        { "FiscalYearCode", fiscalYearCode },
                        { "ProcessingMonth", payrollMonth },
                        { "EmpCode", model.EmpCode },
                        { "DaysToEncash", model.RemainingLeaves },
                        { "CompanyCode", companyCode },
                        { "UserCode", userCode }
                    }
                };

                var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                return getModel;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("~/api/Leave/Opening")]
        public HttpResponseMessage LeaveOpening(long empCode, int companyCode, int fiscalYearCode)
        {
            try
            {
                var data = GetLeaveOpeningData(empCode, companyCode, fiscalYearCode);

                return Request.CreateResponse(HttpStatusCode.OK, data, formatter);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }
        public LeaveOpeningModel GetLeaveOpeningData(long empCode, int companyCode, int fiscalYearCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].[WebLeaveOpeningByEmpCode]",
                    Parameters = new Dictionary<string, object>
                    {
                        { "EmpCode", empCode },
                        { "CompanyCode", companyCode },
                        { "FiscalYearCode", fiscalYearCode }
                    }
                };

                var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                if (getModel == null)
                {
                    return null;
                }
                else
                {
                    LeaveOpeningModel model = new LeaveOpeningModel();
                    model.CompanyCode = companyCode;
                    model.EmpCode = empCode;
                    model.LeaveOpeningTypes = new List<VM_LeaveOpeningTypes>();

                    foreach (DataRow row in getModel.Rows)
                    {
                        model.LeaveOpeningTypes.Add(new VM_LeaveOpeningTypes
                        {
                            ID = Convert.ToInt64(row["ID"].ToString()),
                            LeaveTypeCode = Convert.ToInt32(row["LeaveTypeCode"].ToString()),
                            NoOfLeaves = Convert.ToDecimal(row["NoOfLeaves"].ToString()),
                            LeaveTypeName = row["LeaveTypeName"].ToString()
                        });
                    }

                    return model;
                }
            }
            catch (Exception ex)
            {
                
            }
            return new LeaveOpeningModel();
        }

        [HttpPost]
        [Route("~/api/Leave/Opening")]
        public HttpResponseMessage LeaveOpening(LeaveOpeningModel model)
        {
            try
            {
                DataTable getModel = new DataTable();
                //DataTable getModel = null;
                SpData data = null;
                if (model.LeaveOpeningTypes != null && model.LeaveOpeningTypes.Count > 0)
                {
                    bool isYrOpBal = true;
                    foreach (var item in model.LeaveOpeningTypes)
                    {
                        if (item.ID == 0)
                        {
                            for (int i = 0; i < 2; i++)
                            {
                                isYrOpBal = true;

                                if (i == 1)
                                {
                                    isYrOpBal = false;
                                }

                                data = new SpData
                                {
                                    SpName = "[HRM].[WebLeaveYearEndProcessSave]",
                                    Parameters = new Dictionary<string, object>
                                    {
                                        { "ID", 0 },
                                        { "CompanyCode", model.CompanyCode },
                                        { "UserCode", model.UserCode },
                                        { "EmpCode", model.EmpCode },
                                        { "IsYearlyOpeningBalance", isYrOpBal },
                                        { "NoOfLeaves", item.NoOfLeaves },
                                        { "FiscalYearCode", model.FiscalYearCode },
                                        { "LeaveTypeCode", item.LeaveTypeCode },
                                        //{ "Remarks", null }
                                    }
                                };

                                getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                            }
                        }
                        else if (item.ID > 0)
                        {
                            data = new SpData
                            {
                                SpName = "[HRM].[WebLeaveYearEndProcessSave]",
                                Parameters = new Dictionary<string, object>
                                {
                                    { "ID", item.ID },
                                    { "CompanyCode", model.CompanyCode },
                                    { "UserCode", model.UserCode },
                                    { "EmpCode", model.EmpCode },
                                    { "IsYearlyOpeningBalance", false },
                                    { "NoOfLeaves", item.NoOfLeaves },
                                    { "FiscalYearCode", model.FiscalYearCode },
                                    { "LeaveTypeCode", item.LeaveTypeCode },
                                    { "IsLeaveOpeningView", true },
                                    //{ "IsDelete", item.IsDelete },
                                }
                            };

                            getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                        }
                    }

                    var savedID = getModel.Rows[0]["ID"].ToString();

                    if (!string.IsNullOrEmpty(savedID))
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, getModel, formatter);
                    }
                    else
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, savedID);
                    }
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, new CustomMsg { Msg = "No leave opening details found to save", TotalRows = 0 }, formatter);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }

        [HttpGet]
        [Route("~/api/Leave/OpeningBalancesNewEmp")]
        public HttpResponseMessage LeaveOpeningBalancesNewEmp(long empCode, int compCode, int userCode, int? probComp)
        {
            try
            {
                DataTable getModel = new DataTable();   
                //DataTable getModel = null;
                SpData data = null;
                if (empCode > 0)
                {

                    data = new SpData
                    {
                        SpName = "[HRM].[WebGetLeaveBalancesNewEmp]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "EmpCode", empCode }
                        }
                    };

                    getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);

                    if (getModel == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "0");
                    }
                    else
                    {

                        DateTime joiningDate = Convert.ToDateTime(getModel.Rows[0]["DOJ"].ToString());
                        int ProbationPeriod = Convert.ToInt32(getModel.Rows[0]["ProbationPeriod"].ToString());
                        joiningDate = joiningDate.AddMonths(ProbationPeriod);
                        DateTime FyDteEnd = Convert.ToDateTime(getModel.Rows[0]["FiscalYrEndDate"].ToString());
                        
                        double employeeRemainingDays = (FyDteEnd - joiningDate).TotalDays;

                        foreach (DataRow row in getModel.Rows)
                        {

                            int LeaveTypeCode = Convert.ToInt32(row["LeaveTypeCode"].ToString());
                            int fiscalYearCode = Convert.ToInt32(row["FiscalYearCode"].ToString());
                            decimal TotalDays = Convert.ToDecimal(row["TotalDays"].ToString());
                            string leaveTypeName = row["FullName"].ToString();
                            bool? isGender = null;
                            bool? isMaternity = null;

                            bool AddFullTotalDays = false;

                            AddFullTotalDays = Convert.ToBoolean(row["AddFullTotalDays"].ToString());

                            if (DBNull.Value == row["IsGender"])
                            {
                              isGender = null;
                            }
                            else
                            {
                                isGender = Convert.ToBoolean(row["IsGender"]);
                            }

                            if (DBNull.Value == row["IsMaternity"])
                            {
                                isMaternity = null;
                            }
                            else
                            {
                                isMaternity = Convert.ToBoolean(row["IsMaternity"]);
                            }

                            decimal noofLeaves = 0;

                            if (isMaternity == true)
                            {
                                if (isGender == false)
                                {
                                    // go ahead to following loop to add for a FEMALE only OTHERWISE no addition of this particular leave type
                                }
                                else
                                {
                                    continue;
                                }
                            }

                            if (TotalDays > 0)
                            {
                                //noofLeaves = TotalDays;

                                if (employeeRemainingDays <= 365)
                                {
                                    if (AddFullTotalDays)
                                    {
                                        noofLeaves = TotalDays;
                                    }
                                    else
                                    {

                                        if (!leaveTypeName.ToLower().Contains("annual"))
                                        {
                                            decimal leavePerDay = TotalDays / 365;
                                            noofLeaves = leavePerDay * Convert.ToDecimal(employeeRemainingDays);

                                            if (noofLeaves < 0)
                                            {
                                                noofLeaves = 0;
                                            }
                                            else
                                            {
                                                noofLeaves = Math.Round(noofLeaves, 2);
                                            }
                                        }
                                        else
                                        {
                                            noofLeaves = 0;
                                        }
                                    }
                                }
                                else
                                {
                                    noofLeaves = 0; // add all leave types with Zero 
                                    //-- cuz its new client having old employee and are opening in our system for first time 
                                    //-- so their leave balance will b added / updated from some kind of excel import or 
                                    //user update it from leave opening page one by one
                                }
                            }

                            bool isYrOpBal = true;
                            
                            for (int i = 0; i < 2; i++)
                            {
                                if (i == 1)
                                {
                                    isYrOpBal = false;
                                }

                                data = new SpData
                                {
                                    SpName = "[HRM].[WebLeaveYearEndProcessSave]",
                                    Parameters = new Dictionary<string, object>
                                    {
                                        { "ID", 0 },
                                        { "CompanyCode", compCode },
                                        { "UserCode", userCode },
                                        { "EmpCode", empCode },
                                        { "IsYearlyOpeningBalance", isYrOpBal },
                                        { "NoOfLeaves", noofLeaves },
                                        { "FiscalYearCode", fiscalYearCode },
                                        { "LeaveTypeCode", LeaveTypeCode },
                                        { "OnProbCompletion", probComp }
                                    }
                                };

                                getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                            }
                        }

                        return Request.CreateResponse(HttpStatusCode.OK, getModel, formatter);
                    }

                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, new CustomMsg { Msg = "No employee found to save", TotalRows = 0 }, formatter);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }
    }
    public class LeavePolicyModel
    {
        public int CompanyCode { get; set; }
        public int UserCode { get; set; }
        public LeavePolicy LeavePolicy { get; set; }
        public List<LeavePolicyDetail> PolicyDetails { get; set; }
        public LeavePolicyRule PolicyRules { get; set; }

        //public LeavePolicyModel()
        //{
        //    this.LeavePolicy = new LeavePolicy();
        //    PolicyDetails = new List<LeavePolicyDetail>();
        //    PolicyDetails.Add(new LeavePolicyDetail()
        //    {

        //    });
        //    PolicyDetails.Add(new LeavePolicyDetail()
        //    {

        //    });
        //    PolicyRules = new LeavePolicyRule();
        //}
    }
    public class LeavePolicy
    {
        public short ID { get; set; }
        public string PolicyName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsMaintainBalanceHistory { get; set; }
        public decimal? ProcessDaysBeforeNextYear { get; set; }
        public bool IsMarkHoliday { get; set; }
        public bool IsEncashmentBasedOnGrossSalary { get; set; }
        public bool IsIncludeHolidaySandwich { get; set; }
        public bool IsIncludeOffDaySandwich { get; set; }
        public bool IsMarkAbsent { get; set; }
        public bool EnableDisableSandwichPolicy { get; set; }

    }
    public class LeavePolicyDetail
    {
        public int ID { get; set; }
        public short LeavePolicyCode { get; set; }
        public byte LeaveTypeCode { get; set; }
        public byte CalculationCriteria { get; set; }
        public decimal TotalDays { get; set; }
        public decimal MinimumDays { get; set; }
        public decimal MaximumDays { get; set; }
        public bool IsActive { get; set; }
        public decimal BalanceAccumulationLimit { get; set; }
        public decimal BalanceMaxYear { get; set; }
        public bool ApplicableForPermanentEmployees { get; set; }
        public bool ApplicableForContractualEmployees { get; set; }
        public bool ApplicableForProbationaryEmployees { get; set; }
        public bool ApplicableForResignedEmployees { get; set; }
        public bool IsLaps { get; set; }
        public bool IsSandwich { get; set; }
        public bool IsEncashable { get; set; }
        public bool IsUnPaid { get; set; }
        public decimal? ServiceInYear { get; set; }
        public decimal? AllowedPerMonth { get; set; }
        public bool? IsOffDaysIncluded { get; set; }
        public bool? IsHolidaysIncluded { get; set; }


    }
    public class LeavePolicyRule
    {
        public short LeavePolicyCode { get; set; }
        public int? FirstID { get; set; }
        public int? FirstPriority { get; set; }
        public string FirstPriorityStr { get; set; }
        public int? SecondID { get; set; }
        public int? SecondPriority { get; set; }
        public string SecondPriorityStr { get; set; }
        public int? ThirdID { get; set; }
        public int? ThirdPriority { get; set; }
        public string ThirdPriorityStr { get; set; }
        public int? FourthID { get; set; }
        public int? FourthPriority { get; set; }
        public string FourthPriorityStr { get; set; }

    }

    public class LeaveBalanceModel
    {
        public int CompanyCode { get; set; }

        public int CenterCode { get; set; }

        public int FiscalYearCode { get; set; }
        public int UserCode { get; set; }

    }
    public class LeaveBalance
    {
        public long ID { get; set; }
        public long EmpCode { get; set; }
        public string Status { get; set; }
        public bool IsYearlyOpeningBalance { get; set; }
        public decimal NoOfLeaves { get; set; }
        public Int16 FiscalYearCode { get; set; }
        public int LeaveTypeCode { get; set; }
        public string Remarks { get; set; }
        public int CompanyCode { get; set; }
        public int UserCode { get; set; }
    }
    public class CustomMsg
    {
        public int TotalRows { get; set; }
        public string Msg { get; set; }
    }

    public class LeaveEncashmentModel
    {
        public int CompanyCode { get; set; }
        public int UserCode { get; set; }
        public int FiscalYearCode { get; set; }
        public int LeaveTypeCode { get; set; }
        public DateTime PayrollMonth { get; set; }
        public List<VM_LeaveEncashment> LeaveEncashments { get; set; }
        //public LeaveEncashmentModel()
        //{
        //    LeaveEncashments = new List<VM_LeaveEncashment>();
        //    LeaveEncashments.Add(new VM_LeaveEncashment { });
        //}
    }
    public class VM_LeaveEncashment
    {
        public long EmpCode { get; set; }
        public string Employee { get; set; }
        public bool IsYearlyOpeningBalance { get; set; }
        public decimal NoOfLeaves { get; set; }
        //public int LeaveTypeCode { get; set; }
        //public decimal SalaryAmount { get; set; }
        public decimal TotalLeaves { get; set; }
        public decimal AvailedLeaves { get; set; }
        public decimal RemainingLeaves { get; set; }
        public decimal LeaveHoursDeduction { get; set; }
        public bool IsSelected { get; set; }
    }

    public class LeaveOpeningModel
    {
        public int CompanyCode { get; set; }
        public int UserCode { get; set; }
        public long EmpCode { get; set; }
        public int FiscalYearCode { get; set; }
        //public int LocCode { get; set; }
        //public int DeptCode { get; set; }
        public List<VM_LeaveOpeningTypes> LeaveOpeningTypes { get; set; }
        //public LeaveOpeningModel()
        //{
        //    LeaveOpeningTypes = new List<VM_LeaveOpeningTypes>();
        //    LeaveOpeningTypes.Add(new VM_LeaveOpeningTypes { });
        //}
    }
    public class VM_LeaveOpeningTypes
    {
        public long ID { get; set; }
        public int LeaveTypeCode { get; set; }
        public string LeaveTypeName { get; set; }
        public decimal NoOfLeaves { get; set; }
        //public bool IsDelete { get; set; }

    }
}

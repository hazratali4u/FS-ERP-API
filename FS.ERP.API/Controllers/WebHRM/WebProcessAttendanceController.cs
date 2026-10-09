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
    public class WebProcessAttendanceController : ApiController
    {
        public WebProcessAttendanceController()
        {

        }
        public WebProcessAttendanceController(string constr, string throwOrNot)
        {
            this.ConStr = constr;
            this.ThrowOrNot = throwOrNot;
        }
        public string ConStr { get; set; }
        public string ThrowOrNot { get; set; }
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
        [Route("~/Api/Process/ExecuteProcessAttendance")]
        public HttpResponseMessage ProcessAttendance(ProcessAttendanceModel model)
        {
            string emailMsg = "";

            try
            {
                DataTable getModel = new DataTable();

                //GET CONFIGURATION DATA
                getModel = ExecuteProcessAttendanceConfigData(model.userCode);
                int id = 0;
                if (getModel != null)
                {
                    foreach (DataRow row in getModel.Rows)
                    {
                        id = Convert.ToInt32(row["ID"].ToString());
                    }
                }

                if (id > 6)
                {
                    //START HTML
                    emailMsg = "<table border=0 cellpadding=3 cellspacing=3 width=70% style=''font-family: Arial, sans-serif;''><tr><td><table border=0 cellpadding=2 cellspacing=2 width=100%><tr><td bgcolor=#ccc width=center colspan=2 align=center style=''padding: 20px; color: #fff; font-family: Arial, sans-serif; font-size: 18px;''> <b>Process Details</b> </td></tr>";

                    if (!string.IsNullOrEmpty(model.deptCodes))
                    {
                        DataTable empCodesData = ExecuteDeptCodeSP(model.deptCodes);
                        if (empCodesData != null)
                        {
                            string eId = "";
                            foreach (DataRow row in empCodesData.Rows)
                            {
                                eId = eId + "," + row["ID"].ToString();
                            }

                            if (eId.Length > 0)
                            {
                                if (eId.Length > 1)
                                {
                                    eId = eId.Substring(1, eId.Length - 1);
                                    model.EmpCode = eId;
                                }
                                else
                                {
                                    eId = "";
                                }
                            }
                        }
                    }

                    bool procLateInEarlyOutCount = false;
                    bool procInOutMissingCount = false;
                    bool procShortHourDeduction_Attendance = false;
                    bool procLateMinutesDeduction_Attendance = false;


                    foreach (DataRow row in getModel.Rows)
                    {
                        if (Convert.ToInt32(row["ID"].ToString()) > 6)
                        {
                            if (Convert.ToBoolean(row["IncludeInProcess"].ToString()))
                            {
                                if (row["SPName"].ToString().Equals("[HRM].[SpLateInEarlyOutCount]"))
                                {
                                    emailMsg = emailMsg + "<tr><td>Late-In Early-Out Count</td>";

                                    procLateInEarlyOutCount = true;
                                }
                                else if (row["SPName"].ToString().Equals("[HRM].[SpInOutMissingCount]"))
                                {
                                    emailMsg = emailMsg + "<tr><td>In-Out Missing Count</td>";

                                    procInOutMissingCount = true;
                                }
                                else if (row["SPName"].ToString().Equals("[HRM].[ProcEmployeeDailyAttendanceInfoShortHourDeduction_Attendance]"))
                                {
                                    emailMsg = emailMsg + "<tr><td>Attendance Short Hour Deduction</td>";

                                    procShortHourDeduction_Attendance = true;
                                }
                                else if (row["SPName"].ToString().Equals("[HRM].[ProcEmployeeDailyAttendanceInfoLateMinutesDeduction_Attendance]"))
                                {
                                    emailMsg = emailMsg + "<tr><td>Attendance Late Minutes Deduction</td>";

                                    procLateMinutesDeduction_Attendance = true;
                                }                                

                                if (procLateInEarlyOutCount || procInOutMissingCount || procShortHourDeduction_Attendance || procLateMinutesDeduction_Attendance)
                                {
                                    //set params - get all employees if no emp/dept sent
                                    string empCodesForInOutErlyMissing = "";
                                    List<string> empCodeList = new List<string>();

                                    if (!string.IsNullOrEmpty(model.EmpCode))
                                    {
                                        empCodesForInOutErlyMissing = model.EmpCode;
                                        empCodeList = model.EmpCode.Split(',').ToList();
                                    }
                                    else
                                    {
                                        DataTable empCodesData = ExecuteGetAllEmpCode(model.userCode);
                                        if (empCodesData != null)
                                        {
                                            string eId = "";
                                            foreach (DataRow row2 in empCodesData.Rows)
                                            {
                                                eId = eId + "," + row2["ID"].ToString();
                                            }

                                            if (eId.Length > 0)
                                            {
                                                if (eId.Length > 1)
                                                {
                                                    eId = eId.Substring(1, eId.Length - 1);
                                                    empCodesForInOutErlyMissing = eId;
                                                    empCodeList = empCodesForInOutErlyMissing.Split(',').ToList();
                                                }
                                            }
                                        }
                                    }

                                    //emailMsg = emailMsg + " b4 Calling Method -> ";

                                    //call method
                                    var lateInEarlyOut = ExecuteLateInEarlyOutAndMissing(model.fromDate, model.toDate, empCodeList, empCodesForInOutErlyMissing, procLateInEarlyOutCount, procInOutMissingCount, false, false, procShortHourDeduction_Attendance, procLateMinutesDeduction_Attendance);

                                    emailMsg = emailMsg + "<td>Done</td></tr>";

                                    procLateInEarlyOutCount = false;
                                    procInOutMissingCount = false;
                                    procShortHourDeduction_Attendance = false;
                                    procLateMinutesDeduction_Attendance = false;
                                }
                                else
                                {

                                    if (row["SPName"].ToString().Equals("[HRM].[ProcEmployeeDailyAttendanceInfo_Attendance]"))
                                    {
                                        emailMsg = emailMsg + "<tr><td>Attendance Sync Process</td>";
                                    }
                                    else if (row["SPName"].ToString().Equals("[HRM].[ProcEmployeeDailyAttendanceInfoSandwichPolicy_Attendance]"))
                                    {
                                        emailMsg = emailMsg + "<tr><td>Attendance Sandwich Policy</td>";
                                    }
                                    else if (row["SPName"].ToString().Equals("[HRM].[ProcEmployeeDailyAttendanceInfoOverTimeAmount_Attendance]"))
                                    {
                                        emailMsg = emailMsg + "<tr><td>Over Time Amount Process</td>";
                                    }
                                    else if (row["SPName"].ToString().Equals("[HRM].SendAttendanceProcessedEmail"))
                                    {
                                        emailMsg = emailMsg + "<tr><td>Email Attendance Process</td>";
                                    }
                                    else
                                    {
                                        emailMsg = emailMsg + "<tr><td>" + row["SPName"].ToString() + "</td>";
                                    }

                                    ExecuteProcessSP(model.fromDate, model.toDate, model.EmpCode, model.userCode,
                                                    row["SPName"].ToString());

                                    emailMsg = emailMsg + "<td>Done</td></tr>";
                                }
                            }
                        }
                    }

                    return Request.CreateResponse(HttpStatusCode.OK, getModel, formatter);
                }
                else
                {

                    bool procAttendance = true;
                    bool procLateInEarlyOutCount = false;
                    bool procInOutMissingCount = false;
                    bool procAttendanceInOut = false;
                    bool procAttendanceInOutMissing = false;
                    bool procAttEmail = true;

                    if (getModel != null)
                    {
                        foreach (DataRow row in getModel.Rows)
                        {
                            if (row["SPName"].ToString().Equals("[HRM].[ProcEmployeeDailyAttendanceInfo]"))
                            {
                                procAttendance = Convert.ToBoolean(row["IncludeInProcess"].ToString());
                            }
                            else if (row["SPName"].ToString().Equals("[HRM].[SpLateInEarlyOutCount]"))
                            {
                                procLateInEarlyOutCount = Convert.ToBoolean(row["IncludeInProcess"].ToString());
                            }
                            else if (row["SPName"].ToString().Equals("[HRM].[SpInOutMissingCount]"))
                            {
                                procInOutMissingCount = Convert.ToBoolean(row["IncludeInProcess"].ToString());
                            }
                            else if (row["SPName"].ToString().Equals("[HRM].[ProcEmployeeDailyAttendanceInfoInOut]"))
                            {
                                procAttendanceInOut = Convert.ToBoolean(row["IncludeInProcess"].ToString());
                            }
                            else if (row["SPName"].ToString().Equals("[HRM].[ProcEmployeeDailyAttendanceInfoInOutMissing]"))
                            {
                                procAttendanceInOutMissing = Convert.ToBoolean(row["IncludeInProcess"].ToString());
                            }
                            else if (row["SPName"].ToString().Equals("[HRM].SendAttendanceProcessedEmail"))
                            {
                                procAttEmail = Convert.ToBoolean(row["IncludeInProcess"].ToString());
                            }
                        }
                    }

                    if (!string.IsNullOrEmpty(model.deptCodes))
                    {
                        DataTable empCodesData = ExecuteDeptCodeSP(model.deptCodes);
                        if (empCodesData != null)
                        {
                            string eId = "";
                            foreach (DataRow row in empCodesData.Rows)
                            {
                                eId = eId + "," + row["ID"].ToString();
                            }

                            if (eId.Length > 0)
                            {
                                if (eId.Length > 1)
                                {
                                    eId = eId.Substring(1, eId.Length - 1);
                                    model.EmpCode = eId;
                                }
                                else
                                {
                                    eId = "";
                                }
                            }
                        }
                    }

                    if (procAttendance) // this will always b TRUE and executed for all clients - its basic Process Attendance SP
                    {
                        getModel = ExecuteProcessAttendanceDailyInfo(model.fromDate, model.toDate, model.EmpCode, model.userCode);
                    }

                    //GET NEXT SP values to execute or not


                    if (procLateInEarlyOutCount || procInOutMissingCount || procAttendanceInOut || procAttendanceInOutMissing)
                    {

                        List<string> empCodeList = new List<string>();

                        if (!string.IsNullOrEmpty(model.EmpCode))
                        {
                            empCodeList = model.EmpCode.Split(',').ToList();
                        }
                        else
                        {
                            DataTable empCodesData = ExecuteGetAllEmpCode(model.userCode);
                            if (empCodesData != null)
                            {
                                string eId = "";
                                foreach (DataRow row in empCodesData.Rows)
                                {
                                    eId = eId + "," + row["ID"].ToString();
                                }

                                if (eId.Length > 0)
                                {
                                    if (eId.Length > 1)
                                    {
                                        eId = eId.Substring(1, eId.Length - 1);
                                        model.EmpCode = eId;
                                        empCodeList = model.EmpCode.Split(',').ToList();
                                    }
                                }
                            }
                        }

                        var lateInEarlyOut = ExecuteLateInEarlyOutAndMissing(model.fromDate, model.toDate, empCodeList, model.EmpCode, procLateInEarlyOutCount, procInOutMissingCount, procAttendanceInOut, procAttendanceInOutMissing, false, false);

                    }

                    if (procAttEmail && string.IsNullOrEmpty(ThrowOrNot))
                    {
                        var sendEmail = SendProcessAttendanceEmail(model.userCode, model.fromDate, model.toDate);
                    }


                    if (getModel == null)
                    {
                        return Request.CreateResponse(HttpStatusCode.NotFound);
                    }

                    return Request.CreateResponse(HttpStatusCode.OK, getModel, formatter);
                }
            }
            catch (Exception ex)
            {
                if (!string.IsNullOrEmpty(ThrowOrNot))
                {
                    return null;
                }
                // send email 
                string inner = "";
                if (ex.InnerException != null && ex.InnerException.Message != null)
                {
                    inner = ex.InnerException.Message;
                }
                emailMsg = emailMsg + " <tr><td colspan=2><br/>EXCEPTION :: <br/><br/>" + ex.Message + " <br/><br/>Inner :: " + inner + "</td></tr>";
                //last HTML
                emailMsg = emailMsg + "</table></td></tr></table>";

                var sendEmail = SendProcessAttendanceEmailOnException(model.userCode, model.fromDate, model.toDate, emailMsg);

                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }
        public DataTable ExecuteDeptCodeSP(string deptCodes)
        {
            var getModel = new DataTable();

            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].[procGetEmpIdsByDeptCodes]",
                    Parameters = new Dictionary<string, object>
                        {
                            { "DeptCode", deptCodes }
                        }
                };

                getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return getModel;
        }
        public DataTable ExecuteGetAllEmpCode(int userCode)
        {
            var getModel = new DataTable();

            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].[procGetEmpIdsAll]",
                    Parameters = new Dictionary<string, object>
                        {
                            { "UserCode", userCode }
                        }
                };

                getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return getModel;
        }
        public DataTable ExecuteProcessAttendanceConfigData(int userCode)
        {
            var getModel = new DataTable();

            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].[WebExecuteProcessAttendanceConfigData]",
                    Parameters = new Dictionary<string, object>
                        {
                            { "UserCode", userCode }
                        }
                };

                getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return getModel;
        }

        public DataTable ExecuteProcessSP(DateTime fromDate, DateTime toDate, string empCodes, int userCode, string spName)
        {
            var getModel = new DataTable();

            try
            {
                SpData data = new SpData
                {
                    SpName = spName,
                    Parameters = new Dictionary<string, object>
                        {
                            { "EmpCode", empCodes },
                            { "DateFrom", fromDate },
                            { "DateTo", toDate },
                            { "UserCode", userCode }
                        }
                };

                getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return getModel;
        }

        public DataTable ExecuteProcessAttendanceDailyInfo(DateTime fromDate, DateTime toDate, string empCodes, int userCode)
        {
            var getModel = new DataTable();

            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].[ProcEmployeeDailyAttendanceInfo]",
                    Parameters = new Dictionary<string, object>
                        {
                            { "EmpCode", empCodes },
                            { "DateFrom", fromDate },
                            { "DateTo", toDate },
                            { "UserCode", userCode }
                        }
                };

                getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return getModel;
        }
        public DataTable ExecuteLateInEarlyOutAndMissing(DateTime fromDate, DateTime toDate, List<string> empCodeList, string empCodes, bool procLateInEarlyOutCount, bool procInOutMissingCount, bool procAttendanceInOut, bool procAttendanceInOutMissing, bool procShortHourDeduction_Attendance, bool procLateMinutesDeduction_Attendance)
        {
            var getModel = new DataTable();

            try
            {
                var eGetModel = new List<ShortHrModel>();
                bool shortHrFlag = false;
                var ltGetModel = new List<ShortHrModel>();
                bool lteMinFlag = false;
                int Count = 1;
                SpData data = null;
                DateTime AttendanceDate = Convert.ToDateTime(fromDate).AddDays(-1);
                double TDays = ((toDate - fromDate).TotalDays) + 1;
                for (int i = 0; i < empCodeList.Count; i++)
                {
                    shortHrFlag = false;
                    lteMinFlag = false;
                    Count = 1;

                    //emailMsg = emailMsg + " :: " + empCodeList[i] + " :: ";

                    if (procShortHourDeduction_Attendance)
                    {
                        data = new SpData
                        {
                            SpName = "[HRM].[ProcEmployeesShortHour]",
                            Parameters = new Dictionary<string, object>
                                {
                                    { "EmpCode", Convert.ToInt64(empCodeList[i]) },
                                    { "FromDate", fromDate },
                                    { "ToDate", toDate }
                                }
                        };

                        //emailMsg = emailMsg + " [HRM].[ProcEmployeesShortHour] calling :> " ;

                        eGetModel = new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<ShortHrModel>();

                        if (eGetModel.Count > 0)
                        {
                            shortHrFlag = true;
                        }
                        else
                        {
                            shortHrFlag = false;
                        }

                    }
                    if (procLateMinutesDeduction_Attendance)
                    {
                        data = new SpData
                        {
                            SpName = "[HRM].[ProcEmployeesLateMinutes]",
                            Parameters = new Dictionary<string, object>
                                {
                                    { "EmpCode", Convert.ToInt64(empCodeList[i]) },
                                    { "FromDate", fromDate },
                                    { "ToDate", toDate }
                                }
                        };

                        //emailMsg = emailMsg + " [HRM].[ProcEmployeesLateMinutes] calling :> ";

                        ltGetModel = new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<ShortHrModel>();

                        if (ltGetModel.Count > 0)
                        {
                            lteMinFlag = true;
                        }
                        else
                        {
                            lteMinFlag = false;
                        }
                    }

                    for (int f = 0; f < TDays; f++)
                    {
                        if (procLateInEarlyOutCount)
                        {
                            data = new SpData
                            {
                                SpName = "[HRM].[SpLateInEarlyOutCount]",
                                Parameters = new Dictionary<string, object>
                                {
                                    { "EmpCode", Convert.ToInt64(empCodeList[i]) },
                                    { "FromDate", fromDate },
                                    { "ToDate", toDate },
                                    { "AttendanceDate", AttendanceDate.AddDays(Count) }
                                }
                            };

                            getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                        }

                        if (procInOutMissingCount)
                        {
                            data = new SpData
                            {
                                SpName = "[HRM].[SpInOutMissingCount]",
                                Parameters = new Dictionary<string, object>
                                {
                                    { "EmpCode", Convert.ToInt64(empCodeList[i]) },
                                    { "FromDate", fromDate },
                                    { "ToDate", toDate },
                                    { "AttendanceDate", AttendanceDate.AddDays(Count) }
                                }
                            };

                            getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                        }

                        if (shortHrFlag)
                        {
                            if (eGetModel.Where(x => x.AttendanceDate.Equals(AttendanceDate.AddDays(Count))).Count() > 0)
                            {
                                data = new SpData
                                {
                                    SpName = "[HRM].[ProcEmployeeDailyAttendanceInfoShortHourDeduction_Attendance]",
                                    Parameters = new Dictionary<string, object>
                                    {
                                        { "EmpCode", Convert.ToInt64(empCodeList[i]) },
                                        { "FromDate", fromDate },
                                        { "ToDate", toDate },
                                        { "AttendanceDate", AttendanceDate.AddDays(Count) }
                                    }
                                };

                                getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                            }
                        }

                        if (lteMinFlag)
                        {
                            if (ltGetModel.Where(x => x.AttendanceDate.Equals(AttendanceDate.AddDays(Count))).Count() > 0)
                            {
                                data = new SpData
                                {
                                    SpName = "[HRM].[ProcEmployeeDailyAttendanceInfoLateMinutesDeduction_Attendance]",
                                    Parameters = new Dictionary<string, object>
                                    {
                                        { "EmpCode", Convert.ToInt64(empCodeList[i]) },
                                        { "FromDate", fromDate },
                                        { "ToDate", toDate },
                                        { "AttendanceDate", AttendanceDate.AddDays(Count) }
                                    }
                                };

                                getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                            }
                        }

                        Count += 1;
                    }
                }

                if (procAttendanceInOut)
                {
                    //emailMsg = emailMsg + " [HRM].[ProcEmployeeDailyAttendanceInfoInOut] calling :> ";

                    var result = ExecuteDailyAttendanceINOut(fromDate, toDate, empCodes);
                }

                if (procAttendanceInOutMissing)
                {
                    //emailMsg = emailMsg + " [HRM].[ProcEmployeeDailyAttendanceInfoInOutMissing] calling :> ";

                    var result1 = ExecuteDailyAttendanceInOutMissing(fromDate, toDate, empCodes);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return getModel;
        }

        public DataTable ExecuteDailyAttendanceINOut(DateTime fromDate, DateTime toDate, string empCodes)
        {
            var getModel = new DataTable();

            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].[ProcEmployeeDailyAttendanceInfoInOut]",
                    Parameters = new Dictionary<string, object>
                        {
                            { "EmpCode", empCodes },
                            { "DateFrom", fromDate },
                            { "DateTo", toDate },
                        }
                };

                getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return getModel;
        }

        public DataTable ExecuteDailyAttendanceInOutMissing(DateTime fromDate, DateTime toDate, string empCodes)
        {
            var getModel = new DataTable();

            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].[ProcEmployeeDailyAttendanceInfoInOutMissing]",
                    Parameters = new Dictionary<string, object>
                        {
                            { "EmpCode", empCodes },
                            { "DateFrom", fromDate },
                            { "DateTo", toDate },
                        }
                };

                getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return getModel;
        }

        public DataTable SendProcessAttendanceEmail(int userCode, DateTime fromDate, DateTime toDate)
        {
            var getModel = new DataTable();

            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].SendAttendanceProcessedEmail",
                    Parameters = new Dictionary<string, object>
                        {
                            { "UserCode", userCode },
                            { "DateFrom", fromDate },
                            { "DateTo", toDate }
                        }
                };

                getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return getModel;
        }
        public DataTable SendProcessAttendanceEmailOnException(int userCode, DateTime fromDate, DateTime toDate, string emailMsg)
        {
            var getModel = new DataTable();

            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].[SendAttendanceProcessedEmailOnException]",
                    Parameters = new Dictionary<string, object>
                    {
                        { "UserCode", userCode },
                        { "DateFrom", fromDate },
                        { "DateTo", toDate },
                        {"EmailMsg", emailMsg }
                    }
                };

                getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return getModel;
        }
    }
    public class ProcessAttendanceModel
    {
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public string EmpCode { get; set; }
        public string deptCodes { get; set; }
        public int userCode { get; set; }
    }
    public class ShortHrModel
    {
        public string EmpCode { get; set; }
        public DateTime AttendanceDate { get; set; }
        public decimal? ShortHours { get; set; }
        public decimal? LateMinutes { get; set; }        
    }
    
}

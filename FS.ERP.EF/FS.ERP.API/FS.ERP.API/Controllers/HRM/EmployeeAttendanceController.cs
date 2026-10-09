using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using CST.CCL.Helper.Common;
using FS.ERP.Models.BO;

namespace FS.ERP.API.Controllers.HRM.AttendanceManagement
{
    public class EmployeeAttendanceController : FsErpController<BOEmployeeAttendance>
    {
        [HttpGet]
        public HttpResponseMessage GetEmployees(string procedureName, string lpm)
        {
            try
            {
                List<ParameterList> lpmData = JsonHelper.DeserializeByNewtonSoftJson<List<ParameterList>>(lpm);
                var getModel = new FS.CAPI.BAL.HRM.AttendanceManagement.EmployeeAttendanceRepository(ConStr).GetEmployees(procedureName, lpmData);
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
    }
}
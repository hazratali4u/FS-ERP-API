using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using FS.ERP.Models.BO;

namespace FS.ERP.API.Controllers.HRM.EmployeeAdministration
{
    public class EmployeeInfoController : FsErpControllerWithDataType<BOEmployeeInfo, long>
    {
        //SaveMasterChild

        [HttpGet]
        [Route("~/api/EmployeeInfo/GetCompleteInfo")]
        public HttpResponseMessage GetCompleteEmployeeInfo(int empId)
        {
            try
            {
                var getModel = new FS.CAPI.BAL.HRM.EmployeeInfoRepositiry(ConStr).GetCompleteEmployeeInfo(empId);
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
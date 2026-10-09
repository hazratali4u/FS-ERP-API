using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using FS.CAPI.BAL;
using FS.ERP.Models.BO;
using FS.ERP.API.Filters;

namespace FS.ERP.API.Controllers.MenuCNF
{
    public class MenuController : FsErpController<BOMenu>
    {
        [HttpGet]
        [CacheFilter(TimeDuration = 60)]
        public HttpResponseMessage GetUserMenu(int userCode, int companyCode)
        {
            try
            {
                var getModel = new MenuRepository(ConStr).GetUserMenu(userCode, companyCode);
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

        [HttpGet]
        [CacheFilter(TimeDuration = 60)]
        public HttpResponseMessage GetChildMenus(int menuCode)
        {
            try
            {
                var getModel = new MenuRepository(ConStr).GetChildMenus(menuCode);
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

        public HttpResponseMessage GetUserReportMenu(int userCode, int companyCode)
        {
            try
            {
                var getModel = new MenuRepository(ConStr).GetUserReportMenu(userCode, companyCode);
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

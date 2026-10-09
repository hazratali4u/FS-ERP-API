using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using FS.ERP.Models.BO;

namespace FS.ERP.API.Controllers.AppCNF.Geography
{
    public class SectorZoneController : FsErpController<BOSectorZone>
    {
        [HttpGet]
        public HttpResponseMessage GetSectorZones()
        {
            try
            {

                var getModel = new FS.CAPI.BAL.AppCNF.Geography.SectorZoneRepository(ConStr).GetSectorZones();
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
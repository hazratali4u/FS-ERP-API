using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using CST.CCL.Helper.Common;
using FS.ERP.Models.BO;

namespace FS.ERP.API.Controllers.AppCNF.Geography
{
    public class CountryRegionController : FsErpController<BOCountryRegion>
    {
        [HttpGet]
        public HttpResponseMessage GetCountryRegions(int? sectorZoneCode)
        {
            try
            {
                List<ParameterList> lpm = null;
                if (sectorZoneCode != null)
                {
                    lpm = new List<ParameterList>();
                    lpm.Add(new ParameterList("sectorCode", sectorZoneCode));
                }

                var getModel = new FS.CAPI.BAL.AppCNF.Geography.CountryRegionRepository(ConStr).GetCountryRegions(lpm);
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

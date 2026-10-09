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
    public class AreaOfDistrictWardController : FsErpController<BOAreaOfDistrictWard>
    {
        [HttpGet]
        public HttpResponseMessage GetAreaOfDistrictWards(int? districtWardCode)
        {
            try
            {
                List<ParameterList> lpm = null;
                if (districtWardCode != null)
                {
                    lpm = new List<ParameterList>();
                    lpm.Add(new ParameterList("districtCode", districtWardCode));
                }

                var getModel = new FS.CAPI.BAL.AppCNF.Geography.AreaOfDistrictWardRepository(ConStr).GetAreaOfDistrictWards(lpm);
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

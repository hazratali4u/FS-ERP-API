using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using CST.CCL.Helper.Common;
using FS.ERP.Models.BO;

namespace FS.ERP.API.Controllers.AppCNF
{
    public class AppConfigurationController : FsErpController<BOAppConfiguration>
    {
        [HttpGet]
        public HttpResponseMessage GetDocumentModuleCode(string documentType)
        {
            try
            {
                List<ParameterList> lpm = new List<ParameterList>();
                lpm.Add(new ParameterList("documentType", documentType));

                var getModel = new FS.CAPI.BAL.AppCNF.AppConfigurationRepository(ConStr).GetDocumentModuleCode(lpm);

                if (getModel == -1)
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

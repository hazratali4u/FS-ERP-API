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
    public class TransactionDocumentProcessController : FsErpController<BOTransactionDocumentProcess>
    {
        [HttpGet]
        public HttpResponseMessage GetDocumentProcesses(int? companyCode)
        {
            try
            {
                List<ParameterList> lpm = null;
                if (companyCode != null)
                {
                    lpm = new List<ParameterList>();
                    lpm.Add(new ParameterList("companyCode", companyCode));
                }

                var getModel = new FS.CAPI.BAL.AppCNF.TransactionDocumentProcessRepository(ConStr).GetDocumentsProcesses(lpm);
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

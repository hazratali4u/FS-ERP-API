using System;
using System.Data;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;
using CST.CCL.Helper.Common;
using FS.ERP.Models.IdentityModel;
using System.Web.Http;
using FS.ERP.Business.IdentityManager;
using FS.ERP.EF.IdentityStore;
using Microsoft.AspNet.Identity;
using Newtonsoft.Json;
using System.Collections.Generic;
using FS.ERP.Models.Custom;
using FS.CAPI.BAL;

namespace FS.ERP.API.Controllers.UMS
{
    public class UserController : FsErpController<BOUser>
    {
        [System.Web.Http.HttpGet]
        public async Task<HttpResponseMessage> GetUserPermissionDataSet(string queryName, int userCode)
        {
            try
            {
                DataTable dt;
                var result = Task.Factory.StartNew(() =>
                {
                    dt = new FS.CAPI.BAL.UserRepository(ConStr).GetUserPermissionDataSet(queryName, userCode);
                    return dt;
                });
                await result;

                string strJson = JsonHelper.DataTableToJSONWithStringBuilder(result.Result);
                var response = this.Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(strJson, Encoding.UTF8, "application/json");
                return response;
                //return Request.CreateResponse(HttpStatusCode.OK, getModel);
            }
            catch (Exception ex)
            {
                //LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetUserMenu", "tbl_Menu", "dbo.ProcGetUserMenu", ex, false, false);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, new JsonMediaTypeFormatter());
            }
        }
    }
}

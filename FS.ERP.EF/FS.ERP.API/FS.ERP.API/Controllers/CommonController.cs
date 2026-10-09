using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Cors;
using FS.CAPI.BAL;
using CST.CCL.Helper;
using CST.CCL.Helper.Common;
using CST.CRY;
using FS.ERP.Business.IdentityManager;
using FS.ERP.EF.Db_Context;
using FS.ERP.EF.IdentityStore;
using FS.ERP.Models.BO;
using FS.ERP.Models.Custom;
using FS.ERP.Models.IdentityModel;
using Microsoft.AspNet.Identity;
using Newtonsoft.Json;
using PLINQO;
using FS.ERP.API.Filters;

namespace FS.ERP.API.Controllers
{
    [Authorize]
    [EnableCors("*", "*", "*")]
    public class CommonController : ApiController
    {
        public string ConStr { get; set; }
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

        [HttpGet]
        [Route("~/Api/User/HashPassword/{password}")]
        public HttpResponseMessage HashPassword(string password)
        {
            try
            {
                var userManager = new ApplicationUserManager(new ApplicationUserStore(FsERPContext.Create(ConStr)));
                string hashedPassword = userManager.PasswordHasher.HashPassword(password);
                return Request.CreateResponse(HttpStatusCode.OK, hashedPassword, formatter);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }

        [HttpPost]
        [Route("~/Api/Common/RunSimpleQuery")]
        public async Task<HttpResponseMessage> RunSimpleQuery([FromBody]string query)
        {
            try
            {
                bool val = false;
                var result = Task.Factory.StartNew(() => {
                    val = new CommonRepository(ConStr).RunSimpleQuery(query);
                    return val;
                });
                await result;
                return Request.CreateResponse(HttpStatusCode.OK, result.Result, new JsonMediaTypeFormatter());
            }
            catch (Exception ex)
            {
                //LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetUserMenu", "tbl_Menu", "dbo.ProcGetUserMenu", ex, false, false);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, new JsonMediaTypeFormatter());
            }
        }

        [HttpPost]
        [Route("~/Api/Common/RunQuery")]
        public async Task<HttpResponseMessage> RunQuery([FromBody]string query)
        {
            try
            {
                DataTable data = null;
                var result = Task.Factory.StartNew(() => {
                    data = new CommonRepository(ConStr).RunQuery(query);
                    return data;
                });
                await result;
                return Request.CreateResponse(HttpStatusCode.OK, result.Result, new JsonMediaTypeFormatter());
            }
            catch (Exception ex)
            {
                //LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetUserMenu", "tbl_Menu", "dbo.ProcGetUserMenu", ex, false, false);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, new JsonMediaTypeFormatter());
            }
        }

        [HttpGet]
        [CacheFilter(TimeDuration = 60)]
        public HttpResponseMessage GetLookUpDataSet(string procedureName, string lpm)
        {
            try
            {
                List<ParameterList> lpmData = JsonHelper.DeserializeByNewtonSoftJson<List<ParameterList>>(lpm);
                var getModel = new CommonRepository(ConStr).GetLookUpDataSet(procedureName, lpmData);
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

        [HttpPost]
        public HttpResponseMessage IsValidateForDelete(IsValidateForDelete modal)
        {
            try
            {
                var getModel = new CommonRepository(ConStr).IsValidateForDelete(modal);
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
        public HttpResponseMessage GetCodeValue(string strReturnType, string strTableName, string strColName, string strWhere, string strCompositeKey, string strCompositeValue)
        {
            try
            {
                var getModel = new CommonRepository(ConStr).GetCodeValue(strReturnType, strTableName, strColName, strWhere, strCompositeKey, strCompositeValue);
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

        [HttpPost]
        [Route("~/api/Common/ExecSp")]
        [CacheFilter(TimeDuration = 60)]
        public HttpResponseMessage ExecSp(SpData data)
        {
            try
            {
                var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
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
        public HttpResponseMessage GetDataWithJoin(string entityName, string whereClause)
        {
            try
            {
                var getModel = new CommonRepository(ConStr).GetDataWithJoin(entityName, whereClause);
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
        public HttpResponseMessage SoftDelete(string id, string tableName)
        {
            try
            {
                var getModel = new CommonRepository(ConStr).SoftDelete(Convert.ToInt32(id), tableName);
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
        public HttpResponseMessage GetToolBarRights(int userCode, int companyCode, int menuCode)
        {
            try
            {
                var getModel = new FS.CAPI.BAL.UserRepository(ConStr).GetToolBarRights(userCode, companyCode, menuCode);
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

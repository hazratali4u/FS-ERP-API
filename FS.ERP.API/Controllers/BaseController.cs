using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Dynamic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Cors;
using System.Web.Http.OData;
using System.Web.Http.OData.Routing;
using PLINQO;
using CST.CCL.Helper;
using CST.CCL.Helper.Common;
using CST.CRY;
using FS.ERP.Business.Repository;
using FS.ERP.EF.Db_Context;
using FS.ERP.Models;
using FS.ERP.TenantDal;
using Newtonsoft.Json;
using FS.ERP.API.Filters;

namespace FS.ERP.API.Controllers
{
    public abstract class FsErpController<TModel> : BaseController<TModel, FsERP_Context, int> where TModel : class
    {

    }

    [Authorize]
    public abstract class FsErpControllerWithDataType<TModel, TId> : BaseController<TModel, FsERP_Context, TId> where TModel : class where TId : struct 
    {

    }

    public abstract class TenantController<TModel> : BaseController<TModel, TenantContext, int> where TModel : class
    {
        protected TenantController()
        {
            InitRepo = false;
            _repo = new Repository<TModel, TenantContext, int>(Encryptor.Decrypt(AppSettings.PrivateKey,
                AppSettings.ConnectionString));
        }
    }

    [EnableCors("*","*","*")]
    public abstract class BaseController<TModel, TContext, TId> 
        : EntitySetController<TModel, TId> 
        where TModel : class where TContext : DbContext where TId : struct
    {
        public string ConStr { get; set; }

        protected bool InitRepo = true;

        private JsonMediaTypeFormatter formatter;

        protected Repository<TModel, TContext, TId> _repo;

        protected override void Initialize(HttpControllerContext controllerContext)
        {
            if (InitRepo)
            {
                string _connStr = controllerContext.Request.GetFirstHeaderValueOrDefault<string>("x-conn", x => "", Convert.ToString);
                if (string.IsNullOrEmpty(_connStr))
                    throw new UnauthorizedAccessException("You are not authorized to access this link. Please contact administrator");

                ConStr = Encryptor.Decrypt(AppSettings.PrivateKey, _connStr);
                _repo = new Repository<TModel, TContext, TId>(ConStr, false, false);
            }

            formatter = new JsonMediaTypeFormatter
            {
                SerializerSettings = { ReferenceLoopHandling = ReferenceLoopHandling.Ignore }
            };
            base.Initialize(controllerContext);
        }

        [System.Web.Http.OData.EnableQuery]
        [CacheFilter(TimeDuration=60)]
        public override IQueryable<TModel> Get()
        {
            return _repo.FilterDataQuery();
        }
        [CacheFilter(TimeDuration = 60)]
        public HttpResponseMessage GetAllWithPaging(int page = 0, int pageSize = 5)
        {
            try
            {
                int totalCount = _repo.Count();
                List<TModel> data = _repo.SelectAllPaging(pageSize, page * pageSize);
                var returnData = new
                {
                    Data = data,
                    Paging =
                    new
                    {
                        Total = totalCount,
                        Limit = pageSize,
                        CurrentPage = page,
                        PageCount = (int)Math.Ceiling((double)totalCount / pageSize)
                    }
                };

                return Request.CreateResponse(HttpStatusCode.OK, returnData, formatter);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }

        [CacheFilter(TimeDuration = 60)]
        public async Task<HttpResponseMessage> GetById(TId id)
        {
            try
            {
                TModel data = await _repo.FindByIdAsync(id);
                return Request.CreateResponse(HttpStatusCode.OK, data, formatter);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }

        [HttpPut]
        public override HttpResponseMessage Put([FromODataUri] TId key, [FromBody]TModel update)
        {
            try
            {
                var result = _repo.Update(key, update);

                return Request.CreateResponse(HttpStatusCode.OK, result, formatter);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }


        [HttpPost]
        public override HttpResponseMessage Post(TModel entity)
        {
            try
            {
                var result = _repo.Insert(entity);
                return Request.CreateResponse(HttpStatusCode.OK, result, formatter);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }



        [HttpDelete]
        public async Task<HttpResponseMessage> DeleteData(TId id)
        {
            try
            {
                await _repo.DeleteAsync(id);
                return Request.CreateResponse(HttpStatusCode.OK, true, formatter);
            }
            catch (Exception ex)
            {
                //LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetUserMenu", "tbl_Menu", "dbo.ProcGetUserMenu", ex, false, false);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }


        [HttpPost]
        [Route("PostCollection")]
        public HttpResponseMessage PostCollection([FromBody] List<TModel> entity)
        {
            try
            {
                var result = _repo.Insert(entity);
                return Request.CreateResponse(HttpStatusCode.OK, result, formatter);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }
    }
}

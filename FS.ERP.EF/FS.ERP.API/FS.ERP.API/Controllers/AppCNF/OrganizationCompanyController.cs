using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using FS.CAPI.BAL.AppCNF;
using FS.ERP.Models.BO;

namespace FS.ERP.API.Controllers.AppCNF
{
    public class OrganizationCompanyController : FsErpController<BOOrganizationCompany>
    {
        [HttpGet]
        [Route("~/api/OrganizationCompany/GetChildCompanies")]
        public HttpResponseMessage GetChildCompanies(int companyCode)
        {
            try
            {
                var getModel = new OrganizationCompanyRepo(ConStr).GetChildOrganizations(companyCode);
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
        [Route("~/api/OrganizationCompany/GetParentCompanies")]
        public HttpResponseMessage GetParentOrganizations(int orgId)
        {
            try
            {
                var getModel = new OrganizationCompanyRepo(ConStr).GetParentOrganizations(orgId);
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
        [Route("~/api/OrganizationCompany/GetGroupProfitCenter")]
        public HttpResponseMessage GetGroupProfitCenter(int companyCode)
        {
            try
            {
                var getModel = new OrganizationCompanyRepo(ConStr).GetGroupProfitCenter(companyCode);
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
        [Route("~/api/OrganizationCompany/CheckDuplicate")]
        public HttpResponseMessage CheckDuplicateOrganization(int id, string name, int level, string ntn, string gst, string iata, string sns)
        {
            try
            {
                var getModel = new OrganizationCompanyRepo(ConStr).CheckDuplicateOrganization(id, name, level, ntn, gst, iata, sns);
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
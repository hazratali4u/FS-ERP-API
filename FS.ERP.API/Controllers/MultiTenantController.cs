using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;
//using System.Web.OData.Routing;
using FS.BO.MultiTanent;
using CST.CCL.Helper;
using CST.CRY;
using FS.ERP.Business.Repository;
using FS.ERP.Models;
//using Microsoft.OData;
using Newtonsoft.Json;

namespace FS.ERP.API.Controllers
{
    //[ODataRoutePrefix("MultiTenant")]
    public class MultiTenantController : TenantController<BOMultiTenant>
    {
        [System.Web.Http.AllowAnonymous]
        [System.Web.Http.HttpGet]
        //[ODataRoute("Default.GetClientInfo")]
        //[ODataRoute("GetClientInfo(user={user},pin={pin})")]
        //[ODataRoute("GetClientInfo?user={user}&pin={pin}")]
        [System.Web.Http.Route("~/api/MultiTenant/GetClientInfo")]
        public HttpResponseMessage GetClientInfo(string pin)
        {
            try
            {
                var _repo =
                    new FsErpTanentRepository<BOMultiTenant>(Encryptor.Decrypt(AppSettings.PrivateKey,
                        AppSettings.ConnectionString));
                //List<BOMultiTenant> data = _repo.FilterData(x => x.ClientUser.ToLower() == user.ToLower() && x.PinCode == pin);
                List<BOMultiTenant> data = _repo.FilterData(x => x.PinCode.ToLower() == pin.ToLower());

                MultiTenantResponse returnData = null;
                var clientData = data.FirstOrDefault();
                if (clientData != null)
                {
                    if (clientData.IsOperative.HasValue && clientData.IsOperative.Value == true)
                    {
                        if (clientData.ExpiryDate > DateTime.Now)
                        {
                            returnData = new MultiTenantResponse
                            {
                                IsSuccess = true,
                                DbInfo = clientData.DBConInfo,
                                Message = "Success",
                                ClientId = clientData.Id,
                                ExpiryDate = clientData.ExpiryDate,
                                EndDate = clientData.EndDate,
                                ExpiryMessage = clientData.DBAuthentication
                            };
                        }
                        else
                        {
                            returnData = new MultiTenantResponse
                            {
                                ClientId = 0,
                                IsSuccess = false,
                                DbInfo = null,
                                Message = "You are not authorized to access this company. Please contact Administrator"
                            };
                        }
                    }
                    else
                    {
                        returnData = new MultiTenantResponse
                        {
                            ClientId = 0,
                            IsSuccess = false,
                            DbInfo = null,
                            Message = "Client is not active"
                        };
                    }
                }
                else
                {
                    returnData = new MultiTenantResponse
                    {
                        ClientId = 0,
                        IsSuccess = false,
                        DbInfo = null,
                        Message = "Client user or PIN number is incorrect"
                    };
                }

                return Request.CreateResponse(HttpStatusCode.OK, returnData, new JsonMediaTypeFormatter());
            }
            catch (Exception ex)
            {
                //LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetUserMenu", "tbl_Menu", "dbo.ProcGetUserMenu", ex, false, false);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, new JsonMediaTypeFormatter());
            }
        }
    }
}

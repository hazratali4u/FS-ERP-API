using CST.CCL.Helper;
using CST.CCL.Helper.Common;
using CST.CRY;
using FS.CAPI.BAL;
using FS.ERP.Business.IdentityManager;
using FS.ERP.EF.IdentityStore;
using FS.ERP.Models.Custom;
using Google.Authenticator;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Cors;

namespace FS.ERP.API.Controllers
{
    [Authorize]
    [EnableCors("*", "*", "*")]
    public class WebAccountController : ApiController
    {
        public WebAccountController()
        {

        }
        public WebAccountController(string constr, string throwOrNot)
        {
            this.ConStr = constr;
            this.ThrowOrNot = throwOrNot;
        }
        public string ConStr { get; set; }
        public string ThrowOrNot { get; set; }
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

        #region 2FA-AUTH-GOOGLE        

        //https://www.c-sharpcorner.com/article/two-factor-authentication-using-google-authenticator-in-asp-net-mvc/

        [HttpPost]
        [Route("~/api/account/Generate2FAGoogle")]
        public HttpResponseMessage Generate2FAGoogle(VerifyCodeViewModel model)
        {
            // model.PIN and model.Username are required in it
            try
            {
                string key = "FSTeamsuite";
                string weburl = "teamsuite.pk";

                if (model.UserCode == 0 && string.IsNullOrEmpty(model.Username))
                {
                    return Request.CreateResponse(HttpStatusCode.NotAcceptable, new Exception("User credentials are not provided"), new JsonMediaTypeFormatter());
                }

                string UserUniqueKey = model.PIN + model.Username + key;

                TwoFactorAuthenticator TwoFacAuth = new TwoFactorAuthenticator();
                var setupInfo = TwoFacAuth.GenerateSetupCode(model.PIN + "." + weburl, model.Username, ConvertSecretToBytes(UserUniqueKey, false));

                string barcodeURL = setupInfo.QrCodeSetupImageUrl;
                //string SetupCode = setupInfo.ManualEntryKey;


                // return QR IMAGE now that is in barcodeURL 
                if (!string.IsNullOrEmpty(barcodeURL))
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new Google2FAModel
                    {
                        Msg = "QR Image",
                        QrImage = barcodeURL

                    }, formatter);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new Google2FAModel
                    {
                        Msg = "Some error occurred",
                        QrImage = null

                    }, formatter);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, new JsonMediaTypeFormatter());
            }
        }


        [HttpPost]
        //[ValidateAntiForgeryToken]
        [Route("~/api/account/VerifyCode")]
        public HttpResponseMessage VerifyCode(VerifyCodeViewModel model)
        {
            try
            {
                string googlekey = "";
                string key = "FSTeamsuite";

                if (!ModelState.IsValid)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new Exception("Model state invalid"), new JsonMediaTypeFormatter());
                }

                if (model.UserCode == 0 || string.IsNullOrEmpty(model.AuthCode))
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new Exception("User credentials / verify code are not provided"), new JsonMediaTypeFormatter());
                }

                if (!model.AfterGeneration && false) // At the moment make THIS CONDITION FALSE - as runtime we can get google key so avoid DB call to get user key - if we get google key from DB then also DECRYPT it
                {
                    DataTable getModel = new DataTable();

                    //GET USER DATA
                    getModel = ExecuteGetUserData(model.UserCode);
                    
                    if (getModel != null)
                    {
                        foreach (DataRow row in getModel.Rows)
                        {
                            googlekey = row["GoogleKey"].ToString();
                        }

                        //decrypt the Google key IF GETTING FROM DB
                    }
                    else
                    {
                        // do nothing at the moment
                    }
                }
                else
                {
                    googlekey = model.PIN + model.Username + key;
                }
                
                string UserUniqueKey = model.PIN + model.Username + key;

                TwoFactorAuthenticator TwoFacAuth = new TwoFactorAuthenticator();
                bool isValid = TwoFacAuth.ValidateTwoFactorPIN(UserUniqueKey, model.AuthCode, false);

                if (isValid)
                {
                    if (model.AfterGeneration)
                    {
                        var userManager = new ApplicationUserManager(new ApplicationUserStore(FsERPContext.Create(ConStr)));
                        string hashedUserUniqueKey = userManager.PasswordHasher.HashPassword(UserUniqueKey);
                        var getModel2 = ExecuteEnableDisable2FAGoogle(model.UserCode, true, hashedUserUniqueKey);
                        if (getModel2 != null)
                        {
                            return Request.CreateResponse(HttpStatusCode.OK, new ResultModel
                            {
                                Msg = "Data is saved after successful authentication",
                                TotalRows = 1

                            }, formatter);
                        }
                        else
                        {
                            return Request.CreateResponse(HttpStatusCode.OK, new ResultModel
                            {
                                Msg = "Authentication is successful, but data could not be saved",
                                TotalRows = 0

                            }, formatter);
                        }
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, new ResultModel
                        {
                            Msg = "Authentication is successful",
                            TotalRows = 1

                        }, formatter);
                    }
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new ResultModel
                    {
                        Msg = "Authentication is not successful",
                        TotalRows = 0

                    }, formatter);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, new JsonMediaTypeFormatter());
            }
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        [Route("~/api/account/Disable2FAGoogle")]
        public HttpResponseMessage Disable2FAGoogle(VerifyCodeViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new Exception("Model state invalid"), new JsonMediaTypeFormatter());
                }

                if (model.UserCode == 0)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new Exception("User credentials are not provided"), new JsonMediaTypeFormatter());
                }
                else
                {
                    DataTable getModel = new DataTable();

                    //DISABLE GOOGLE 2FA 
                    getModel = ExecuteEnableDisable2FAGoogle(model.UserCode, false);
                    
                    if (getModel != null)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, getModel, formatter);
                    }
                    else
                    {
                        return Request.CreateResponse(
                            HttpStatusCode.InternalServerError,
                            new ResultModel
                            {
                                Msg = "Some error occurred",
                                TotalRows = 0
                            },
                            formatter);
                    }
                }

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, new JsonMediaTypeFormatter());
            }
        }

        public DataTable ExecuteEnableDisable2FAGoogle(int userCode, bool isEnable, string googleKey = null)
        {
            var getModel = new DataTable();

            try
            {
                SpData data = new SpData
                {
                    SpName = "[UMS].[WebEnableDisable2FAGoogle]",
                    Parameters = new Dictionary<string, object>
                    {
                        { "UserCode", userCode },
                        { "IsGoogleEnable", isEnable },
                        { "GoogleKey", googleKey }
                    }
                };

                getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return getModel;
        }

        public DataTable ExecuteGetUserData(int userCode)
        {
            var getModel = new DataTable();

            try
            {
                SpData data = new SpData
                {
                    SpName = "[UMS].[WebGetUserGoogleAuthData]",
                    Parameters = new Dictionary<string, object>
                        {
                            { "UserCode", userCode }
                        }
                };

                getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return getModel;
        }
        private static byte[] ConvertSecretToBytes(string secret, bool secretIsBase32) =>
        secretIsBase32 ? Base32Encoding.ToBytes(secret) : Encoding.UTF8.GetBytes(secret);

        #endregion



        //#region 2FA-AUTH-GOOGLE

        //[HttpPost]
        ////[AllowAnonymous]
        ////[ValidateAntiForgeryToken]
        //[Route("~/api/account/VerifyCode")]
        //public async Task<HttpResponseMessage> VerifyCode(VerifyCodeViewModel model)
        //{
        //    //model.Code = "770474";
        //    //model.Provider = "Google Authenticator";

        //    //var userManager = new ApplicationUserManager(new ApplicationUserStore(FsERPContext.Create(ConStr)));
        //    var mgr = new ApplicationUserManager(new ApplicationUserStore(FsERPContext.Create(Request.GetOwinContext())));

        //    var userId = await new ApplicationSignInManager(mgr, Request.GetOwinContext().Authentication).GetVerifiedUserIdAsync();
        //    if (userId == null)
        //    {
        //        return null;
        //    }
        //    var userFactors = await mgr.GetValidTwoFactorProvidersAsync(userId);


        //    if (!ModelState.IsValid)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError, new Exception(), new JsonMediaTypeFormatter());
        //    }

        //    // The following code protects for brute force attacks against the two factor codes. 
        //    // If a user enters incorrect codes for a specified amount of time then the user account 
        //    // will be locked out for a specified amount of time. 
        //    // You can configure the account lockout settings in IdentityConfig
        //    var result = await new ApplicationSignInManager(mgr, Request.GetOwinContext().Authentication).TwoFactorSignInAsync(
        //        model.Provider,
        //        model.Code,
        //        isPersistent: model.RememberMe,
        //        rememberBrowser: model.RememberBrowser);

        //    switch (result)
        //    {
        //        case SignInStatus.Success:
        //            var response = this.Request.CreateResponse(HttpStatusCode.OK);
        //            return response;
        //        case SignInStatus.LockedOut:
        //            //return View("Lockout");
        //            var response2 = this.Request.CreateResponse(HttpStatusCode.OK);
        //            return response2;
        //        case SignInStatus.Failure:
        //        default:
        //            return Request.CreateResponse(HttpStatusCode.InternalServerError, new Exception(), new JsonMediaTypeFormatter());
        //    }
        //}

        //#endregion
    }

    public class VerifyCodeViewModel
    {
        public int UserCode { get; set; }
        public string Username { get; set; }
        public string AuthCode { get; set; }
        public string PIN { get; set; }
        public bool AfterGeneration { get; set; }
    }

    public class ResultModel
    {
        public int TotalRows { get; set; }
        public string Msg { get; set; }
    }

    public class Google2FAModel
    {
        public string QrImage { get; set; }
        public string Msg { get; set; }
    }
}

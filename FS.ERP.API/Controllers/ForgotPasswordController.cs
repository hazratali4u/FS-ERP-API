using CST.CCL.Helper;
using CST.CCL.Helper.Common;
using CST.CRY;
using FS.CAPI.BAL;
using FS.ERP.Business.IdentityManager;
using FS.ERP.EF.IdentityStore;
using FS.ERP.Models.Custom;
using FS.ERP.Models.IdentityModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Cors;

namespace FS.ERP.API.Controllers
{
    [EnableCors("*", "*", "*")]
    public class ForgotPasswordController : ApiController
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

        [HttpPost]
        [Route("~/Api/User/ForgotPassword")]
        public HttpResponseMessage ForgotPassword(string userName, string url)
        {
            DataTable dt = GetUserByUsernameOrEmail(userName);
            if (dt.Rows.Count > 0)
            {
                string serializeddt = JsonConvert.SerializeObject(dt, Formatting.Indented);
                List<BOUser> user = JsonConvert.DeserializeObject<List<BOUser>>(serializeddt,
                    new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

                if (user != null && user[0] != null)
                {
                    string resetCode = Guid.NewGuid().ToString();
                    var verifyUrl = url + "/verify-user/?resetcode=" + resetCode;
                    string link = new Uri(verifyUrl).ToString();

                    string msg = "Hi " + user[0].FirstName + ' ' + user[0].LastName + "," +
                        "<br/> You recently requested to reset your password for your account. Click the link below to reset it. " +

                             " <br/><br/><a href='" + link + "'>" + link + "</a> <br/><br/>" +
                             "If you did not request a password reset, please ignore this email or reply to let us know.<br/><br/> Thank you";

                    SendResetEmailFromDataEmailProfile(resetCode, link, msg, user[0].Email);
                    //string response = SendLocationWiseEmailMessage(locData.EmailFrom, user.Email, "", msg, locData.EmailPort, locData.EmailPWD, locData.EmailReply);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Username / Email Incorrect");
                }
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "User not found!");
            }

            return Request.CreateResponse(HttpStatusCode.OK, "Email Sent Successfully", formatter);
        }

        public DataTable GetUserByUsernameOrEmail(string userNameOrEmail)
        {
            SpData data = new SpData
            {
                SpName = "[UMS].[GetUserByUsernameOrEmail]",
                Parameters = new Dictionary<string, object>
                        {
                            { "usernameOrEmail", userNameOrEmail }
                        }
            };
            var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
            return getModel;
        }
        public bool SendResetEmailFromDataEmailProfile(string resetCode, string link, string msg, string userEmail)
        {
            SpData data = new SpData
            {
                SpName = "[UMS].sendPasswordResetEmail",
                Parameters = new Dictionary<string, object> { { "userEmail", userEmail },
                { "resetPasswordCode", resetCode }, { "link", link }, { "msg", msg }
                }
            };

            new CommonRepository(ConStr).ExecStoreProcedure(data);

            return true;
        }

        [HttpPost]
        [Route("~/Api/User/ResetPassword")]
        public HttpResponseMessage ResetPassword(VM_ResetPassword model)
        {
            if (!model.Password.Equals(model.ConfirmPassword))
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Password and Confirm Password are not same");
            }

            DataTable dt = GetUserByPasswordResetCode(model.ResetCode);

            if (dt.Rows.Count > 0)
            {
                string serializeddt = JsonConvert.SerializeObject(dt, Formatting.Indented);
                List<BOUser> user = JsonConvert.DeserializeObject<List<BOUser>>(serializeddt,
                    new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

                if (user != null && user[0] != null)
                {
                    var userManager = new ApplicationUserManager(new ApplicationUserStore(FsERPContext.Create(ConStr)));
                    string hashedPassword = userManager.PasswordHasher.HashPassword(model.ConfirmPassword);

                    SpData data = new SpData
                    {
                        SpName = "[HRM].[procResetUserPassword]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "UserCode", user[0].Id },
                            { "NewPassword", model.ConfirmPassword },
                            { "NewPasswordHash", hashedPassword }
                        }
                    };

                    var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);

                    return Request.CreateResponse(HttpStatusCode.OK, "Your password has been changed Successfully", formatter);
                }
            }

            return Request.CreateResponse(HttpStatusCode.NotFound, "Link has been expired.", formatter);
        }
        public DataTable GetUserByPasswordResetCode(string resetCode)
        {
            SpData data = new SpData
            {
                SpName = "[UMS].[GetUserByResetPasswordCode]",
                Parameters = new Dictionary<string, object>
                        {
                            { "resetCode", resetCode }
                        }
            };

            var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
            return getModel;
        }
    }
    public class VM_ResetPassword
    {
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string ResetCode { get; set; }
    }
}

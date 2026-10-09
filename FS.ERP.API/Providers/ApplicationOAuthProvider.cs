using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using FS.ERP.Business.IdentityManager;
using FS.ERP.EF.IdentityStore;
using FS.ERP.Models.IdentityModel;
using FS.ERP.Models.Custom;
using FS.CAPI.BAL;
using System.Web.Http.Controllers;
using CST.CCL.Helper.Common;
using CST.CRY;
using System.Net.Http.Formatting;
using CST.CCL.Helper;
using Newtonsoft.Json;
using FS.ERP.API.Controllers;

namespace FS.ERP.API.Providers
{
    public class ApplicationOAuthProvider : OAuthAuthorizationServerProvider
    {
        public string ConStr { get; set; }
        private readonly string _publicClientId;

        public ApplicationOAuthProvider(string publicClientId)
        {
            if (publicClientId == null)
            {
                throw new ArgumentNullException("publicClientId");
            }

            _publicClientId = publicClientId;
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            //var userManager = context.OwinContext.GetUserManager<ApplicationUserManager>();
            var userManager = new ApplicationUserManager(new ApplicationUserStore(FsERPContext.Create(context.OwinContext)));

            BOUser user = await userManager.FindAsync(context.UserName, context.Password);

            if (user == null)
            {
                context.SetError("invalid_grant", "The user name or password is incorrect.");
                return;
            }
            else if (user.RecordStatusCode == 13)
            {
                context.SetError("not_found", "This User is deleted");
                return;
            }
            else if (user.IsActive == false)
            {
                context.SetError("in_active", "This User is In-Active");
                return;
            }

            ClaimsIdentity oAuthIdentity = await user.GenerateUserIdentityAsync(userManager,
               OAuthDefaults.AuthenticationType);
            ClaimsIdentity cookiesIdentity = await user.GenerateUserIdentityAsync(userManager,
                CookieAuthenticationDefaults.AuthenticationType);

            AuthenticationProperties properties = CreateProperties(user.UserName, user.Id, user.CompanyCode, user.IsGoogleAuthenticatorEnabled ?? false, user.GoogleAuthenticatorEnabledOn);

            try
            {
                var request = context.Request;
                var headers = request.Headers;
                var headerKey = "x-conn";
                // custome header
                if (headers.ContainsKey(headerKey))
                {
                    var _connStr = headers[headerKey];
                    ConStr = Encryptor.Decrypt(AppSettings.PrivateKey, _connStr);
                }
                else
                {
                    throw new UnauthorizedAccessException(
                        "You are not authorized to access this link. Please contact administrator");
                }

                var defaultMenu = GetDefaultMenu(user.Id);

                if (defaultMenu != null && defaultMenu.Count > 0 && !string.IsNullOrEmpty(defaultMenu[0].URLPathV1))
                    properties.Dictionary.Add("defaultMenuUrl", defaultMenu[0].URLPathV1);
            }
            catch (Exception ex)
            {
            }

            AuthenticationTicket ticket = new AuthenticationTicket(oAuthIdentity, properties);
            context.Validated(ticket);
            context.Request.Context.Authentication.SignIn(cookiesIdentity);
        }

        public override Task TokenEndpoint(OAuthTokenEndpointContext context)
        {
            foreach (KeyValuePair<string, string> property in context.Properties.Dictionary)
            {
                context.AdditionalResponseParameters.Add(property.Key, property.Value);
            }

            return Task.FromResult<object>(null);
        }

        public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            // Resource owner password credentials does not provide a client ID.
            if (context.ClientId == null)
            {
                context.Validated();
            }

            return Task.FromResult<object>(null);
        }

        public override Task ValidateClientRedirectUri(OAuthValidateClientRedirectUriContext context)
        {
            if (context.ClientId == _publicClientId)
            {
                Uri expectedRootUri = new Uri(context.Request.Uri, "/");

                if (expectedRootUri.AbsoluteUri == context.RedirectUri)
                {
                    context.Validated();
                }
            }

            return Task.FromResult<object>(null);
        }

        public static AuthenticationProperties CreateProperties(string userName, int userId, int companyCode, bool IsGoogleAuthenticatorEnabled, DateTime? GoogleAuthenticatorEnabledOn)
        {
            string dayStr = "";
            if (GoogleAuthenticatorEnabledOn.HasValue)
            {
                double days = (DateTime.Now.Date - GoogleAuthenticatorEnabledOn.Value.Date).TotalDays;
                if (days < 0)
                {
                    dayStr = "0";
                }
                else
                {
                    dayStr = Convert.ToInt32(days) + "";
                }
            }

            IDictionary<string, string> data = new Dictionary<string, string>
            {
                { "userName", userName },
                { "userId", userId.ToString() },
                { "IsG2FAEnabled", IsGoogleAuthenticatorEnabled.ToString() },
                { "G2FADays", dayStr },
                { "companyCode", companyCode.ToString() }
            };
            return new AuthenticationProperties(data);
        }
        public List<VM_ActionMenu> GetDefaultMenu(long userId)
        {
            SpData data = new SpData
            {
                SpName = "[UMS].getDefaultMenu",
                Parameters = new Dictionary<string, object> { { "userId", userId } }
            };
            return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<VM_ActionMenu>();
        }
    }
    public class VM_ActionMenu
    {
        public int ID { get; set; }
        public string MenuTitle { get; set; }
        public string URLPath { get; set; }
        public string URLPathV1 { get; set; }
    }
}
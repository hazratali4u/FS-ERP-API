using System;
using System.Security.Claims;
using System.Threading.Tasks;
using CST.CCL.Helper;
using CST.CCL.Helper.Common;
using CST.CRY;
using FS.ERP.EF.Db_Context;
using FS.ERP.EF.IdentityStore;
using FS.ERP.Models.IdentityModel;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;

namespace FS.ERP.Business.IdentityManager
{
    public class FsErpPasswordHash : IPasswordHasher
    {
        public string HashPassword(string password)
        {
            return Encryptor.Encrypt(AppSettings.PublicKey, password);
        }

        public PasswordVerificationResult VerifyHashedPassword(string hashedPassword, string providedPassword)
        {
            string oriPassword = Encryptor.Decrypt(AppSettings.PrivateKey, hashedPassword);
            if (oriPassword.Equals(providedPassword))
                return PasswordVerificationResult.Success;
            return PasswordVerificationResult.Failed;
        }
    }

    public class ApplicationUserManager : UserManager<BOUser, int>
    {
        public string UserId { get; set; }

        public ApplicationUserManager(IUserStore<BOUser, int> store)
            : base(store)
        {
            UserTokenProvider = new TotpSecurityStampBasedTokenProvider<BOUser, int>();
            PasswordHasher = new FsErpPasswordHash();
        }

        public static ApplicationUserManager Create(IdentityFactoryOptions<ApplicationUserManager> options, IOwinContext context)
        {
            var manager = new ApplicationUserManager(new ApplicationUserStore(FsERPContext.Create(context)));
            manager.UserValidator = new UserValidator<BOUser, int>(manager)
            {
                AllowOnlyAlphanumericUserNames = false,
                RequireUniqueEmail = true
            };

            manager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 6,
                RequireNonLetterOrDigit = false,
                RequireDigit = false,
                RequireLowercase = false,
                RequireUppercase = false,
            };

            manager.UserLockoutEnabledByDefault = true;
            manager.DefaultAccountLockoutTimeSpan = TimeSpan.FromMinutes(5);
            manager.MaxFailedAccessAttemptsBeforeLockout = 5;

            manager.PasswordHasher = new FsErpPasswordHash();
            var dataProtectionProvider = options.DataProtectionProvider;
            if (dataProtectionProvider != null)
            {
                manager.UserTokenProvider =
                    new DataProtectorTokenProvider<BOUser, int>(dataProtectionProvider.Create("FsERP Identity"));
            }
            return manager;
        }
    }

    public class ApplicationSignInManager : SignInManager<BOUser, int>
    {
        public ApplicationSignInManager(ApplicationUserManager userManager, IAuthenticationManager authenticationManager)
            : base(userManager, authenticationManager)
        {
        }

        public override Task<ClaimsIdentity> CreateUserIdentityAsync(BOUser user)
        {
            return user.GenerateUserIdentityAsync((ApplicationUserManager)UserManager);
        }

        public static ApplicationSignInManager Create(IdentityFactoryOptions<ApplicationSignInManager> options, IOwinContext context)
        {
            return new ApplicationSignInManager(context.GetUserManager<ApplicationUserManager>(), context.Authentication);
        }
    }

    public class ApplicationRoleManager : RoleManager<ApplicationRole, int>
    {
        public ApplicationRoleManager(IRoleStore<ApplicationRole, int> roleStore)
            : base(roleStore)
        {
        }

        public string UserId { get; set; }

        public static ApplicationRoleManager Create(
            IdentityFactoryOptions<ApplicationRoleManager> options, IOwinContext context)
        {
            return new ApplicationRoleManager(
                new ApplicationRoleStore(context.Get<FsERP_Context>()));
        }
    }

    public class FsERPContext
    {
        public static FsERP_Context Create(string connStr)
        {
            return new FsERP_Context(connStr);
        }

        public static FsERP_Context Create(IOwinContext context)
        {
            IHeaderDictionary headers = context.Request.Headers;

            if (headers.IsNullOrEmpty() || (!headers.IsNullOrEmpty()) && !headers.ContainsKey("x-conn"))
                throw new UnauthorizedAccessException("You are not authorized to access this link. Please contact administrator");

            string connStr = headers["x-conn"];
            connStr = Encryptor.Decrypt(AppSettings.PrivateKey, connStr);
            return new FsERP_Context(connStr);
        }
    }
}

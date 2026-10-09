using System;
using System.Data.Entity;
using FS.ERP.EF.Db_Context;
using FS.ERP.Models.IdentityModel;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace FS.ERP.EF.IdentityStore
{
    public class ApplicationUserStore : UserStore<BOUser, ApplicationRole, int, ApplicationUserLogin, ApplicationUserRole, ApplicationUserClaim>, IUserStore<BOUser, int>, IDisposable
    {
        public ApplicationUserStore(string connectionString) : this(new FsERP_Context(connectionString))
        {
            base.DisposeContext = true;
        }

        public ApplicationUserStore(DbContext context) : base(context) { }
    }
}

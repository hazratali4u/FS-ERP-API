using FS.ERP.Models;

namespace FS.ERP.TenantDal
{
    using System.Data.Entity;

    public partial class TenantContext : DbContext
    {
        public TenantContext(string connectionString) : this(connectionString, false, false) { }

        public TenantContext(string connectionString, bool lazyLoading = true, bool proxyCreation = true)
            : base(connectionString)
        {
            this.Configuration.LazyLoadingEnabled = lazyLoading;
            this.Configuration.ProxyCreationEnabled = proxyCreation;
        }


        public virtual DbSet<BOMultiTenant> BOMultiTenant { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

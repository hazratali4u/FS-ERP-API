using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class CultureConfiguration : EntityTypeConfiguration<BOCulture>
    {
        public CultureConfiguration()
        {
            this.HasMany(e => e.BOPartyOrCustomer)
            .WithOptional(e => e.BOCulture)
            .HasForeignKey(e => e.DefaultCultureCode);

            this.HasMany(e => e.BOVendorOrSupplier)
            .WithOptional(e => e.BOCulture)
            .HasForeignKey(e => e.DefaultCultureCode);
        }
    }
}

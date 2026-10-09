using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class LeaseTypeConfiguration : EntityTypeConfiguration<BOLeaseType>
    {
        public LeaseTypeConfiguration()
        {
               this.HasMany(e => e.BOEmployeeLease)
               .WithRequired(e => e.BOLeaseType)
               .HasForeignKey(e => e.LeaseTypeCode)
               .WillCascadeOnDelete(false);
        }
    }
}

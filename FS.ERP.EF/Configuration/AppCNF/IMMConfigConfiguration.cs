using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class IMMConfigConfiguration : EntityTypeConfiguration<BOIMMConfiguration>
    {
        public IMMConfigConfiguration()
        {
               this.HasMany(e => e.BOIMMConfiguration1)
               .WithOptional(e => e.BOIMMConfiguration2)
               .HasForeignKey(e => e.ParentCode);

                this.HasMany(e => e.BOItemCategory)
                .WithRequired(e => e.BOIMMConfiguration)
                .HasForeignKey(e => e.IMMConfigurationCode)
                .WillCascadeOnDelete(false);
        }
    }
}

using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class COAConfigConfiguration : EntityTypeConfiguration<BOCOAConfiguration>
    {
        public COAConfigConfiguration()
        {
                this.HasMany(e => e.BOCOA)
                .WithOptional(e => e.BOCOAConfiguration)
                .HasForeignKey(e => e.COAConfigurationCode);

            this.HasMany(e => e.BOCOAConfiguration1)
                .WithOptional(e => e.BOCOAConfiguration2)
                .HasForeignKey(e => e.ParentCode);

            this.HasMany(e => e.BOCOAMapping)
                .WithOptional(e => e.BOCOAConfiguration)
                .HasForeignKey(e => e.COAConfigurationCode);
        }
    }
}

using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class SectorZoneConfiguration : EntityTypeConfiguration<BOSectorZone>
    {
        public SectorZoneConfiguration()
        {
               this.HasMany(e => e.BOCountryRegion)
               .WithRequired(e => e.BOSectorZone)
               .HasForeignKey(e => e.SectorZoneCode)
               .WillCascadeOnDelete(false);
        }
    }
}

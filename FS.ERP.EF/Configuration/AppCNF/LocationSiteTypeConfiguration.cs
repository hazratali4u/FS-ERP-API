using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class LocationSiteTypeConfiguration : EntityTypeConfiguration<BOLocationSiteType>
    {
        public LocationSiteTypeConfiguration()
        {
                this.HasMany(e => e.BOLocationSite)
                .WithRequired(e => e.BOLocationSiteType)
                .HasForeignKey(e => e.LocationSiteTypeCode)
                .WillCascadeOnDelete(false);
        }
    }
}

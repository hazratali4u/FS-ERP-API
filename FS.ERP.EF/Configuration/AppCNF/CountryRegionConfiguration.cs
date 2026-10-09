using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class CountryRegionConfiguration : EntityTypeConfiguration<BOCountryRegion>
    {
        public CountryRegionConfiguration()
        {
             this.HasMany(e => e.BOCityTown)
             .WithRequired(e => e.BOCountryRegion)
             .HasForeignKey(e => e.CountryRegionCode)
             .WillCascadeOnDelete(false);

                this.HasMany(e => e.BOStateProvince)
                .WithRequired(e => e.BOCountryRegion)
                .HasForeignKey(e => e.CountryRegionCode)
                .WillCascadeOnDelete(false);
        }
    }
}

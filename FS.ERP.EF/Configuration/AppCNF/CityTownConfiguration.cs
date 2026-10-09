using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class CityTownConfiguration : EntityTypeConfiguration<BOCityTown>
    {
        public CityTownConfiguration()
        {
               this.HasMany(e => e.BOPartyOrCustomer)
               .WithOptional(e => e.BOCityTown)
               .HasForeignKey(e => e.CityTownCode);

            this.HasMany(e => e.BODistrictWard)
                .WithRequired(e => e.BOCityTown)
                .HasForeignKey(e => e.CityTownCode)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOEmployeeInfo)
                .WithRequired(e => e.BOCityTown)
                .HasForeignKey(e => e.CityTownCode)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOEmployeeInfoRevision)
                .WithRequired(e => e.BOCityTown)
                .HasForeignKey(e => e.CityTownCode)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOVendorOrSupplier)
                .WithOptional(e => e.BOCityTown)
                .HasForeignKey(e => e.CityTownCode);

        this.HasMany(e => e.BOFieldExpensePolicyDetail)
        .WithRequired(e => e.BOCityTown)
        .HasForeignKey(e => e.CityCode)
        .WillCascadeOnDelete(false);
        }
    }
}

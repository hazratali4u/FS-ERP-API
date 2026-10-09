using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class DistrictWardConfiguration : EntityTypeConfiguration<BODistrictWard>
    {
        public DistrictWardConfiguration()
        {
               this.HasMany(e => e.BOPartyOrCustomer)
               .WithOptional(e => e.BODistrictWard)
               .HasForeignKey(e => e.DistrictWardCode);

            this.HasMany(e => e.BOAreaOfDistrictWard)
                .WithOptional(e => e.BODistrictWard)
                .HasForeignKey(e => e.DistrictWardCode);

            this.HasMany(e => e.BOEmployeeInfo)
                .WithOptional(e => e.BODistrictWard)
                .HasForeignKey(e => e.DistrictWardCode);

            this.HasMany(e => e.BOEmployeeInfoRevision)
                .WithOptional(e => e.BODistrictWard)
                .HasForeignKey(e => e.DistrictWardCode);

                this.HasMany(e => e.BOVendorOrSupplier)
                .WithOptional(e => e.BODistrictWard)
                .HasForeignKey(e => e.DistrictWardCode);
        }
    }
}

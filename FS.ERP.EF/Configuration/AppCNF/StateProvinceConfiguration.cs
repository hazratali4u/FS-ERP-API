using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class StateProvinceConfiguration : EntityTypeConfiguration<BOStateProvince>
    {
        public StateProvinceConfiguration()
        {
             this.HasMany(e => e.BOIMMTaxGroup)
             .WithOptional(e => e.BOStateProvince)
             .HasForeignKey(e => e.StateProvinceCode);

            this.HasMany(e => e.BOIMMTaxGroupDetail)
                .WithOptional(e => e.BOStateProvince)
                .HasForeignKey(e => e.StateProvinceCode);

            this.HasMany(e => e.BOCityTown)
                .WithOptional(e => e.BOStateProvince)
                .HasForeignKey(e => e.StateProvinceCode);
        }
    }
}

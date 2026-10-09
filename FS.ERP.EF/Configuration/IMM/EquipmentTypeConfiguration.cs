using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class EquipmentTypeConfiguration : EntityTypeConfiguration<BOEquipmentType>
    {
        public EquipmentTypeConfiguration()
        {
            this.HasMany(e => e.BOEquipment)
            .WithRequired(e => e.BOEquipmentType)
            .HasForeignKey(e => e.EquipmentTypeCode)
            .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOVendorOrSupplierWiseItem)
            .WithRequired(e => e.BOEquipmentType)
            .HasForeignKey(e => e.EquipmentTypeCode)
            .WillCascadeOnDelete(false);

              this.HasMany(e => e.BOSeparationChecklistSetup)
              .WithRequired(e => e.BOEquipmentType)
              .HasForeignKey(e => e.AssetCategoryCode)
              .WillCascadeOnDelete(false);
        }
    }
}

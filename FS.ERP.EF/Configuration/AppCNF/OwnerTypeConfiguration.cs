using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class OwnerTypeConfiguration : EntityTypeConfiguration<BOOnwerShipType>
    {
        public OwnerTypeConfiguration()
        {
               this.HasMany(e => e.BOEquipment)
               .WithRequired(e => e.BOOnwerShipType)
               .HasForeignKey(e => e.OwnershipTypeCode)
               .WillCascadeOnDelete(false);

                this.HasMany(e => e.BOItem)
                .WithOptional(e => e.BOOnwerShipType)
                .HasForeignKey(e => e.OnwerShipTypeCode);
        }
    }
}

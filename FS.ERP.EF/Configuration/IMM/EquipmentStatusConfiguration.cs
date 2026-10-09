using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class EquipmentStatusConfiguration : EntityTypeConfiguration<BOEquipmentStatus>
    {
        public EquipmentStatusConfiguration()
        {
               this.HasMany(e => e.BOEquipment)
               .WithRequired(e => e.BOEquipmentStatus)
               .HasForeignKey(e => e.EquipmentStatusCode)
               .WillCascadeOnDelete(false);
        }
    }
}

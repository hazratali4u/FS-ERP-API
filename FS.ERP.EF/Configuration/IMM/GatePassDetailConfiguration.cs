using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class GatePassDetailConfiguration : EntityTypeConfiguration<BOGatePassDetail>
    {
        public GatePassDetailConfiguration()
        {
               this.HasMany(e => e.BOGatePassDetail1)
               .WithRequired(e => e.BOGatePassDetail2)
               .HasForeignKey(e => e.GatePassDetailCode)
               .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOGRNandReturnDetail)
               .WithOptional(e => e.BOGatePassDetail)
               .HasForeignKey(e => e.GatePassDetailCode)
               .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOGRNandReturnCheckList)
               .WithRequired(e => e.BOGatePassDetail)
               .HasForeignKey(e => e.GatePassDetailCode)
               .WillCascadeOnDelete(false);
        }
    }
}

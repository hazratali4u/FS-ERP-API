using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class GatePassConfiguration : EntityTypeConfiguration<BOGatePass>
    {
        public GatePassConfiguration()
        {
               this.HasMany(e => e.BOGatePass1)
               .WithRequired(e => e.BOGatePass2)
               .HasForeignKey(e => e.GatePassCode)
               .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOGatePassDetail)
               .WithRequired(e => e.BOGatePass)
               .HasForeignKey(e => e.GatePassCode)
               .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOGRNandReturn)
               .WithOptional(e => e.BOGatePass)
               .HasForeignKey(e => e.GatePassCode)
               .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOGRNandReturnCheckList)
               .WithRequired(e => e.BOGatePass)
               .HasForeignKey(e => e.GatePassCode)
               .WillCascadeOnDelete(false);
        }
    }
}

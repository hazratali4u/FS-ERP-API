using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class BankConfiguration : EntityTypeConfiguration<BOBank>
    {
        public BankConfiguration()
        {
                  this.HasMany(e => e.BOBankBranch)
                  .WithRequired(e => e.BOBank)
                  .HasForeignKey(e => e.BankCode)
                  .WillCascadeOnDelete(false);
        }
    }
}

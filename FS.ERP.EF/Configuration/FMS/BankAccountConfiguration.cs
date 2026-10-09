using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class BankAccountConfiguration : EntityTypeConfiguration<BOBankAccount>
    {
        public BankAccountConfiguration()
        {
               this.HasMany(e => e.BOBankAccountInstrumentInfo)
               .WithRequired(e => e.BOBankAccount)
               .HasForeignKey(e => e.BankAccountCode)
               .WillCascadeOnDelete(false);
        }
    }
}

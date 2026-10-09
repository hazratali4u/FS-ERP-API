using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class BankAccountInstrumentInfoConfiguration : EntityTypeConfiguration<BOBankAccountInstrumentInfo>
    {
        public BankAccountInstrumentInfoConfiguration()
        {
          this.HasMany(e => e.BOVendorPayment)
          .WithOptional(e => e.BOBankAccountInstrumentInfo)
          .HasForeignKey(e => e.ChequeCode)
          .WillCascadeOnDelete(false);
        }
    }
}

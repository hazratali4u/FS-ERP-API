using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class InstrumentStatusConfiguration : EntityTypeConfiguration<BOInstrumentStatus>
    {
        public InstrumentStatusConfiguration()
        {
             this.HasMany(e => e.BOBankAccountInstrumentInfo)
             .WithRequired(e => e.BOInstrumentStatus)
             .HasForeignKey(e => e.InstrumentStatusCode)
             .WillCascadeOnDelete(false);

            this.HasMany(e => e.BORemittanceAdviceDetail)
                .WithOptional(e => e.BOInstrumentStatus)
                .HasForeignKey(e => e.InstrumentStatusCode);

            this.HasMany(e => e.BOTransactionDetail)
                .WithOptional(e => e.BOInstrumentStatus)
                .HasForeignKey(e => e.InstrumentStatusCode);
        }
    }
}

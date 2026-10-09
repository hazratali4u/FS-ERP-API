using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class InstrumentTypeConfiguration : EntityTypeConfiguration<BOInstrumentType>
    {
        public InstrumentTypeConfiguration()
        {
                this.HasMany(e => e.BOBankAccountInstrumentInfo)
                .WithOptional(e => e.BOInstrumentType)
                .HasForeignKey(e => e.InstrumentTypeCode);
        }
    }
}

using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class FiscalYearMonthConfiguration : EntityTypeConfiguration<BOFiscalYearMonth>
    {
        public FiscalYearMonthConfiguration()
        {
                this.HasMany(e => e.BOFiscalYearMonthDetail)
                .WithRequired(e => e.BOFiscalYearMonth)
                .HasForeignKey(e => e.FiscalYearMonthCode)
                .WillCascadeOnDelete(false);
        }
    }
}

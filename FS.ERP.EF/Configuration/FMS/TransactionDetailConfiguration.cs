using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class TransactionDetailConfiguration : EntityTypeConfiguration<BOTransactionDetail>
    {
        public TransactionDetailConfiguration()
        {
              this.Property(e => e.DrAmount)
              .HasPrecision(18, 7);

            this.Property(e => e.CrAmount)
                .HasPrecision(18, 7);

            this.Property(e => e.ExchangeRate)
                .HasPrecision(18, 7);

            this.Property(e => e.ExchangeRateForMultiCurrency)
                .HasPrecision(18, 7);
        }
    }
}

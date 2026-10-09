using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class BillOrInvoiceMasterDetailConfiguration : EntityTypeConfiguration<BOBillOrInvoiceMasterDetail>
    {
        public BillOrInvoiceMasterDetailConfiguration()
        {
           this
                .Property(e => e.SalePrice)
                .HasPrecision(18, 7);

           this
                .Property(e => e.RetailPrice)
                .HasPrecision(18, 7);

           this
                .Property(e => e.PrvBalanceAmount)
                .HasPrecision(18, 7);

           this
                .Property(e => e.Qty)
                .HasPrecision(18, 7);

           this
                .Property(e => e.SaleAmount)
                .HasPrecision(18, 7);

           this
                .Property(e => e.RetailAmount)
                .HasPrecision(18, 7);

           this
                .Property(e => e.GSTRate)
                .HasPrecision(18, 7);

           this
                .Property(e => e.GSTAmount)
                .HasPrecision(18, 7);

           this
                .Property(e => e.FEDRate)
                .HasPrecision(18, 7);

           this
                .Property(e => e.FEDAmount)
                .HasPrecision(18, 7);

           this
                .Property(e => e.FTRate)
                .HasPrecision(18, 7);

           this
                .Property(e => e.FTAmount)
                .HasPrecision(18, 7);

           this
                .Property(e => e.ExchangeRate)
                .HasPrecision(18, 7);

           this
                .Property(e => e.ExchangeRateForMultiCurrency)
                .HasPrecision(18, 7);

           this
                .HasMany(e => e.BORemittanceAdviceDetail)
                .WithRequired(e => e.BOBillOrInvoiceMasterDetail)
                .HasForeignKey(e => e.BillOrInvoiceMasterDetailCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOTransactionDetail)
                .WithOptional(e => e.BOBillOrInvoiceMasterDetail)
                .HasForeignKey(e => e.BillOrInvoiceDetailCode);
        }
    }
}

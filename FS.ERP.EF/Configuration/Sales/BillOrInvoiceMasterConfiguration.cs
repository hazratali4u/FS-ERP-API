using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class BillOrInvoiceMasterConfiguration : EntityTypeConfiguration<BOBillOrInvoiceMaster>
    {
        public BillOrInvoiceMasterConfiguration()
        {
           this
                .Property(e => e.ExchangeRate)
                .HasPrecision(18, 7);

           this
                .Property(e => e.ProfitShare)
                .HasPrecision(18, 7);

           this
                .Property(e => e.DiscountAmount)
                .HasPrecision(18, 7);

           this
                .Property(e => e.GSTAmount)
                .HasPrecision(18, 7);

           this
                .Property(e => e.FEDAmount)
                .HasPrecision(18, 7);

           this
                .Property(e => e.FTAmount)
                .HasPrecision(18, 7);

           this
                .Property(e => e.BillOrInvoiceAmount)
                .HasPrecision(18, 7);

           this
                .HasMany(e => e.BOBillOrInvoiceMasterDetail)
                .WithRequired(e => e.BOBillOrInvoiceMaster)
                .HasForeignKey(e => e.BillOrInvoiceMasterCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BORemittanceAdviceDetail)
                .WithRequired(e => e.BOBillOrInvoiceMaster)
                .HasForeignKey(e => e.BillOrInvoiceMasterCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOTransactionDetail)
                .WithOptional(e => e.BOBillOrInvoiceMaster)
                .HasForeignKey(e => e.BillOrInvoiceCode);
        }
    }
}

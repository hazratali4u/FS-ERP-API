using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class PaymentModeConfiguration : EntityTypeConfiguration<BOPaymentMode>
    {
        public PaymentModeConfiguration()
        {
           this
              .HasMany(e => e.BOGRNandReturn)
              .WithOptional(e => e.BOPaymentMode)
              .HasForeignKey(e => e.PaymentModeCode)
              .WillCascadeOnDelete(false);

           this
               .HasMany(e => e.BOGRNandReturnDetail)
               .WithOptional(e => e.BOPaymentMode)
               .HasForeignKey(e => e.PaymentModeCode)
               .WillCascadeOnDelete(false);

           this
               .HasMany(e => e.BOPurchaseOrderAndReturnDetail)
               .WithRequired(e => e.BOPaymentMode)
               .HasForeignKey(e => e.PaymentModeCode)
               .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOCustomerReceipt)
            .WithOptional(e => e.BOPaymentMode)
            .HasForeignKey(e => e.PaymentMode)
            .WillCascadeOnDelete(false);

        }
    }
}

using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class VendorAdjustmentConfiguration : EntityTypeConfiguration<BOVendorAdjustment>
    {
        public VendorAdjustmentConfiguration()
        {
           this
           .HasMany(e => e.BOCommissionBooking)
           .WithOptional(e => e.BOVendorAdjustment)
           .HasForeignKey(e => e.AdjustmentCode)
           .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOPurchaseInvoiceMaster)
            .WithOptional(e => e.BOVendorAdjustment)
            .HasForeignKey(e => e.AdjustmentCode)
            .WillCascadeOnDelete(false);

           this
           .HasMany(e => e.BOVendorAdjustmentInvoiceMapping)
           .WithRequired(e => e.BOVendorAdjustment)
           .HasForeignKey(e => e.VendorAdjustmentCode)
           .WillCascadeOnDelete(false);
        }
    }
}

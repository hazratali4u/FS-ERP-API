using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class PurchaseInvoiceMasterConfiguration : EntityTypeConfiguration<BOPurchaseInvoiceMaster>
    {
        public PurchaseInvoiceMasterConfiguration()
        {
         this.HasMany(e => e.BOPurchaseInvoiceDetail)
         .WithOptional(e => e.BOPurchaseInvoiceMaster)
         .HasForeignKey(e => e.PurchaseInvoiceCode)
         .WillCascadeOnDelete(false);
        }
    }
}

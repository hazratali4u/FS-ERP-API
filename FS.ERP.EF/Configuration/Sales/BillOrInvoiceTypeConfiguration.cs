using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class BillOrInvoiceTypeConfiguration : EntityTypeConfiguration<BOBillOrInvoiceType>
    {
        public BillOrInvoiceTypeConfiguration()
        {
           this.HasMany(e => e.BOBillOrInvoiceMaster)
           .WithOptional(e => e.BOBillOrInvoiceType)
           .HasForeignKey(e => e.BillorInvoiceTypeCode);
        }
    }
}

using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class HoldBillOrInvoiceMasterConfiguration : EntityTypeConfiguration<BOHoldBillOrInvoiceMaster>
    {
        public HoldBillOrInvoiceMasterConfiguration()
        {
              this.HasMany(e => e.BOHoldBillOrInvoiceMasterDetail)
              .WithRequired(e => e.BOHoldBillOrInvoiceMaster)
              .HasForeignKey(e => e.BillOrInvoiceMasterCode)
              .WillCascadeOnDelete(false);
        }
    }
}

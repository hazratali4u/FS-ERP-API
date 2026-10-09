using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class CustomerAdjustmentConfiguration : EntityTypeConfiguration<BOCustomerAdjustment>
    {
        public CustomerAdjustmentConfiguration()
        {
           this.HasMany(e => e.BOBillOrInvoiceMaster)
           .WithOptional(e => e.BOCustomerAdjustment)
           .HasForeignKey(e => e.AdjustmentCode)
           .WillCascadeOnDelete(false);
        }
    }
}

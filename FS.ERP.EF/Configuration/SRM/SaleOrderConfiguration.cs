using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class SaleOrderConfiguration : EntityTypeConfiguration<BOSaleOrderMaster>
    {
        public SaleOrderConfiguration()
        {
            this.HasMany(e => e.BOBillOrInvoiceMaster)
            .WithOptional(e => e.BOSaleOrderMaster)
            .HasForeignKey(e => e.SaleOrderCode)
            .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOSaleOrderDetail)
            .WithRequired(e => e.BOSaleOrderMaster)
            .HasForeignKey(e => e.SaleOrderCode)
            .WillCascadeOnDelete(false);

            this.HasMany(e => e.BODeliveryNoteMaster)
            .WithOptional(e => e.BOSaleOrderMaster)
            .HasForeignKey(e => e.SaleOrderCode)
            .WillCascadeOnDelete(false);
        }
    }
}

using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class ItemPriceConfiguration : EntityTypeConfiguration<BOItemPrice>
    {
        public ItemPriceConfiguration()
        {
                this.HasMany(e => e.BOStockRequisitionOrIssuanceDetail)
                .WithRequired(e => e.BOItemPrice)
                .HasForeignKey(e => e.ItemPriceCode)
                .WillCascadeOnDelete(false);

               this.HasMany(e => e.BOGRNandReturnDetail)
               .WithOptional(e => e.BOItemPrice)
               .HasForeignKey(e => e.ItemPriceCode)
               .WillCascadeOnDelete(false);

               this.HasMany(e => e.BOReceipeMaster)
               .WithRequired(e => e.BOItemPrice)
               .HasForeignKey(e => e.ItemProfileCode)
               .WillCascadeOnDelete(false);
        }
    }
}

using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class ItemDealConfiguration : EntityTypeConfiguration<BOItemDeal>
    {
        public ItemDealConfiguration()
        {
               this.HasMany(e => e.BOItemDealAssignment)
               .WithRequired(e => e.BOItemDeal)
               .HasForeignKey(e => e.ItemDealCode)
               .WillCascadeOnDelete(false);

               this.HasMany(e => e.BOItemDealDetail)
               .WithRequired(e => e.BOItemDeal)
               .HasForeignKey(e => e.ItemDealCode)
               .WillCascadeOnDelete(false);
        }
    }
}

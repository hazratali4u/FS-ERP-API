using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class ItemCategoryConfiguration : EntityTypeConfiguration<BOItemCategory>
    {
        public ItemCategoryConfiguration()
        {
                this.HasMany(e => e.BOItem)
                .WithRequired(e => e.BOItemCategory)
                .HasForeignKey(e => e.ItemCategoryCode)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOItemCategory1)
                .WithOptional(e => e.BOItemCategory2)
                .HasForeignKey(e => e.ParentCode);

            this.HasMany(e => e.BOItemCategoryAttributeAspect)
                .WithRequired(e => e.BOItemCategory)
                .HasForeignKey(e => e.ItemCategoryCode)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOItemCategoryAttributeAspectDetail)
                .WithRequired(e => e.BOItemCategory)
                .HasForeignKey(e => e.ItemCategoryCode)
                .WillCascadeOnDelete(false);
        }
    }
}

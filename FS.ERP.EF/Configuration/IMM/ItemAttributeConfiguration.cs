using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class ItemAttributeConfiguration : EntityTypeConfiguration<BOItemAttribute>
    {
        public ItemAttributeConfiguration()
        {
                this.HasMany(e => e.BOItemAttributeAspect)
                .WithOptional(e => e.BOItemAttribute)
                .HasForeignKey(e => e.ItemAttributeCode);

            this.HasMany(e => e.BOItemAttributeDetail)
                .WithRequired(e => e.BOItemAttribute)
                .HasForeignKey(e => e.ItemAttributeCode)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOItemCategoryAttributeAspect)
                .WithOptional(e => e.BOItemAttribute)
                .HasForeignKey(e => e.ItemAttributeCode);
        }
    }
}

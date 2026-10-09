using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class ItemCategoryAttributeAspectConfiguration : EntityTypeConfiguration<BOItemCategoryAttributeAspect>
    {
        public ItemCategoryAttributeAspectConfiguration()
        {
             this.HasMany(e => e.BOItemCategoryAttributeAspectDetail)
             .WithRequired(e => e.BOItemCategoryAttributeAspect)
             .HasForeignKey(e => e.ItemCategoryAttributeAspectCode)
             .WillCascadeOnDelete(false);
        }
    }
}

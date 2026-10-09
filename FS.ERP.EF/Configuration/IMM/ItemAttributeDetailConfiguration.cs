using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class ItemAttributeDetailConfiguration : EntityTypeConfiguration<BOItemAttributeDetail>
    {
        public ItemAttributeDetailConfiguration()
        {
            this.HasMany(e => e.BOItemAttributeAspectDetail)
            .WithOptional(e => e.BOItemAttributeDetail)
            .HasForeignKey(e => e.ItemAttributeDetailCode);

            this.HasMany(e => e.BOItemCategoryAttributeAspectDetail)
                .WithOptional(e => e.BOItemAttributeDetail)
                .HasForeignKey(e => e.ItemAttributeDetailCode);
        }
    }
}

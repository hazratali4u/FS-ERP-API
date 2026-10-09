using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class ItemModifierConfiguration : EntityTypeConfiguration<BOItemModifier>
    {
        public ItemModifierConfiguration()
        {
                 this.HasMany(e => e.BOItemDealDetail)
                 .WithRequired(e => e.BOItemModifier)
                 .HasForeignKey(e => e.ItemModifierCode)
                 .WillCascadeOnDelete(false);
        }
    }
}

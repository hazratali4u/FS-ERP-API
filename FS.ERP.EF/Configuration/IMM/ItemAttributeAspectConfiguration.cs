using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class ItemAttributeAspectConfiguration : EntityTypeConfiguration<BOItemAttributeAspect>
    {
        public ItemAttributeAspectConfiguration()
        {
                this.HasMany(e => e.BOItemAttributeAspectDetail)
                .WithRequired(e => e.BOItemAttributeAspect)
                .HasForeignKey(e => e.ItemAttributeAspectCode)
                .WillCascadeOnDelete(false);
        }
    }
}

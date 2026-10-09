using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class FlavorConfiguration : EntityTypeConfiguration<BOFlavor>
    {
        public FlavorConfiguration()
        {
            this.HasMany(e => e.BOFlavorDetail)
            .WithRequired(e => e.BOFlavor)
            .HasForeignKey(e => e.FlavorCode)
            .WillCascadeOnDelete(false);
        }
    }
}

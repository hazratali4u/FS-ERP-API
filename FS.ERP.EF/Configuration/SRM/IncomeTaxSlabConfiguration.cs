using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class IncomeTaxSlabConfiguration : EntityTypeConfiguration<BOIncomeTaxSlab>
    {
        public IncomeTaxSlabConfiguration()
        {
              this.HasMany(e => e.BOIncomeTaxSlabDetail)
              .WithRequired(e => e.BOIncomeTaxSlab)
              .HasForeignKey(e => e.TaxSlabCode)
              .WillCascadeOnDelete(false);
        }
    }
}

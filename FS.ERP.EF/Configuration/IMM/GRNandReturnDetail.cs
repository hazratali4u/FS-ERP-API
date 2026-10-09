using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class GRNandReturnDetail : EntityTypeConfiguration<BOGRNandReturnDetail>
    {
        public GRNandReturnDetail()
        {
          this.HasMany(e => e.BOGRNandReturnDetail1)
          .WithOptional(e => e.BOGRNandReturnDetail2)
          .HasForeignKey(e => e.GRNandReturnDetailCode)
          .WillCascadeOnDelete(false);

               this.HasMany(e => e.BOPurchaseOrderAndReturnDetail1)
               .WithRequired(e => e.BOGRNandReturnDetail1)
               .HasForeignKey(e => e.GRNandReturnDetailCode)
               .WillCascadeOnDelete(false);
        }
    }
}

using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class PurchaseOrderAndReturnDetailConfiguration : EntityTypeConfiguration<BOPurchaseOrderAndReturnDetail>
    {
        public PurchaseOrderAndReturnDetailConfiguration()
        {
                this.HasMany(e => e.BOGRNandReturnDetail)
                .WithOptional(e => e.BOPurchaseOrderAndReturnDetail)
                .HasForeignKey(e => e.POandReturnDetailCode)
                .WillCascadeOnDelete(false);

              this.HasMany(e => e.BOGRNandReturnCheckList)
              .WithRequired(e => e.BOPurchaseOrderAndReturnDetail)
              .HasForeignKey(e => e.POandReturnDetailCode)
              .WillCascadeOnDelete(false);
        }
    }
}

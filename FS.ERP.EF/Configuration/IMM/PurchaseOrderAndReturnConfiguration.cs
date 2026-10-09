using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class PurchaseOrderAndReturnConfiguration : EntityTypeConfiguration<BOPurchaseOrderAndReturn>
    {
        public PurchaseOrderAndReturnConfiguration()
        {
               this.HasMany(e => e.BOPurchaseOrderAndReturnDetail)
               .WithRequired(e => e.BOPurchaseOrderAndReturn)
               .HasForeignKey(e => e.POandReturnCode)
               .WillCascadeOnDelete(false);
        }
    }
}

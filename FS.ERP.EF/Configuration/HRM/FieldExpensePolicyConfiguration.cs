using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class FieldExpensePolicyConfiguration : EntityTypeConfiguration<BOFieldExpensePolicy>
    {
        public FieldExpensePolicyConfiguration()
        {
             this.HasMany(e => e.BOFieldExpensePolicyDetail)
             .WithRequired(e => e.BOFieldExpensePolicy)
             .HasForeignKey(e => e.PolicyCode)
             .WillCascadeOnDelete(false);
        }
    }
}

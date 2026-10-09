using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class SalaryBreakUpPolicyConfiguration : EntityTypeConfiguration<BOSalaryBreakUpPolicy>
    {
        public SalaryBreakUpPolicyConfiguration()
        {
               this.HasMany(e => e.BOSalaryBreakUpPolicyDetail)
               .WithRequired(e => e.BOSalaryBreakUpPolicy)
               .HasForeignKey(e => e.SalaryBreakUpPolicyCode)
               .WillCascadeOnDelete(false);
        }
    }
}

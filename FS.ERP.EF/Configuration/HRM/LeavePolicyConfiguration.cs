using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class LeavePolicyConfiguration : EntityTypeConfiguration<BOLeavePolicy>
    {
        public LeavePolicyConfiguration()
        {
                this.HasMany(e => e.BOEmployeeInfo)
                .WithOptional(e => e.BOLeavePolicy)
                .HasForeignKey(e => e.LeavePolicyCode);

            this.HasMany(e => e.BOEmployeeHistory)
                .WithOptional(e => e.BOLeavePolicy)
                .HasForeignKey(e => e.LeavePolicyCode);

            this.HasMany(e => e.BOEmployeeLeave)
                .WithOptional(e => e.BOLeavePolicy)
                .HasForeignKey(e => e.LeavePolicyCode);

            this.HasMany(e => e.BOEmployeeSalary)
                .WithOptional(e => e.BOLeavePolicy)
                .HasForeignKey(e => e.LeavePolicyCode);

            this.HasMany(e => e.BOLeaveDeductionAgainstLate)
                .WithOptional(e => e.BOLeavePolicy)
                .HasForeignKey(e => e.LeavePolicyCode);

            this.HasMany(e => e.BOLeavePolicyDetail)
                .WithRequired(e => e.BOLeavePolicy)
                .HasForeignKey(e => e.LeavePolicyCode)
                .WillCascadeOnDelete(false);
        }
    }
}

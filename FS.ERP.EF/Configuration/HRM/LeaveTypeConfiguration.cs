using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class LeaveTypeConfiguration : EntityTypeConfiguration<BOLeaveType>
    {
        public LeaveTypeConfiguration()
        {
            this.HasMany(e => e.BOEmployeeLeave)
            .WithRequired(e => e.BOLeaveType)
            .HasForeignKey(e => e.LeaveTypeCode);

            this.HasMany(e => e.BOEmployeeLeaveBalance)
                .WithOptional(e => e.BOLeaveType)
                .HasForeignKey(e => e.LeaveTypeCode);

            this.HasMany(e => e.BOLeaveDeductionAgainstLate)
                .WithOptional(e => e.BOLeaveType)
                .HasForeignKey(e => e.LeaveTypeCode);

            this.HasMany(e => e.BOLeavePolicyDetail)
                .WithRequired(e => e.BOLeaveType)
                .HasForeignKey(e => e.LeaveTypeCode)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOLeaveYearEndProcess)
           .WithRequired(e => e.BOLeaveType)
           .HasForeignKey(e => e.LeaveTypeCode)
           .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOLeaveEncashmentProcess)
           .WithRequired(e => e.BOLeaveType)
           .HasForeignKey(e => e.LeaveTypeCode)
           .WillCascadeOnDelete(false);
        }
    }
}

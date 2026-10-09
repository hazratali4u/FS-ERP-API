using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class ShiftConfiguration : EntityTypeConfiguration<BOShift>
    {
        public ShiftConfiguration()
        {
            this
              .HasMany(e => e.BOAttendanceDiscrepancy)
              .WithRequired(e => e.BOShift)
              .HasForeignKey(e => e.ShiftCode)
              .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOEmployeeAttendance)
                .WithRequired(e => e.BOShift)
                .HasForeignKey(e => e.ShiftCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOEmployeeInfo)
                .WithRequired(e => e.BOShift)
                .HasForeignKey(e => e.ShiftCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOEmployeeSalary)
                .WithRequired(e => e.BOShift)
                .HasForeignKey(e => e.ShiftCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOLeaveDeductionAgainstLate)
                .WithRequired(e => e.BOShift)
                .HasForeignKey(e => e.ShiftCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOShiftDay)
                .WithRequired(e => e.BOShift)
                .HasForeignKey(e => e.ShiftCode)
                .WillCascadeOnDelete(false);

            this
             .HasMany(e => e.BOShiftOverTimeCriteria)
             .WithRequired(e => e.BOShift)
             .HasForeignKey(e => e.ShiftCode)
             .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOEmployeeHistory)
               .WithRequired(e => e.BOShift)
               .HasForeignKey(e => e.ShiftCode)
               .WillCascadeOnDelete(false);

            this
             .HasMany(e => e.BODutyRoster)
             .WithRequired(e => e.BOShift)
             .HasForeignKey(e => e.ShiftCode)
             .WillCascadeOnDelete(false);
        }
    }
}

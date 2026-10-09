using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class AttendanceMachineTypeConfiguration : EntityTypeConfiguration<BOAttendanceMachineType>
    {
        public AttendanceMachineTypeConfiguration()
        {
            this.HasMany(e => e.BOAttendanceDiscrepancy)
            .WithOptional(e => e.BOAttendanceMachineType)
            .HasForeignKey(e => e.AttendanceMachineCode);


            this.HasMany(e => e.BOEmployeeAttendance)
            .WithOptional(e => e.BOAttendanceMachineType)
            .HasForeignKey(e => e.AttendanceMachineCode);
        }
    }
}

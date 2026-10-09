using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class OvertimeTypeConfiguration : EntityTypeConfiguration<BOOverTimeType>
    {
        public OvertimeTypeConfiguration()
        {
             this.HasMany(e => e.BOShiftOverTimeCriteria)
             .WithRequired(e => e.BOOverTimeType)
             .HasForeignKey(e => e.DayTypeCode)
             .WillCascadeOnDelete(false);

           this.HasMany(e => e.BOEmployeeOvertimeProcess)
           .WithOptional(e => e.BOOverTimeType)
           .HasForeignKey(e => e.OverTimeTypeCode)
           .WillCascadeOnDelete(false);
        }
    }
}

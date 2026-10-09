using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class CalendarConfiguration : EntityTypeConfiguration<BOCalendar>
    {
        public CalendarConfiguration()
        {
              this.HasMany(e => e.BOEmployeeAttendance)
              .WithRequired(e => e.BOCalendar)
              .HasForeignKey(e => e.CalendarCode)
              .WillCascadeOnDelete(false);
        }
    }
}

using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class PerformanceGoalConfiguration : EntityTypeConfiguration<BOPerformanceGoal>
    {
        public PerformanceGoalConfiguration()
        {
             this.HasMany(e => e.BOEmployeeGoalAssignment)
             .WithRequired(e => e.BOPerformanceGoal)
             .HasForeignKey(e => e.GoalCode)
             .WillCascadeOnDelete(false);
        }
    }
}

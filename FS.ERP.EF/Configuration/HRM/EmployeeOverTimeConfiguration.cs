using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class EmployeeOverTimeConfiguration : EntityTypeConfiguration<BOEmployeeOverTime>
    {
        public EmployeeOverTimeConfiguration()
        {
                this.HasMany(e => e.BOEmployeeSalaryOverTime)
                .WithRequired(e => e.BOEmployeeOverTime)
                .HasForeignKey(e => e.EmpOverTimeCode)
                .WillCascadeOnDelete(false);
        }
    }
}

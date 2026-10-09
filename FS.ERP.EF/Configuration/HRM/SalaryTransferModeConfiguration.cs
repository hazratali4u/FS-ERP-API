using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class SalaryTransferModeConfiguration : EntityTypeConfiguration<BOSalaryTransferMode>
    {
        public SalaryTransferModeConfiguration()
        {
              this.HasMany(e => e.BOEmployeeInfo)
              .WithRequired(e => e.BOSalaryTransferMode)
              .HasForeignKey(e => e.SalaryTransferMode)
              .WillCascadeOnDelete(false);

                this.HasMany(e => e.BOEmployeeInfoRevision)
                .WithRequired(e => e.BOSalaryTransferMode)
                .HasForeignKey(e => e.SalaryTransferMode)
                .WillCascadeOnDelete(false);

                this.HasMany(e => e.BOEmployeeSalary)
                .WithRequired(e => e.BOSalaryTransferMode)
                .HasForeignKey(e => e.SalaryTransferMode)
                .WillCascadeOnDelete(false);
        }
    }
}

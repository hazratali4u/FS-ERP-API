using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class HireTypeConfiguration : EntityTypeConfiguration<BOHireType>
    {
        public HireTypeConfiguration()
        {
               this.Property(e => e.PeriodInDays)
               .HasPrecision(18, 7);

            this.HasMany(e => e.BOEmployeeInfo)
                .WithRequired(e => e.BOHireType)
                .HasForeignKey(e => e.HireTypeCode)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOEmployeeInfoRevision)
                .WithRequired(e => e.BOHireType)
                .HasForeignKey(e => e.HireTypeCode)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOEmployeeSalary)
                .WithRequired(e => e.BOHireType)
                .HasForeignKey(e => e.HireTypeCode)
                .WillCascadeOnDelete(false);
        }
    }
}

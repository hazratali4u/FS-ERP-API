using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class EmployeeAllowanceOrBenefitConfiguration : EntityTypeConfiguration<BOEmployeeAllowanceOrBenefit>
    {
        public EmployeeAllowanceOrBenefitConfiguration()
        {
                this.Property(e => e.AllowanceOrBenefitAmount)
                .HasPrecision(18, 7);

            this.HasMany(e => e.BOEmployeeIncrementAllowanceOrBenefit)
                .WithRequired(e => e.BOEmployeeAllowanceOrBenefit)
                .HasForeignKey(e => e.EmployeeAllowanceOrBenefitCode)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOEmployeeSalaryAllowanceOrBenefit)
                .WithRequired(e => e.BOEmployeeAllowanceOrBenefit)
                .HasForeignKey(e => e.EmployeeAllowanceOrBenefitCode)
                .WillCascadeOnDelete(false);

             this.HasMany(e => e.BOEmployeeManualAllowanceOrBenefit)
             .WithRequired(e => e.BOEmployeeAllowanceOrBenefit)
             .HasForeignKey(e => e.EmployeeAllowanceOrBenefitCode)
             .WillCascadeOnDelete(false);
        }
    }
}

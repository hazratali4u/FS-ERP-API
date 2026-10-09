using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class EmployeeSalaryConfiguration : EntityTypeConfiguration<BOEmployeeSalary>
    {
        public EmployeeSalaryConfiguration()
        {
              this.HasMany(e => e.BOEmployeeSalaryDeduction)
              .WithRequired(e => e.BOEmployeeSalary)
              .HasForeignKey(e => e.EmpSalaryCode)
              .WillCascadeOnDelete(false);

                this.Property(e => e.PFAmount)
                .HasPrecision(33, 6);

                this.HasMany(e => e.BOEmployeeSalaryDeduction)
                .WithRequired(e => e.BOEmployeeSalary)
                .HasForeignKey(e => e.EmpSalaryCode)
                .WillCascadeOnDelete(false);

                this.HasMany(e => e.BOEmployeeSalaryAllowanceOrBenefit)
                .WithRequired(e => e.BOEmployeeSalary)
                .HasForeignKey(e => e.EmpSalaryCode)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOEmployeeSalaryReimbursement)
                .WithRequired(e => e.BOEmployeeSalary)
                .HasForeignKey(e => e.EmpSalaryCode)
                .WillCascadeOnDelete(false);

             this.HasMany(e => e.BOEmployeeSalaryLoanLease)
             .WithRequired(e => e.BOEmployeeSalary)
             .HasForeignKey(e => e.EmpSalaryCode)
             .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOEmployeeIncomeTax)
            .WithRequired(e => e.BOEmployeeSalary)
            .HasForeignKey(e => e.EmpSalaryCode)
            .WillCascadeOnDelete(false);
        }
    }
}

using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class PayGradeConfiguration : EntityTypeConfiguration<BOPayGrade>
    {
        public PayGradeConfiguration()
        {
            this
                .Property(e => e.SalaryFrom)
                .HasPrecision(18, 7);

            this
                .Property(e => e.SalaryTo)
                .HasPrecision(18, 7);

            this
                .HasMany(e => e.BOEmployeeInfo)
                .WithOptional(e => e.BOPayGrade)
                .HasForeignKey(e => e.PayGradeCode);

            this
                .HasMany(e => e.BOEmployeeInfoRevision)
                .WithOptional(e => e.BOPayGrade)
                .HasForeignKey(e => e.PayGradeCode);

            this
                .HasMany(e => e.BOEmployeeSalary)
                .WithOptional(e => e.BOPayGrade)
                .HasForeignKey(e => e.PayGradeCode);

            this
                .HasMany(e => e.BOPayGradeAllowanceOrBenefit)
                .WithRequired(e => e.BOPayGrade)
                .HasForeignKey(e => e.PayGradeCode)
                .WillCascadeOnDelete(false);

            this
            .HasMany(e => e.BOPayGradeAssetsAllocation)
            .WithRequired(e => e.BOPayGrade)
            .HasForeignKey(e => e.PayGradeCode)
            .WillCascadeOnDelete(false);

            this
            .HasMany(e => e.BOPayGradeDocCheckListAllocation)
            .WithRequired(e => e.BOPayGrade)
            .HasForeignKey(e => e.PayGradeCode)
            .WillCascadeOnDelete(false);

            this
          .HasMany(e => e.BOPayGradeEarningsAllocation)
          .WithRequired(e => e.BOPayGrade)
          .HasForeignKey(e => e.PayGradeCode)
          .WillCascadeOnDelete(false);

            this
              .HasMany(e => e.BOPayGradeEOBIAllocation)
              .WithRequired(e => e.BOPayGrade)
              .HasForeignKey(e => e.PayGradeCode)
              .WillCascadeOnDelete(false);

            this
        .HasMany(e => e.BOPayGradeExpenseLimitAllocation)
        .WithRequired(e => e.BOPayGrade)
        .HasForeignKey(e => e.PayGradeCode)
        .WillCascadeOnDelete(false);

            this
                    .HasMany(e => e.BOPayGradeGratuityCriteria)
                    .WithRequired(e => e.BOPayGrade)
                    .HasForeignKey(e => e.PayGradeCode)
                    .WillCascadeOnDelete(false);

            this
              .HasMany(e => e.BOPayGradePayrollGroup)
              .WithRequired(e => e.BOPayGrade)
              .HasForeignKey(e => e.PayGradeCode)
              .WillCascadeOnDelete(false);

            this
                 .HasMany(e => e.BOPayGradeProvidentFundAllocation)
                 .WithRequired(e => e.BOPayGrade)
                 .HasForeignKey(e => e.PayGradeCode)
                 .WillCascadeOnDelete(false);

            this
              .HasMany(e => e.BOPayGradeBonusAllocation)
              .WithRequired(e => e.BOPayGrade)
              .HasForeignKey(e => e.PayGradeCode)
              .WillCascadeOnDelete(false);

            this
          .HasMany(e => e.BOPayGradeDeductionAllocation)
          .WithRequired(e => e.BOPayGrade)
          .HasForeignKey(e => e.PayGradeCode)
          .WillCascadeOnDelete(false);
        }
    }
}

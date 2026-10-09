using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class FiscalYearConfiguration : EntityTypeConfiguration<BOFiscalYear>
    {
        public FiscalYearConfiguration()
        {
            this
               .HasMany(e => e.BOIMMTaxGroup)
               .WithOptional(e => e.BOFiscalYear)
               .HasForeignKey(e => e.FiscalYearCode);

            this
                .HasMany(e => e.BOIMMTaxGroupDetail)
                .WithOptional(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode);

            this
                .HasMany(e => e.BOIncomeTaxSlab)
                .WithRequired(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOBillOrInvoiceMaster)
                .WithRequired(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BODocumentDetailOfStatement)
                .WithRequired(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BODocumentOfStatement)
                .WithRequired(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BODomainOfStatement)
                .WithRequired(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOAttendanceDiscrepancy)
                .WithRequired(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode)
                .WillCascadeOnDelete(false);

            //this
            //    .HasMany(e => e.BOCalendar)
            //    .WithOptional(e => e.BOFiscalYear)
            //    .HasForeignKey(e => e.FiscalYearCode);

            this
                .HasMany(e => e.BOEmployeeAttendance)
                .WithRequired(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOEmployeeIncrement)
                .WithOptional(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode);

            this
                .HasMany(e => e.BOEmployeeLease)
                .WithRequired(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode)
                .WillCascadeOnDelete(false);

            //this
            //    .HasMany(e => e.BOEmployeeLeave)
            //    .WithRequired(e => e.BOFiscalYear)
            //    .HasForeignKey(e => e.FiscalYearCode)
            //    .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOEmployeeLeaveBalance)
                .WithRequired(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOEmployeeLoan)
                .WithRequired(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOEmployeeSalary)
                .WithOptional(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode);

            this
                .HasMany(e => e.BOFiscalYearMonth)
                .WithRequired(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOFiscalYearMonthDetail)
                .WithRequired(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOFundDemandRegister)
                .WithRequired(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOFundDemandRequest)
                .WithRequired(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOLeaveDeductionAgainstLate)
                .WithRequired(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BORemittanceAdvice)
                .WithRequired(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOTransactionMaster)
                .WithRequired(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode)
                .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOGatePass)
               .WithRequired(e => e.BOFiscalYear)
               .HasForeignKey(e => e.FiscalYearCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOGRNandReturn)
               .WithOptional(e => e.BOFiscalYear)
               .HasForeignKey(e => e.FiscalYearCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOProductionMaster)
               .WithRequired(e => e.BOFiscalYear)
               .HasForeignKey(e => e.FiscalYearCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOReceipeMaster)
               .WithRequired(e => e.BOFiscalYear)
               .HasForeignKey(e => e.FiscalYearCode)
               .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOIncrementOrDecrementRules)
                .WithOptional(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode);

            this
                .HasMany(e => e.BOProductAssemblyMaster)
                .WithOptional(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode);
        }
    }
}

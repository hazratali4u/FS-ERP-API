using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class COAConfiguration : EntityTypeConfiguration<BOCOA>
    {
        public COAConfiguration()
        {
            this
                 .Property(e => e.OpenDrAmount)
                 .HasPrecision(18, 7);

            this
                .Property(e => e.OpenCrAmount)
                .HasPrecision(18, 7);

            this
                .HasMany(e => e.BOSalaryBreakUpPolicyDetail)
                .WithOptional(e => e.BOCOA)
                .HasForeignKey(e => e.COACode);

            this
                .HasMany(e => e.BOEquipment)
                .WithOptional(e => e.BOCOA)
                .HasForeignKey(e => e.COACode);

            this
                .HasMany(e => e.BOEquipment1)
                .WithOptional(e => e.BOCOA1)
                .HasForeignKey(e => e.AccumulatedCOACode);

            this
                .HasMany(e => e.BOPartyOrCustomer)
                .WithOptional(e => e.BOCOA)
                .HasForeignKey(e => e.COACode);

            this
                .HasMany(e => e.BOBankAccount)
                .WithOptional(e => e.BOCOA)
                .HasForeignKey(e => e.COACode);

            this
                .HasMany(e => e.BODeductionType)
                .WithOptional(e => e.BOCOA)
                .HasForeignKey(e => e.COACode);

            this
                .HasMany(e => e.BOAllowancesOrBenefit)
                .WithOptional(e => e.BOCOA)
                .HasForeignKey(e => e.AllowanceOrBenefitCOACode);

            this
                .HasMany(e => e.BOAllowancesOrBenefit1)
                .WithOptional(e => e.BOCOA1)
                .HasForeignKey(e => e.DeductionCOACode);

            this
                .HasMany(e => e.BOCOA1)
                .WithOptional(e => e.BOCOA2)
                .HasForeignKey(e => e.COAParentCode);

            this
                .HasMany(e => e.BOCOAMapping)
                .WithOptional(e => e.BOCOA)
                .HasForeignKey(e => e.COACode);

            this
                .HasMany(e => e.BOCOAMappingForPCorCC)
                .WithOptional(e => e.BOCOA)
                .HasForeignKey(e => e.COACode);

            this
                .HasMany(e => e.BODeductionType)
                .WithOptional(e => e.BOCOA)
                .HasForeignKey(e => e.COACode);

            this
                .HasMany(e => e.BODocumentDetailOfStatement)
                .WithRequired(e => e.BOCOA)
                .HasForeignKey(e => e.COACode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOEmployeeInfo)
                .WithOptional(e => e.BOCOA)
                .HasForeignKey(e => e.COACode);

            this
                .HasMany(e => e.BOEmployeeInfoRevision)
                .WithOptional(e => e.BOCOA)
                .HasForeignKey(e => e.COACode);

            this
                .HasMany(e => e.BOEmployeeSalary)
                .WithOptional(e => e.BOCOA)
                .HasForeignKey(e => e.COACode);

            this
                .HasMany(e => e.BOFundDemandRegisterDetail)
                .WithOptional(e => e.BOCOA)
                .HasForeignKey(e => e.COACode);

            this
                .HasMany(e => e.BOItemCategory)
                .WithOptional(e => e.BOCOA)
                .HasForeignKey(e => e.COACode);

            this
                .HasMany(e => e.BORemittanceAdviceDetail)
                .WithRequired(e => e.BOCOA)
                .HasForeignKey(e => e.COACode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOTransactionDetail)
                .WithRequired(e => e.BOCOA)
                .HasForeignKey(e => e.COACode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOVendorOrSupplier)
                .WithOptional(e => e.BOCOA)
                .HasForeignKey(e => e.COACode);

            this
            .HasMany(e => e.BOCustomerAdjustment)
            .WithOptional(e => e.BOCOA)
            .HasForeignKey(e => e.COACode)
            .WillCascadeOnDelete(false);

            this
           .HasMany(e => e.BOCustomerReceipt)
           .WithOptional(e => e.BOCOA)
           .HasForeignKey(e => e.COACode)
           .WillCascadeOnDelete(false);

            this
           .HasMany(e => e.BOPayrollCOAMapping)
           .WithOptional(e => e.BOCOA)
           .HasForeignKey(e => e.COACode)
           .WillCascadeOnDelete(false);

            this
           .HasMany(e => e.BOLoanType)
           .WithOptional(e => e.BOCOA)
           .HasForeignKey(e => e.LoanPaymentCOACode)
           .WillCascadeOnDelete(false);

            this
          .HasMany(e => e.BOLoanType1)
          .WithOptional(e => e.BOCOA1)
          .HasForeignKey(e => e.LoanAdjustmentCOACode)
          .WillCascadeOnDelete(false);
        }
    }
}

using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class EmployeeInfoConfiguration : EntityTypeConfiguration<BOEmployeeInfo>
    {
        public EmployeeInfoConfiguration()
        {
            this
                .HasMany(e => e.BOBillOrInvoiceMaster)
                .WithOptional(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.RecoveredByEmpCode);

            this
                .HasMany(e => e.BOJobProjectScheme)
                .WithOptional(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.BeneficiaryEmpCode);

            this
                .HasMany(e => e.BOJobProjectScheme1)
                .WithOptional(e => e.BOEmployeeInfo1)
                .HasForeignKey(e => e.AssignedToEmpCode);

            this
                .HasMany(e => e.BORemittanceAdvice)
                .WithOptional(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.CheckedByEmpCode);

            this
                .HasMany(e => e.BORemittanceAdvice1)
                .WithOptional(e => e.BOEmployeeInfo1)
                .HasForeignKey(e => e.ApprovedByEmpCode);

            this
                .HasMany(e => e.BORemittanceAdvice2)
                .WithOptional(e => e.BOEmployeeInfo2)
                .HasForeignKey(e => e.SalePersonEmpCode);

            this
                .HasMany(e => e.BOTransactionDetail)
                .WithOptional(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.RecoveredByEmpCode);

            this
                .HasMany(e => e.BOTransactionMaster)
                .WithOptional(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.RecoveredByEmpCode);

            this
                .HasMany(e => e.BOAttendanceDiscrepancy)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOEmpDocumentCheckList)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOEmployeeAcademic)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOEmployeeAllowanceOrBenefit)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOEmployeeAttendance)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOEmployeeEmployment)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOEmployeeFaceOrBiometric)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOEmployeeFamily)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOEmployeeIncrement)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOEmployeeIncrementAllowanceOrBenefit)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOEmployeeInfo1)
                .WithOptional(e => e.BOEmployeeInfo2)
                .HasForeignKey(e => e.FunctionalEmployeeCode);

            this
                .HasMany(e => e.BOEmployeeInfo11)
                .WithOptional(e => e.BOEmployeeInfo3)
                .HasForeignKey(e => e.ReportingEmployeeCode);

            this
                .HasMany(e => e.BOEmployeeInfo12)
                .WithOptional(e => e.BOEmployeeInfo4)
                .HasForeignKey(e => e.HODEmployeeCode);

            this
                .HasMany(e => e.BOEmployeeInfoRevision)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpOldCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOEmployeeLease)
                .WithOptional(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode);

            this
                .HasMany(e => e.BOEmployeeLeave)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOEmployeeLeave1)
                .WithOptional(e => e.BOEmployeeInfo1)
                .HasForeignKey(e => e.ApprovedBy)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOEmployeeLeaveBalance)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOEmployeeLoan)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOEmployeeReference)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOEmployeeSalary)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOEmployeeSalaryDeduction)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOEmployeeSalaryAllowanceOrBenefit)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOEmployeeSalaryDeduction)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOEmployeeSalaryReimbursement)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOFundDemandRegister)
                .WithOptional(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.RequestedByEmpCode);

            this
                .HasMany(e => e.BOFundDemandRegister1)
                .WithOptional(e => e.BOEmployeeInfo1)
                .HasForeignKey(e => e.PaidByEmpCode);

            this
                .HasMany(e => e.BOFundDemandRequest)
                .WithOptional(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.RequestedByEmpCode);

            this
                .HasMany(e => e.BOLeaveDeductionAgainstLate)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOProcessApprovalAlert)
                .WithOptional(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.ActionByEmpCode);

            this
                .HasMany(e => e.BOReimbursement)
                .WithOptional(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode);

            this
                .HasMany(e => e.BOUser3)
                .WithOptional(e => e.BOEmployeeInfo3)
                .HasForeignKey(e => e.DefaultEmpCode);

            this
                .HasMany(e => e.BOStockRequisitionOrIssuanceDetail)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.IssuanceToEmpCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOStockRequisitionOrIssuanceDetail1)
                .WithRequired(e => e.BOEmployeeInfo1)
                .HasForeignKey(e => e.ReceivedByEmpCode)
                .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOGatePassDetail)
               .WithRequired(e => e.BOEmployeeInfo)
               .HasForeignKey(e => e.GeneratedByEmpCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOGatePassDetail1)
               .WithRequired(e => e.BOEmployeeInfo1)
               .HasForeignKey(e => e.InspectedByEmpCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOGatePass)
               .WithRequired(e => e.BOEmployeeInfo)
               .HasForeignKey(e => e.GeneratedByEmpCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOGatePass1)
               .WithRequired(e => e.BOEmployeeInfo1)
               .HasForeignKey(e => e.InspectedByEmpCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOGRNandReturn)
               .WithRequired(e => e.BOEmployeeInfo)
               .HasForeignKey(e => e.GeneratedByEmpCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOGRNandReturnDetail)
               .WithRequired(e => e.BOEmployeeInfo)
               .HasForeignKey(e => e.GeneratedByEmpCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOPurchaseOrderAndReturnDetail)
               .WithRequired(e => e.BOEmployeeInfo)
               .HasForeignKey(e => e.GeneratedByEmpCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOProductionMaster)
               .WithRequired(e => e.BOEmployeeInfo)
               .HasForeignKey(e => e.ProducedByEmpCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOReceipeMaster)
               .WithRequired(e => e.BOEmployeeInfo)
               .HasForeignKey(e => e.ReceipeByEmpCode)
               .WillCascadeOnDelete(false);

            this
              .HasMany(e => e.BOGenerateLetter)
              .WithRequired(e => e.BOEmployeeInfo)
              .HasForeignKey(e => e.SignatoryCode)
              .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOGenerateLetter1)
               .WithRequired(e => e.BOEmployeeInfo1)
               .HasForeignKey(e => e.EmpCode)
               .WillCascadeOnDelete(false);

            this
              .HasMany(e => e.BOBulletin)
              .WithRequired(e => e.BOEmployeeInfo)
              .HasForeignKey(e => e.EmpCode)
              .WillCascadeOnDelete(false);

            this
              .HasMany(e => e.BOMassCommunication)
              .WithRequired(e => e.BOEmployeeInfo)
              .HasForeignKey(e => e.EmpCode)
              .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOEmployeeAward)
               .WithRequired(e => e.BOEmployeeInfo)
               .HasForeignKey(e => e.EmpCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOEmployeeRelative)
               .WithRequired(e => e.BOEmployeeInfo)
               .HasForeignKey(e => e.EmpCode)
               .WillCascadeOnDelete(false);

            this
           .HasMany(e => e.BOEmployeeRelative1)
           .WithRequired(e => e.BOEmployeeInfo1)
           .HasForeignKey(e => e.RelativeEmpCode)
           .WillCascadeOnDelete(false);

            this
            .HasMany(e => e.BOEmployeeIncident)
            .WithRequired(e => e.BOEmployeeInfo)
            .HasForeignKey(e => e.EmpCode)
            .WillCascadeOnDelete(false);

            this
              .HasMany(e => e.BOEmployeeHiringReference)
              .WithRequired(e => e.BOEmployeeInfo)
              .HasForeignKey(e => e.EmpCode)
              .WillCascadeOnDelete(false);

            this
             .HasMany(e => e.BOEmployeePersonalAttribute)
             .WithRequired(e => e.BOEmployeeInfo)
             .HasForeignKey(e => e.EmpCode)
             .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOEmployeeManagementRemarks)
               .WithRequired(e => e.BOEmployeeInfo)
               .HasForeignKey(e => e.EmpCode)
               .WillCascadeOnDelete(false);

            this
          .HasMany(e => e.BOSeparationCheckList)
          .WithRequired(e => e.BOEmployeeInfo)
          .HasForeignKey(e => e.EmpCode)
          .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOSeparationCheckList1)
               .WithRequired(e => e.BOEmployeeInfo1)
               .HasForeignKey(e => e.ClearanceAuthority)
               .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOSeparationChecklistSetup)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.SpecificEmployeeCode)
                .WillCascadeOnDelete(false);

            this
           .HasMany(e => e.BOSeparationSubmission)
           .WithRequired(e => e.BOEmployeeInfo)
           .HasForeignKey(e => e.EmpCode)
           .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOSeparationSubmission1)
                .WithRequired(e => e.BOEmployeeInfo1)
                .HasForeignKey(e => e.ApprovedBy)
                .WillCascadeOnDelete(false);

            this
           .HasMany(e => e.BOBonusProcess)
           .WithRequired(e => e.BOEmployeeInfo)
           .HasForeignKey(e => e.EmpCode)
           .WillCascadeOnDelete(false);

            this
           .HasMany(e => e.BOExpensePayment)
           .WithRequired(e => e.BOEmployeeInfo)
           .HasForeignKey(e => e.EmpCode)
           .WillCascadeOnDelete(false);

            this
         .HasMany(e => e.BOExpenseClaim)
         .WithRequired(e => e.BOEmployeeInfo)
         .HasForeignKey(e => e.EmpCode)
         .WillCascadeOnDelete(false);

            this
            .HasMany(e => e.BOLeaveYearEndProcess)
            .WithRequired(e => e.BOEmployeeInfo)
            .HasForeignKey(e => e.EmpCode)
            .WillCascadeOnDelete(false);

            this
             .HasMany(e => e.BOLeaveEncashmentProcess)
             .WithRequired(e => e.BOEmployeeInfo)
             .HasForeignKey(e => e.EmpCode)
             .WillCascadeOnDelete(false);

            this
             .HasMany(e => e.BOEmployeeDocuments)
             .WithRequired(e => e.BOEmployeeInfo)
             .HasForeignKey(e => e.EmpCode)
             .WillCascadeOnDelete(false);

            this
             .HasMany(e => e.BOEmployeeGeoRestrictions)
             .WithRequired(e => e.BOEmployeeInfo)
             .HasForeignKey(e => e.EmpCode)
             .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOEmployeeOvertimeProcess)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            this
           .HasMany(e => e.BOSaleOrderMaster)
           .WithOptional(e => e.BOEmployeeInfo)
           .HasForeignKey(e => e.EmpCode)
           .WillCascadeOnDelete(false);

            this
            .HasMany(e => e.BODeliveryNoteMaster)
            .WithOptional(e => e.BOEmployeeInfo)
            .HasForeignKey(e => e.EmpCode)
            .WillCascadeOnDelete(false);

            this
            .HasMany(e => e.BOEmployeeTrackingConfiguration)
            .WithRequired(e => e.BOEmployeeInfo)
            .HasForeignKey(e => e.EmpCode)
            .WillCascadeOnDelete(false);

            this
           .HasMany(e => e.BOEmployeeTrackingDetail)
           .WithRequired(e => e.BOEmployeeInfo)
           .HasForeignKey(e => e.EmpCode)
           .WillCascadeOnDelete(false);

            this
             .HasMany(e => e.BOEquipmentIssuedOrReturn)
             .WithRequired(e => e.BOEmployeeInfo)
             .HasForeignKey(e => e.EmpCode)
             .WillCascadeOnDelete(false);

            this
             .HasMany(e => e.BODutyRoster)
             .WithRequired(e => e.BOEmployeeInfo)
             .HasForeignKey(e => e.EmpCode)
             .WillCascadeOnDelete(false);

            this
            .HasMany(e => e.BOEmployeeSalaryLoanLease)
            .WithRequired(e => e.BOEmployeeInfo)
            .HasForeignKey(e => e.EmpCode)
            .WillCascadeOnDelete(false);

            this
             .HasMany(e => e.BOEmployeeManualOvertime)
             .WithRequired(e => e.BOEmployeeInfo)
             .HasForeignKey(e => e.EmpCode)
             .WillCascadeOnDelete(false);

            this
             .HasMany(e => e.BOEmployeeManualAllowanceOrBenefit)
             .WithRequired(e => e.BOEmployeeInfo)
             .HasForeignKey(e => e.EmpCode)
             .WillCascadeOnDelete(false);

            this
             .HasMany(e => e.BOEmployeeLockedAttendanceDetails)
             .WithRequired(e => e.BOEmployeeInfo)
             .HasForeignKey(e => e.EmpCode)
             .WillCascadeOnDelete(false);

            this
             .HasMany(e => e.BOEmployeeLoanPayment)
             .WithRequired(e => e.BOEmployeeInfo)
             .HasForeignKey(e => e.EmpCode)
             .WillCascadeOnDelete(false);

            this
             .HasMany(e => e.BOPayrollInputMaster)
             .WithRequired(e => e.BOEmployeeInfo)
             .HasForeignKey(e => e.EmpCode)
             .WillCascadeOnDelete(false);
        }
    }
}

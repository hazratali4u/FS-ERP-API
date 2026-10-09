using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class RecordStatusConfiguration : EntityTypeConfiguration<BORecordStatus>
    {
        public RecordStatusConfiguration()
        {
            this
               .HasMany(e => e.BOEmployeeIncomeTax)
               .WithRequired(e => e.BORecordStatus)
               .HasForeignKey(e => e.RecordStatusCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOAppConfiguration)
               .WithRequired(e => e.BORecordStatus)
               .HasForeignKey(e => e.RecordStatusCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOAppConfiguration)
               .WithRequired(e => e.BORecordStatus)
               .HasForeignKey(e => e.RecordStatusCode)
               .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOAppConfigurationDetail)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOApprovalAuthorityType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOAttendanceMachineType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOBillOrInvoiceType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOCulture)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOCurrency)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BODataType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BODiscrepancyType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeRelation)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEquipmentStatus)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEquipmentType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOExpenseType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOIMMAcquireType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOIMMGender)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOIMMGroup)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOIMMLifeType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOIMMManufacturedBy)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOIMMTaxGroup)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOIMMTaxGroupDetail)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOIMMTransactionMethod)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOIncomeTaxSlab)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOInstrumentStatus)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOInstrumentType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOLeaseType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOLoanType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOLocationSite)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOLocationSiteType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOOnwerShipType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOOrganizationCompany)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOPackingType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOPaymentMode)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOPriority)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOProcessApprovalWorkflow)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BORebateType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOActionLogging)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BODeductionType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOAllowancesOrBenefit)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOAPPCNFDataLogging)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOAreaOfDistrictWard)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOAttendanceDiscrepancy)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOBank)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOBankAccount)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOBankAccountInstrumentInfo)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOBankBranch)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOBillOrInvoiceMaster)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOBillOrInvoiceMasterDetail)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOCalendar)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOCityTown)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOCOA)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOCOAConfiguration)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOCOAMapping)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOCOAMappingForPCorCC)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOCOANature)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOCountryRegion)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOCRMDataLogging)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BODeductionType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BODegree)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BODegreeInstitute)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BODepartment)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BODesignation)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BODistrictWard)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BODocumentCheckList)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BODocumentDetailOfStatement)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BODocumentOfStatement)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BODomainOfStatement)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmpDocumentCheckList)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<BORecordStatus>()
            //    .HasMany(e => e.BOEmployeeAcademic)
            //    .WithRequired(e => e.BORecordStatus)
            //    .HasForeignKey(e => e.RecordStatusCode)
            //    .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeAllowanceOrBenefit)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeAttendance)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<BORecordStatus>()
            //    .HasMany(e => e.BOEmployeeEmployment)
            //    .WithRequired(e => e.BORecordStatus)
            //    .HasForeignKey(e => e.RecordStatusCode)
            //    .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeFaceOrBiometric)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<BORecordStatus>()
            //    .HasMany(e => e.BOEmployeeFamily)
            //    .WithRequired(e => e.BORecordStatus)
            //    .HasForeignKey(e => e.RecordStatusCode)
            //    .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeIncrement)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeIncrementAllowanceOrBenefit)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeInfo)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeInfoHistory)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeInfoRevision)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeLease)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeLeaseInstallment)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeLeave)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeLeaveBalance)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeLoan)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeLoanInstallment)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeReference)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeSalary)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeSalaryDeduction)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeSalaryAllowanceOrBenefit)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeSalaryDeduction)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeSalaryReimbursement)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeStatus)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEquipment)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOErrorLogging)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOFICODataLogging)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOFiscalYear)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOFiscalYearMonth)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOFiscalYearMonthDetail)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOFundDemandRegister)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOFundDemandRegisterDetail)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOFundDemandRequest)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOFundDemandRequestDetail)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOHireType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOHRMDataLogging)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOIMMConfiguration)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOIMMDataLogging)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOIMMSectionOrBrand)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOItem)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOItemAspect)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOItemAspectDetail)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOItemAttribute)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOItemAttributeAspect)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOItemAttributeAspectDetail)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOItemAttributeDetail)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOItemCategory)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOItemCategoryAttributeAspect)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOItemCategoryAttributeAspectDetail)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOItemPrice)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOItemProfile)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOJobProjectScheme)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOJobProjectSchemeDetail)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOJobRole)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOLeaveDeductionAgainstLate)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOLeavePolicy)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOLeavePolicyDetail)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOLeaveType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOLinkToTransaction)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOLoggingInformation)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOLoginAttempts)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOMenu)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOMenuControlInfo)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOModuleColInfo)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOModuleParamInfo)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOPartyOrCustomer)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOPayGrade)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOPayGradeAllowanceOrBenefit)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOProcessApprovalAlert)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOProfileGroup)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOProfileGroupDetail)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOReimbursement)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOReimbursementType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BORemittanceAdvice)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BORemittanceAdviceDetail)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOReportDashboardInfo)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOSalaryBreakUpPolicy)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOSalaryBreakUpPolicyDetail)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOSalaryTransferMode)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOSectorZone)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOSecurityRight)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOShift)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOShiftDay)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOSRMDataLogging)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOStateProvince)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOSystemOrWebPool)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOTaxAdjustmentType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOTransactionDetail)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOTransactionDocumentConfiguration)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOTransactionDocumentProcess)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOTransactionMaster)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOUMSDataLogging)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOUOM)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOUser3)
                .WithRequired(e => e.BORecordStatus3)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOUserLocationSitePermission)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOUserOrganizationCompanyPermission)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOUserPartyOrCustomerPermission)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOUserProfileGroup)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOUserSystemOrWebPermission)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOUserVendorOrSupplierPermission)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOVendorOrSupplier)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOVoucherType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeAcademic)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeEmployment)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeFamily)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOGRNandReturn)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOGRNandReturnDetail)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOReligion)
            .WithRequired(e => e.BORecordStatus)
            .HasForeignKey(e => e.RecordStatusCode)
            .WillCascadeOnDelete(false);

           this
              .HasMany(e => e.BOSeparationCheckList)
              .WithRequired(e => e.BORecordStatus)
              .HasForeignKey(e => e.RecordStatusCode)
              .WillCascadeOnDelete(false);

           this
              .HasMany(e => e.BOSeparationChecklistSetup)
              .WithRequired(e => e.BORecordStatus)
              .HasForeignKey(e => e.RecordStatusCode)
              .WillCascadeOnDelete(false);

           this
              .HasMany(e => e.BOSeparationSubmission)
              .WithRequired(e => e.BORecordStatus)
              .HasForeignKey(e => e.RecordStatusCode)
              .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOSeparationTypeOrReason)
            .WithRequired(e => e.BORecordStatus)
            .HasForeignKey(e => e.RecordStatusCode)
            .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOBonusType)
            .WithRequired(e => e.BORecordStatus)
            .HasForeignKey(e => e.RecordStatusCode)
            .WillCascadeOnDelete(false);

           this
           .HasMany(e => e.BOBonusProcess)
           .WithRequired(e => e.BORecordStatus)
           .HasForeignKey(e => e.RecordStatusCode)
           .WillCascadeOnDelete(false);

           this
           .HasMany(e => e.BOBonusPolicy)
           .WithRequired(e => e.BORecordStatus)
           .HasForeignKey(e => e.RecordStatusCode)
           .WillCascadeOnDelete(false);

           this
           .HasMany(e => e.BOBonusAllowancesMapping)
           .WithRequired(e => e.BORecordStatus)
           .HasForeignKey(e => e.RecordStatusCode)
           .WillCascadeOnDelete(false);

           this
          .HasMany(e => e.BOPayGradeBonusAllocation)
          .WithRequired(e => e.BORecordStatus)
          .HasForeignKey(e => e.RecordStatusCode)
          .WillCascadeOnDelete(false);

           this
         .HasMany(e => e.BOFieldExpensePolicyDetail)
         .WithRequired(e => e.BORecordStatus)
         .HasForeignKey(e => e.RecordStatusCode)
         .WillCascadeOnDelete(false);

           this
               .HasMany(e => e.BOFieldExpensePolicy)
               .WithRequired(e => e.BORecordStatus)
               .HasForeignKey(e => e.RecordStatusCode)
               .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOExpensePayment)
            .WithRequired(e => e.BORecordStatus)
            .HasForeignKey(e => e.RecordStatusCode)
            .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOExpenseClaim)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOExpenseClaimDetails)
            .WithRequired(e => e.BORecordStatus)
            .HasForeignKey(e => e.RecordStatusCode)
            .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOFieldExpenseType)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOLeaveYearEndProcess)
            .WithRequired(e => e.BORecordStatus)
            .HasForeignKey(e => e.RecordStatusCode)
            .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOLeaveEncashmentProcess)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOEmployeeDocuments)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOEmployeeGeoRestrictions)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOEmployeeOvertimeProcess)
            .WithRequired(e => e.BORecordStatus)
            .HasForeignKey(e => e.RecordStatusCode)
            .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOSaleOrderDetail)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOSaleOrderMaster)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BODeliveryNoteMaster)
            .WithRequired(e => e.BORecordStatus)
            .HasForeignKey(e => e.RecordStatusCode)
            .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BODeliveryNoteDetail)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOCustomerAdjustment)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOCustomerReceipt)
            .WithRequired(e => e.BORecordStatus)
            .HasForeignKey(e => e.RecordStatusCode)
            .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOFreightEntrySlip)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOVendorAdjustment)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOCommissionBooking)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOCommissionReceipt)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOPurchaseInvoiceMaster)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOPurchaseInvoiceDetail)
            .WithRequired(e => e.BORecordStatus)
            .HasForeignKey(e => e.RecordStatusCode)
            .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOVendorPayment)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOCommissionReceiptInvoiceMapping)
            .WithRequired(e => e.BORecordStatus)
            .HasForeignKey(e => e.RecordStatusCode)
            .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOCustomerReceiptInvoiceMapping)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOCustomerAdjustmentInvoiceMapping)
            .WithRequired(e => e.BORecordStatus)
            .HasForeignKey(e => e.RecordStatusCode)
            .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOVendorPaymentInvoiceMapping)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOIMMFinishTypeOptions)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOVendorAdjustmentInvoiceMapping)
            .WithRequired(e => e.BORecordStatus)
            .HasForeignKey(e => e.RecordStatusCode)
            .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOPurchaseOrderAndReturnMapping)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOItemImages)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOLocationSiteWiseItem)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOCafeOrRestaurantConfiguration)
            .WithRequired(e => e.BORecordStatus)
            .HasForeignKey(e => e.RecordStatusCode)
            .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOSlipNotes)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOEmployeeTrackingConfiguration)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOEmployeeTrackingDetail)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOHoldBillOrInvoiceMaster)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOHoldBillOrInvoiceMasterDetail)
            .WithRequired(e => e.BORecordStatus)
            .HasForeignKey(e => e.RecordStatusCode)
            .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOItemProfileBarCode)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOSMSOrEmailDescription)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOSMSOrEmailOperationsOrBehaviour)
            .WithRequired(e => e.BORecordStatus)
            .HasForeignKey(e => e.RecordStatusCode)
            .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOSMSOrEmailTags)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOItemDefinition)
            .WithRequired(e => e.BORecordStatus)
            .HasForeignKey(e => e.RecordStatusCode)
            .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOSubjectToDeliver)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOPerformanceGoal)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOTravellingMedium)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOTravelRequest)
            .WithRequired(e => e.BORecordStatus)
            .HasForeignKey(e => e.RecordStatusCode)
            .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOTravelRequestDetails)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOEmployeeGoalAssignment)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOLocationWiseSMSInfo)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOEmailTemplateAssignment)
            .WithRequired(e => e.BORecordStatus)
            .HasForeignKey(e => e.RecordStatusCode)
            .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOCustomerGroupOrTag)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOCustomerGroupOrTagCustomerAssignment)
            .WithRequired(e => e.BORecordStatus)
            .HasForeignKey(e => e.RecordStatusCode)
            .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOCustomerGroupOrTagUserAssignment)
            .WithRequired(e => e.BORecordStatus)
            .HasForeignKey(e => e.RecordStatusCode)
            .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOEmailAccounts)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOUserEmailAssignment)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOUserEmailLog)
            .WithRequired(e => e.BORecordStatus)
            .HasForeignKey(e => e.RecordStatusCode)
            .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOEquipmentIssuedOrReturn)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BODutyRoster)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOEmployeeSalaryLoanLease)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BORequestTaxCertificate)
            .WithRequired(e => e.BORecordStatus)
            .HasForeignKey(e => e.RecordStatusCode)
            .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOEmployeeManualOvertime)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOEmployeeManualAllowanceOrBenefit)
            .WithRequired(e => e.BORecordStatus)
            .HasForeignKey(e => e.RecordStatusCode)
            .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOQuotationTemplate)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOQuotationParameter)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOQuotationParameterMapping)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOGenerateQuotation)
            .WithRequired(e => e.BORecordStatus)
            .HasForeignKey(e => e.RecordStatusCode)
            .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOGenerateQuotationDetail)
            .WithRequired(e => e.BORecordStatus)
            .HasForeignKey(e => e.RecordStatusCode)
            .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOQuotationParameterItemDetail)
            .WithRequired(e => e.BORecordStatus)
            .HasForeignKey(e => e.RecordStatusCode)
            .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOPartyOrCustomerPlan)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOEmployeeLockedAttendanceDetails)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOEmployeeLoanPayment)
            .WithRequired(e => e.BORecordStatus)
            .HasForeignKey(e => e.RecordStatusCode)
            .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOPayrollInputMaster)
             .WithRequired(e => e.BORecordStatus)
             .HasForeignKey(e => e.RecordStatusCode)
             .WillCascadeOnDelete(false);
        }
    }
}

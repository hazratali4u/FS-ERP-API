using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class OrganizationConfiguration : EntityTypeConfiguration<BOOrganizationCompany>
    {
        public OrganizationConfiguration()
        {
           this
                .Property(e => e.Longitude)
                .HasPrecision(18, 7);

           this
                .Property(e => e.Latitude)
                .HasPrecision(18, 7);

           this
                .Property(e => e.Altitude)
                .HasPrecision(18, 7);

           this
                .Property(e => e.Radius)
                .HasPrecision(18, 7);

           this
                .HasMany(e => e.BOAppConfiguration)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOAppConfigurationDetail)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOApprovalAuthorityType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOAttendanceMachineType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOBillOrInvoiceType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BODiscrepancyType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOEmployeeRelation)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOEquipmentStatus)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOEquipmentType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOExpenseType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);



           this
                .HasMany(e => e.BOIMMAcquireType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOIMMGender)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOIMMGroup)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOIMMLifeType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOIMMManufacturedBy)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOIMMTaxGroup)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOIMMTaxGroupDetail)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOIMMTransactionMethod)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOIncomeTaxSlab)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOInstrumentStatus)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOInstrumentType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOLeaseType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOLoanType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOLocationSite)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOOnwerShipType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOActionLogging)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOAllowancesOrBenefit)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOAPPCNFDataLogging)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOAttendanceDiscrepancy)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOBank)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOBankAccount)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOBankAccountInstrumentInfo)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOBankAccountInstrumentInfo1)
                .WithOptional(e => e.BOOrganizationCompany1)
                .HasForeignKey(e => e.PCorCCFromCode);

           this
                .HasMany(e => e.BOBankAccountInstrumentInfo2)
                .WithOptional(e => e.BOOrganizationCompany2)
                .HasForeignKey(e => e.PCorCCToCode);

           this
                .HasMany(e => e.BOBankBranch)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOBillOrInvoiceMaster)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOBillOrInvoiceMaster1)
                .WithOptional(e => e.BOOrganizationCompany1)
                .HasForeignKey(e => e.PCorCCCode);

           this
                .HasMany(e => e.BOBillOrInvoiceMasterDetail)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);


           this
                .HasMany(e => e.BOCalendar)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOCOA)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOCOAConfiguration)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOCOAMapping)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOCOAMappingForPCorCC)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOCOAMappingForPCorCC1)
                .WithOptional(e => e.BOOrganizationCompany1)
                .HasForeignKey(e => e.PcOrCcCode);

           this
                .HasMany(e => e.BOCOANature)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOCRMDataLogging)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BODeductionType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BODegree)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BODegreeInstitute)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BODepartment)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BODesignation)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BODocumentCheckList)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BODocumentDetailOfStatement)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BODocumentOfStatement)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BODomainOfStatement)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOEmpDocumentCheckList)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<BOOrganizationCompany>()
            //    .HasMany(e => e.BOEmployeeAcademic)
            //    .WithRequired(e => e.BOOrganizationCompany)
            //    .HasForeignKey(e => e.CompanyCode)
            //    .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeAllowanceOrBenefit)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOEmployeeAttendance)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<BOOrganizationCompany>()
            //    .HasMany(e => e.BOEmployeeEmployment)
            //    .WithRequired(e => e.BOOrganizationCompany)
            //    .HasForeignKey(e => e.CompanyCode)
            //    .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeFaceOrBiometric)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<BOOrganizationCompany>()
            //    .HasMany(e => e.BOEmployeeFamily)
            //    .WithRequired(e => e.BOOrganizationCompany)
            //    .HasForeignKey(e => e.CompanyCode)
            //    .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeIncrement)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeIncrementAllowanceOrBenefit)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeInfo)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeInfo1)
                .WithRequired(e => e.BOOrganizationCompany1)
                .HasForeignKey(e => e.PayrollCostOrProfitCenterCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeInfo2)
                .WithRequired(e => e.BOOrganizationCompany2)
                .HasForeignKey(e => e.CostOrProfitCenterCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeInfo3)
                .WithRequired(e => e.BOOrganizationCompany3)
                .HasForeignKey(e => e.EmpCompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeInfoHistory)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeInfoRevision)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeInfoRevision1)
                .WithRequired(e => e.BOOrganizationCompany1)
                .HasForeignKey(e => e.PayrollCostOrProfitCenterCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeInfoRevision2)
                .WithRequired(e => e.BOOrganizationCompany2)
                .HasForeignKey(e => e.CostOrProfitCenterCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeInfoRevision3)
                .WithRequired(e => e.BOOrganizationCompany3)
                .HasForeignKey(e => e.EmpCompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeLease)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeLeaseInstallment)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeLeave)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeLeaveBalance)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);



           this
                .HasMany(e => e.BOEmployeeLoan)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeLoanInstallment)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeReference)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeSalary)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeSalary1)
                .WithRequired(e => e.BOOrganizationCompany1)
                .HasForeignKey(e => e.PayrollCostOrProfitCenterCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeSalary2)
                .WithRequired(e => e.BOOrganizationCompany2)
                .HasForeignKey(e => e.CostOrProfitCenterCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeSalary3)
                .WithRequired(e => e.BOOrganizationCompany3)
                .HasForeignKey(e => e.EmpCompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeSalaryDeduction)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeSalaryAllowanceOrBenefit)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);


           this
                .HasMany(e => e.BOEmployeeSalaryReimbursement)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeStatus)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOEquipment)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOEquipment1)
                .WithOptional(e => e.BOOrganizationCompany1)
                .HasForeignKey(e => e.CostOrProfitCenterCode);

           this
                .HasMany(e => e.BOEquipment2)
                .WithOptional(e => e.BOOrganizationCompany2)
                .HasForeignKey(e => e.TransferCostOrProfitCenterCode);

           this
                .HasMany(e => e.BOErrorLogging)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOFICODataLogging)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOFiscalYear)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOFiscalYearMonth)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOFiscalYearMonth1)
                .WithRequired(e => e.BOOrganizationCompany1)
                .HasForeignKey(e => e.PcOrCcCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOFiscalYearMonthDetail)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOFiscalYearMonthDetail1)
                .WithRequired(e => e.BOOrganizationCompany1)
                .HasForeignKey(e => e.PcOrCcCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOFiscalYearMonthDetail2)
                .WithRequired(e => e.BOOrganizationCompany2)
                .HasForeignKey(e => e.CompanyOrOrganizationCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOFundDemandRegister)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOFundDemandRegisterDetail)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOFundDemandRequest)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOFundDemandRequestDetail)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOHireType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOHRMDataLogging)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOIMMConfiguration)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOIMMDataLogging)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOIMMSectionOrBrand)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOItem)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOItemAspect)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOItemAspectDetail)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOItemAttribute)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOItemAttributeAspect)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOItemAttributeAspectDetail)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOItemAttributeDetail)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOItemCategory)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOItemCategoryAttributeAspect)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOItemCategoryAttributeAspectDetail)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOItemPrice)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOItemPrice1)
                .WithOptional(e => e.BOOrganizationCompany1)
                .HasForeignKey(e => e.PcOCcCode);

           this
                .HasMany(e => e.BOItemProfile)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOJobProjectScheme)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOJobProjectSchemeDetail)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOJobRole)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOLeaveDeductionAgainstLate)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOLeavePolicy)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOLeavePolicyDetail)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);


           this
                .HasMany(e => e.BOLeaveType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOLinkToTransaction)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOLoggingInformation)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOLoginAttempts)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOOrganizationCompany1)
                .WithOptional(e => e.BOOrganizationCompany2)
                .HasForeignKey(e => e.ParentCode);



           this
                .HasMany(e => e.BOPackingType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            //modelBuilder.Entity<BOOrganizationCompany>()
            //    .HasMany(e => e.BOPartyOrCustomer)
            //    .WithRequired(e => e.BOOrganizationCompany)
            //    .HasForeignKey(e => e.CompanyCode)
            //    .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOPayGrade)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOPayGradeAllowanceOrBenefit)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOPaymentMode)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOPriority)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOProcessApprovalWorkflow)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOProcessApprovalAlert)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOProfileGroup)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOProfileGroupDetail)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BORebateType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOReimbursement)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOReimbursementType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BORemittanceAdvice)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BORemittanceAdvice1)
                .WithOptional(e => e.BOOrganizationCompany1)
                .HasForeignKey(e => e.PCorCCCode);

           this
                .HasMany(e => e.BORemittanceAdviceDetail)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOSalaryBreakUpPolicy)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOSalaryBreakUpPolicy1)
                .WithRequired(e => e.BOOrganizationCompany1)
                .HasForeignKey(e => e.PolicyCompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOSalaryBreakUpPolicyDetail)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOSalaryBreakUpPolicyDetail1)
                .WithRequired(e => e.BOOrganizationCompany1)
                .HasForeignKey(e => e.PolicyCompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOSalaryTransferMode)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOShift)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOShiftDay)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOSRMDataLogging)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOSystemOrWebPool)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOTaxAdjustmentType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOTransactionDetail)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOTransactionDocumentConfiguration)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOTransactionDocumentProcess)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOTransactionMaster)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOUMSDataLogging)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOUser3)
                .WithRequired(e => e.BOOrganizationCompany3)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOUser4)
                .WithOptional(e => e.BOOrganizationCompany4)
                .HasForeignKey(e => e.DefaultCCorPCCode);

           this
                .HasMany(e => e.BOUserLocationSitePermission)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOUserOrganizationCompanyPermission)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOUserOrganizationCompanyPermission1)
                .WithRequired(e => e.BOOrganizationCompany1)
                .HasForeignKey(e => e.OrganizationCompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOUserPartyOrCustomerPermission)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOUserProfileGroup)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOUserSystemOrWebPermission)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOUserVendorOrSupplierPermission)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOVendorOrSupplier)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOVoucherType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

           this
                .HasMany(e => e.BOEmployeeAcademic)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOEmployeeEmployment)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
               .HasMany(e => e.BOEmployeeFamily)
               .WithRequired(e => e.BOOrganizationCompany)
               .HasForeignKey(e => e.CompanyCode)
               .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOOpportunity)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOOpportunity1)
                .WithRequired(e => e.BOOrganizationCompany1)
                .HasForeignKey(e => e.ProfitCenterCode)
                .WillCascadeOnDelete(false);

           this
               .HasMany(e => e.BOPartyOrCustomer)
               .WithRequired(e => e.BOOrganizationCompany)
               .HasForeignKey(e => e.CompanyCode)
               .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOGRNandReturn)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
         .HasMany(e => e.BOGRNandReturnDetail)
         .WithRequired(e => e.BOOrganizationCompany)
         .HasForeignKey(e => e.CompanyCode)
         .WillCascadeOnDelete(false);

           this
               .HasMany(e => e.BOItemDealAssignment)
               .WithRequired(e => e.BOOrganizationCompany1)
               .HasForeignKey(e => e.PcOCcCode)
               .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOTable)
            .WithRequired(e => e.BOOrganizationCompany)
            .HasForeignKey(e => e.PcOrCcCode)
            .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOReligion)
            .WithRequired(e => e.BOOrganizationCompany)
            .HasForeignKey(e => e.CompanyCode)
            .WillCascadeOnDelete(false);

           this
               .HasMany(e => e.BOSeparationChecklistSetup)
               .WithRequired(e => e.BOOrganizationCompany)
               .HasForeignKey(e => e.CompanyCode)
               .WillCascadeOnDelete(false);

           this
              .HasMany(e => e.BOSeparationSubmission)
              .WithRequired(e => e.BOOrganizationCompany)
              .HasForeignKey(e => e.CompanyCode)
              .WillCascadeOnDelete(false);

           this
              .HasMany(e => e.BOSeparationTypeOrReason)
              .WithRequired(e => e.BOOrganizationCompany)
              .HasForeignKey(e => e.CompanyCode)
              .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOBonusType)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
              .HasMany(e => e.BOBonusProcess)
              .WithRequired(e => e.BOOrganizationCompany)
              .HasForeignKey(e => e.CompanyCode)
              .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOBonusPolicy)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
           .HasMany(e => e.BOBonusAllowancesMapping)
           .WithRequired(e => e.BOOrganizationCompany)
           .HasForeignKey(e => e.CompanyCode)
           .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOPayGradeBonusAllocation)
            .WithRequired(e => e.BOOrganizationCompany)
            .HasForeignKey(e => e.CompanyCode)
            .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOFieldExpensePolicyDetail)
            .WithRequired(e => e.BOOrganizationCompany)
            .HasForeignKey(e => e.CompanyCode)
            .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOFieldExpensePolicy)
            .WithRequired(e => e.BOOrganizationCompany)
            .HasForeignKey(e => e.CompanyCode)
            .WillCascadeOnDelete(false);

           this
           .HasMany(e => e.BOExpensePayment)
           .WithRequired(e => e.BOOrganizationCompany)
           .HasForeignKey(e => e.CompanyCode)
           .WillCascadeOnDelete(false);

           this
         .HasMany(e => e.BOExpenseClaim)
         .WithRequired(e => e.BOOrganizationCompany)
         .HasForeignKey(e => e.CompanyCode)
         .WillCascadeOnDelete(false);

           this
               .HasMany(e => e.BOExpenseClaimDetails)
               .WithRequired(e => e.BOOrganizationCompany)
               .HasForeignKey(e => e.CompanyCode)
               .WillCascadeOnDelete(false);

           this
              .HasMany(e => e.BOFieldExpenseType)
              .WithRequired(e => e.BOOrganizationCompany)
              .HasForeignKey(e => e.CompanyCode)
              .WillCascadeOnDelete(false);

           this
              .HasMany(e => e.BOLeaveYearEndProcess)
              .WithRequired(e => e.BOOrganizationCompany)
              .HasForeignKey(e => e.CompanyCode)
              .WillCascadeOnDelete(false);

           this
              .HasMany(e => e.BOLeaveYearEndProcess1)
              .WithRequired(e => e.BOOrganizationCompany1)
              .HasForeignKey(e => e.CompanyID)
              .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOLeaveEncashmentProcess)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOEmployeeDocuments)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOEmployeeGeoRestrictions)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOEmployeeOvertimeProcess)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOSaleOrderDetail)
            .WithRequired(e => e.BOOrganizationCompany)
            .HasForeignKey(e => e.CompanyCode)
            .WillCascadeOnDelete(false);

           this
           .HasMany(e => e.BOSaleOrderMaster1)
           .WithOptional(e => e.BOOrganizationCompany1)
           .HasForeignKey(e => e.ProfitOrCostCenterCode)
           .WillCascadeOnDelete(false);

           this
           .HasMany(e => e.BOSaleOrderMaster)
           .WithRequired(e => e.BOOrganizationCompany)
           .HasForeignKey(e => e.CompanyCode)
           .WillCascadeOnDelete(false);

           this
          .HasMany(e => e.BODeliveryNoteMaster1)
          .WithOptional(e => e.BOOrganizationCompany1)
          .HasForeignKey(e => e.ProfitOrCostCenterCode)
          .WillCascadeOnDelete(false);

           this
           .HasMany(e => e.BODeliveryNoteMaster)
           .WithRequired(e => e.BOOrganizationCompany)
           .HasForeignKey(e => e.CompanyCode)
           .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BODeliveryNoteDetail)
            .WithRequired(e => e.BOOrganizationCompany)
            .HasForeignKey(e => e.CompanyCode)
            .WillCascadeOnDelete(false);

           this
               .HasMany(e => e.BOSeparationCheckList)
               .WithRequired(e => e.BOOrganizationCompany)
               .HasForeignKey(e => e.CompanyCode)
               .WillCascadeOnDelete(false);

           this
               .HasMany(e => e.BOIncomeTaxSlabDetail)
               .WithRequired(e => e.BOOrganizationCompany)
               .HasForeignKey(e => e.CompanyCode)
               .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOCustomerAdjustment1)
            .WithOptional(e => e.BOOrganizationCompany1)
            .HasForeignKey(e => e.ProfitOrCostCenterCode)
            .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOCustomerAdjustment)
            .WithRequired(e => e.BOOrganizationCompany)
            .HasForeignKey(e => e.CompanyCode)
            .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOCustomerReceipt1)
            .WithOptional(e => e.BOOrganizationCompany1)
            .HasForeignKey(e => e.ProfitOrCostCenterCode)
            .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOCustomerReceipt)
            .WithRequired(e => e.BOOrganizationCompany)
            .HasForeignKey(e => e.CompanyCode)
            .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOFreightEntrySlip)
            .WithRequired(e => e.BOOrganizationCompany)
            .HasForeignKey(e => e.CompanyCode)
            .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOVendorAdjustment)
            .WithRequired(e => e.BOOrganizationCompany)
            .HasForeignKey(e => e.CompanyCode)
            .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOCommissionBooking)
            .WithRequired(e => e.BOOrganizationCompany)
            .HasForeignKey(e => e.CompanyCode)
            .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOPurchaseInvoiceMaster)
            .WithRequired(e => e.BOOrganizationCompany)
            .HasForeignKey(e => e.CompanyCode)
            .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOPurchaseInvoiceDetail)
            .WithRequired(e => e.BOOrganizationCompany)
            .HasForeignKey(e => e.CompanyCode)
            .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOVendorPayment)
            .WithRequired(e => e.BOOrganizationCompany)
            .HasForeignKey(e => e.CompanyCode)
            .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOCommissionReceiptInvoiceMapping)
            .WithRequired(e => e.BOOrganizationCompany)
            .HasForeignKey(e => e.CompanyCode)
            .WillCascadeOnDelete(false);

           this
           .HasMany(e => e.BOCustomerReceiptInvoiceMapping)
           .WithRequired(e => e.BOOrganizationCompany)
           .HasForeignKey(e => e.CompanyCode)
           .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOCustomerAdjustmentInvoiceMapping)
            .WithRequired(e => e.BOOrganizationCompany)
            .HasForeignKey(e => e.CompanyCode)
            .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOVendorPaymentInvoiceMapping)
            .WithRequired(e => e.BOOrganizationCompany)
            .HasForeignKey(e => e.CompanyCode)
            .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOCommissionReceipt)
            .WithRequired(e => e.BOOrganizationCompany)
            .HasForeignKey(e => e.CompanyCode)
            .WillCascadeOnDelete(false);

           this
           .HasMany(e => e.BOIMMFinishTypeOptions)
           .WithRequired(e => e.BOOrganizationCompany)
           .HasForeignKey(e => e.CompanyCode)
           .WillCascadeOnDelete(false);

           this
           .HasMany(e => e.BOVendorAdjustmentInvoiceMapping)
           .WithRequired(e => e.BOOrganizationCompany)
           .HasForeignKey(e => e.CompanyCode)
           .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOItemImages)
            .WithRequired(e => e.BOOrganizationCompany)
            .HasForeignKey(e => e.CompanyCode)
            .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOLocationSiteWiseItem)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOCafeOrRestaurantConfiguration)
            .WithRequired(e => e.BOOrganizationCompany)
            .HasForeignKey(e => e.CompanyCode)
            .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOSlipNotes)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOEmployeeTrackingConfiguration)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOEmployeeTrackingDetail)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOHoldBillOrInvoiceMaster)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOHoldBillOrInvoiceMasterDetail)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOItemProfileBarCode)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOSMSOrEmailDescription)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOSMSOrEmailOperationsOrBehaviour)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOSMSOrEmailTags)
            .WithRequired(e => e.BOOrganizationCompany)
            .HasForeignKey(e => e.CompanyCode)
            .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOItemDefinition)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOSubjectToDeliver)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOPerformanceGoal)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOTravellingMedium)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOTravelRequest)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOTravelRequestDetails)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOEmployeeGoalAssignment)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOLocationWiseSMSInfo)
            .WithRequired(e => e.BOOrganizationCompany)
            .HasForeignKey(e => e.CompanyCode)
            .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOEmailTemplateAssignment)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOCustomerGroupOrTag)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOCustomerGroupOrTagCustomerAssignment)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOCustomerGroupOrTagUserAssignment)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOEmailAccounts)
            .WithRequired(e => e.BOOrganizationCompany)
            .HasForeignKey(e => e.CompanyCode)
            .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOUserEmailAssignment)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOUserEmailLog)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOEquipmentIssuedOrReturn)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BODutyRoster)
            .WithRequired(e => e.BOOrganizationCompany)
            .HasForeignKey(e => e.CompanyCode)
            .WillCascadeOnDelete(false);

           this
            .HasMany(e => e.BOEmployeeSalaryLoanLease)
            .WithRequired(e => e.BOOrganizationCompany)
            .HasForeignKey(e => e.CompanyCode)
            .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BORequestTaxCertificate)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOEmployeeManualOvertime)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOEmployeeManualAllowanceOrBenefit)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOQuotationTemplate)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOQuotationParameter)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOQuotationParameterMapping)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
                         .HasMany(e => e.BOGenerateQuotation)
                         .WithRequired(e => e.BOOrganizationCompany)
                         .HasForeignKey(e => e.CompanyCode)
                         .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOGenerateQuotationDetail)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOQuotationParameterItemDetail)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOPartyOrCustomerPlan)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOEmployeeLockedAttendanceDetails)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOEmployeeLoanPayment)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOPayrollInputMaster)
             .WithRequired(e => e.BOOrganizationCompany)
             .HasForeignKey(e => e.CompanyCode)
             .WillCascadeOnDelete(false);
        }
    }
}

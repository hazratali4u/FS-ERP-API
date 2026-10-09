using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using FS.ERP.Models.BO;
using FS.ERP.Models.IdentityModel;
using Microsoft.AspNet.Identity.EntityFramework;
using FS.ERP.EF.Configuration.AppCNF;
using FS.ERP.EF.Configuration.HRM;

namespace FS.ERP.EF.Db_Context
{
    public partial class FsERP_Context : IdentityDbContext<BOUser, ApplicationRole, int, ApplicationUserLogin, ApplicationUserRole, ApplicationUserClaim>
    {
        public FsERP_Context(string connectionString) : this(connectionString, false, false) { }

        public FsERP_Context(string connectionString, bool lazyLoading = true, bool proxyCreation = true)
            : base(connectionString)
        {
            this.Configuration.LazyLoadingEnabled = lazyLoading;
            this.Configuration.ProxyCreationEnabled = proxyCreation;
            this.RequireUniqueEmail = true;
            this.Database.CommandTimeout = 180;
        }

        #region Other Developers
        public DbSet<ApplicationUserRole> UserRole { get; set; }
        public DbSet<ApplicationUserLogin> UserLogin { get; set; }
        public DbSet<ApplicationUserClaim> UserClaim { get; set; }

        public virtual DbSet<BOAllowanceOrBenefitType> BOAllowanceOrBenefitType { get; set; }
        public virtual DbSet<BOEmployeeIncomeTax> BOEmployeeIncomeTax { get; set; }
        public virtual DbSet<BOAppConfiguration> BOAppConfiguration { get; set; }
        public virtual DbSet<BOAppConfigurationDetail> BOAppConfigurationDetail { get; set; }
        public virtual DbSet<BOApprovalAuthorityType> BOApprovalAuthorityType { get; set; }
        public virtual DbSet<BOAttendanceMachineType> BOAttendanceMachineType { get; set; }
        public virtual DbSet<BOBillOrInvoiceType> BOBillOrInvoiceType { get; set; }
        public virtual DbSet<BOCulture> BOCulture { get; set; }
        public virtual DbSet<BOCurrency> BOCurrency { get; set; }
        public virtual DbSet<BODataType> BODataType { get; set; }
        public virtual DbSet<BODiscrepancyType> BODiscrepancyType { get; set; }
        public virtual DbSet<BODomainType> BODomainType { get; set; }
        public virtual DbSet<BOEmployeeRelation> BOEmployeeRelation { get; set; }
        public virtual DbSet<BOEquipmentStatus> BOEquipmentStatus { get; set; }
        public virtual DbSet<BOEquipmentType> BOEquipmentType { get; set; }
        public virtual DbSet<BOExpenseType> BOExpenseType { get; set; }
        public virtual DbSet<BOIMMAcquireType> BOIMMAcquireType { get; set; }
        public virtual DbSet<BOIMMGender> BOIMMGender { get; set; }
        public virtual DbSet<BOIMMGroup> BOIMMGroup { get; set; }
        public virtual DbSet<BOIMMLifeType> BOIMMLifeType { get; set; }
        public virtual DbSet<BOIMMManufacturedBy> BOIMMManufacturedBy { get; set; }
        public virtual DbSet<BOIMMTaxGroup> BOIMMTaxGroup { get; set; }
        public virtual DbSet<BOIMMTaxGroupDetail> BOIMMTaxGroupDetail { get; set; }
        public virtual DbSet<BOIMMTransactionMethod> BOIMMTransactionMethod { get; set; }
        public virtual DbSet<BOIncomeTaxSlab> BOIncomeTaxSlab { get; set; }
        public virtual DbSet<BOInstrumentStatus> BOInstrumentStatus { get; set; }
        public virtual DbSet<BOInstrumentType> BOInstrumentType { get; set; }
        public virtual DbSet<BOLeaseType> BOLeaseType { get; set; }
        public virtual DbSet<BOLoanType> BOLoanType { get; set; }
        public virtual DbSet<BOLocationSite> BOLocationSite { get; set; }
        public virtual DbSet<BOLocationSiteType> BOLocationSiteType { get; set; }
        public virtual DbSet<BOOnwerShipType> BOOnwerShipType { get; set; }
        public virtual DbSet<BOOrganizationCompany> BOOrganizationCompany { get; set; }
        public virtual DbSet<BOPackingType> BOPackingType { get; set; }
        public virtual DbSet<BOPaymentMode> BOPaymentMode { get; set; }
        public virtual DbSet<BOPriority> BOPriority { get; set; }
        public virtual DbSet<BOProcessApprovalWorkflow> BOProcessApprovalWorkflow { get; set; }
        public virtual DbSet<BORebateType> BORebateType { get; set; }
        public virtual DbSet<BORecordStatus> BORecordStatus { get; set; }
        public virtual DbSet<BOReimbursementType> BOReimbursementType { get; set; }
        public virtual DbSet<BOSalaryBreakUpPolicy> BOSalaryBreakUpPolicy { get; set; }
        public virtual DbSet<BOSalaryBreakUpPolicyDetail> BOSalaryBreakUpPolicyDetail { get; set; }
        public virtual DbSet<BOSalaryTransferMode> BOSalaryTransferMode { get; set; }
        public virtual DbSet<BOTaxAdjustmentType> BOTaxAdjustmentType { get; set; }
        public virtual DbSet<BOTransactionDocumentConfiguration> BOTransactionDocumentConfiguration { get; set; }
        public virtual DbSet<BOTransactionDocumentProcess> BOTransactionDocumentProcess { get; set; }
        public virtual DbSet<BOUOM> BOUOM { get; set; }
        public virtual DbSet<BOEquipment> BOEquipment { get; set; }
        public virtual DbSet<BOActionLogging> BOActionLogging { get; set; }
        public virtual DbSet<BOAPPCNFDataLogging> BOAPPCNFDataLogging { get; set; }
        public virtual DbSet<BOCRMDataLogging> BOCRMDataLogging { get; set; }
        public virtual DbSet<BOErrorLogging> BOErrorLogging { get; set; }
        public virtual DbSet<BOFICODataLogging> BOFICODataLogging { get; set; }
        public virtual DbSet<BOHRMDataLogging> BOHRMDataLogging { get; set; }
        public virtual DbSet<BOIMMDataLogging> BOIMMDataLogging { get; set; }
        public virtual DbSet<BOLoggingInformation> BOLoggingInformation { get; set; }
        public virtual DbSet<BOLoginAttempts> BOLoginAttempts { get; set; }
        public virtual DbSet<BOSRMDataLogging> BOSRMDataLogging { get; set; }
        public virtual DbSet<BOUMSDataLogging> BOUMSDataLogging { get; set; }
        public virtual DbSet<BOPartyOrCustomer> BOPartyOrCustomer { get; set; }
        public virtual DbSet<BOBank> BOBank { get; set; }
        public virtual DbSet<BOBankAccount> BOBankAccount { get; set; }
        public virtual DbSet<BOBankAccountInstrumentInfo> BOBankAccountInstrumentInfo { get; set; }
        public virtual DbSet<BOBankBranch> BOBankBranch { get; set; }
        public virtual DbSet<BOBillOrInvoiceMaster> BOBillOrInvoiceMaster { get; set; }
        public virtual DbSet<BOBillOrInvoiceMasterDetail> BOBillOrInvoiceMasterDetail { get; set; }
        public virtual DbSet<BOCOA> BOCOA { get; set; }
        public virtual DbSet<BOCOAConfiguration> BOCOAConfiguration { get; set; }
        public virtual DbSet<BOCOAMapping> BOCOAMapping { get; set; }
        public virtual DbSet<BOCOAMappingForPCorCC> BOCOAMappingForPCorCC { get; set; }
        public virtual DbSet<BOCOANature> BOCOANature { get; set; }
        public virtual DbSet<BOCOAAsset> BOCOAAsset { get; set; }
        public virtual DbSet<BODocumentDetailOfStatement> BODocumentDetailOfStatement { get; set; }
        public virtual DbSet<BODocumentOfStatement> BODocumentOfStatement { get; set; }
        public virtual DbSet<BODomainOfStatement> BODomainOfStatement { get; set; }
        public virtual DbSet<BOFiscalYear> BOFiscalYear { get; set; }
        public virtual DbSet<BOFiscalYearMonth> BOFiscalYearMonth { get; set; }
        public virtual DbSet<BOFiscalYearMonthDetail> BOFiscalYearMonthDetail { get; set; }
        public virtual DbSet<BOJobProjectScheme> BOJobProjectScheme { get; set; }
        public virtual DbSet<BOJobProjectSchemeDetail> BOJobProjectSchemeDetail { get; set; }
        public virtual DbSet<BOLinkToTransaction> BOLinkToTransaction { get; set; }
        public virtual DbSet<BORemittanceAdvice> BORemittanceAdvice { get; set; }
        public virtual DbSet<BORemittanceAdviceDetail> BORemittanceAdviceDetail { get; set; }
        public virtual DbSet<BOTransactionDetail> BOTransactionDetail { get; set; }
        public virtual DbSet<BOTransactionMaster> BOTransactionMaster { get; set; }
        public virtual DbSet<BOVoucherType> BOVoucherType { get; set; }
        public virtual DbSet<BOAreaOfDistrictWard> BOAreaOfDistrictWard { get; set; }
        public virtual DbSet<BOCityTown> BOCityTown { get; set; }
        public virtual DbSet<BOCountryRegion> BOCountryRegion { get; set; }
        public virtual DbSet<BODistrictWard> BODistrictWard { get; set; }
        public virtual DbSet<BOSectorZone> BOSectorZone { get; set; }
        public virtual DbSet<BOStateProvince> BOStateProvince { get; set; }
        public virtual DbSet<BODeductionType> BODeductionType { get; set; }
        public virtual DbSet<BOAllowancesOrBenefit> BOAllowancesOrBenefit { get; set; }
        public virtual DbSet<BOAttendanceDiscrepancy> BOAttendanceDiscrepancy { get; set; }
        public virtual DbSet<BOCalendar> BOCalendar { get; set; }
        public virtual DbSet<BODegree> BODegree { get; set; }
        public virtual DbSet<BODegreeInstitute> BODegreeInstitute { get; set; }
        public virtual DbSet<BODepartment> BODepartment { get; set; }
        public virtual DbSet<BODesignation> BODesignation { get; set; }
        public virtual DbSet<BODocumentCheckList> BODocumentCheckList { get; set; }
        public virtual DbSet<BOEmpDocumentCheckList> BOEmpDocumentCheckList { get; set; }
        public virtual DbSet<BOEmployeeAcademic> BOEmployeeAcademic { get; set; }
        public virtual DbSet<BOEmployeeAllowanceOrBenefit> BOEmployeeAllowanceOrBenefit { get; set; }
        public virtual DbSet<BOEmployeeAttendance> BOEmployeeAttendance { get; set; }
        public virtual DbSet<BOEmployeeEmployment> BOEmployeeEmployment { get; set; }
        public virtual DbSet<BOEmployeeFaceOrBiometric> BOEmployeeFaceOrBiometric { get; set; }
        public virtual DbSet<BOEmployeeFamily> BOEmployeeFamily { get; set; }
        public virtual DbSet<BOEmployeeIncrement> BOEmployeeIncrement { get; set; }
        public virtual DbSet<BOEmployeeIncrementAllowanceOrBenefit> BOEmployeeIncrementAllowanceOrBenefit { get; set; }
        public virtual DbSet<BOEmployeeInfo> BOEmployeeInfo { get; set; }
        public virtual DbSet<BOEmployeeInfoHistory> BOEmployeeInfoHistory { get; set; }
        public virtual DbSet<BOEmployeeInfoRevision> BOEmployeeInfoRevision { get; set; }
        public virtual DbSet<BOEmployeeLease> BOEmployeeLease { get; set; }
        public virtual DbSet<BOEmployeeLeaseInstallment> BOEmployeeLeaseInstallment { get; set; }
        public virtual DbSet<BOEmployeeLeave> BOEmployeeLeave { get; set; }
        public virtual DbSet<BOEmployeeLeaveBalance> BOEmployeeLeaveBalance { get; set; }
        public virtual DbSet<BOEmployeeLoan> BOEmployeeLoan { get; set; }
        public virtual DbSet<BOEmployeeLoanInstallment> BOEmployeeLoanInstallment { get; set; }
        public virtual DbSet<BOEmployeeReference> BOEmployeeReference { get; set; }
        public virtual DbSet<BOEmployeeSalary> BOEmployeeSalary { get; set; }
        public virtual DbSet<BOEmployeeSalaryDeduction> BOEmployeeSalaryDeduction { get; set; }
        public virtual DbSet<BOEmployeeSalaryAllowanceOrBenefit> BOEmployeeSalaryAllowanceOrBenefit { get; set; }
        public virtual DbSet<BOEmployeeSalaryReimbursement> BOEmployeeSalaryReimbursement { get; set; }
        public virtual DbSet<BOEmployeeStatus> BOEmployeeStatus { get; set; }
        public virtual DbSet<BOFundDemandRegister> BOFundDemandRegister { get; set; }
        public virtual DbSet<BOFundDemandRegisterDetail> BOFundDemandRegisterDetail { get; set; }
        public virtual DbSet<BOFundDemandRequest> BOFundDemandRequest { get; set; }
        public virtual DbSet<BOFundDemandRequestDetail> BOFundDemandRequestDetail { get; set; }
        public virtual DbSet<BOHireType> BOHireType { get; set; }
        public virtual DbSet<BOJobRole> BOJobRole { get; set; }
        public virtual DbSet<BOLeaveDeductionAgainstLate> BOLeaveDeductionAgainstLate { get; set; }
        public virtual DbSet<BOLeavePolicy> BOLeavePolicy { get; set; }
        public virtual DbSet<BOLeavePolicyDetail> BOLeavePolicyDetail { get; set; }
        public virtual DbSet<BOLeaveType> BOLeaveType { get; set; }
        public virtual DbSet<BOPayGrade> BOPayGrade { get; set; }
        public virtual DbSet<BOPayGradeAllowanceOrBenefit> BOPayGradeAllowanceOrBenefit { get; set; }
        public virtual DbSet<BOReimbursement> BOReimbursement { get; set; }
        public virtual DbSet<BOShift> BOShift { get; set; }
        public virtual DbSet<BOShiftDay> BOShiftDay { get; set; }
        public virtual DbSet<BOIMMConfiguration> BOIMMConfiguration { get; set; }
        public virtual DbSet<BOIMMSectionOrBrand> BOIMMSectionOrBrand { get; set; }
        public virtual DbSet<BOItem> BOItem { get; set; }
        public virtual DbSet<BOItemAspect> BOItemAspect { get; set; }
        public virtual DbSet<BOItemAspectDetail> BOItemAspectDetail { get; set; }
        public virtual DbSet<BOItemAttribute> BOItemAttribute { get; set; }
        public virtual DbSet<BOItemAttributeAspect> BOItemAttributeAspect { get; set; }
        public virtual DbSet<BOItemAttributeAspectDetail> BOItemAttributeAspectDetail { get; set; }
        public virtual DbSet<BOItemAttributeDetail> BOItemAttributeDetail { get; set; }
        public virtual DbSet<BOItemCategory> BOItemCategory { get; set; }
        public virtual DbSet<BOItemCategoryAttributeAspect> BOItemCategoryAttributeAspect { get; set; }
        public virtual DbSet<BOItemCategoryAttributeAspectDetail> BOItemCategoryAttributeAspectDetail { get; set; }
        public virtual DbSet<BOItemPrice> BOItemPrice { get; set; }
        public virtual DbSet<BOItemProfile> BOItemProfile { get; set; }
        public virtual DbSet<BOMenu> BOMenu { get; set; }
        public virtual DbSet<BOMenuControlInfo> BOMenuControlInfo { get; set; }
        public virtual DbSet<BOModuleColInfo> BOModuleColInfo { get; set; }
        public virtual DbSet<BOModuleParamInfo> BOModuleParamInfo { get; set; }
        public virtual DbSet<BOProfileGroup> BOProfileGroup { get; set; }
        public virtual DbSet<BOProfileGroupDetail> BOProfileGroupDetail { get; set; }
        public virtual DbSet<BOReportDashboardInfo> BOReportDashboardInfo { get; set; }
        public virtual DbSet<BOSecurityRight> BOSecurityRight { get; set; }
        public virtual DbSet<BOProcessApprovalAlert> BOProcessApprovalAlert { get; set; }

        public virtual DbSet<BOFlavor> BOFlavor { get; set; }

        public virtual DbSet<BOFlavorDetail> BOFlavorDetail { get; set; }

        //public virtual DbSet<Models.BO.IdentityRole> IdentityRoles { get; set; }
        //public virtual DbSet<Models.BO.IdentityUser> IdentityUsers { get; set; }
        //public virtual DbSet<Models.BO.IdentityUserClaim> IdentityUserClaims { get; set; }
        //public virtual DbSet<Models.BO.IdentityUserLogin> IdentityUserLogins { get; set; }
        //public virtual DbSet<IdentityUserProfile> IdentityUserProfiles { get; set; }
        //public virtual DbSet<IdentityUserRole> IdentityUserRoles { get; set; }

        public virtual DbSet<BOVendorOrSupplier> BOVendorOrSupplier { get; set; }
        public virtual DbSet<BOSystemOrWebPool> BOSystemOrWebPool { get; set; }

        //public virtual DbSet<BOUser> BOUser { get; set; }

        public virtual DbSet<BOUserLocationSitePermission> BOUserLocationSitePermission { get; set; }
        public virtual DbSet<BOUserOrganizationCompanyPermission> BOUserOrganizationCompanyPermission { get; set; }
        public virtual DbSet<BOUserPartyOrCustomerPermission> BOUserPartyOrCustomerPermission { get; set; }
        public virtual DbSet<BOUserProfileGroup> BOUserProfileGroup { get; set; }
        public virtual DbSet<BOUserSystemOrWebPermission> BOUserSystemOrWebPermission { get; set; }
        public virtual DbSet<BOUserVendorOrSupplierPermission> BOUserVendorOrSupplierPermission { get; set; }
        public virtual DbSet<BOStockTakingAdjustmentDetail> BOStockTakingAdjustmentDetail { get; set; }
        public virtual DbSet<BOStockTakingAdjustment> BOStockTakingAdjustment { get; set; }
        public virtual DbSet<BOStockRequisitionOrIssuanceDetail> BOStockRequisitionOrIssuanceDetail { get; set; }
        public virtual DbSet<BOStockRequisitionOrIssuance> BOStockRequisitionOrIssuance { get; set; }
        public virtual DbSet<BOPurchaseOrderAndReturnDetail> BOPurchaseOrderAndReturnDetail { get; set; }
        public virtual DbSet<BOPurchaseOrderAndReturn> BOPurchaseOrderAndReturn { get; set; }
        public virtual DbSet<BOGRNandReturnDetail> BOGRNandReturnDetail { get; set; }
        public virtual DbSet<BOGRNandReturn> BOGRNandReturn { get; set; }
        public virtual DbSet<BOGatePass> BOGatePass { get; set; }
        public virtual DbSet<BOGatePassDetail> BOGatePassDetail { get; set; }
        public virtual DbSet<BOIMMOrEquipmentCondition> BOIMMOrEquipmentCondition { get; set; }
        public virtual DbSet<BODispatchReceiveMedium> BODispatchReceiveMedium { get; set; }
        public virtual DbSet<BOCRMConfiguration> BOCRMConfiguration { get; set; }
        public virtual DbSet<BOLeadActivity> BOLeadActivity { get; set; }
        public virtual DbSet<BOLead> BOLead { get; set; }

        public virtual DbSet<BOContacts> BOContacts { get; set; }
        public virtual DbSet<BOOpportunity> BOOpportunity { get; set; }
        public virtual DbSet<BOPipeline> BOPipeline { get; set; }
        public virtual DbSet<BOPipelineDetail> BOPipelineDetail { get; set; }
        public virtual DbSet<BOTeamInfo> BOTeamInfo { get; set; }
        public virtual DbSet<BOTeamMembers> BOTeamMembers { get; set; }
        public virtual DbSet<BOTeamPermissions> BOTeamPermissions { get; set; }
        public virtual DbSet<BOCRMTeamRole> BOCRMTeamRole { get; set; }
        public virtual DbSet<BOCRMPermissionType> BOCRMPermissionType { get; set; }
        public virtual DbSet<BOVendorOrSupplierWiseItem> BOVendorOrSupplierWiseItem { get; set; }

        public virtual DbSet<BOIMMCheckList> BOIMMCheckList { get; set; }

        public virtual DbSet<BOItemOrProfileServiceType> BOItemOrProfileServiceType { get; set; }

        public virtual DbSet<BOServiceType> BOServiceType { get; set; }

        public virtual DbSet<BOPartyOrCustomerServiceType> BOPartyOrCustomerServiceType { get; set; }

        public virtual DbSet<BOProductionDetail> BOProductionDetail { get; set; }

        public virtual DbSet<BOProductionMaster> BOProductionMaster { get; set; }

        public virtual DbSet<BOReceipeDetail> BOReceipeDetail { get; set; }

        public virtual DbSet<BOReceipeMaster> BOReceipeMaster { get; set; }

        public virtual DbSet<BOVendorOrSupplierServiceType> BOVendorOrSupplierServiceType { get; set; }

        public virtual DbSet<BOItemDeal> BOItemDeal { get; set; }

        public virtual DbSet<BOItemDealAssignment> BOItemDealAssignment { get; set; }

        public virtual DbSet<BOItemDealDetail> BOItemDealDetail { get; set; }

        public virtual DbSet<BOItemModifier> BOItemModifier { get; set; }
        public virtual DbSet<BODocument> BODocument { get; set; }
        public virtual DbSet<BOMaritalStatus> BOMaritalStatus { get; set; }

        public virtual DbSet<BOAddition> BOAddition { get; set; }

        public virtual DbSet<BODeduction> BODeduction { get; set; }

        public virtual DbSet<BOEmployeeHistory> BOEmployeeHistory { get; set; }

        public virtual DbSet<BOBulletinCommunicationCategory> BOBulletinCommunicationCategory { get; set; }
        public virtual DbSet<BOLetterTemplates> BOLetterTemplates { get; set; }
        public virtual DbSet<BOGenerateLetter> BOGenerateLetter { get; set; }
        public virtual DbSet<BOBulletin> BOBulletin { get; set; }
        public virtual DbSet<BOMassCommunication> BOMassCommunication { get; set; }
        public virtual DbSet<BOLetterCode> BOLetterCode { get; set; }
        public virtual DbSet<BOIMMLoyaltyType> BOIMMLoyaltyType { get; set; }
        public virtual DbSet<BOLoyaltyCard> BOLoyaltyCard { get; set; }
        public virtual DbSet<BOLoyaltyPcOrCc> BOLoyaltyPcOrCc { get; set; }
        public virtual DbSet<BOPartyOrCustomerLoyalty> BOPartyOrCustomerLoyalty { get; set; }
        public virtual DbSet<BOOverTimeType> BOOverTimeType { get; set; }
        public virtual DbSet<BOLeavePolicyRule> BOLeavePolicyRule { get; set; }
        #endregion
        #region BY M. IJAZ JAMIL AKHTAR
        public virtual DbSet<BOPOSTableType> BOPOSTableType { get; set; }
        public virtual DbSet<BOTable> BOTable { get; set; }
        public virtual DbSet<BOPayGradeAssetsAllocation> BOPayGradeAssetsAllocation { get; set; }
        public virtual DbSet<BOPayGradeDeductionAllocation> BOPayGradeDeductionAllocation { get; set; }
        public virtual DbSet<BOPayGradeDocCheckListAllocation> BOPayGradeDocCheckListAllocation { get; set; }
        public virtual DbSet<BOPayGradeEarningsAllocation> BOPayGradeEarningsAllocation { get; set; }
        public virtual DbSet<BOPayGradeEOBIAllocation> BOPayGradeEOBIAllocation { get; set; }
        public virtual DbSet<BOPayGradeEOBIAllowanceDetail> BOPayGradeEOBIAllowanceDetail { get; set; }
        public virtual DbSet<BOPayGradeExpenseLimitAllocation> BOPayGradeExpenseLimitAllocation { get; set; }
        public virtual DbSet<BOPayGradeGratuityCriteria> BOPayGradeGratuityCriteria { get; set; }
        public virtual DbSet<BOPayGradePayrollGroup> BOPayGradePayrollGroup { get; set; }
        public virtual DbSet<BOPayrollGroup> BOPayrollGroup { get; set; }
        public virtual DbSet<BOPayGradeProvidentFundAllocation> BOPayGradeProvidentFundAllocation { get; set; }
        public virtual DbSet<BOPayGradeProvidentFundAllowanceDetail> BOPayGradeProvidentFundAllowanceDetail { get; set; }
        public virtual DbSet<BOEmployeeAward> BOEmployeeAward { get; set; }
        public virtual DbSet<BOEmployeeRelative> BOEmployeeRelative { get; set; }
        public virtual DbSet<BOIncidentType> BOIncidentType { get; set; }
        public virtual DbSet<BOEmployeeIncident> BOEmployeeIncident { get; set; }
        public virtual DbSet<BOEmployeeHiringReference> BOEmployeeHiringReference { get; set; }
        public virtual DbSet<BOEmployeePersonalAttribute> BOEmployeePersonalAttribute { get; set; }
        public virtual DbSet<BOEmployeeManagementRemarks> BOEmployeeManagementRemarks { get; set; }
        public virtual DbSet<BOShiftOverTimeCriteria> BOShiftOverTimeCriteria { get; set; }
        public virtual DbSet<BOIncomeTaxSlabDetail> BOIncomeTaxSlabDetail { get; set; }
        public virtual DbSet<BOSeparationCheckList> BOSeparationCheckList { get; set; }
        public virtual DbSet<BOSeparationChecklistSetup> BOSeparationChecklistSetup { get; set; }
        public virtual DbSet<BOSeparationSubmission> BOSeparationSubmission { get; set; }
        public virtual DbSet<BOSeparationTypeOrReason> BOSeparationTypeOrReason { get; set; }
        public virtual DbSet<BOBonusType> BOBonusType { get; set; }
        public virtual DbSet<BOBonusProcess> BOBonusProcess { get; set; }
        public virtual DbSet<BOBonusPolicy> BOBonusPolicy { get; set; }
        public virtual DbSet<BOBonusAllowancesMapping> BOBonusAllowancesMapping { get; set; }
        public virtual DbSet<BOPayGradeBonusAllocation> BOPayGradeBonusAllocation { get; set; }
        public virtual DbSet<BOFieldExpensePolicyDetail> BOFieldExpensePolicyDetail { get; set; }
        public virtual DbSet<BOFieldExpensePolicy> BOFieldExpensePolicy { get; set; }
        public virtual DbSet<BOExpensePayment> BOExpensePayment { get; set; }
        public virtual DbSet<BOExpenseClaim> BOExpenseClaim { get; set; }
        public virtual DbSet<BOExpenseClaimDetails> BOExpenseClaimDetails { get; set; }
        public virtual DbSet<BOFieldExpenseType> BOFieldExpenseType { get; set; }
        public virtual DbSet<BOLeaveYearEndProcess> BOLeaveYearEndProcess { get; set; }
        public virtual DbSet<BOLeaveEncashmentProcess> BOLeaveEncashmentProcess { get; set; }
        public virtual DbSet<BOEmployeeDocuments> BOEmployeeDocuments { get; set; }
        public virtual DbSet<BOReligion> BOReligion { get; set; }
        public virtual DbSet<BOEmployeeGeoRestrictions> BOEmployeeGeoRestrictions { get; set; }
        public virtual DbSet<BOIncrementOrDecrementType> BOIncrementOrDecrementType { get; set; }
        public virtual DbSet<BOIncrementOrDecrementRules> BOIncrementOrDecrementRules { get; set; }
        public virtual DbSet<BOEmployeeSalaryOverTime> BOEmployeeSalaryOverTime { get; set; }
        public virtual DbSet<BOEmployeeOvertimeProcess> BOEmployeeOvertimeProcess { get; set; }
        public virtual DbSet<BOSaleOrderDetail> BOSaleOrderDetail { get; set; }
        public virtual DbSet<BOSaleOrderMaster> BOSaleOrderMaster { get; set; }
        public virtual DbSet<BODeliveryNoteMaster> BODeliveryNoteMaster { get; set; }
        public virtual DbSet<BODeliveryNoteDetail> BODeliveryNoteDetail { get; set; }
        //public virtual DbSet<BOSaleInvoiceMaster> BOSaleInvoiceMaster { get; set; }
        //public virtual DbSet<BOSaleInvoiceDetail> BOSaleInvoiceDetail { get; set; }
        public virtual DbSet<BOCustomerAdjustment> BOCustomerAdjustment { get; set; }
        public virtual DbSet<BOCustomerReceipt> BOCustomerReceipt { get; set; }
        public virtual DbSet<BOFreightEntrySlip> BOFreightEntrySlip { get; set; }
        public virtual DbSet<BOVendorAdjustment> BOVendorAdjustment { get; set; }
        public virtual DbSet<BOCommissionBooking> BOCommissionBooking { get; set; }
        public virtual DbSet<BOCommissionReceipt> BOCommissionReceipt { get; set; }
        public virtual DbSet<BOPurchaseInvoiceMaster> BOPurchaseInvoiceMaster { get; set; }
        public virtual DbSet<BOPurchaseInvoiceDetail> BOPurchaseInvoiceDetail { get; set; }
        public virtual DbSet<BOVendorPayment> BOVendorPayment { get; set; }
        public virtual DbSet<BOCommissionReceiptInvoiceMapping> BOCommissionReceiptInvoiceMapping { get; set; }
        public virtual DbSet<BOCustomerReceiptInvoiceMapping> BOCustomerReceiptInvoiceMapping { get; set; }
        public virtual DbSet<BOCustomerAdjustmentInvoiceMapping> BOCustomerAdjustmentInvoiceMapping { get; set; }
        public virtual DbSet<BOVendorPaymentInvoiceMapping> BOVendorPaymentInvoiceMapping { get; set; }
        public virtual DbSet<BOIMMFinishTypeOptions> BOIMMFinishTypeOptions { get; set; }
        public virtual DbSet<BOVendorAdjustmentInvoiceMapping> BOVendorAdjustmentInvoiceMapping { get; set; }
        public virtual DbSet<BOPurchaseOrderAndReturnMapping> BOPurchaseOrderAndReturnMapping { get; set; }
        public virtual DbSet<BOItemImages> BOItemImages { get; set; }
        public virtual DbSet<BOLocationSiteWiseItem> BOLocationSiteWiseItem { get; set; }
        public virtual DbSet<BOCafeOrRestaurantConfiguration> BOCafeOrRestaurantConfiguration { get; set; }
        public virtual DbSet<BOSlipNotes> BOSlipNotes { get; set; }
        public virtual DbSet<BOEmployeeTrackingConfiguration> BOEmployeeTrackingConfiguration { get; set; }
        public virtual DbSet<BOHall> BOHall { get; set; }
        public virtual DbSet<BOHoldBillOrInvoiceMaster> BOHoldBillOrInvoiceMaster { get; set; }
        public virtual DbSet<BOHoldBillOrInvoiceMasterDetail> BOHoldBillOrInvoiceMasterDetail { get; set; }
        public virtual DbSet<BOLocationWiseSMSInfo> BOLocationWiseSMSInfo { get; set; }
        public virtual DbSet<BOItemProfileBarCode> BOItemProfileBarCode { get; set; }
        public virtual DbSet<BOSMSOrEmailDescription> BOSMSOrEmailDescription { get; set; }
        public virtual DbSet<BOSMSOrEmailOperationsOrBehaviour> BOSMSOrEmailOperationsOrBehaviour { get; set; }
        public virtual DbSet<BOSMSOrEmailTags> BOSMSOrEmailTags { get; set; }
        public virtual DbSet<BOItemDefinition> BOItemDefinition { get; set; }
        public virtual DbSet<BOSubjectToDeliver> BOSubjectToDeliver { get; set; }
        public virtual DbSet<BOPerformanceGoal> BOPerformanceGoal { get; set; }
        public virtual DbSet<BOTravellingMedium> BOTravellingMedium { get; set; }
        public virtual DbSet<BOTravelRequest> BOTravelRequest { get; set; }
        public virtual DbSet<BOTravelRequestDetails> BOTravelRequestDetails { get; set; }
        public virtual DbSet<BOEmployeeGoalAssignment> BOEmployeeGoalAssignment { get; set; }
        public virtual DbSet<BOEmailTemplateAssignment> BOEmailTemplateAssignment { get; set; }
        public virtual DbSet<BOCustomerGroupOrTag> BOCustomerGroupOrTag { get; set; }
        public virtual DbSet<BOCustomerGroupOrTagCustomerAssignment> BOCustomerGroupOrTagCustomerAssignment { get; set; }
        public virtual DbSet<BOCustomerGroupOrTagUserAssignment> BOCustomerGroupOrTagUserAssignment { get; set; }
        public virtual DbSet<BOEmailAccounts> BOEmailAccounts { get; set; }
        public virtual DbSet<BOUserEmailAssignment> BOUserEmailAssignment { get; set; }
        public virtual DbSet<BOUserEmailLog> BOUserEmailLog { get; set; }
        public virtual DbSet<BOEquipmentIssuedOrReturn> BOEquipmentIssuedOrReturn { get; set; }
        public virtual DbSet<BODutyRoster> BODutyRoster { get; set; }
        public virtual DbSet<BOEmployeeSalaryLoanLease> BOEmployeeSalaryLoanLease { get; set; }
        public virtual DbSet<BORequestTaxCertificate> BORequestTaxCertificate { get; set; }
        public virtual DbSet<BOEmployeeManualOvertime> BOEmployeeManualOvertime { get; set; }
        public virtual DbSet<BOQuotationTemplate> BOQuotationTemplate { get; set; }
        public virtual DbSet<BOQuotationParameter> BOQuotationParameter { get; set; }
        public virtual DbSet<BOQuotationParameterMapping> BOQuotationParameterMapping { get; set; }
        public virtual DbSet<BOGenerateQuotation> BOGenerateQuotation { get; set; }
        public virtual DbSet<BOGenerateQuotationDetail> BOGenerateQuotationDetail { get; set; }
        public virtual DbSet<BOQuotationParameterDetail> BOQuotationParameterDetail { get; set; }
        public virtual DbSet<BOQuotationParameterItemDetail> BOQuotationParameterItemDetail { get; set; }
        public virtual DbSet<BOPayrollCOAMapping> BOPayrollCOAMapping { get; set; }
        public virtual DbSet<BOPartyOrCustomerPlan> BOPartyOrCustomerPlan { get; set; }
        public virtual DbSet<BOEmployeeLockedAttendanceDetails> BOEmployeeLockedAttendanceDetails { get; set; }
        public virtual DbSet<BOEmployeeLoanPayment> BOEmployeeLoanPayment { get; set; }
        public virtual DbSet<BOPayrollInputMaster> BOPayrollInputMaster { get; set; }
        //public virtual DbSet<BOPayrollInputDetails> BOPayrollInputDetails { get; set; }
        public virtual DbSet<BOProductAssemblyMaster> BOProductAssemblyMaster { get; set; }
        public virtual DbSet<BOProductAssemblyDetail> BOProductAssemblyDetail { get; set; }
        public virtual DbSet<BOSalaryPayment> BOSalaryPayment { get; set; }
        public virtual DbSet<BOBudgetPlan> BOBudgetPlan { get; set; }
        public virtual DbSet<BONoteSheet> BONoteSheet { get; set; }
        public virtual DbSet<BONoteSheetRemarks> BONoteSheetRemarks { get; set; }
        public virtual DbSet<BOJobCard> BOJobCard { get; set; }
        public virtual DbSet<BOJobCardDetail> BOJobCardDetail { get; set; }
        public virtual DbSet<BOJobCardHistory> BOJobCardHistory { get; set; }
        public virtual DbSet<BOWorkFromHome> BOWorkFromHome { get; set; }

        #endregion
        public virtual DbSet<BORequestMissingAttendance> BORequestMissingAttendance { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Entity<BOUser>().ToTable("UMS.tbl_User");
            modelBuilder.Entity<ApplicationRole>().ToTable("security.IdentityRole");
            modelBuilder.Entity<ApplicationUserLogin>().ToTable("security.IdentityUserLogin");
            modelBuilder.Entity<ApplicationUserRole>().ToTable("security.IdentityUserRole");
            modelBuilder.Entity<ApplicationUserClaim>().ToTable("security.IdentityUserClaim");


            modelBuilder.Configurations.Add(new AppConfigConfiguration());
            modelBuilder.Configurations.Add(new AppConfigDetailConfiguration());
            modelBuilder.Configurations.Add(new DesignationConfiguration());
            modelBuilder.Configurations.Add(new AttendanceMachineTypeConfiguration());
            modelBuilder.Configurations.Add(new BillOrInvoiceTypeConfiguration());
            modelBuilder.Configurations.Add(new CultureConfiguration());
            modelBuilder.Configurations.Add(new CurrencyConfiguration());
            modelBuilder.Configurations.Add(new DataTypeConfiguration());
            modelBuilder.Configurations.Add(new DiscrepancyTypeConfiguration());
            modelBuilder.Configurations.Add(new DomainTypeConfiguration());
            modelBuilder.Configurations.Add(new EmployeeRelationConfiguration());
            modelBuilder.Configurations.Add(new EquipmentStatusConfiguration());
            modelBuilder.Configurations.Add(new EquipmentTypeConfiguration());
            modelBuilder.Configurations.Add(new ExpenseTypeConfiguration());
            modelBuilder.Configurations.Add(new AcquireTypeConfiguration());
            modelBuilder.Configurations.Add(new GenderConfiguration());
            modelBuilder.Configurations.Add(new IMMGroupConfiguration());
            modelBuilder.Configurations.Add(new IMMLifeTypeConfiguration());
            modelBuilder.Configurations.Add(new IMMManufacturedByConfiguration());
            modelBuilder.Configurations.Add(new IMMTaxGroupConfiguration());
            modelBuilder.Configurations.Add(new IMMTaxGroupDetailConfiguration());
            modelBuilder.Configurations.Add(new IMMTransactionMethodConfiguration());
            modelBuilder.Configurations.Add(new InstrumentStatusConfiguration());
            modelBuilder.Configurations.Add(new InstrumentTypeConfiguration());
            modelBuilder.Configurations.Add(new LeaseTypeConfiguration());
            modelBuilder.Configurations.Add(new LoanTypeConfiguration());
            modelBuilder.Configurations.Add(new LocationSiteConfiguration());
            modelBuilder.Configurations.Add(new LocationSiteTypeConfiguration());
            modelBuilder.Configurations.Add(new OwnerTypeConfiguration());
            modelBuilder.Configurations.Add(new OrganizationConfiguration());
            modelBuilder.Configurations.Add(new CustomerAdjustmentConfiguration());
            modelBuilder.Configurations.Add(new DeliveryNoteConfiguration());
            modelBuilder.Configurations.Add(new SaleOrderConfiguration());
            modelBuilder.Configurations.Add(new IncrementOrDecrementTypeConfiguration());
            modelBuilder.Configurations.Add(new PackingTypeConfiguration());
            modelBuilder.Configurations.Add(new RecordStatusConfiguration());
            modelBuilder.Configurations.Add(new EmployeeSalaryConfiguration());
            modelBuilder.Configurations.Add(new ReimbursementTypeConfiguration());
            modelBuilder.Configurations.Add(new SalaryBreakUpPolicyConfiguration());
            modelBuilder.Configurations.Add(new SalaryTransferModeConfiguration());
            modelBuilder.Configurations.Add(new TransactionDocumentConfigConfiguration());
            modelBuilder.Configurations.Add(new UOMConfiguration());
            modelBuilder.Configurations.Add(new EquipmentConfiguration());
            modelBuilder.Configurations.Add(new PartyOrCustomerConfiguration());
            modelBuilder.Configurations.Add(new BankConfiguration());
            modelBuilder.Configurations.Add(new BankAccountConfiguration());
            modelBuilder.Configurations.Add(new BankBranchConfiguration());
            modelBuilder.Configurations.Add(new BillOrInvoiceMasterConfiguration());
            modelBuilder.Configurations.Add(new BillOrInvoiceMasterDetailConfiguration());
            modelBuilder.Configurations.Add(new COAConfiguration());
            modelBuilder.Configurations.Add(new COAConfigConfiguration());
            modelBuilder.Configurations.Add(new COANatureConfiguration());
            modelBuilder.Configurations.Add(new TransactionDocumentProcessConfiguration());
            modelBuilder.Configurations.Add(new DocumentDetailOfStatementConfiguration());
            modelBuilder.Configurations.Add(new DocumentOfStatementConfiguration());
            modelBuilder.Configurations.Add(new FiscalYearConfiguration());
            modelBuilder.Configurations.Add(new FiscalYearMonthConfiguration());
            modelBuilder.Configurations.Add(new TransactionDetailConfiguration());
            modelBuilder.Configurations.Add(new TransactionMasterConfiguration());
            modelBuilder.Configurations.Add(new VoucherTypeConfiguration());
            modelBuilder.Configurations.Add(new CityTownConfiguration());
            modelBuilder.Configurations.Add(new CountryRegionConfiguration());
            modelBuilder.Configurations.Add(new DistrictWardConfiguration());
            modelBuilder.Configurations.Add(new SectorZoneConfiguration());
            modelBuilder.Configurations.Add(new StateProvinceConfiguration());
            modelBuilder.Configurations.Add(new DeductionTypeConfiguration());
            modelBuilder.Configurations.Add(new DegreeInstituteConfiguration());
            modelBuilder.Configurations.Add(new DepartmentConfiguration());
            modelBuilder.Configurations.Add(new DocumentCheckListConfiguration());
            modelBuilder.Configurations.Add(new EmployeeAllowanceOrBenefitConfiguration());
            modelBuilder.Configurations.Add(new TeamInfoConfiguration());
            modelBuilder.Configurations.Add(new ReligionConfiguration());
            modelBuilder.Configurations.Add(new EmployeeInfoConfiguration());
            modelBuilder.Configurations.Add(new EmployeeInfoHistoryConfiguration());
            modelBuilder.Configurations.Add(new EmployeeInfoRevisionConfiguration());
            modelBuilder.Configurations.Add(new EmployeeLeaseConfiguration());
            modelBuilder.Configurations.Add(new EmployeeLoanConfiguration());
            modelBuilder.Configurations.Add(new EmployeeStatusConfiguration());
            modelBuilder.Configurations.Add(new HireTypeConfiguration());
            modelBuilder.Configurations.Add(new JobRoleConfiguration());
            modelBuilder.Configurations.Add(new LeavePolicyConfiguration());
            modelBuilder.Configurations.Add(new LeavePolicyDetailConfiguration());
            modelBuilder.Configurations.Add(new LeaveTypeConfiguration());
            modelBuilder.Configurations.Add(new PayGradeConfiguration());
            modelBuilder.Configurations.Add(new AllowancesOrBenefitConfiguration());
            modelBuilder.Configurations.Add(new PayGradeAllowancesOrBenefitConfiguration());
            modelBuilder.Configurations.Add(new AllowanceOrBenefitTypeConfiguration());
            modelBuilder.Configurations.Add(new ShiftConfiguration());
            modelBuilder.Configurations.Add(new IMMConfigConfiguration());
            modelBuilder.Configurations.Add(new ItemConfiguration());
            modelBuilder.Configurations.Add(new ItemAttributeConfiguration());
            modelBuilder.Configurations.Add(new ItemAttributeAspectConfiguration());
            modelBuilder.Configurations.Add(new ItemAttributeDetailConfiguration());
            modelBuilder.Configurations.Add(new ItemCategoryConfiguration());
            modelBuilder.Configurations.Add(new ItemCategoryAttributeAspectConfiguration());
            modelBuilder.Configurations.Add(new ItemProfileConfiguration());
            modelBuilder.Configurations.Add(new MenuConfiguration());
            modelBuilder.Configurations.Add(new MenuControlInfoConfiguration());
            modelBuilder.Configurations.Add(new ModuleParamInfoConfiguration());
            modelBuilder.Configurations.Add(new ProfileGroupConfiguration());
            modelBuilder.Configurations.Add(new SecurityRightConfiguration());
            modelBuilder.Configurations.Add(new VendorOrSupplierConfiguration());
            modelBuilder.Configurations.Add(new CRMTeamRoleConfiguration());
            modelBuilder.Configurations.Add(new CRMPermissionTypeConfiguration());
            modelBuilder.Configurations.Add(new PipeLineConfiguration());
            modelBuilder.Configurations.Add(new CRMConfigConfiguration());
            modelBuilder.Configurations.Add(new LeadConfiguration());
            modelBuilder.Configurations.Add(new StockRequisitionOrIssuanceConfiguration());
            modelBuilder.Configurations.Add(new IMMOrEquipmentConditionConfiguration());
            modelBuilder.Configurations.Add(new ItemPriceConfiguration());
            modelBuilder.Configurations.Add(new StockRequisitionOrIssuanceDetailConfiguration());
            modelBuilder.Configurations.Add(new FlavorConfiguration());
            modelBuilder.Configurations.Add(new GatePassDetailConfiguration());
            modelBuilder.Configurations.Add(new GatePassConfiguration());
            modelBuilder.Configurations.Add(new DispatchReceiveMediumConfiguration());
            modelBuilder.Configurations.Add(new PaymentModeConfiguration());
            modelBuilder.Configurations.Add(new PurchaseOrderAndReturnDetailConfiguration());
            modelBuilder.Configurations.Add(new GRNandReturnDetail());
            modelBuilder.Configurations.Add(new GRNandReturn());
            modelBuilder.Configurations.Add(new GRNandReturnCheckList());
            modelBuilder.Configurations.Add(new ServiceTypeConfiguration());
            modelBuilder.Configurations.Add(new ReceipeMasterConfiguration());
            modelBuilder.Configurations.Add(new ProductionMasterConfiguration());
            modelBuilder.Configurations.Add(new ReceipeDetailConfiguration());
            modelBuilder.Configurations.Add(new IMMCheckListConfiguration());
            modelBuilder.Configurations.Add(new ItemDealConfiguration());
            modelBuilder.Configurations.Add(new ItemModifierConfiguration());
            modelBuilder.Configurations.Add(new MaritalStatusConfiguration());
            modelBuilder.Configurations.Add(new PurchaseOrderAndReturnConfiguration());
            modelBuilder.Configurations.Add(new EmployeeOverTimeConfiguration());
            modelBuilder.Configurations.Add(new LoyaltyTypeConfiguration());
            modelBuilder.Configurations.Add(new LoyaltyCardConfiguration());
            modelBuilder.Configurations.Add(new CalendarConfiguration());
            modelBuilder.Configurations.Add(new LetterTemplatesConfiguration());
            modelBuilder.Configurations.Add(new BulletinBoardConfiguration());
            modelBuilder.Configurations.Add(new PayGradeEOBIAllocationConfiguration());
            modelBuilder.Configurations.Add(new PayrollGroupConfiguration());
            modelBuilder.Configurations.Add(new PayGradeProvidentFundAllocationConfiguration());
            modelBuilder.Configurations.Add(new OvertimeTypeConfiguration());
            modelBuilder.Configurations.Add(new IncomeTaxSlabConfiguration());
            modelBuilder.Configurations.Add(new SeparationCheckListSetupConfiguration());
            modelBuilder.Configurations.Add(new SeparationTypeOrReasonConfiguration());
            modelBuilder.Configurations.Add(new BonusTypeConfiguration());
            modelBuilder.Configurations.Add(new FieldExpensePolicyConfiguration());
            modelBuilder.Configurations.Add(new ExpenseClaimConfiguration());
            modelBuilder.Configurations.Add(new VendorAdjustmentConfiguration());
            modelBuilder.Configurations.Add(new PurchaseInvoiceMasterConfiguration());
            modelBuilder.Configurations.Add(new BankAccountInstrumentInfoConfiguration());
            modelBuilder.Configurations.Add(new HoldBillOrInvoiceMasterConfiguration());
            modelBuilder.Configurations.Add(new SMSOrEmailOperationsOrBehaviourConfiguration());
            modelBuilder.Configurations.Add(new IMMFinishTypeOptionsConfiguration());
            modelBuilder.Configurations.Add(new TravelRequestConfiguration());
            modelBuilder.Configurations.Add(new TravelMediumConfiguration());
            modelBuilder.Configurations.Add(new PerformanceGoalConfiguration());
            modelBuilder.Configurations.Add(new QuotationParameterConfiguration());
            modelBuilder.Configurations.Add(new QuotationTemplateConfiguration());
            modelBuilder.Configurations.Add(new GenerateQuotationConfiguration());
            modelBuilder.Configurations.Add(new QuotationParameterMappingConfiguration());
            modelBuilder.Configurations.Add(new DegreeConfiguration());
            modelBuilder.Configurations.Add(new IncidentTypeConfiguration());
            modelBuilder.Configurations.Add(new ProductAssemblyMasterConfiguration());
            modelBuilder.Configurations.Add(new NoteSheetConfiguration());
            modelBuilder.Configurations.Add(new JobCardConfiguration());

            #region To be removed
            modelBuilder.Entity<BOPOSTableType>()
              .HasMany(e => e.BOTable)
              .WithRequired(e => e.BOPOSTableType)
              .HasForeignKey(e => e.TableTypeCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOSystemOrWebPool>()
                .HasMany(e => e.BOUserSystemOrWebPermission)
                .WithRequired(e => e.BOSystemOrWebPool)
                .HasForeignKey(e => e.SystemOrWebCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOItemAspect>()
                .HasMany(e => e.BOItemAspectDetail)
                .WithRequired(e => e.BOItemAspect)
                .HasForeignKey(e => e.ItemAspectCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOItemAspect>()
                .HasMany(e => e.BOItemAttributeAspect)
                .WithOptional(e => e.BOItemAspect)
                .HasForeignKey(e => e.ItemAspectCode);

            modelBuilder.Entity<BOItemAspect>()
                .HasMany(e => e.BOItemCategoryAttributeAspect)
                .WithOptional(e => e.BOItemAspect)
                .HasForeignKey(e => e.ItemAspectCode);

            modelBuilder.Entity<BOItemAspectDetail>()
                .HasMany(e => e.BOItemAttributeAspectDetail)
                .WithOptional(e => e.BOItemAspectDetail)
                .HasForeignKey(e => e.ItemAspectDetailCode);

            modelBuilder.Entity<BOItemAspectDetail>()
                .HasMany(e => e.BOItemCategoryAttributeAspectDetail)
                .WithOptional(e => e.BOItemAspectDetail)
                .HasForeignKey(e => e.ItemAspectDetailCode);

            modelBuilder.Entity<BOReimbursement>()
                .Property(e => e.ActualAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOReimbursement>()
                .Property(e => e.TransactionAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOReimbursement>()
                .HasMany(e => e.BOEmployeeSalaryReimbursement)
                .WithRequired(e => e.BOReimbursement)
                .HasForeignKey(e => e.ReimbursementCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BODomainOfStatement>()
                .HasMany(e => e.BODocumentDetailOfStatement)
                .WithRequired(e => e.BODomainOfStatement)
                .HasForeignKey(e => e.DomainOfStatementCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BODomainOfStatement>()
                .HasMany(e => e.BOFiscalYearMonthDetail)
                .WithOptional(e => e.BODomainOfStatement)
                .HasForeignKey(e => e.DomainofStatementCode);

            modelBuilder.Entity<BOJobProjectScheme>()
                .Property(e => e.ExpectedCost)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOJobProjectScheme>()
                .Property(e => e.ActualCost)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOJobProjectScheme>()
                .HasMany(e => e.BOBillOrInvoiceMasterDetail)
                .WithOptional(e => e.BOJobProjectScheme)
                .HasForeignKey(e => e.JobProjectSchemeCode);

            modelBuilder.Entity<BOJobProjectScheme>()
                .HasMany(e => e.BOFundDemandRegisterDetail)
                .WithOptional(e => e.BOJobProjectScheme)
                .HasForeignKey(e => e.JobProjectSchemeCode);

            modelBuilder.Entity<BOJobProjectScheme>()
                .HasMany(e => e.BOFundDemandRequestDetail)
                .WithOptional(e => e.BOJobProjectScheme)
                .HasForeignKey(e => e.JobProjectSchemeCode);

            modelBuilder.Entity<BOJobProjectScheme>()
                .HasMany(e => e.BOJobProjectSchemeDetail)
                .WithRequired(e => e.BOJobProjectScheme)
                .HasForeignKey(e => e.JobProjectSchemeCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOJobProjectScheme>()
                .HasMany(e => e.BORemittanceAdviceDetail)
                .WithOptional(e => e.BOJobProjectScheme)
                .HasForeignKey(e => e.JobProjectSchemeCode);

            modelBuilder.Entity<BOJobProjectScheme>()
                .HasMany(e => e.BOTransactionDetail)
                .WithOptional(e => e.BOJobProjectScheme)
                .HasForeignKey(e => e.JobProjectSchemeCode);

            modelBuilder.Entity<BOJobProjectSchemeDetail>()
                .Property(e => e.Qty)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOJobProjectSchemeDetail>()
                .Property(e => e.Weight)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOJobProjectSchemeDetail>()
                .Property(e => e.Length)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOJobProjectSchemeDetail>()
                .Property(e => e.Heigth)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOJobProjectSchemeDetail>()
                .Property(e => e.Width)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOJobProjectSchemeDetail>()
                .HasMany(e => e.BOBillOrInvoiceMasterDetail)
                .WithOptional(e => e.BOJobProjectSchemeDetail)
                .HasForeignKey(e => e.JobProjectSchemeDetailCode);

            modelBuilder.Entity<BOJobProjectSchemeDetail>()
                .HasMany(e => e.BORemittanceAdviceDetail)
                .WithOptional(e => e.BOJobProjectSchemeDetail)
                .HasForeignKey(e => e.JobProjectSchemeDetailCode);

            modelBuilder.Entity<BOJobProjectSchemeDetail>()
                .HasMany(e => e.BOTransactionDetail)
                .WithOptional(e => e.BOJobProjectSchemeDetail)
                .HasForeignKey(e => e.JobProjectSchemeDetailCode);

            modelBuilder.Entity<BORemittanceAdvice>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BORemittanceAdvice>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BORemittanceAdvice>()
                .Property(e => e.GSTAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BORemittanceAdvice>()
                .Property(e => e.WHTAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BORemittanceAdvice>()
                .Property(e => e.OtherTaxAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BORemittanceAdvice>()
                .Property(e => e.RemmittaceAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BORemittanceAdvice>()
                .HasMany(e => e.BOBillOrInvoiceMaster)
                .WithOptional(e => e.BORemittanceAdvice)
                .HasForeignKey(e => e.RemittanceAdviceCode);

            modelBuilder.Entity<BORemittanceAdvice>()
                .HasMany(e => e.BORemittanceAdviceDetail)
                .WithRequired(e => e.BORemittanceAdvice)
                .HasForeignKey(e => e.RemittanceCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORemittanceAdvice>()
                .HasMany(e => e.BOTransactionDetail)
                .WithOptional(e => e.BORemittanceAdvice)
                .HasForeignKey(e => e.RemittanceAdviceCode);

            modelBuilder.Entity<BORemittanceAdvice>()
                .HasMany(e => e.BOTransactionMaster)
                .WithOptional(e => e.BORemittanceAdvice)
                .HasForeignKey(e => e.RemittanceAdviceCode);

            modelBuilder.Entity<BORemittanceAdviceDetail>()
                .Property(e => e.PrvBalanceAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BORemittanceAdviceDetail>()
                .Property(e => e.BillAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BORemittanceAdviceDetail>()
                .Property(e => e.PaidAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BORemittanceAdviceDetail>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BORemittanceAdviceDetail>()
                .Property(e => e.ExchangeRateForMultiCurrency)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BORemittanceAdviceDetail>()
                .Property(e => e.GSTRate)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BORemittanceAdviceDetail>()
                .Property(e => e.GSTAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BORemittanceAdviceDetail>()
                .Property(e => e.WHTRate)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BORemittanceAdviceDetail>()
                .Property(e => e.WHTAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BORemittanceAdviceDetail>()
                .Property(e => e.OtherDeductionAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BORemittanceAdviceDetail>()
                .HasMany(e => e.BOTransactionDetail)
                .WithOptional(e => e.BORemittanceAdviceDetail)
                .HasForeignKey(e => e.RemittanceAdviceDetailCode);

            modelBuilder.Entity<BOFundDemandRegister>()
                .Property(e => e.TotalRequestedAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOFundDemandRegister>()
                .Property(e => e.TotalIssuedAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOFundDemandRegister>()
                .Property(e => e.TotalUsedAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOFundDemandRegister>()
                .HasMany(e => e.BOFundDemandRegisterDetail)
                .WithRequired(e => e.BOFundDemandRegister)
                .HasForeignKey(e => e.FundDemandRegisterCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOFundDemandRegisterDetail>()
                .Property(e => e.RequestedAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOFundDemandRegisterDetail>()
                .Property(e => e.lssuedAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOFundDemandRegisterDetail>()
                .Property(e => e.UsedAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOFundDemandRequest>()
                .Property(e => e.TotalRequestedAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOFundDemandRequest>()
                .Property(e => e.TotalIssuedAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOFundDemandRequest>()
                .HasMany(e => e.BOFundDemandRegisterDetail)
                .WithOptional(e => e.BOFundDemandRequest)
                .HasForeignKey(e => e.FundDemandRequestCode);

            modelBuilder.Entity<BOFundDemandRequest>()
                .HasMany(e => e.BOFundDemandRequestDetail)
                .WithRequired(e => e.BOFundDemandRequest)
                .HasForeignKey(e => e.FundDemandRequestCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOFundDemandRequest>()
                .HasMany(e => e.BOReimbursement)
                .WithOptional(e => e.BOFundDemandRequest)
                .HasForeignKey(e => e.FundDemandRegisterCode);

            modelBuilder.Entity<BOFundDemandRequestDetail>()
                .Property(e => e.RequestedAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOFundDemandRequestDetail>()
                .Property(e => e.lssuedAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOFundDemandRequestDetail>()
                .HasMany(e => e.BOFundDemandRegisterDetail)
                .WithOptional(e => e.BOFundDemandRequestDetail)
                .HasForeignKey(e => e.FundDemandRequestDetailCode);

            #endregion

            #region BOUser
            #region BOEmployeeIncomeTax
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOEmployeeIncomeTax)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.OwnerCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOEmployeeIncomeTax1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.CreatedByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOEmployeeIncomeTax2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);
            #endregion

            modelBuilder.Entity<BOUser>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOAllowanceOrBenefitType)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOAllowanceOrBenefitType1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOAllowanceOrBenefitType2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOAppConfiguration)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOAppConfiguration1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOAppConfiguration2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOAppConfigurationDetail)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOAppConfigurationDetail1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOAppConfigurationDetail2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOApprovalAuthorityType)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOApprovalAuthorityType1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOApprovalAuthorityType2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOAttendanceMachineType)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOAttendanceMachineType1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOAttendanceMachineType2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOBillOrInvoiceType)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOBillOrInvoiceType1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOBillOrInvoiceType2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOCulture)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOCulture1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOCulture2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOCurrency)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOCurrency1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOCurrency2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODataType)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODataType1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODataType2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODiscrepancyType)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODiscrepancyType1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODiscrepancyType2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeRelation)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeRelation1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeRelation2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEquipmentStatus)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEquipmentStatus1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEquipmentStatus2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEquipmentType)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEquipmentType1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEquipmentType2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOExpenseType)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOExpenseType1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOExpenseType2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIMMAcquireType)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIMMAcquireType1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIMMAcquireType2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIMMGender)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIMMGender1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIMMGender2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIMMGroup)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIMMGroup1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIMMGroup2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIMMLifeType)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIMMLifeType1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIMMLifeType2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIMMManufacturedBy)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIMMManufacturedBy1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIMMManufacturedBy2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIMMTaxGroup)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIMMTaxGroup1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIMMTaxGroup2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIMMTaxGroupDetail)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIMMTaxGroupDetail1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIMMTaxGroupDetail2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIMMTransactionMethod)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIMMTransactionMethod1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIMMTransactionMethod2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIncomeTaxSlab)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIncomeTaxSlab1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIncomeTaxSlab2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOInstrumentStatus)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOInstrumentStatus1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOInstrumentStatus2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOInstrumentType)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOInstrumentType1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOInstrumentType2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOLeaseType)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOLeaseType1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOLeaseType2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOLoanType)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOLoanType1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOLoanType2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOLocationSite)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOLocationSite1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOLocationSite2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOLocationSiteType)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOLocationSiteType1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOLocationSiteType2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOOnwerShipType)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOOnwerShipType1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOOnwerShipType2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOOrganizationCompany)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOOrganizationCompany1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOOrganizationCompany2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPackingType)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPackingType1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPackingType2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPaymentMode)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPaymentMode1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPaymentMode2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPriority)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPriority1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPriority2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOProcessApprovalWorkflow)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOProcessApprovalWorkflow1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOProcessApprovalWorkflow2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BORebateType)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BORebateType1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BORebateType2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BORecordStatus)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BORecordStatus1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BORecordStatus2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOReimbursementType)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOReimbursementType1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOReimbursementType2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOSalaryBreakUpPolicy)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOSalaryBreakUpPolicy1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOSalaryBreakUpPolicy2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOSalaryBreakUpPolicyDetail)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOSalaryBreakUpPolicyDetail1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOSalaryBreakUpPolicyDetail2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOSalaryTransferMode)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOSalaryTransferMode1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOSalaryTransferMode2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOTaxAdjustmentType)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOTaxAdjustmentType1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOTaxAdjustmentType2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOTransactionDocumentConfiguration)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOTransactionDocumentConfiguration1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOTransactionDocumentConfiguration2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOTransactionDocumentProcess)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOTransactionDocumentProcess1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOTransactionDocumentProcess2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOUOM)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOUOM1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOUOM2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEquipment)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEquipment1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEquipment2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOActionLogging)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOActionLogging1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOActionLogging2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOAPPCNFDataLogging)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOAPPCNFDataLogging1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOAPPCNFDataLogging2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOCRMDataLogging)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOCRMDataLogging1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOCRMDataLogging2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOErrorLogging)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOErrorLogging1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOErrorLogging2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOFICODataLogging)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOFICODataLogging1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOFICODataLogging2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOHRMDataLogging)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOHRMDataLogging1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOHRMDataLogging2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIMMDataLogging)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIMMDataLogging1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIMMDataLogging2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOLoggingInformation)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOLoggingInformation1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOLoggingInformation2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOLoginAttempts)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOLoginAttempts1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOLoginAttempts2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOSRMDataLogging)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOSRMDataLogging1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOSRMDataLogging2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOUMSDataLogging)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOUMSDataLogging1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOUMSDataLogging2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPartyOrCustomer)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPartyOrCustomer1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPartyOrCustomer2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOBank)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOBank1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOBank2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOBankAccount)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOBankAccount1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOBankAccount2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOBankAccountInstrumentInfo)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOBankAccountInstrumentInfo1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOBankAccountInstrumentInfo2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOBankBranch)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOBankBranch1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOBankBranch2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOBillOrInvoiceMaster)
                .WithOptional(e => e.BOUser)
                .HasForeignKey(e => e.PostedUserCode);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOBillOrInvoiceMaster1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOBillOrInvoiceMaster2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOBillOrInvoiceMaster3)
                .WithRequired(e => e.BOUser3)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOBillOrInvoiceMaster4)
                .WithOptional(e => e.BOUser4)
                .HasForeignKey(e => e.VoidUserCode);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOBillOrInvoiceMasterDetail)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOBillOrInvoiceMasterDetail1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOBillOrInvoiceMasterDetail2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOCOA)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOCOA1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOCOA2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOCOAConfiguration)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOCOAConfiguration1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOCOAConfiguration2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOCOAMapping)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOCOAMapping1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOCOAMapping2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOCOAMappingForPCorCC)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOCOAMappingForPCorCC1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOCOAMappingForPCorCC2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOCOANature)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOCOANature1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOCOANature2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODocumentDetailOfStatement)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODocumentDetailOfStatement1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODocumentDetailOfStatement2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODocumentOfStatement)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODocumentOfStatement1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODocumentOfStatement2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODomainOfStatement)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODomainOfStatement1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODomainOfStatement2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOFiscalYear)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOFiscalYear1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOFiscalYear2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOFiscalYearMonth)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOFiscalYearMonth1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOFiscalYearMonth2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOFiscalYearMonthDetail)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOFiscalYearMonthDetail1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOFiscalYearMonthDetail2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOJobProjectScheme)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOJobProjectScheme1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOJobProjectScheme2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOJobProjectSchemeDetail)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOJobProjectSchemeDetail1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOJobProjectSchemeDetail2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOLinkToTransaction)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOLinkToTransaction1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOLinkToTransaction2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BORemittanceAdvice)
                .WithOptional(e => e.BOUser)
                .HasForeignKey(e => e.PostedUserCode);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BORemittanceAdvice1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BORemittanceAdvice2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BORemittanceAdvice3)
                .WithRequired(e => e.BOUser3)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BORemittanceAdvice4)
                .WithOptional(e => e.BOUser4)
                .HasForeignKey(e => e.VoidUserCode);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BORemittanceAdviceDetail)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BORemittanceAdviceDetail1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BORemittanceAdviceDetail2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOTransactionDetail)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOTransactionDetail1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOTransactionDetail2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOTransactionMaster)
                .WithOptional(e => e.BOUser)
                .HasForeignKey(e => e.PostedUserCode);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOTransactionMaster1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOTransactionMaster2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOTransactionMaster3)
                .WithRequired(e => e.BOUser3)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOTransactionMaster4)
                .WithOptional(e => e.BOUser4)
                .HasForeignKey(e => e.VoidUserCode);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOVoucherType)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOVoucherType1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOVoucherType2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOAreaOfDistrictWard)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOAreaOfDistrictWard1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOAreaOfDistrictWard2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOCityTown)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOCityTown1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOCityTown2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOCountryRegion)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOCountryRegion1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOCountryRegion2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODistrictWard)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODistrictWard1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODistrictWard2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOSectorZone)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOSectorZone1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOSectorZone2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOStateProvince)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOStateProvince1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOStateProvince2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODeductionType)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODeductionType1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODeductionType2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOAllowancesOrBenefit)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOAllowancesOrBenefit1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOAllowancesOrBenefit2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOAttendanceDiscrepancy)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOAttendanceDiscrepancy1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOAttendanceDiscrepancy2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOCalendar)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOCalendar1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOCalendar2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODeductionType)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODeductionType1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODeductionType2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODegree)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODegree1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODegree2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODegreeInstitute)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODegreeInstitute1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODegreeInstitute2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODepartment)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODepartment1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODepartment2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODesignation)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODesignation1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODesignation2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODocumentCheckList)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODocumentCheckList1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BODocumentCheckList2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmpDocumentCheckList)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmpDocumentCheckList1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmpDocumentCheckList2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeAcademic)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeAcademic1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeAcademic2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeAllowanceOrBenefit)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeAllowanceOrBenefit1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeAllowanceOrBenefit2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeAttendance)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeAttendance1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeAttendance2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeEmployment)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeEmployment1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeEmployment2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeFaceOrBiometric)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeFaceOrBiometric1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeFaceOrBiometric2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeFamily)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeFamily1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeFamily2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeIncrement)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeIncrement1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeIncrement2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeIncrementAllowanceOrBenefit)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeIncrementAllowanceOrBenefit1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeIncrementAllowanceOrBenefit2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeInfo)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeInfo1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeInfo2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeInfoHistory)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeInfoHistory1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeInfoHistory2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeInfoRevision)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeInfoRevision1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeInfoRevision2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeLease)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeLease1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeLease2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeLeaseInstallment)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeLeaseInstallment1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeLeaseInstallment2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeLeave)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeLeave1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeLeave2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeLeaveBalance)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeLeaveBalance1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeLeaveBalance2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeLoan)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeLoan1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeLoan2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeLoanInstallment)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeLoanInstallment1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeLoanInstallment2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeReference)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeReference1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeReference2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeSalary)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeSalary1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeSalary2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeSalaryDeduction)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeSalaryDeduction1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeSalaryDeduction2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeSalaryAllowanceOrBenefit)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeSalaryAllowanceOrBenefit1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeSalaryAllowanceOrBenefit2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeSalaryDeduction)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeSalaryDeduction1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeSalaryDeduction2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeSalaryReimbursement)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeSalaryReimbursement1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeSalaryReimbursement2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeStatus)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeStatus1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeStatus2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOFundDemandRegister)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOFundDemandRegister1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOFundDemandRegister2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOFundDemandRegisterDetail)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOFundDemandRegisterDetail1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOFundDemandRegisterDetail2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOFundDemandRequest)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOFundDemandRequest1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOFundDemandRequest2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOFundDemandRequestDetail)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOFundDemandRequestDetail1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOFundDemandRequestDetail2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOHireType)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOHireType1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOHireType2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOJobRole)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOJobRole1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOJobRole2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOLeaveDeductionAgainstLate)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOLeaveDeductionAgainstLate1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOLeaveDeductionAgainstLate2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOLeavePolicy)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOLeavePolicy1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOLeavePolicy2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOLeavePolicyDetail)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOLeavePolicyDetail1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOLeavePolicyDetail2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOLeaveType)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOLeaveType1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOLeaveType2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPayGrade)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPayGrade1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPayGrade2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPayGradeAllowanceOrBenefit)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPayGradeAllowanceOrBenefit1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPayGradeAllowanceOrBenefit2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOReimbursement)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOReimbursement1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOReimbursement2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOShift)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOShift1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOShift2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOShiftDay)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOShiftDay1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOShiftDay2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIMMConfiguration)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIMMConfiguration1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIMMConfiguration2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIMMSectionOrBrand)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIMMSectionOrBrand1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIMMSectionOrBrand2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOItem)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOItem1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOItem2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOItemAspect)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOItemAspect1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOItemAspect2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOItemAspectDetail)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOItemAspectDetail1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOItemAspectDetail2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOItemAttribute)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOItemAttribute1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOItemAttribute2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOItemAttributeAspect)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOItemAttributeAspect1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOItemAttributeAspect2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOItemAttributeAspectDetail)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOItemAttributeAspectDetail1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOItemAttributeAspectDetail2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOItemAttributeDetail)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOItemAttributeDetail1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOItemAttributeDetail2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOItemCategory)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOItemCategory1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOItemCategory2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOItemCategoryAttributeAspect)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOItemCategoryAttributeAspect1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOItemCategoryAttributeAspect2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOItemCategoryAttributeAspectDetail)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOItemCategoryAttributeAspectDetail1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOItemCategoryAttributeAspectDetail2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOItemPrice)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOItemPrice1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOItemPrice2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOItemProfile)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOItemProfile1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOItemProfile2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOMenu)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOMenu1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOMenu2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOMenuControlInfo)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOMenuControlInfo1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOMenuControlInfo2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOModuleColInfo)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOModuleColInfo1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOModuleColInfo2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOModuleParamInfo)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOModuleParamInfo1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOModuleParamInfo2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOProfileGroup)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOProfileGroup1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOProfileGroup2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOProfileGroupDetail)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOProfileGroupDetail1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOProfileGroupDetail2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOReportDashboardInfo)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOReportDashboardInfo1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOReportDashboardInfo2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOSecurityRight)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOSecurityRight1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOSecurityRight2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOProcessApprovalAlert)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOProcessApprovalAlert1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOProcessApprovalAlert2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOVendorOrSupplier)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOVendorOrSupplier1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOVendorOrSupplier2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOSystemOrWebPool)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOSystemOrWebPool1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOSystemOrWebPool2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOUser1)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.AlteredByCode);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOUser11)
                .WithRequired(e => e.BOUser3)
                .HasForeignKey(e => e.CreatedByCode);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOUser12)
                .WithRequired(e => e.BOUser4)
                .HasForeignKey(e => e.OwnerCode);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOUserLocationSitePermission)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.UserCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOUserLocationSitePermission1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOUserLocationSitePermission2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOUserLocationSitePermission3)
                .WithRequired(e => e.BOUser3)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOUserOrganizationCompanyPermission)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.UserCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOUserOrganizationCompanyPermission1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOUserOrganizationCompanyPermission2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOUserOrganizationCompanyPermission3)
                .WithRequired(e => e.BOUser3)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOUserPartyOrCustomerPermission)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.UserCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOUserPartyOrCustomerPermission1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOUserPartyOrCustomerPermission2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOUserPartyOrCustomerPermission3)
                .WithRequired(e => e.BOUser3)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOUserProfileGroup)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.UserCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOUserProfileGroup1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOUserProfileGroup2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOUserProfileGroup3)
                .WithRequired(e => e.BOUser3)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOUserSystemOrWebPermission)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.UserCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOUserSystemOrWebPermission1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOUserSystemOrWebPermission2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOUserSystemOrWebPermission3)
                .WithRequired(e => e.BOUser3)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOUserVendorOrSupplierPermission)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.UserCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOUserVendorOrSupplierPermission1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOUserVendorOrSupplierPermission2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOUserVendorOrSupplierPermission3)
                .WithRequired(e => e.BOUser3)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOTeamMembers)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.MemberCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOGRNandReturn)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOGRNandReturn1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOGRNandReturn2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOGRNandReturnDetail)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOGRNandReturnDetail1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOGRNandReturnDetail2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOReligion)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOReligion1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOReligion2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #region BOPayGradeAssetsAllocation

            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOPayGradeAssetsAllocation)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOPayGradeAssetsAllocation1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOPayGradeAssetsAllocation2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);

            #endregion

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOPayGradeDeductionAllocation)
            .WithRequired(e => e.BOUser)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPayGradeDeductionAllocation1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPayGradeDeductionAllocation2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            #region BOPayGradeDocCheckListAllocation
            modelBuilder.Entity<BOUser>()
               .HasMany(e => e.BOPayGradeDocCheckListAllocation)
               .WithRequired(e => e.BOUser)
               .HasForeignKey(e => e.AlteredByCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPayGradeDocCheckListAllocation1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPayGradeDocCheckListAllocation2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            #endregion

            #region BOPayGradeEarningsAllocation
            modelBuilder.Entity<BOUser>()
               .HasMany(e => e.BOPayGradeEarningsAllocation)
               .WithRequired(e => e.BOUser)
               .HasForeignKey(e => e.AlteredByCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPayGradeEarningsAllocation1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPayGradeEarningsAllocation2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            #endregion

            #region BOPayGradeEOBIAllocation
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOPayGradeEOBIAllocation)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.AlteredByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPayGradeEOBIAllocation1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPayGradeEOBIAllocation2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            #endregion

            modelBuilder.Entity<BOUser>()
             .HasMany(e => e.BOPayGradeEOBIAllowanceDetail)
             .WithRequired(e => e.BOUser)
             .HasForeignKey(e => e.AlteredByCode)
             .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPayGradeEOBIAllowanceDetail1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPayGradeEOBIAllowanceDetail2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
             .HasMany(e => e.BOPayGradeExpenseLimitAllocation)
             .WithRequired(e => e.BOUser)
             .HasForeignKey(e => e.AlteredByCode)
             .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPayGradeExpenseLimitAllocation1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPayGradeExpenseLimitAllocation2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            #region BOPayGradeGratuityCriteria
            modelBuilder.Entity<BOUser>()
             .HasMany(e => e.BOPayGradeGratuityCriteria)
             .WithRequired(e => e.BOUser)
             .HasForeignKey(e => e.AlteredByCode)
             .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPayGradeGratuityCriteria1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPayGradeGratuityCriteria2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);
            #endregion

            #region BOPayrollGroup
            modelBuilder.Entity<BOUser>()
                 .HasMany(e => e.BOPayrollGroup)
                 .WithRequired(e => e.BOUser)
                 .HasForeignKey(e => e.AlteredByCode)
                 .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPayrollGroup1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPayrollGroup2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);
            #endregion

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOPayGradePayrollGroup)
            .WithRequired(e => e.BOUser)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPayGradePayrollGroup1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPayGradePayrollGroup2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            #region BOPayGradeProvidentFundAllocation
            modelBuilder.Entity<BOUser>()
               .HasMany(e => e.BOPayGradeProvidentFundAllocation)
               .WithRequired(e => e.BOUser)
               .HasForeignKey(e => e.AlteredByCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPayGradeProvidentFundAllocation1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPayGradeProvidentFundAllocation2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);
            #endregion

            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOPayGradeProvidentFundAllowanceDetail)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.AlteredByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPayGradeProvidentFundAllowanceDetail1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOPayGradeProvidentFundAllowanceDetail2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            #region BOEmployeeAward
            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeAward)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeAward1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeAward2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            #endregion

            #region BOEmployeeRelative
            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeRelative)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeRelative1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeRelative2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            #endregion

            #region BOIncidentType

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIncidentType)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIncidentType1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIncidentType2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            #endregion

            #region BOEmployeeIncident
            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOEmployeeIncident)
            .WithRequired(e => e.BOUser)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeIncident1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeIncident2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);


            #endregion

            #region BOEmployeeHiringReference
            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOEmployeeHiringReference)
            .WithRequired(e => e.BOUser)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeHiringReference1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeHiringReference2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            #endregion

            #region BOEmployeePersonalAttribute
            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOEmployeePersonalAttribute)
            .WithRequired(e => e.BOUser)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeePersonalAttribute1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeePersonalAttribute2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);


            #endregion

            #region BOEmployeeManagementRemarks
            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOEmployeeManagementRemarks)
            .WithRequired(e => e.BOUser)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeManagementRemarks1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeManagementRemarks2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            #endregion

            #region BOContacts 
            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOContacts)
            .WithRequired(e => e.BOUser)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOContacts1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOContacts2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);
            #endregion

            #region BOEmployeeAward
            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeAward)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeAward1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeAward2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            #endregion

            #region BOEmployeeRelative
            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeRelative)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeRelative1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeRelative2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            #endregion

            #region BOIncidentType

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIncidentType)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIncidentType1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIncidentType2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            #endregion

            #region BOEmployeeIncident
            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOEmployeeIncident)
            .WithRequired(e => e.BOUser)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeIncident1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeIncident2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);


            #endregion

            #region BOEmployeeHiringReference
            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOEmployeeHiringReference)
            .WithRequired(e => e.BOUser)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeHiringReference1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeHiringReference2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            #endregion

            #region BOEmployeePersonalAttribute
            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOEmployeePersonalAttribute)
            .WithRequired(e => e.BOUser)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeePersonalAttribute1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeePersonalAttribute2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);


            #endregion

            #region BOEmployeeManagementRemarks
            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOEmployeeManagementRemarks)
            .WithRequired(e => e.BOUser)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeManagementRemarks1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeManagementRemarks2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            #endregion

            #region BOContacts 
            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOContacts)
            .WithRequired(e => e.BOUser)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOContacts1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOContacts2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);
            #endregion

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOShiftOverTimeCriteria)
            .WithRequired(e => e.BOUser)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOShiftOverTimeCriteria1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOShiftOverTimeCriteria2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
           .HasMany(e => e.BOIncomeTaxSlabDetail)
           .WithRequired(e => e.BOUser)
           .HasForeignKey(e => e.AlteredByCode)
           .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIncomeTaxSlabDetail1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOIncomeTaxSlabDetail2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.OwnerCode)
                .WillCascadeOnDelete(false);

            #region BOExpensePayment
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOExpensePayment)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOExpensePayment1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOExpensePayment2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            #region BOEmployeeGeoRestrictions
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOEmployeeGeoRestrictions)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOEmployeeGeoRestrictions1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOEmployeeGeoRestrictions2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOEmployeeOvertimeProcess)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOEmployeeOvertimeProcess1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOEmployeeOvertimeProcess2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
             .HasMany(e => e.BOSaleOrderDetail)
             .WithRequired(e => e.BOUser)
             .HasForeignKey(e => e.CreatedByCode)
             .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOSaleOrderDetail1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOSaleOrderDetail2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOSaleOrderMaster)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOSaleOrderMaster1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOSaleOrderMaster2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);

            #region BODeliveryNoteMaster
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BODeliveryNoteMaster)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BODeliveryNoteMaster1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BODeliveryNoteMaster2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BODeliveryNoteDetail)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BODeliveryNoteDetail1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BODeliveryNoteDetail2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);

            #region BOCustomerAdjustment
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOCustomerAdjustment)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOCustomerAdjustment1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOCustomerAdjustment2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            modelBuilder.Entity<BOUser>()
             .HasMany(e => e.BOCustomerReceipt)
             .WithRequired(e => e.BOUser)
             .HasForeignKey(e => e.CreatedByCode)
             .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOCustomerReceipt1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOCustomerReceipt2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);

            #region BOFreightEntrySlip
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOFreightEntrySlip)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOFreightEntrySlip1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOFreightEntrySlip2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            #region BOVendorAdjustment
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOVendorAdjustment)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOVendorAdjustment1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOVendorAdjustment2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOCommissionBooking)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOCommissionBooking1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOCommissionBooking2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);

            #region BOCommissionReceipt
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOCommissionReceipt)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOCommissionReceipt1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOCommissionReceipt2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOPurchaseInvoiceMaster)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOPurchaseInvoiceMaster1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOPurchaseInvoiceMaster2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOPurchaseInvoiceDetail)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOPurchaseInvoiceDetail1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOPurchaseInvoiceDetail2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOVendorPayment)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOVendorPayment1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOVendorPayment2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);

            #region BOCommissionReceiptInvoiceMapping
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOCommissionReceiptInvoiceMapping)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOCommissionReceiptInvoiceMapping1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOCommissionReceiptInvoiceMapping2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            #region BOCustomerReceiptInvoiceMapping
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOCustomerReceiptInvoiceMapping)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOCustomerReceiptInvoiceMapping1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOCustomerReceiptInvoiceMapping2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            #region BOCustomerAdjustmentInvoiceMapping
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOCustomerAdjustmentInvoiceMapping)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOCustomerAdjustmentInvoiceMapping1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOCustomerAdjustmentInvoiceMapping2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            #region BOVendorPaymentInvoiceMapping
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOVendorPaymentInvoiceMapping)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOVendorPaymentInvoiceMapping1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOVendorPaymentInvoiceMapping2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            #region BOIMMFinishTypeOptions
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOIMMFinishTypeOptions)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOIMMFinishTypeOptions1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOIMMFinishTypeOptions2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOVendorAdjustmentInvoiceMapping)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOVendorAdjustmentInvoiceMapping1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOVendorAdjustmentInvoiceMapping2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);

            #region BOPurchaseOrderAndReturnMapping
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOPurchaseOrderAndReturnMapping)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOPurchaseOrderAndReturnMapping1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOPurchaseOrderAndReturnMapping2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            #region BOItemImages
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOItemImages)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOItemImages1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOItemImages2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            modelBuilder.Entity<BOUser>()
             .HasMany(e => e.BOLocationSiteWiseItem)
             .WithRequired(e => e.BOUser)
             .HasForeignKey(e => e.CreatedByCode)
             .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOLocationSiteWiseItem1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOLocationSiteWiseItem2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);

            #region BOCafeOrRestaurantConfiguration
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOCafeOrRestaurantConfiguration)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOCafeOrRestaurantConfiguration1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOCafeOrRestaurantConfiguration2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion
            #region BOSlipNotes
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOSlipNotes)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOSlipNotes1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOSlipNotes2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            #region BOEmployeeTrackingConfiguration
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOEmployeeTrackingConfiguration)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOEmployeeTrackingConfiguration1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOEmployeeTrackingConfiguration2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            #region BOEmployeeTrackingDetail
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOEmployeeTrackingDetail)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOEmployeeTrackingDetail1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOEmployeeTrackingDetail2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            #region BOHoldBillOrInvoiceMaster
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOHoldBillOrInvoiceMaster)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOHoldBillOrInvoiceMaster1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOHoldBillOrInvoiceMaster2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            modelBuilder.Entity<BOUser>()
             .HasMany(e => e.BOHoldBillOrInvoiceMasterDetail)
             .WithRequired(e => e.BOUser)
             .HasForeignKey(e => e.CreatedByCode)
             .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOHoldBillOrInvoiceMasterDetail1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOHoldBillOrInvoiceMasterDetail2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);

            #region BOItemProfileBarCode
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOItemProfileBarCode)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOItemProfileBarCode1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOItemProfileBarCode2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOSMSOrEmailDescription)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOSMSOrEmailDescription1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOSMSOrEmailDescription2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);

            #region BOSMSOrEmailOperationsOrBehaviour
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOSMSOrEmailOperationsOrBehaviour)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOSMSOrEmailOperationsOrBehaviour1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOSMSOrEmailOperationsOrBehaviour2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            #region BOSMSOrEmailTags
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOSMSOrEmailTags)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOSMSOrEmailTags1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOSMSOrEmailTags2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOItemDefinition)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOItemDefinition1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOItemDefinition2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOSubjectToDeliver)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOSubjectToDeliver1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOSubjectToDeliver2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);

            #region BOPerformanceGoal
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOPerformanceGoal)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOPerformanceGoal1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOPerformanceGoal2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            #region BOTravellingMedium
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOTravellingMedium)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOTravellingMedium1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOTravellingMedium2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            #region BOTravelRequest
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOTravelRequest)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOTravelRequest1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOTravelRequest2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOTravelRequestDetails)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOTravelRequestDetails1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOTravelRequestDetails2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOEmployeeGoalAssignment)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOEmployeeGoalAssignment1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOEmployeeGoalAssignment2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);

            #region BOLocationWiseSMSInfo
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOLocationWiseSMSInfo)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOLocationWiseSMSInfo1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOLocationWiseSMSInfo2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            #region BOEmailTemplateAssignment
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOEmailTemplateAssignment)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOEmailTemplateAssignment1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOEmailTemplateAssignment2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            #region BOCustomerGroupOrTag
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOCustomerGroupOrTag)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOCustomerGroupOrTag1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOCustomerGroupOrTag2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            #region BOCustomerGroupOrTagCustomerAssignment
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOCustomerGroupOrTagCustomerAssignment)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOCustomerGroupOrTagCustomerAssignment1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOCustomerGroupOrTagCustomerAssignment2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            #region BOCustomerGroupOrTagUserAssignment
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOCustomerGroupOrTagUserAssignment)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOCustomerGroupOrTagUserAssignment1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOCustomerGroupOrTagUserAssignment2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            #region BOEmailAccounts
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOEmailAccounts)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOEmailAccounts1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOEmailAccounts2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            #region BOUserEmailAssignment
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOUserEmailAssignment)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOUserEmailAssignment1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOUserEmailAssignment2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            #region BOUserEmailLog
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOUserEmailLog)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOUserEmailLog1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOUserEmailLog2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            #region BOEquipmentIssuedOrReturn
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOEquipmentIssuedOrReturn)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOEquipmentIssuedOrReturn1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOEquipmentIssuedOrReturn2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            #region BODutyRoster
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BODutyRoster)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BODutyRoster1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BODutyRoster2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            #region BOEmployeeSalaryLoanLease
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOEmployeeSalaryLoanLease)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOEmployeeSalaryLoanLease1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOEmployeeSalaryLoanLease2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            #region BORequestTaxCertificate
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BORequestTaxCertificate)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BORequestTaxCertificate1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BORequestTaxCertificate2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            #region BOEmployeeManualOvertime
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOEmployeeManualOvertime)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOEmployeeManualOvertime1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOEmployeeManualOvertime2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            #region BOEmployeeManualAllowanceOrBenefit
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOEmployeeManualAllowanceOrBenefit)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOEmployeeManualAllowanceOrBenefit1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOEmployeeManualAllowanceOrBenefit2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            #region BOQuotationTemplate
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOQuotationTemplate)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOQuotationTemplate1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOQuotationTemplate2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            #region BOQuotationParameter
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOQuotationParameter)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOQuotationParameter1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOQuotationParameter2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOQuotationParameterMapping)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOQuotationParameterMapping1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOQuotationParameterMapping2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOGenerateQuotation)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOGenerateQuotation1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOGenerateQuotation2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOGenerateQuotationDetail)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOGenerateQuotationDetail1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOGenerateQuotationDetail2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOQuotationParameterItemDetail)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOQuotationParameterItemDetail1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOQuotationParameterItemDetail2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);

            #region BOPartyOrCustomerPlan
            modelBuilder.Entity<BOUser>()
             .HasMany(e => e.BOPartyOrCustomerPlan)
             .WithRequired(e => e.BOUser)
             .HasForeignKey(e => e.UserCode)
             .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOPartyOrCustomerPlan1)
              .WithRequired(e => e.BOUser1)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOPartyOrCustomerPlan2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOPartyOrCustomerPlan3)
            .WithRequired(e => e.BOUser3)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            #region BOEmployeeLockedAttendanceDetails
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOEmployeeLockedAttendanceDetails)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOEmployeeLockedAttendanceDetails1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOEmployeeLockedAttendanceDetails2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            #region BOEmployeeLoanPayment
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOEmployeeLoanPayment)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOEmployeeLoanPayment1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOEmployeeLoanPayment2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);
            #endregion

            #region BOPayrollInputMaster
            modelBuilder.Entity<BOUser>()
              .HasMany(e => e.BOPayrollInputMaster)
              .WithRequired(e => e.BOUser)
              .HasForeignKey(e => e.CreatedByCode)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOPayrollInputMaster1)
            .WithRequired(e => e.BOUser1)
            .HasForeignKey(e => e.AlteredByCode)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
            .HasMany(e => e.BOPayrollInputMaster2)
            .WithRequired(e => e.BOUser2)
            .HasForeignKey(e => e.OwnerCode)
            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<BOUser>()
            //  .HasMany(e => e.BOQuotationParameterDetail)
            //  .WithRequired(e => e.BOUser)
            //  .HasForeignKey(e => e.CreatedByCode)
            //  .WillCascadeOnDelete(false);

            //modelBuilder.Entity<BOUser>()
            //.HasMany(e => e.BOQuotationParameterDetail1)
            //.WithRequired(e => e.BOUser1)
            //.HasForeignKey(e => e.AlteredByCode)
            //.WillCascadeOnDelete(false);

            //modelBuilder.Entity<BOUser>()
            //.HasMany(e => e.BOQuotationParameterDetail2)
            //.WithRequired(e => e.BOUser2)
            //.HasForeignKey(e => e.OwnerCode)
            //.WillCascadeOnDelete(false);
            #endregion
            #endregion
        }
    }
}

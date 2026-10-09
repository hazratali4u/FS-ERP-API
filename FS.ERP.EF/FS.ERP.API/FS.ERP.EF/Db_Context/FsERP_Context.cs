using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using FS.ERP.Models.BO;
using FS.ERP.Models.IdentityModel;
using Microsoft.AspNet.Identity.EntityFramework;

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
        }

        public DbSet<ApplicationUserRole> UserRole { get; set; }
        public DbSet<ApplicationUserLogin> UserLogin { get; set; }
        public DbSet<ApplicationUserClaim> UserClaim { get; set; }

        public virtual DbSet<BOAllowanceOrBenefitType> BOAllowanceOrBenefitType { get; set; }
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
        public virtual DbSet<BOAdditionType> BOAdditionType { get; set; }
        public virtual DbSet<BOAllowancesOrBenefit> BOAllowancesOrBenefit { get; set; }
        public virtual DbSet<BOAttendanceDiscrepancy> BOAttendanceDiscrepancy { get; set; }
        public virtual DbSet<BOCalendar> BOCalendar { get; set; }
        public virtual DbSet<BODeductionType> BODeductionType { get; set; }
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
        public virtual DbSet<BOEmployeeSalaryAddition> BOEmployeeSalaryAddition { get; set; }
        public virtual DbSet<BOEmployeeSalaryAllowanceOrBenefit> BOEmployeeSalaryAllowanceOrBenefit { get; set; }
        public virtual DbSet<BOEmployeeSalaryDeduction> BOEmployeeSalaryDeduction { get; set; }
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

        //public virtual DbSet<IdentityRole> IdentityRoles { get; set; }
        //public virtual DbSet<IdentityUser> IdentityUsers { get; set; }
        //public virtual DbSet<IdentityUserClaim> IdentityUserClaims { get; set; }
        //public virtual DbSet<IdentityUserLogin> IdentityUserLogins { get; set; }
        //public virtual DbSet<IdentityUserProfile> IdentityUserProfiles { get; set; }
        //public virtual DbSet<IdentityUserRole> IdentityUserRoles { get; set; }

        public virtual DbSet<BOVendorOrSupplier> BOVendorOrSupplier { get; set; }
        public virtual DbSet<BOSystemOrWebPool> BOSystemOrWebPool { get; set; }

        //public virtual DbSet<BOUser> BOUser { get; set; }

        public virtual DbSet<BOUserLocationSitePermission> BOUserLocationSitePermission { get; set; }
        public virtual DbSet<BOUserMenuAdditionSubtraction> BOUserMenuAdditionSubtraction { get; set; }
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Entity<BOUser>().ToTable("UMS.tbl_User");
            modelBuilder.Entity<ApplicationRole>().ToTable("security.IdentityRole");
            modelBuilder.Entity<ApplicationUserLogin>().ToTable("security.IdentityUserLogin");
            modelBuilder.Entity<ApplicationUserRole>().ToTable("security.IdentityUserRole");
            modelBuilder.Entity<ApplicationUserClaim>().ToTable("security.IdentityUserClaim");


            modelBuilder.Entity<BOAllowanceOrBenefitType>()
                .HasMany(e => e.BOAllowancesOrBenefit)
                .WithRequired(e => e.BOAllowanceOrBenefitType)
                .HasForeignKey(e => e.AllowanceOrBenefitTypeCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOAppConfiguration>()
                .HasMany(e => e.BOAppConfiguration1)
                .WithOptional(e => e.BOAppConfiguration2)
                .HasForeignKey(e => e.TemplateCode);

            modelBuilder.Entity<BOAppConfiguration>()
                .HasMany(e => e.BOAppConfigurationDetail)
                .WithRequired(e => e.BOAppConfiguration)
                .HasForeignKey(e => e.ApplicationConfigurationCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOAppConfigurationDetail>()
                .HasMany(e => e.BOAppConfigurationDetail1)
                .WithOptional(e => e.BOAppConfigurationDetail2)
                .HasForeignKey(e => e.TemplateDetailCode);

            modelBuilder.Entity<BOApprovalAuthorityType>()
                .HasMany(e => e.BOProcessApprovalWorkflow)
                .WithRequired(e => e.BOApprovalAuthorityType)
                .HasForeignKey(e => e.ApprovalAuthorityTypeCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOAttendanceMachineType>()
                .HasMany(e => e.BOAttendanceDiscrepancy)
                .WithOptional(e => e.BOAttendanceMachineType)
                .HasForeignKey(e => e.AttendanceMachineCode);

            modelBuilder.Entity<BOAttendanceMachineType>()
                .HasMany(e => e.BOEmployeeAttendance)
                .WithOptional(e => e.BOAttendanceMachineType)
                .HasForeignKey(e => e.AttendanceMachineCode);

            modelBuilder.Entity<BOBillOrInvoiceType>()
                .HasMany(e => e.BOBillOrInvoiceMaster)
                .WithOptional(e => e.BOBillOrInvoiceType)
                .HasForeignKey(e => e.BillorInvoiceTypeCode);

            modelBuilder.Entity<BOCulture>()
                .HasMany(e => e.BOPartyOrCustomer)
                .WithOptional(e => e.BOCulture)
                .HasForeignKey(e => e.DefaultCultureCode);

            modelBuilder.Entity<BOCulture>()
                .HasMany(e => e.BOVendorOrSupplier)
                .WithOptional(e => e.BOCulture)
                .HasForeignKey(e => e.DefaultCultureCode);

            modelBuilder.Entity<BOCurrency>()
                .HasMany(e => e.BOBankAccount)
                .WithOptional(e => e.BOCurrency)
                .HasForeignKey(e => e.CurrencyCode);

            modelBuilder.Entity<BOCurrency>()
                .HasMany(e => e.BOBillOrInvoiceMaster)
                .WithOptional(e => e.BOCurrency)
                .HasForeignKey(e => e.CurrencyCode);

            modelBuilder.Entity<BOCurrency>()
                .HasMany(e => e.BOBillOrInvoiceMasterDetail)
                .WithOptional(e => e.BOCurrency)
                .HasForeignKey(e => e.CurrencyCode);

            modelBuilder.Entity<BOCurrency>()
                .HasMany(e => e.BOEmployeeIncrement)
                .WithRequired(e => e.BOCurrency)
                .HasForeignKey(e => e.CurrencyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOCurrency>()
                .HasMany(e => e.BOEmployeeInfo)
                .WithRequired(e => e.BOCurrency)
                .HasForeignKey(e => e.CurrencyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOCurrency>()
                .HasMany(e => e.BOEmployeeInfoRevision)
                .WithRequired(e => e.BOCurrency)
                .HasForeignKey(e => e.CurrencyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOCurrency>()
                .HasMany(e => e.BOEmployeeSalary)
                .WithRequired(e => e.BOCurrency)
                .HasForeignKey(e => e.CurrencyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOCurrency>()
                .HasMany(e => e.BOPartyOrCustomer)
                .WithOptional(e => e.BOCurrency)
                .HasForeignKey(e => e.DefaultCurrencyCode);

            modelBuilder.Entity<BOCurrency>()
                .HasMany(e => e.BORemittanceAdvice)
                .WithOptional(e => e.BOCurrency)
                .HasForeignKey(e => e.CurrencyCode);

            modelBuilder.Entity<BOCurrency>()
                .HasMany(e => e.BORemittanceAdviceDetail)
                .WithOptional(e => e.BOCurrency)
                .HasForeignKey(e => e.CurrencyCode);

            modelBuilder.Entity<BOCurrency>()
                .HasMany(e => e.BOSalaryBreakUpPolicyDetail)
                .WithRequired(e => e.BOCurrency)
                .HasForeignKey(e => e.CurrencyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOCurrency>()
                .HasMany(e => e.BOTransactionDetail)
                .WithOptional(e => e.BOCurrency)
                .HasForeignKey(e => e.CurrencyCode);

            modelBuilder.Entity<BOCurrency>()
                .HasMany(e => e.BOVendorOrSupplier)
                .WithOptional(e => e.BOCurrency)
                .HasForeignKey(e => e.DefaultCurrencyCode);

            modelBuilder.Entity<BODataType>()
                .HasMany(e => e.BOAppConfiguration)
                .WithRequired(e => e.BODataType)
                .HasForeignKey(e => e.DataTypeCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BODataType>()
                .HasMany(e => e.BOAppConfigurationDetail)
                .WithRequired(e => e.BODataType)
                .HasForeignKey(e => e.DataTypeCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BODataType>()
                .HasMany(e => e.BOMenuControlInfo)
                .WithOptional(e => e.BODataType)
                .HasForeignKey(e => e.DataTypeCode);

            modelBuilder.Entity<BODataType>()
                .HasMany(e => e.BOModuleColInfo)
                .WithOptional(e => e.BODataType)
                .HasForeignKey(e => e.DataTypeCode);

            modelBuilder.Entity<BODiscrepancyType>()
                .Property(e => e.IsForAttendance)
                .IsFixedLength();

            modelBuilder.Entity<BODiscrepancyType>()
                .HasMany(e => e.BOAttendanceDiscrepancy)
                .WithRequired(e => e.BODiscrepancyType)
                .HasForeignKey(e => e.DiscrepancyType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BODiscrepancyType>()
                .HasMany(e => e.BOAttendanceDiscrepancy1)
                .WithRequired(e => e.BODiscrepancyType1)
                .HasForeignKey(e => e.ActualDiscrepancyType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BODomainType>()
                .HasMany(e => e.BOAppConfiguration)
                .WithOptional(e => e.BODomainType)
                .HasForeignKey(e => e.DomainTypeCode);

            modelBuilder.Entity<BOEmployeeRelation>()
                .HasMany(e => e.BOEmployeeReference)
                .WithRequired(e => e.BOEmployeeRelation)
                .HasForeignKey(e => e.EmployeeRelationCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEquipmentStatus>()
                .HasMany(e => e.BOEquipment)
                .WithRequired(e => e.BOEquipmentStatus)
                .HasForeignKey(e => e.EquipmentStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEquipmentType>()
                .HasMany(e => e.BOEquipment)
                .WithRequired(e => e.BOEquipmentType)
                .HasForeignKey(e => e.EquipmentTypeCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOExpenseType>()
                .HasMany(e => e.BOFundDemandRegisterDetail)
                .WithOptional(e => e.BOExpenseType)
                .HasForeignKey(e => e.ExpenseTypeCode);

            modelBuilder.Entity<BOExpenseType>()
                .HasMany(e => e.BOFundDemandRequestDetail)
                .WithOptional(e => e.BOExpenseType)
                .HasForeignKey(e => e.ExpenseTypeCode);

            modelBuilder.Entity<BOIMMAcquireType>()
                .HasMany(e => e.BOItem)
                .WithOptional(e => e.BOIMMAcquireType)
                .HasForeignKey(e => e.IMMAcquireTypeCode);

            modelBuilder.Entity<BOIMMGender>()
                .HasMany(e => e.BOItem)
                .WithOptional(e => e.BOIMMGender)
                .HasForeignKey(e => e.IMMGenderCode);

            modelBuilder.Entity<BOIMMGroup>()
                .HasMany(e => e.BOItem)
                .WithOptional(e => e.BOIMMGroup)
                .HasForeignKey(e => e.IMMGroupCode);

            modelBuilder.Entity<BOIMMLifeType>()
                .HasMany(e => e.BOItem)
                .WithOptional(e => e.BOIMMLifeType)
                .HasForeignKey(e => e.IMMLifeTypeCode);

            modelBuilder.Entity<BOIMMManufacturedBy>()
                .HasMany(e => e.BOItem)
                .WithOptional(e => e.BOIMMManufacturedBy)
                .HasForeignKey(e => e.IMMManufacturedByCode);

            modelBuilder.Entity<BOIMMTaxGroup>()
                .HasMany(e => e.BOIMMTaxGroupDetail)
                .WithRequired(e => e.BOIMMTaxGroup)
                .HasForeignKey(e => e.IMMTaxGroupCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOIMMTaxGroup>()
                .HasMany(e => e.BOItemCategory)
                .WithOptional(e => e.BOIMMTaxGroup)
                .HasForeignKey(e => e.IMMTaxGroupCode);

            modelBuilder.Entity<BOIMMTaxGroup>()
                .HasMany(e => e.BOItemPrice)
                .WithOptional(e => e.BOIMMTaxGroup)
                .HasForeignKey(e => e.IMMTaxGroupCode);

            modelBuilder.Entity<BOIMMTaxGroupDetail>()
                .HasMany(e => e.BOBillOrInvoiceMasterDetail)
                .WithOptional(e => e.BOIMMTaxGroupDetail)
                .HasForeignKey(e => e.IMMTaxGroupDetailCode);

            modelBuilder.Entity<BOIMMTaxGroupDetail>()
                .HasMany(e => e.BORemittanceAdviceDetail)
                .WithOptional(e => e.BOIMMTaxGroupDetail)
                .HasForeignKey(e => e.IMMTaxGroupDetailCode);

            modelBuilder.Entity<BOIMMTaxGroupDetail>()
                .HasMany(e => e.BOTransactionDetail)
                .WithOptional(e => e.BOIMMTaxGroupDetail)
                .HasForeignKey(e => e.IMMTaxGroupDetailCode);

            modelBuilder.Entity<BOIMMTransactionMethod>()
                .HasMany(e => e.BOItem)
                .WithOptional(e => e.BOIMMTransactionMethod)
                .HasForeignKey(e => e.IMMTransactionMethodCode);

            modelBuilder.Entity<BOInstrumentStatus>()
                .HasMany(e => e.BOBankAccountInstrumentInfo)
                .WithRequired(e => e.BOInstrumentStatus)
                .HasForeignKey(e => e.InstrumentStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOInstrumentStatus>()
                .HasMany(e => e.BORemittanceAdviceDetail)
                .WithOptional(e => e.BOInstrumentStatus)
                .HasForeignKey(e => e.InstrumentStatusCode);

            modelBuilder.Entity<BOInstrumentStatus>()
                .HasMany(e => e.BOTransactionDetail)
                .WithOptional(e => e.BOInstrumentStatus)
                .HasForeignKey(e => e.InstrumentStatusCode);

            modelBuilder.Entity<BOInstrumentType>()
                .HasMany(e => e.BOBankAccountInstrumentInfo)
                .WithOptional(e => e.BOInstrumentType)
                .HasForeignKey(e => e.InstrumentTypeCode);

            modelBuilder.Entity<BOLeaseType>()
                .HasMany(e => e.BOEmployeeLease)
                .WithRequired(e => e.BOLeaseType)
                .HasForeignKey(e => e.LeaseTypeCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOLoanType>()
                .HasMany(e => e.BOEmployeeLoan)
                .WithRequired(e => e.BOLoanType)
                .HasForeignKey(e => e.LoanTypeCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOLocationSite>()
                .Property(e => e.MinHumidity)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOLocationSite>()
                .Property(e => e.MaxHumidity)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOLocationSite>()
                .Property(e => e.MinTemperature)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOLocationSite>()
                .Property(e => e.MaxTemperature)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOLocationSite>()
                .Property(e => e.Length)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOLocationSite>()
                .Property(e => e.Width)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOLocationSite>()
                .Property(e => e.Height)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOLocationSite>()
                .Property(e => e.DiaMeter)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOLocationSite>()
                .Property(e => e.OpenAreaLength)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOLocationSite>()
                .Property(e => e.OpenAreaWidth)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOLocationSite>()
                .Property(e => e.OpenAreaHeight)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOLocationSite>()
                .HasMany(e => e.BOEmployeeIncrement)
                .WithOptional(e => e.BOLocationSite)
                .HasForeignKey(e => e.LocationCode);

            modelBuilder.Entity<BOLocationSite>()
                .HasMany(e => e.BOEmployeeInfo)
                .WithOptional(e => e.BOLocationSite)
                .HasForeignKey(e => e.CurrentLocationCode);

            modelBuilder.Entity<BOLocationSite>()
                .HasMany(e => e.BOEmployeeInfo1)
                .WithOptional(e => e.BOLocationSite1)
                .HasForeignKey(e => e.ReportingLocationCode);

            modelBuilder.Entity<BOLocationSite>()
                .HasMany(e => e.BOEmployeeInfoRevision)
                .WithOptional(e => e.BOLocationSite)
                .HasForeignKey(e => e.CurrentLocationCode);

            modelBuilder.Entity<BOLocationSite>()
                .HasMany(e => e.BOEmployeeInfoRevision1)
                .WithOptional(e => e.BOLocationSite1)
                .HasForeignKey(e => e.ReportingLocationCode);

            modelBuilder.Entity<BOLocationSite>()
                .HasMany(e => e.BOEmployeeSalary)
                .WithOptional(e => e.BOLocationSite)
                .HasForeignKey(e => e.CurrentLocationCode);

            modelBuilder.Entity<BOLocationSite>()
                .HasMany(e => e.BOEquipment)
                .WithOptional(e => e.BOLocationSite)
                .HasForeignKey(e => e.CurrentLocationCode);

            modelBuilder.Entity<BOLocationSite>()
                .HasMany(e => e.BOLocationSite1)
                .WithOptional(e => e.BOLocationSite2)
                .HasForeignKey(e => e.LocationSiteCode);

            modelBuilder.Entity<BOLocationSite>()
                .HasMany(e => e.BOUser3)
                .WithOptional(e => e.BOLocationSite3)
                .HasForeignKey(e => e.DefaultLocationCode);

            modelBuilder.Entity<BOLocationSite>()
                .HasMany(e => e.BOUserLocationSitePermission)
                .WithRequired(e => e.BOLocationSite)
                .HasForeignKey(e => e.LocationSiteCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOLocationSiteType>()
                .HasMany(e => e.BOLocationSite)
                .WithRequired(e => e.BOLocationSiteType)
                .HasForeignKey(e => e.LocationSiteTypeCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOnwerShipType>()
                .HasMany(e => e.BOEquipment)
                .WithRequired(e => e.BOOnwerShipType)
                .HasForeignKey(e => e.OwnershipTypeCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOnwerShipType>()
                .HasMany(e => e.BOItem)
                .WithOptional(e => e.BOOnwerShipType)
                .HasForeignKey(e => e.OnwerShipTypeCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .Property(e => e.Longitude)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOOrganizationCompany>()
                .Property(e => e.Latitude)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOOrganizationCompany>()
                .Property(e => e.Altitude)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOOrganizationCompany>()
                .Property(e => e.Radius)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOAllowanceOrBenefitType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOAppConfiguration)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOAppConfigurationDetail)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOApprovalAuthorityType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOAttendanceMachineType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOBillOrInvoiceType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BODiscrepancyType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmployeeRelation)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEquipmentStatus)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEquipmentType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOExpenseType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOIMMAcquireType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOIMMGender)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOIMMGroup)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOIMMLifeType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOIMMManufacturedBy)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOIMMTaxGroup)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOIMMTaxGroupDetail)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOIMMTransactionMethod)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOIncomeTaxSlab)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOInstrumentStatus)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOInstrumentType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOLeaseType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOLoanType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOLocationSite)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOOnwerShipType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOActionLogging)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOAllowancesOrBenefit)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOAPPCNFDataLogging)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOAttendanceDiscrepancy)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOBank)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOBankAccount)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOBankAccountInstrumentInfo)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOBankAccountInstrumentInfo1)
                .WithOptional(e => e.BOOrganizationCompany1)
                .HasForeignKey(e => e.PCorCCFromCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOBankAccountInstrumentInfo2)
                .WithOptional(e => e.BOOrganizationCompany2)
                .HasForeignKey(e => e.PCorCCToCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOBankBranch)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOBillOrInvoiceMaster)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOBillOrInvoiceMaster1)
                .WithOptional(e => e.BOOrganizationCompany1)
                .HasForeignKey(e => e.PCorCCCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOBillOrInvoiceMasterDetail)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOCalendar)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOCOA)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOCOAConfiguration)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOCOAMapping)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOCOAMappingForPCorCC)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOCOAMappingForPCorCC1)
                .WithOptional(e => e.BOOrganizationCompany1)
                .HasForeignKey(e => e.PcOrCcCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOCOANature)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOCRMDataLogging)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BODeductionType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BODegree)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BODegreeInstitute)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BODepartment)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BODesignation)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BODocumentCheckList)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BODocumentDetailOfStatement)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BODocumentOfStatement)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BODomainOfStatement)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmpDocumentCheckList)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmployeeAcademic)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmployeeAllowanceOrBenefit)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmployeeAttendance)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmployeeEmployment)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmployeeFaceOrBiometric)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmployeeFamily)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmployeeIncrement)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmployeeIncrement1)
                .WithRequired(e => e.BOOrganizationCompany1)
                .HasForeignKey(e => e.PayrollCostOrProfitCenterCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmployeeIncrement2)
                .WithRequired(e => e.BOOrganizationCompany2)
                .HasForeignKey(e => e.CostOrProfitCenterCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmployeeIncrement3)
                .WithRequired(e => e.BOOrganizationCompany3)
                .HasForeignKey(e => e.EmpCompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmployeeIncrementAllowanceOrBenefit)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmployeeInfo)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmployeeInfo1)
                .WithRequired(e => e.BOOrganizationCompany1)
                .HasForeignKey(e => e.PayrollCostOrProfitCenterCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmployeeInfo2)
                .WithRequired(e => e.BOOrganizationCompany2)
                .HasForeignKey(e => e.CostOrProfitCenterCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmployeeInfo3)
                .WithRequired(e => e.BOOrganizationCompany3)
                .HasForeignKey(e => e.EmpCompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmployeeInfoHistory)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmployeeInfoRevision)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmployeeInfoRevision1)
                .WithRequired(e => e.BOOrganizationCompany1)
                .HasForeignKey(e => e.PayrollCostOrProfitCenterCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmployeeInfoRevision2)
                .WithRequired(e => e.BOOrganizationCompany2)
                .HasForeignKey(e => e.CostOrProfitCenterCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmployeeInfoRevision3)
                .WithRequired(e => e.BOOrganizationCompany3)
                .HasForeignKey(e => e.EmpCompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmployeeLease)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmployeeLeaseInstallment)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmployeeLeave)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmployeeLeaveBalance)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmployeeLoan)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmployeeLoanInstallment)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmployeeReference)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmployeeSalary)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmployeeSalary1)
                .WithRequired(e => e.BOOrganizationCompany1)
                .HasForeignKey(e => e.PayrollCostOrProfitCenterCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmployeeSalary2)
                .WithRequired(e => e.BOOrganizationCompany2)
                .HasForeignKey(e => e.CostOrProfitCenterCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmployeeSalary3)
                .WithRequired(e => e.BOOrganizationCompany3)
                .HasForeignKey(e => e.EmpCompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmployeeSalaryAddition)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmployeeSalaryAllowanceOrBenefit)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmployeeSalaryDeduction)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmployeeSalaryReimbursement)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEmployeeStatus)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEquipment)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEquipment1)
                .WithOptional(e => e.BOOrganizationCompany1)
                .HasForeignKey(e => e.CostOrProfitCenterCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOEquipment2)
                .WithOptional(e => e.BOOrganizationCompany2)
                .HasForeignKey(e => e.TransferCostOrProfitCenterCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOErrorLogging)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOFICODataLogging)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOFiscalYear)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOFiscalYearMonth)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOFiscalYearMonth1)
                .WithRequired(e => e.BOOrganizationCompany1)
                .HasForeignKey(e => e.PcOrCcCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOFiscalYearMonthDetail)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOFiscalYearMonthDetail1)
                .WithRequired(e => e.BOOrganizationCompany1)
                .HasForeignKey(e => e.PcOrCcCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOFiscalYearMonthDetail2)
                .WithRequired(e => e.BOOrganizationCompany2)
                .HasForeignKey(e => e.CompanyOrOrganizationCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOFundDemandRegister)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOFundDemandRegisterDetail)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOFundDemandRequest)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOFundDemandRequestDetail)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOHireType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOHRMDataLogging)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOIMMConfiguration)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOIMMDataLogging)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOIMMSectionOrBrand)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOItem)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOItemAspect)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOItemAspectDetail)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOItemAttribute)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOItemAttributeAspect)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOItemAttributeAspectDetail)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOItemAttributeDetail)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOItemCategory)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOItemCategoryAttributeAspect)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOItemCategoryAttributeAspectDetail)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOItemPrice)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOItemPrice1)
                .WithOptional(e => e.BOOrganizationCompany1)
                .HasForeignKey(e => e.PcOCcCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOItemProfile)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOJobProjectScheme)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOJobProjectSchemeDetail)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOJobRole)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOLeaveDeductionAgainstLate)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOLeavePolicy)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOLeavePolicyDetail)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);


            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOLeaveType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOLinkToTransaction)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOLoggingInformation)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOLoginAttempts)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOOrganizationCompany1)
                .WithOptional(e => e.BOOrganizationCompany2)
                .HasForeignKey(e => e.ParentCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOPackingType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOPartyOrCustomer)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOPayGrade)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOPayGradeAllowanceOrBenefit)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOPaymentMode)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOPriority)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOProcessApprovalWorkflow)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOProcessApprovalAlert)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOProcessApprovalWorkflow1)
                .WithOptional(e => e.BOOrganizationCompany1)
                .HasForeignKey(e => e.CostOrProfitCenterCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOProfileGroup)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOProfileGroupDetail)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BORebateType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOReimbursement)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOReimbursementType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BORemittanceAdvice)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BORemittanceAdvice1)
                .WithOptional(e => e.BOOrganizationCompany1)
                .HasForeignKey(e => e.PCorCCCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BORemittanceAdviceDetail)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOSalaryBreakUpPolicy)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOSalaryBreakUpPolicy1)
                .WithRequired(e => e.BOOrganizationCompany1)
                .HasForeignKey(e => e.PolicyCompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOSalaryBreakUpPolicyDetail)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOSalaryBreakUpPolicyDetail1)
                .WithRequired(e => e.BOOrganizationCompany1)
                .HasForeignKey(e => e.PolicyCompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOSalaryTransferMode)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOShift)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOShiftDay)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOSRMDataLogging)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOSystemOrWebPool)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOTaxAdjustmentType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOTransactionDetail)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOTransactionDocumentConfiguration)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOTransactionDocumentProcess)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOTransactionMaster)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOUMSDataLogging)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOUser3)
                .WithRequired(e => e.BOOrganizationCompany3)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOUser4)
                .WithOptional(e => e.BOOrganizationCompany4)
                .HasForeignKey(e => e.DefaultCCorPCCode);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOUserLocationSitePermission)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOUserMenuAdditionSubtraction)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOUserOrganizationCompanyPermission)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOUserOrganizationCompanyPermission1)
                .WithRequired(e => e.BOOrganizationCompany1)
                .HasForeignKey(e => e.OrganizationCompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOUserPartyOrCustomerPermission)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOUserProfileGroup)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOUserSystemOrWebPermission)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOUserVendorOrSupplierPermission)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOVendorOrSupplier)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOVoucherType)
                .WithOptional(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode);

            modelBuilder.Entity<BOPackingType>()
                .HasMany(e => e.BOItem)
                .WithOptional(e => e.BOPackingType)
                .HasForeignKey(e => e.PackingTypeCode);

            modelBuilder.Entity<BOPackingType>()
                .HasMany(e => e.BOJobProjectSchemeDetail)
                .WithOptional(e => e.BOPackingType)
                .HasForeignKey(e => e.PackTypeCode);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOAllowanceOrBenefitType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOAppConfiguration)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOAppConfigurationDetail)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOApprovalAuthorityType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOAttendanceMachineType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOBillOrInvoiceType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOCulture)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOCurrency)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BODataType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BODiscrepancyType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOEmployeeRelation)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOEquipmentStatus)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOEquipmentType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOExpenseType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOIMMAcquireType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOIMMGender)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOIMMGroup)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOIMMLifeType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOIMMManufacturedBy)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOIMMTaxGroup)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOIMMTaxGroupDetail)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOIMMTransactionMethod)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOIncomeTaxSlab)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOInstrumentStatus)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOInstrumentType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOLeaseType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOLoanType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOLocationSite)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOLocationSiteType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOOnwerShipType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOOrganizationCompany)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOPackingType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOPaymentMode)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOPriority)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOProcessApprovalWorkflow)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BORebateType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOActionLogging)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOAdditionType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOAllowancesOrBenefit)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOAPPCNFDataLogging)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOAreaOfDistrictWard)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOAttendanceDiscrepancy)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOBank)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOBankAccount)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOBankAccountInstrumentInfo)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOBankBranch)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOBillOrInvoiceMaster)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOBillOrInvoiceMasterDetail)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOCalendar)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOCityTown)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOCOA)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOCOAConfiguration)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOCOAMapping)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOCOAMappingForPCorCC)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOCOANature)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOCountryRegion)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOCRMDataLogging)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BODeductionType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BODegree)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BODegreeInstitute)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BODepartment)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BODesignation)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BODistrictWard)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BODocumentCheckList)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BODocumentDetailOfStatement)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BODocumentOfStatement)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BODomainOfStatement)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOEmpDocumentCheckList)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOEmployeeAcademic)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOEmployeeAllowanceOrBenefit)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOEmployeeAttendance)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOEmployeeEmployment)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOEmployeeFaceOrBiometric)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOEmployeeFamily)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOEmployeeIncrement)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOEmployeeIncrementAllowanceOrBenefit)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOEmployeeInfo)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOEmployeeInfoHistory)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOEmployeeInfoRevision)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOEmployeeLease)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOEmployeeLeaseInstallment)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOEmployeeLeave)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOEmployeeLeaveBalance)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOEmployeeLoan)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOEmployeeLoanInstallment)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOEmployeeReference)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOEmployeeSalary)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOEmployeeSalaryAddition)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOEmployeeSalaryAllowanceOrBenefit)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOEmployeeSalaryDeduction)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOEmployeeSalaryReimbursement)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOEmployeeStatus)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOEquipment)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOErrorLogging)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOFICODataLogging)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOFiscalYear)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOFiscalYearMonth)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOFiscalYearMonthDetail)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOFundDemandRegister)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOFundDemandRegisterDetail)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOFundDemandRequest)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOFundDemandRequestDetail)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOHireType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOHRMDataLogging)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOIMMConfiguration)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOIMMDataLogging)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOIMMSectionOrBrand)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOItem)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOItemAspect)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOItemAspectDetail)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOItemAttribute)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOItemAttributeAspect)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOItemAttributeAspectDetail)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOItemAttributeDetail)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOItemCategory)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOItemCategoryAttributeAspect)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOItemCategoryAttributeAspectDetail)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOItemPrice)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOItemProfile)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOJobProjectScheme)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOJobProjectSchemeDetail)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOJobRole)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOLeaveDeductionAgainstLate)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOLeavePolicy)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOLeavePolicyDetail)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOLeaveType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOLinkToTransaction)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOLoggingInformation)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOLoginAttempts)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOMenu)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOMenuControlInfo)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOModuleColInfo)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOModuleParamInfo)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOPartyOrCustomer)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOPayGrade)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOPayGradeAllowanceOrBenefit)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOProcessApprovalAlert)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOProfileGroup)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOProfileGroupDetail)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOReimbursement)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOReimbursementType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BORemittanceAdvice)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BORemittanceAdviceDetail)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOReportDashboardInfo)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOSalaryBreakUpPolicy)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOSalaryBreakUpPolicyDetail)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOSalaryTransferMode)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOSectorZone)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOSecurityRight)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOShift)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOShiftDay)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOSRMDataLogging)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOStateProvince)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOSystemOrWebPool)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOTaxAdjustmentType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOTransactionDetail)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOTransactionDocumentConfiguration)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOTransactionDocumentProcess)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOTransactionMaster)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOUMSDataLogging)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOUOM)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOUser3)
                .WithRequired(e => e.BORecordStatus3)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOUserLocationSitePermission)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOUserMenuAdditionSubtraction)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOUserOrganizationCompanyPermission)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOUserPartyOrCustomerPermission)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOUserProfileGroup)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOUserSystemOrWebPermission)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOUserVendorOrSupplierPermission)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOVendorOrSupplier)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BORecordStatus>()
                .HasMany(e => e.BOVoucherType)
                .WithRequired(e => e.BORecordStatus)
                .HasForeignKey(e => e.RecordStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOReimbursementType>()
                .HasMany(e => e.BOReimbursement)
                .WithRequired(e => e.BOReimbursementType)
                .HasForeignKey(e => e.ReimbursementTypeCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOSalaryBreakUpPolicy>()
                .HasMany(e => e.BOEmployeeInfo)
                .WithOptional(e => e.BOSalaryBreakUpPolicy)
                .HasForeignKey(e => e.SalaryBreakUpPolicyCode);

            modelBuilder.Entity<BOSalaryBreakUpPolicy>()
                .HasMany(e => e.BOSalaryBreakUpPolicyDetail)
                .WithRequired(e => e.BOSalaryBreakUpPolicy)
                .HasForeignKey(e => e.SalaryBreakUpPolicyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOSalaryTransferMode>()
                .HasMany(e => e.BOEmployeeInfo)
                .WithRequired(e => e.BOSalaryTransferMode)
                .HasForeignKey(e => e.SalaryTransferMode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOSalaryTransferMode>()
                .HasMany(e => e.BOEmployeeInfoRevision)
                .WithRequired(e => e.BOSalaryTransferMode)
                .HasForeignKey(e => e.SalaryTransferMode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOSalaryTransferMode>()
                .HasMany(e => e.BOEmployeeSalary)
                .WithRequired(e => e.BOSalaryTransferMode)
                .HasForeignKey(e => e.SalaryTransferMode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOTransactionDocumentConfiguration>()
                .HasMany(e => e.BOTransactionDocumentProcess)
                .WithRequired(e => e.BOTransactionDocumentConfiguration)
                .HasForeignKey(e => e.TransactionDocumentConfigurationCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOTransactionDocumentProcess>()
                .HasMany(e => e.BOProcessApprovalWorkflow)
                .WithRequired(e => e.BOTransactionDocumentProcess)
                .HasForeignKey(e => e.TransactionDocumentProcessCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOTransactionDocumentProcess>()
                .HasMany(e => e.BOProcessApprovalAlert)
                .WithRequired(e => e.BOTransactionDocumentProcess)
                .HasForeignKey(e => e.TransactionDocumentProcessCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUOM>()
                .HasMany(e => e.BOItem)
                .WithOptional(e => e.BOUOM)
                .HasForeignKey(e => e.StockUOMCode);

            modelBuilder.Entity<BOUOM>()
                .HasMany(e => e.BOItem1)
                .WithOptional(e => e.BOUOM1)
                .HasForeignKey(e => e.PurchaseUOMCode);

            modelBuilder.Entity<BOUOM>()
                .HasMany(e => e.BOItem2)
                .WithOptional(e => e.BOUOM2)
                .HasForeignKey(e => e.SaleUOMCode);

            modelBuilder.Entity<BOUOM>()
                .HasMany(e => e.BOItem3)
                .WithOptional(e => e.BOUOM3)
                .HasForeignKey(e => e.AssemblyUOMCode);

            modelBuilder.Entity<BOUOM>()
                .HasMany(e => e.BOItem4)
                .WithOptional(e => e.BOUOM4)
                .HasForeignKey(e => e.LifeUOMCode);

            modelBuilder.Entity<BOUOM>()
                .HasMany(e => e.BOJobProjectSchemeDetail)
                .WithOptional(e => e.BOUOM)
                .HasForeignKey(e => e.WeightUOMCode);

            modelBuilder.Entity<BOUOM>()
                .HasMany(e => e.BOJobProjectSchemeDetail1)
                .WithOptional(e => e.BOUOM1)
                .HasForeignKey(e => e.LWHUOMCode);

            modelBuilder.Entity<BOEquipment>()
                .HasMany(e => e.BOBillOrInvoiceMasterDetail)
                .WithOptional(e => e.BOEquipment)
                .HasForeignKey(e => e.EquipmentCode);

            modelBuilder.Entity<BOEquipment>()
                .HasMany(e => e.BOEmployeeLease)
                .WithRequired(e => e.BOEquipment)
                .HasForeignKey(e => e.EquipmentCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOPartyOrCustomer>()
                .Property(e => e.Longitude)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOPartyOrCustomer>()
                .Property(e => e.Latitude)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOPartyOrCustomer>()
                .Property(e => e.Altitude)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOPartyOrCustomer>()
                .Property(e => e.Radius)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOPartyOrCustomer>()
                .HasMany(e => e.BOLocationSite)
                .WithOptional(e => e.BOPartyOrCustomer)
                .HasForeignKey(e => e.PartyOrCustomerCode);

            modelBuilder.Entity<BOPartyOrCustomer>()
                .HasMany(e => e.BOEquipment)
                .WithOptional(e => e.BOPartyOrCustomer)
                .HasForeignKey(e => e.SoldToCustomerCode);

            modelBuilder.Entity<BOPartyOrCustomer>()
                .HasMany(e => e.BOBillOrInvoiceMaster)
                .WithOptional(e => e.BOPartyOrCustomer)
                .HasForeignKey(e => e.CustomerPartyCode);

            modelBuilder.Entity<BOPartyOrCustomer>()
                .HasMany(e => e.BOFundDemandRegisterDetail)
                .WithOptional(e => e.BOPartyOrCustomer)
                .HasForeignKey(e => e.CustomerPartyCode);

            modelBuilder.Entity<BOPartyOrCustomer>()
                .HasMany(e => e.BOFundDemandRequestDetail)
                .WithOptional(e => e.BOPartyOrCustomer)
                .HasForeignKey(e => e.CustomerPartyCode);

            modelBuilder.Entity<BOPartyOrCustomer>()
                .HasMany(e => e.BOPartyOrCustomer1)
                .WithOptional(e => e.BOPartyOrCustomer2)
                .HasForeignKey(e => e.ParentCode);

            modelBuilder.Entity<BOPartyOrCustomer>()
                .HasMany(e => e.BOUserPartyOrCustomerPermission)
                .WithRequired(e => e.BOPartyOrCustomer)
                .HasForeignKey(e => e.PartyOrCustomerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOBank>()
                .HasMany(e => e.BOBankBranch)
                .WithRequired(e => e.BOBank)
                .HasForeignKey(e => e.BankCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOBankAccount>()
                .HasMany(e => e.BOBankAccountInstrumentInfo)
                .WithRequired(e => e.BOBankAccount)
                .HasForeignKey(e => e.BankAccountCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOBankBranch>()
                .HasMany(e => e.BOBankAccount)
                .WithRequired(e => e.BOBankBranch)
                .HasForeignKey(e => e.BankBranchCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOBankBranch>()
                .HasMany(e => e.BOEmployeeInfo)
                .WithOptional(e => e.BOBankBranch)
                .HasForeignKey(e => e.BankBranchCode);

            modelBuilder.Entity<BOBankBranch>()
                .HasMany(e => e.BOEmployeeInfoRevision)
                .WithOptional(e => e.BOBankBranch)
                .HasForeignKey(e => e.BankBranchCode);

            modelBuilder.Entity<BOBankBranch>()
                .HasMany(e => e.BOEmployeeSalary)
                .WithOptional(e => e.BOBankBranch)
                .HasForeignKey(e => e.BankBranchCode);

            modelBuilder.Entity<BOBillOrInvoiceMaster>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOBillOrInvoiceMaster>()
                .Property(e => e.ProfitShare)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOBillOrInvoiceMaster>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOBillOrInvoiceMaster>()
                .Property(e => e.GSTAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOBillOrInvoiceMaster>()
                .Property(e => e.FEDAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOBillOrInvoiceMaster>()
                .Property(e => e.FTAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOBillOrInvoiceMaster>()
                .Property(e => e.BillOrInvoiceAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOBillOrInvoiceMaster>()
                .HasMany(e => e.BOBillOrInvoiceMasterDetail)
                .WithRequired(e => e.BOBillOrInvoiceMaster)
                .HasForeignKey(e => e.BillOrInvoiceMasterCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOBillOrInvoiceMaster>()
                .HasMany(e => e.BORemittanceAdviceDetail)
                .WithRequired(e => e.BOBillOrInvoiceMaster)
                .HasForeignKey(e => e.BillOrInvoiceMasterCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOBillOrInvoiceMaster>()
                .HasMany(e => e.BOTransactionDetail)
                .WithOptional(e => e.BOBillOrInvoiceMaster)
                .HasForeignKey(e => e.BillOrInvoiceCode);

            modelBuilder.Entity<BOBillOrInvoiceMasterDetail>()
                .Property(e => e.SalePrice)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOBillOrInvoiceMasterDetail>()
                .Property(e => e.RetailPrice)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOBillOrInvoiceMasterDetail>()
                .Property(e => e.PrvBalanceAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOBillOrInvoiceMasterDetail>()
                .Property(e => e.Qty)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOBillOrInvoiceMasterDetail>()
                .Property(e => e.SaleAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOBillOrInvoiceMasterDetail>()
                .Property(e => e.RetailAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOBillOrInvoiceMasterDetail>()
                .Property(e => e.GSTRate)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOBillOrInvoiceMasterDetail>()
                .Property(e => e.GSTAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOBillOrInvoiceMasterDetail>()
                .Property(e => e.FEDRate)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOBillOrInvoiceMasterDetail>()
                .Property(e => e.FEDAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOBillOrInvoiceMasterDetail>()
                .Property(e => e.FTRate)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOBillOrInvoiceMasterDetail>()
                .Property(e => e.FTAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOBillOrInvoiceMasterDetail>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOBillOrInvoiceMasterDetail>()
                .Property(e => e.ExchangeRateForMultiCurrency)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOBillOrInvoiceMasterDetail>()
                .HasMany(e => e.BORemittanceAdviceDetail)
                .WithRequired(e => e.BOBillOrInvoiceMasterDetail)
                .HasForeignKey(e => e.BillOrInvoiceMasterDetailCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOBillOrInvoiceMasterDetail>()
                .HasMany(e => e.BOTransactionDetail)
                .WithOptional(e => e.BOBillOrInvoiceMasterDetail)
                .HasForeignKey(e => e.BillOrInvoiceDetailCode);

            modelBuilder.Entity<BOCOA>()
                .Property(e => e.OpenDrAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOCOA>()
                .Property(e => e.OpenCrAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOCOA>()
                .HasMany(e => e.BOSalaryBreakUpPolicyDetail)
                .WithOptional(e => e.BOCOA)
                .HasForeignKey(e => e.COACode);

            modelBuilder.Entity<BOCOA>()
                .HasMany(e => e.BOEquipment)
                .WithOptional(e => e.BOCOA)
                .HasForeignKey(e => e.COACode);

            modelBuilder.Entity<BOCOA>()
                .HasMany(e => e.BOEquipment1)
                .WithOptional(e => e.BOCOA1)
                .HasForeignKey(e => e.AccumulatedCOACode);

            modelBuilder.Entity<BOCOA>()
                .HasMany(e => e.BOPartyOrCustomer)
                .WithOptional(e => e.BOCOA)
                .HasForeignKey(e => e.COACode);

            modelBuilder.Entity<BOCOA>()
                .HasMany(e => e.BOBankAccount)
                .WithOptional(e => e.BOCOA)
                .HasForeignKey(e => e.COACode);

            modelBuilder.Entity<BOCOA>()
                .HasMany(e => e.BOAdditionType)
                .WithOptional(e => e.BOCOA)
                .HasForeignKey(e => e.COACode);

            modelBuilder.Entity<BOCOA>()
                .HasMany(e => e.BOAllowancesOrBenefit)
                .WithOptional(e => e.BOCOA)
                .HasForeignKey(e => e.AllowanceOrBenefitCOACode);

            modelBuilder.Entity<BOCOA>()
                .HasMany(e => e.BOAllowancesOrBenefit1)
                .WithOptional(e => e.BOCOA1)
                .HasForeignKey(e => e.DeductionCOACode);

            modelBuilder.Entity<BOCOA>()
                .HasMany(e => e.BOCOA1)
                .WithOptional(e => e.BOCOA2)
                .HasForeignKey(e => e.COAParentCode);

            modelBuilder.Entity<BOCOA>()
                .HasMany(e => e.BOCOAMapping)
                .WithOptional(e => e.BOCOA)
                .HasForeignKey(e => e.COACode);

            modelBuilder.Entity<BOCOA>()
                .HasMany(e => e.BOCOAMappingForPCorCC)
                .WithOptional(e => e.BOCOA)
                .HasForeignKey(e => e.COACode);

            modelBuilder.Entity<BOCOA>()
                .HasMany(e => e.BODeductionType)
                .WithOptional(e => e.BOCOA)
                .HasForeignKey(e => e.COACode);

            modelBuilder.Entity<BOCOA>()
                .HasMany(e => e.BODocumentDetailOfStatement)
                .WithRequired(e => e.BOCOA)
                .HasForeignKey(e => e.COACode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOCOA>()
                .HasMany(e => e.BOEmployeeInfo)
                .WithOptional(e => e.BOCOA)
                .HasForeignKey(e => e.COACode);

            modelBuilder.Entity<BOCOA>()
                .HasMany(e => e.BOEmployeeInfoRevision)
                .WithOptional(e => e.BOCOA)
                .HasForeignKey(e => e.COACode);

            modelBuilder.Entity<BOCOA>()
                .HasMany(e => e.BOEmployeeSalary)
                .WithOptional(e => e.BOCOA)
                .HasForeignKey(e => e.COACode);

            modelBuilder.Entity<BOCOA>()
                .HasMany(e => e.BOFundDemandRegisterDetail)
                .WithOptional(e => e.BOCOA)
                .HasForeignKey(e => e.COACode);

            modelBuilder.Entity<BOCOA>()
                .HasMany(e => e.BOItemCategory)
                .WithOptional(e => e.BOCOA)
                .HasForeignKey(e => e.COACode);

            modelBuilder.Entity<BOCOA>()
                .HasMany(e => e.BORemittanceAdviceDetail)
                .WithRequired(e => e.BOCOA)
                .HasForeignKey(e => e.COACode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOCOA>()
                .HasMany(e => e.BOTransactionDetail)
                .WithRequired(e => e.BOCOA)
                .HasForeignKey(e => e.COACode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOCOA>()
                .HasMany(e => e.BOVendorOrSupplier)
                .WithOptional(e => e.BOCOA)
                .HasForeignKey(e => e.COACode);

            modelBuilder.Entity<BOCOAConfiguration>()
                .HasMany(e => e.BOCOA)
                .WithOptional(e => e.BOCOAConfiguration)
                .HasForeignKey(e => e.COAConfigurationCode);

            modelBuilder.Entity<BOCOAConfiguration>()
                .HasMany(e => e.BOCOAConfiguration1)
                .WithOptional(e => e.BOCOAConfiguration2)
                .HasForeignKey(e => e.ParentCode);

            modelBuilder.Entity<BOCOAConfiguration>()
                .HasMany(e => e.BOCOAMapping)
                .WithOptional(e => e.BOCOAConfiguration)
                .HasForeignKey(e => e.COAConfigurationCode);

            modelBuilder.Entity<BOCOANature>()
                .HasMany(e => e.BOCOA)
                .WithOptional(e => e.BOCOANature)
                .HasForeignKey(e => e.COANatureCode);

            modelBuilder.Entity<BODocumentDetailOfStatement>()
                .HasMany(e => e.BOFiscalYearMonthDetail)
                .WithOptional(e => e.BODocumentDetailOfStatement)
                .HasForeignKey(e => e.DocumentOfStatementDetailCode);

            modelBuilder.Entity<BODocumentOfStatement>()
                .HasMany(e => e.BODocumentDetailOfStatement)
                .WithRequired(e => e.BODocumentOfStatement)
                .HasForeignKey(e => e.DocumentOfStatementCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BODocumentOfStatement>()
                .HasMany(e => e.BOFiscalYearMonthDetail)
                .WithOptional(e => e.BODocumentOfStatement)
                .HasForeignKey(e => e.DocumentOfStatementCode);

            modelBuilder.Entity<BODomainOfStatement>()
                .HasMany(e => e.BODocumentDetailOfStatement)
                .WithRequired(e => e.BODomainOfStatement)
                .HasForeignKey(e => e.DomainOfStatementCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BODomainOfStatement>()
                .HasMany(e => e.BOFiscalYearMonthDetail)
                .WithOptional(e => e.BODomainOfStatement)
                .HasForeignKey(e => e.DomainofStatementCode);

            modelBuilder.Entity<BOFiscalYear>()
                .HasMany(e => e.BOIMMTaxGroup)
                .WithOptional(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode);

            modelBuilder.Entity<BOFiscalYear>()
                .HasMany(e => e.BOIMMTaxGroupDetail)
                .WithOptional(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode);

            modelBuilder.Entity<BOFiscalYear>()
                .HasMany(e => e.BOIncomeTaxSlab)
                .WithRequired(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOFiscalYear>()
                .HasMany(e => e.BOBillOrInvoiceMaster)
                .WithRequired(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOFiscalYear>()
                .HasMany(e => e.BODocumentDetailOfStatement)
                .WithRequired(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOFiscalYear>()
                .HasMany(e => e.BODocumentOfStatement)
                .WithRequired(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOFiscalYear>()
                .HasMany(e => e.BODomainOfStatement)
                .WithRequired(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOFiscalYear>()
                .HasMany(e => e.BOAttendanceDiscrepancy)
                .WithRequired(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOFiscalYear>()
                .HasMany(e => e.BOCalendar)
                .WithOptional(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode);

            modelBuilder.Entity<BOFiscalYear>()
                .HasMany(e => e.BOEmployeeAttendance)
                .WithRequired(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOFiscalYear>()
                .HasMany(e => e.BOEmployeeIncrement)
                .WithOptional(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode);

            modelBuilder.Entity<BOFiscalYear>()
                .HasMany(e => e.BOEmployeeLease)
                .WithRequired(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOFiscalYear>()
                .HasMany(e => e.BOEmployeeLeave)
                .WithRequired(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOFiscalYear>()
                .HasMany(e => e.BOEmployeeLeaveBalance)
                .WithRequired(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOFiscalYear>()
                .HasMany(e => e.BOEmployeeLoan)
                .WithRequired(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOFiscalYear>()
                .HasMany(e => e.BOEmployeeSalary)
                .WithOptional(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode);

            modelBuilder.Entity<BOFiscalYear>()
                .HasMany(e => e.BOFiscalYearMonth)
                .WithRequired(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOFiscalYear>()
                .HasMany(e => e.BOFiscalYearMonthDetail)
                .WithRequired(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOFiscalYear>()
                .HasMany(e => e.BOFundDemandRegister)
                .WithRequired(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOFiscalYear>()
                .HasMany(e => e.BOFundDemandRequest)
                .WithRequired(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOFiscalYear>()
                .HasMany(e => e.BOLeaveDeductionAgainstLate)
                .WithRequired(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOFiscalYear>()
                .HasMany(e => e.BORemittanceAdvice)
                .WithRequired(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOFiscalYear>()
                .HasMany(e => e.BOTransactionMaster)
                .WithRequired(e => e.BOFiscalYear)
                .HasForeignKey(e => e.FiscalYearCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOFiscalYearMonth>()
                .HasMany(e => e.BOFiscalYearMonthDetail)
                .WithRequired(e => e.BOFiscalYearMonth)
                .HasForeignKey(e => e.FiscalYearMonthCode)
                .WillCascadeOnDelete(false);

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

            modelBuilder.Entity<BOTransactionDetail>()
                .Property(e => e.DrAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOTransactionDetail>()
                .Property(e => e.CrAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOTransactionDetail>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOTransactionDetail>()
                .Property(e => e.ExchangeRateForMultiCurrency)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOTransactionMaster>()
                .HasMany(e => e.BOTransactionDetail)
                .WithRequired(e => e.BOTransactionMaster)
                .HasForeignKey(e => e.TransactionCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOVoucherType>()
                .HasMany(e => e.BOTransactionMaster)
                .WithRequired(e => e.BOVoucherType)
                .HasForeignKey(e => e.VoucherTypeCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOCityTown>()
                .HasMany(e => e.BOPartyOrCustomer)
                .WithOptional(e => e.BOCityTown)
                .HasForeignKey(e => e.CityTownCode);

            modelBuilder.Entity<BOCityTown>()
                .HasMany(e => e.BODistrictWard)
                .WithRequired(e => e.BOCityTown)
                .HasForeignKey(e => e.CityTownCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOCityTown>()
                .HasMany(e => e.BOEmployeeInfo)
                .WithRequired(e => e.BOCityTown)
                .HasForeignKey(e => e.CityTownCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOCityTown>()
                .HasMany(e => e.BOEmployeeInfoRevision)
                .WithRequired(e => e.BOCityTown)
                .HasForeignKey(e => e.CityTownCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOCityTown>()
                .HasMany(e => e.BOVendorOrSupplier)
                .WithOptional(e => e.BOCityTown)
                .HasForeignKey(e => e.CityTownCode);

            modelBuilder.Entity<BOCountryRegion>()
                .HasMany(e => e.BOCityTown)
                .WithRequired(e => e.BOCountryRegion)
                .HasForeignKey(e => e.CountryRegionCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOCountryRegion>()
                .HasMany(e => e.BOStateProvince)
                .WithRequired(e => e.BOCountryRegion)
                .HasForeignKey(e => e.CountryRegionCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BODistrictWard>()
                .HasMany(e => e.BOPartyOrCustomer)
                .WithOptional(e => e.BODistrictWard)
                .HasForeignKey(e => e.DistrictWardCode);

            modelBuilder.Entity<BODistrictWard>()
                .HasMany(e => e.BOAreaOfDistrictWard)
                .WithOptional(e => e.BODistrictWard)
                .HasForeignKey(e => e.DistrictWardCode);

            modelBuilder.Entity<BODistrictWard>()
                .HasMany(e => e.BOEmployeeInfo)
                .WithOptional(e => e.BODistrictWard)
                .HasForeignKey(e => e.DistrictWardCode);

            modelBuilder.Entity<BODistrictWard>()
                .HasMany(e => e.BOEmployeeInfoRevision)
                .WithOptional(e => e.BODistrictWard)
                .HasForeignKey(e => e.DistrictWardCode);

            modelBuilder.Entity<BODistrictWard>()
                .HasMany(e => e.BOVendorOrSupplier)
                .WithOptional(e => e.BODistrictWard)
                .HasForeignKey(e => e.DistrictWardCode);

            modelBuilder.Entity<BOSectorZone>()
                .HasMany(e => e.BOCountryRegion)
                .WithRequired(e => e.BOSectorZone)
                .HasForeignKey(e => e.SectorZoneCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOStateProvince>()
                .HasMany(e => e.BOIMMTaxGroup)
                .WithOptional(e => e.BOStateProvince)
                .HasForeignKey(e => e.StateProvinceCode);

            modelBuilder.Entity<BOStateProvince>()
                .HasMany(e => e.BOIMMTaxGroupDetail)
                .WithOptional(e => e.BOStateProvince)
                .HasForeignKey(e => e.StateProvinceCode);

            modelBuilder.Entity<BOStateProvince>()
                .HasMany(e => e.BOCityTown)
                .WithOptional(e => e.BOStateProvince)
                .HasForeignKey(e => e.StateProvinceCode);

            modelBuilder.Entity<BOAdditionType>()
                .HasMany(e => e.BOEmployeeSalaryAddition)
                .WithRequired(e => e.BOAdditionType)
                .HasForeignKey(e => e.AdditionTypeCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOAllowancesOrBenefit>()
                .HasMany(e => e.BOPayGradeAllowanceOrBenefit)
                .WithRequired(e => e.BOAllowancesOrBenefit)
                .HasForeignKey(e => e.AllowanceOrBenefitAmountCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BODeductionType>()
                .HasMany(e => e.BOEmployeeSalaryDeduction)
                .WithRequired(e => e.BODeductionType)
                .HasForeignKey(e => e.DeductionTypeCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BODegreeInstitute>()
                .Property(e => e.Longitude)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BODegreeInstitute>()
                .Property(e => e.Latitude)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BODegreeInstitute>()
                .Property(e => e.Altitude)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BODegreeInstitute>()
                .Property(e => e.Radius)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BODepartment>()
                .HasMany(e => e.BOProcessApprovalWorkflow)
                .WithOptional(e => e.BODepartment)
                .HasForeignKey(e => e.DeptCode);

            modelBuilder.Entity<BODepartment>()
                .HasMany(e => e.BODepartment1)
                .WithOptional(e => e.BODepartment2)
                .HasForeignKey(e => e.ParentCode);

            modelBuilder.Entity<BODepartment>()
                .HasMany(e => e.BODesignation)
                .WithOptional(e => e.BODepartment)
                .HasForeignKey(e => e.DepartmentCode);

            modelBuilder.Entity<BODepartment>()
                .HasMany(e => e.BODocumentCheckList)
                .WithOptional(e => e.BODepartment)
                .HasForeignKey(e => e.DepartmentCode);

            modelBuilder.Entity<BODepartment>()
                .HasMany(e => e.BOEmployeeInfo)
                .WithRequired(e => e.BODepartment)
                .HasForeignKey(e => e.DeptCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BODepartment>()
                .HasMany(e => e.BOEmployeeInfoRevision)
                .WithRequired(e => e.BODepartment)
                .HasForeignKey(e => e.DeptCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BODesignation>()
                .HasMany(e => e.BOEmployeeInfo)
                .WithRequired(e => e.BODesignation)
                .HasForeignKey(e => e.DesignationCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BODesignation>()
                .HasMany(e => e.BOEmployeeInfoRevision)
                .WithRequired(e => e.BODesignation)
                .HasForeignKey(e => e.DesignationCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BODocumentCheckList>()
                .HasMany(e => e.BOEmpDocumentCheckList)
                .WithRequired(e => e.BODocumentCheckList)
                .HasForeignKey(e => e.DocumentCheckListCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeAllowanceOrBenefit>()
                .Property(e => e.AllowanceOrBenefitAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOEmployeeAllowanceOrBenefit>()
                .HasMany(e => e.BOEmployeeIncrementAllowanceOrBenefit)
                .WithRequired(e => e.BOEmployeeAllowanceOrBenefit)
                .HasForeignKey(e => e.EmployeeAllowanceOrBenefitCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeAllowanceOrBenefit>()
                .HasMany(e => e.BOEmployeeSalaryAllowanceOrBenefit)
                .WithRequired(e => e.BOEmployeeAllowanceOrBenefit)
                .HasForeignKey(e => e.EmployeeAllowanceOrBenefitCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeIncrement>()
                .Property(e => e.PFAmount)
                .HasPrecision(33, 6);

            modelBuilder.Entity<BOEmployeeIncrement>()
                .HasMany(e => e.BOEmployeeIncrementAllowanceOrBenefit)
                .WithRequired(e => e.BOEmployeeIncrement)
                .HasForeignKey(e => e.EmpIncrementCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeInfo>()
                .Property(e => e.PFAmount)
                .HasPrecision(33, 6);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOBillOrInvoiceMaster)
                .WithOptional(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.RecoveredByEmpCode);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOJobProjectScheme)
                .WithOptional(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.BeneficiaryEmpCode);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOJobProjectScheme1)
                .WithOptional(e => e.BOEmployeeInfo1)
                .HasForeignKey(e => e.AssignedToEmpCode);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BORemittanceAdvice)
                .WithOptional(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.CheckedByEmpCode);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BORemittanceAdvice1)
                .WithOptional(e => e.BOEmployeeInfo1)
                .HasForeignKey(e => e.ApprovedByEmpCode);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BORemittanceAdvice2)
                .WithOptional(e => e.BOEmployeeInfo2)
                .HasForeignKey(e => e.SalePersonEmpCode);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOTransactionDetail)
                .WithOptional(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.RecoveredByEmpCode);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOTransactionMaster)
                .WithOptional(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.RecoveredByEmpCode);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOAttendanceDiscrepancy)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOEmpDocumentCheckList)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOEmployeeAcademic)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOEmployeeAllowanceOrBenefit)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOEmployeeAttendance)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOEmployeeEmployment)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOEmployeeFaceOrBiometric)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOEmployeeFamily)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOEmployeeIncrement)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOEmployeeIncrementAllowanceOrBenefit)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOEmployeeInfo1)
                .WithOptional(e => e.BOEmployeeInfo2)
                .HasForeignKey(e => e.FunctionalEmployeeCode);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOEmployeeInfo11)
                .WithOptional(e => e.BOEmployeeInfo3)
                .HasForeignKey(e => e.ReportingEmployeeCode);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOEmployeeInfo12)
                .WithOptional(e => e.BOEmployeeInfo4)
                .HasForeignKey(e => e.HODEmployeeCode);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOEmployeeInfoRevision)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpOldCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOEmployeeLease)
                .WithOptional(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOEmployeeLeave)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOEmployeeLeaveBalance)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOEmployeeLoan)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOEmployeeReference)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOEmployeeSalary)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOEmployeeSalaryAddition)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOEmployeeSalaryAllowanceOrBenefit)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOEmployeeSalaryDeduction)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOEmployeeSalaryReimbursement)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOFundDemandRegister)
                .WithOptional(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.RequestedByEmpCode);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOFundDemandRegister1)
                .WithOptional(e => e.BOEmployeeInfo1)
                .HasForeignKey(e => e.PaidByEmpCode);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOFundDemandRequest)
                .WithOptional(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.RequestedByEmpCode);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOLeaveDeductionAgainstLate)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOProcessApprovalAlert)
                .WithOptional(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.ActionByEmpCode);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOReimbursement)
                .WithOptional(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.EmpCode);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOUser3)
                .WithOptional(e => e.BOEmployeeInfo3)
                .HasForeignKey(e => e.DefaultEmpCode);

            modelBuilder.Entity<BOEmployeeInfoHistory>()
                .Property(e => e.BasicPay)
                .HasPrecision(38, 2);

            modelBuilder.Entity<BOEmployeeInfoHistory>()
                .Property(e => e.Salary)
                .HasPrecision(38, 2);

            modelBuilder.Entity<BOEmployeeInfoHistory>()
                .Property(e => e.EOBI)
                .HasPrecision(38, 2);

            modelBuilder.Entity<BOEmployeeInfoHistory>()
                .Property(e => e.HospitalDeduction)
                .HasPrecision(38, 2);

            modelBuilder.Entity<BOEmployeeInfoHistory>()
                .Property(e => e.MaternityDeduction)
                .HasPrecision(38, 2);

            modelBuilder.Entity<BOEmployeeInfoHistory>()
                .Property(e => e.MonthlyTax)
                .HasPrecision(38, 2);

            modelBuilder.Entity<BOEmployeeInfoHistory>()
                .Property(e => e.AnnaulTax)
                .HasPrecision(38, 2);

            modelBuilder.Entity<BOEmployeeInfoHistory>()
                .Property(e => e.PFAmount)
                .HasPrecision(38, 6);

            modelBuilder.Entity<BOEmployeeInfoHistory>()
                .Property(e => e.TempCurrentMonthAddition)
                .HasPrecision(38, 2);

            modelBuilder.Entity<BOEmployeeInfoRevision>()
                .Property(e => e.PFAmount)
                .HasPrecision(33, 6);

            modelBuilder.Entity<BOEmployeeInfoRevision>()
                .HasMany(e => e.BOEmployeeIncrement)
                .WithRequired(e => e.BOEmployeeInfoRevision)
                .HasForeignKey(e => e.EmpRevisionCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeInfoRevision>()
                .HasMany(e => e.BOEmployeeInfoRevision1)
                .WithOptional(e => e.BOEmployeeInfoRevision2)
                .HasForeignKey(e => e.FunctionalEmployeeCode);

            modelBuilder.Entity<BOEmployeeInfoRevision>()
                .HasMany(e => e.BOEmployeeInfoRevision11)
                .WithOptional(e => e.BOEmployeeInfoRevision3)
                .HasForeignKey(e => e.ReportingEmployeeCode);

            modelBuilder.Entity<BOEmployeeInfoRevision>()
                .HasMany(e => e.BOEmployeeInfoRevision12)
                .WithOptional(e => e.BOEmployeeInfoRevision4)
                .HasForeignKey(e => e.HODEmployeeCode);

            modelBuilder.Entity<BOEmployeeLease>()
                .HasMany(e => e.BOEmployeeLeaseInstallment)
                .WithRequired(e => e.BOEmployeeLease)
                .HasForeignKey(e => e.EmployeeLeaseCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeLease>()
                .HasMany(e => e.BOReimbursement)
                .WithOptional(e => e.BOEmployeeLease)
                .HasForeignKey(e => e.EmployeeLeaseCode);

            modelBuilder.Entity<BOEmployeeLoan>()
                .HasMany(e => e.BOEmployeeLoanInstallment)
                .WithRequired(e => e.BOEmployeeLoan)
                .HasForeignKey(e => e.EmployeeLoanCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeLoan>()
                .HasMany(e => e.BOReimbursement)
                .WithOptional(e => e.BOEmployeeLoan)
                .HasForeignKey(e => e.EmployeeLoanCode);

            modelBuilder.Entity<BOEmployeeSalary>()
                .Property(e => e.PFAmount)
                .HasPrecision(33, 6);

            modelBuilder.Entity<BOEmployeeSalary>()
                .HasMany(e => e.BOEmployeeSalaryAddition)
                .WithRequired(e => e.BOEmployeeSalary)
                .HasForeignKey(e => e.EmpSalaryCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeSalary>()
                .HasMany(e => e.BOEmployeeSalaryAllowanceOrBenefit)
                .WithRequired(e => e.BOEmployeeSalary)
                .HasForeignKey(e => e.EmpSalaryCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeSalary>()
                .HasMany(e => e.BOEmployeeSalaryReimbursement)
                .WithRequired(e => e.BOEmployeeSalary)
                .HasForeignKey(e => e.EmpSalaryCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeStatus>()
                .HasMany(e => e.BOEmployeeIncrement)
                .WithRequired(e => e.BOEmployeeStatus)
                .HasForeignKey(e => e.EmpStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeStatus>()
                .HasMany(e => e.BOEmployeeInfo)
                .WithRequired(e => e.BOEmployeeStatus)
                .HasForeignKey(e => e.EmpStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeStatus>()
                .HasMany(e => e.BOEmployeeInfoRevision)
                .WithRequired(e => e.BOEmployeeStatus)
                .HasForeignKey(e => e.EmpStatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeStatus>()
                .HasMany(e => e.BOEmployeeSalary)
                .WithRequired(e => e.BOEmployeeStatus)
                .HasForeignKey(e => e.EmpStatusCode)
                .WillCascadeOnDelete(false);

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

            modelBuilder.Entity<BOHireType>()
                .Property(e => e.PeriodInDays)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOHireType>()
                .HasMany(e => e.BOEmployeeIncrement)
                .WithRequired(e => e.BOHireType)
                .HasForeignKey(e => e.HireTypeCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOHireType>()
                .HasMany(e => e.BOEmployeeInfo)
                .WithRequired(e => e.BOHireType)
                .HasForeignKey(e => e.HireTypeCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOHireType>()
                .HasMany(e => e.BOEmployeeInfoRevision)
                .WithRequired(e => e.BOHireType)
                .HasForeignKey(e => e.HireTypeCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOHireType>()
                .HasMany(e => e.BOEmployeeSalary)
                .WithRequired(e => e.BOHireType)
                .HasForeignKey(e => e.HireTypeCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOJobRole>()
                .HasMany(e => e.BOEmployeeInfo)
                .WithOptional(e => e.BOJobRole)
                .HasForeignKey(e => e.JobRoleCode);

            modelBuilder.Entity<BOJobRole>()
                .HasMany(e => e.BOEmployeeInfoRevision)
                .WithOptional(e => e.BOJobRole)
                .HasForeignKey(e => e.JobRoleCode);

            modelBuilder.Entity<BOLeavePolicy>()
                .HasMany(e => e.BOEmployeeInfo)
                .WithOptional(e => e.BOLeavePolicy)
                .HasForeignKey(e => e.LeavePolicyCode);

            modelBuilder.Entity<BOLeavePolicy>()
                .HasMany(e => e.BOEmployeeInfoRevision)
                .WithOptional(e => e.BOLeavePolicy)
                .HasForeignKey(e => e.LeavePolicyCode);

            modelBuilder.Entity<BOLeavePolicy>()
                .HasMany(e => e.BOEmployeeLeave)
                .WithOptional(e => e.BOLeavePolicy)
                .HasForeignKey(e => e.LeavePolicyCode);

            modelBuilder.Entity<BOLeavePolicy>()
                .HasMany(e => e.BOEmployeeLeaveBalance)
                .WithOptional(e => e.BOLeavePolicy)
                .HasForeignKey(e => e.LeavePolicyCode);

            modelBuilder.Entity<BOLeavePolicy>()
                .HasMany(e => e.BOEmployeeSalary)
                .WithOptional(e => e.BOLeavePolicy)
                .HasForeignKey(e => e.LeavePolicyCode);

            modelBuilder.Entity<BOLeavePolicy>()
                .HasMany(e => e.BOLeaveDeductionAgainstLate)
                .WithOptional(e => e.BOLeavePolicy)
                .HasForeignKey(e => e.LeavePolicyCode);

            modelBuilder.Entity<BOLeavePolicy>()
                .HasMany(e => e.BOLeavePolicyDetail)
                .WithRequired(e => e.BOLeavePolicy)
                .HasForeignKey(e => e.LeavePolicyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOLeavePolicyDetail>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOLeavePolicyDetail>()
                .Property(e => e.ServiceInYear)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOLeaveType>()
                .HasMany(e => e.BOEmployeeLeave)
                .WithOptional(e => e.BOLeaveType)
                .HasForeignKey(e => e.LeaveTypeCode);

            modelBuilder.Entity<BOLeaveType>()
                .HasMany(e => e.BOEmployeeLeaveBalance)
                .WithOptional(e => e.BOLeaveType)
                .HasForeignKey(e => e.LeaveTypeCode);

            modelBuilder.Entity<BOLeaveType>()
                .HasMany(e => e.BOLeaveDeductionAgainstLate)
                .WithOptional(e => e.BOLeaveType)
                .HasForeignKey(e => e.LeaveTypeCode);

            modelBuilder.Entity<BOLeaveType>()
                .HasMany(e => e.BOLeavePolicyDetail)
                .WithRequired(e => e.BOLeaveType)
                .HasForeignKey(e => e.LeaveTypeCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOPayGrade>()
                .Property(e => e.SalaryFrom)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOPayGrade>()
                .Property(e => e.SalaryTo)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOPayGrade>()
                .HasMany(e => e.BOEmployeeIncrement)
                .WithOptional(e => e.BOPayGrade)
                .HasForeignKey(e => e.PayGradeCode);

            modelBuilder.Entity<BOPayGrade>()
                .HasMany(e => e.BOEmployeeInfo)
                .WithOptional(e => e.BOPayGrade)
                .HasForeignKey(e => e.PayGradeCode);

            modelBuilder.Entity<BOPayGrade>()
                .HasMany(e => e.BOEmployeeInfoRevision)
                .WithOptional(e => e.BOPayGrade)
                .HasForeignKey(e => e.PayGradeCode);

            modelBuilder.Entity<BOPayGrade>()
                .HasMany(e => e.BOEmployeeSalary)
                .WithOptional(e => e.BOPayGrade)
                .HasForeignKey(e => e.PayGradeCode);

            modelBuilder.Entity<BOPayGrade>()
                .HasMany(e => e.BOPayGradeAllowanceOrBenefit)
                .WithRequired(e => e.BOPayGrade)
                .HasForeignKey(e => e.PayGradeCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOPayGradeAllowanceOrBenefit>()
                .Property(e => e.AllowanceOrBenefitAmount)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOPayGradeAllowanceOrBenefit>()
                .HasMany(e => e.BOEmployeeAllowanceOrBenefit)
                .WithRequired(e => e.BOPayGradeAllowanceOrBenefit)
                .HasForeignKey(e => e.PayGradeAllowanceOrBenefitCode)
                .WillCascadeOnDelete(false);

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

            modelBuilder.Entity<BOShift>()
                .Property(e => e.ShiftInMinute)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOShift>()
                .Property(e => e.PreGraceStart)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOShift>()
                .Property(e => e.PostGraceStart)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOShift>()
                .Property(e => e.PreGraceEnd)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOShift>()
                .Property(e => e.PostGraceEnd)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOShift>()
                .HasMany(e => e.BOAttendanceDiscrepancy)
                .WithRequired(e => e.BOShift)
                .HasForeignKey(e => e.ShiftCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOShift>()
                .HasMany(e => e.BOEmployeeAttendance)
                .WithRequired(e => e.BOShift)
                .HasForeignKey(e => e.ShiftCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOShift>()
                .HasMany(e => e.BOEmployeeInfo)
                .WithRequired(e => e.BOShift)
                .HasForeignKey(e => e.ShiftCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOShift>()
                .HasMany(e => e.BOEmployeeInfoRevision)
                .WithRequired(e => e.BOShift)
                .HasForeignKey(e => e.ShiftCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOShift>()
                .HasMany(e => e.BOEmployeeSalary)
                .WithRequired(e => e.BOShift)
                .HasForeignKey(e => e.ShiftCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOShift>()
                .HasMany(e => e.BOLeaveDeductionAgainstLate)
                .WithRequired(e => e.BOShift)
                .HasForeignKey(e => e.ShiftCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOShift>()
                .HasMany(e => e.BOShiftDay)
                .WithRequired(e => e.BOShift)
                .HasForeignKey(e => e.ShiftCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOIMMConfiguration>()
                .HasMany(e => e.BOIMMConfiguration1)
                .WithOptional(e => e.BOIMMConfiguration2)
                .HasForeignKey(e => e.ParentCode);

            modelBuilder.Entity<BOIMMConfiguration>()
                .HasMany(e => e.BOItemCategory)
                .WithRequired(e => e.BOIMMConfiguration)
                .HasForeignKey(e => e.IMMConfigurationCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOItem>()
                .Property(e => e.DefaultQty)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOItem>()
                .Property(e => e.MinLevel)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOItem>()
                .Property(e => e.ReOrderLevel)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOItem>()
                .Property(e => e.MaxLevel)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOItem>()
                .Property(e => e.PurchaseConversionFactor)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOItem>()
                .Property(e => e.SaleConversionFactor)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOItem>()
                .Property(e => e.AssemblyConversionFactor)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOItem>()
                .HasMany(e => e.BOItemAttributeAspect)
                .WithRequired(e => e.BOItem)
                .HasForeignKey(e => e.ItemCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOItem>()
                .HasMany(e => e.BOItemAttributeAspectDetail)
                .WithRequired(e => e.BOItem)
                .HasForeignKey(e => e.ItemCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOItem>()
                .HasMany(e => e.BOItemPrice)
                .WithRequired(e => e.BOItem)
                .HasForeignKey(e => e.ItemCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOItem>()
                .HasMany(e => e.BOItemProfile)
                .WithRequired(e => e.BOItem)
                .HasForeignKey(e => e.ItemCode)
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


            modelBuilder.Entity<BOItemAttribute>()
                .HasMany(e => e.BOItemAttributeAspect)
                .WithOptional(e => e.BOItemAttribute)
                .HasForeignKey(e => e.ItemAttributeCode);

            modelBuilder.Entity<BOItemAttribute>()
                .HasMany(e => e.BOItemAttributeDetail)
                .WithRequired(e => e.BOItemAttribute)
                .HasForeignKey(e => e.ItemAttributeCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOItemAttribute>()
                .HasMany(e => e.BOItemCategoryAttributeAspect)
                .WithOptional(e => e.BOItemAttribute)
                .HasForeignKey(e => e.ItemAttributeCode);

            modelBuilder.Entity<BOItemAttributeAspect>()
                .HasMany(e => e.BOItemAttributeAspectDetail)
                .WithRequired(e => e.BOItemAttributeAspect)
                .HasForeignKey(e => e.ItemAttributeAspectCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOItemAttributeDetail>()
                .HasMany(e => e.BOItemAttributeAspectDetail)
                .WithOptional(e => e.BOItemAttributeDetail)
                .HasForeignKey(e => e.ItemAttributeDetailCode);

            modelBuilder.Entity<BOItemAttributeDetail>()
                .HasMany(e => e.BOItemCategoryAttributeAspectDetail)
                .WithOptional(e => e.BOItemAttributeDetail)
                .HasForeignKey(e => e.ItemAttributeDetailCode);

            modelBuilder.Entity<BOItemCategory>()
                .HasMany(e => e.BOItem)
                .WithRequired(e => e.BOItemCategory)
                .HasForeignKey(e => e.ItemCategoryCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOItemCategory>()
                .HasMany(e => e.BOItemCategory1)
                .WithOptional(e => e.BOItemCategory2)
                .HasForeignKey(e => e.ParentCode);

            modelBuilder.Entity<BOItemCategory>()
                .HasMany(e => e.BOItemCategoryAttributeAspect)
                .WithRequired(e => e.BOItemCategory)
                .HasForeignKey(e => e.ItemCategoryCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOItemCategory>()
                .HasMany(e => e.BOItemCategoryAttributeAspectDetail)
                .WithRequired(e => e.BOItemCategory)
                .HasForeignKey(e => e.ItemCategoryCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOItemCategoryAttributeAspect>()
                .HasMany(e => e.BOItemCategoryAttributeAspectDetail)
                .WithRequired(e => e.BOItemCategoryAttributeAspect)
                .HasForeignKey(e => e.ItemCategoryAttributeAspectCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOItemProfile>()
                .HasMany(e => e.BOItemPrice)
                .WithOptional(e => e.BOItemProfile)
                .HasForeignKey(e => e.ItemProfileCode);

            modelBuilder.Entity<BOItemProfile>()
                .HasMany(e => e.BOItemAttributeAspect)
                .WithOptional(e => e.BOItemProfile)
                .HasForeignKey(e => e.ItemProfileCode);

            modelBuilder.Entity<BOMenu>()
                .HasMany(e => e.BOTransactionDocumentProcess)
                .WithOptional(e => e.BOMenu)
                .HasForeignKey(e => e.MenuCode);

            modelBuilder.Entity<BOMenu>()
                .HasMany(e => e.BOActionLogging)
                .WithOptional(e => e.BOMenu)
                .HasForeignKey(e => e.MenuCode);

            modelBuilder.Entity<BOMenu>()
                .HasMany(e => e.BOAPPCNFDataLogging)
                .WithOptional(e => e.BOMenu)
                .HasForeignKey(e => e.MenuCode);

            modelBuilder.Entity<BOMenu>()
                .HasMany(e => e.BOCRMDataLogging)
                .WithOptional(e => e.BOMenu)
                .HasForeignKey(e => e.MenuCode);

            modelBuilder.Entity<BOMenu>()
                .HasMany(e => e.BOErrorLogging)
                .WithOptional(e => e.BOMenu)
                .HasForeignKey(e => e.MenuCode);

            modelBuilder.Entity<BOMenu>()
                .HasMany(e => e.BOFICODataLogging)
                .WithOptional(e => e.BOMenu)
                .HasForeignKey(e => e.MenuCode);

            modelBuilder.Entity<BOMenu>()
                .HasMany(e => e.BOHRMDataLogging)
                .WithOptional(e => e.BOMenu)
                .HasForeignKey(e => e.MenuCode);

            modelBuilder.Entity<BOMenu>()
                .HasMany(e => e.BOIMMDataLogging)
                .WithOptional(e => e.BOMenu)
                .HasForeignKey(e => e.MenuCode);

            modelBuilder.Entity<BOMenu>()
                .HasMany(e => e.BOSRMDataLogging)
                .WithOptional(e => e.BOMenu)
                .HasForeignKey(e => e.MenuCode);

            modelBuilder.Entity<BOMenu>()
                .HasMany(e => e.BOUMSDataLogging)
                .WithOptional(e => e.BOMenu)
                .HasForeignKey(e => e.MenuCode);

            modelBuilder.Entity<BOMenu>()
                .HasMany(e => e.BOMenuControlInfo)
                .WithRequired(e => e.BOMenu)
                .HasForeignKey(e => e.MenuCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOMenu>()
                .HasMany(e => e.BOModuleColInfo)
                .WithRequired(e => e.BOMenu)
                .HasForeignKey(e => e.MenuCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOMenu>()
                .HasMany(e => e.BOModuleParamInfo)
                .WithRequired(e => e.BOMenu)
                .HasForeignKey(e => e.MenuCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOMenu>()
                .HasMany(e => e.BOProfileGroupDetail)
                .WithRequired(e => e.BOMenu)
                .HasForeignKey(e => e.MenuCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOMenu>()
                .HasMany(e => e.BOReportDashboardInfo)
                .WithRequired(e => e.BOMenu)
                .HasForeignKey(e => e.MenuCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOMenu>()
                .HasMany(e => e.BOUser3)
                .WithOptional(e => e.BOMenu3)
                .HasForeignKey(e => e.DefaultMenuCode);

            modelBuilder.Entity<BOMenu>()
                .HasMany(e => e.BOUserMenuAdditionSubtraction)
                .WithOptional(e => e.BOMenu)
                .HasForeignKey(e => e.AdditionMenuCode);

            modelBuilder.Entity<BOMenu>()
                .HasMany(e => e.BOUserMenuAdditionSubtraction1)
                .WithOptional(e => e.BOMenu1)
                .HasForeignKey(e => e.SubtractionMenuCode);

            modelBuilder.Entity<BOMenuControlInfo>()
                .HasMany(e => e.BOModuleColInfo)
                .WithOptional(e => e.BOMenuControlInfo)
                .HasForeignKey(e => e.MenuControlInfoCode);

            modelBuilder.Entity<BOModuleParamInfo>()
                .HasMany(e => e.BOMenuControlInfo)
                .WithOptional(e => e.BOModuleParamInfo)
                .HasForeignKey(e => e.MenuParamInfoCode);

            modelBuilder.Entity<BOModuleParamInfo>()
                .HasMany(e => e.BOModuleColInfo)
                .WithOptional(e => e.BOModuleParamInfo)
                .HasForeignKey(e => e.MenuParamInfoCode);

            modelBuilder.Entity<BOProfileGroup>()
                .HasMany(e => e.BOProfileGroupDetail)
                .WithRequired(e => e.BOProfileGroup)
                .HasForeignKey(e => e.ProfileGroupCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOProfileGroup>()
                .HasMany(e => e.BOUser3)
                .WithOptional(e => e.BOProfileGroup3)
                .HasForeignKey(e => e.DefaultProfileGroupCode);

            modelBuilder.Entity<BOProfileGroup>()
                .HasMany(e => e.BOUserProfileGroup)
                .WithRequired(e => e.BOProfileGroup)
                .HasForeignKey(e => e.ProfileGroupCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOSecurityRight>()
                .HasMany(e => e.BOProfileGroupDetail)
                .WithRequired(e => e.BOSecurityRight)
                .HasForeignKey(e => e.SecurityRightCode)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<IdentityUserProfile>()
            //    .Property(e => e.FirstName)
            //    .IsUnicode(false);
            //
            //modelBuilder.Entity<IdentityUserProfile>()
            //    .Property(e => e.LastName)
            //    .IsUnicode(false);
            //
            //modelBuilder.Entity<IdentityUserProfile>()
            //    .Property(e => e.FullName)
            //    .IsUnicode(false);

            modelBuilder.Entity<BOVendorOrSupplier>()
                .Property(e => e.Longitude)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOVendorOrSupplier>()
                .Property(e => e.Latitude)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOVendorOrSupplier>()
                .Property(e => e.Altitude)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOVendorOrSupplier>()
                .Property(e => e.Radius)
                .HasPrecision(18, 7);

            modelBuilder.Entity<BOVendorOrSupplier>()
                .HasMany(e => e.BORemittanceAdvice)
                .WithOptional(e => e.BOVendorOrSupplier)
                .HasForeignKey(e => e.VendorSupplierCode);

            modelBuilder.Entity<BOVendorOrSupplier>()
                .HasMany(e => e.BOUserVendorOrSupplierPermission)
                .WithRequired(e => e.BOVendorOrSupplier)
                .HasForeignKey(e => e.VendorOrSupplierCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOVendorOrSupplier>()
                .HasMany(e => e.BOVendorOrSupplier1)
                .WithOptional(e => e.BOVendorOrSupplier2)
                .HasForeignKey(e => e.ParentCode);

            modelBuilder.Entity<BOSystemOrWebPool>()
                .HasMany(e => e.BOUserSystemOrWebPermission)
                .WithRequired(e => e.BOSystemOrWebPool)
                .HasForeignKey(e => e.SystemOrWebCode)
                .WillCascadeOnDelete(false);

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
                .HasMany(e => e.BOAdditionType)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOAdditionType1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOAdditionType2)
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
                .HasMany(e => e.BOEmployeeSalaryAddition)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeSalaryAddition1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOEmployeeSalaryAddition2)
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
                .HasMany(e => e.BOUserMenuAdditionSubtraction)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.UserCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOUserMenuAdditionSubtraction1)
                .WithRequired(e => e.BOUser1)
                .HasForeignKey(e => e.AlteredByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOUserMenuAdditionSubtraction2)
                .WithRequired(e => e.BOUser2)
                .HasForeignKey(e => e.CreatedByCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOUserMenuAdditionSubtraction3)
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

            modelBuilder.Entity<BOTeamInfo>()
                .HasMany(e => e.BOTeamMembers)
                .WithRequired(e => e.BOTeamInfo)
                .HasForeignKey(e => e.TeamInfoCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUser>()
                .HasMany(e => e.BOTeamMembers)
                .WithRequired(e => e.BOUser)
                .HasForeignKey(e => e.MemberCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOCRMTeamRole>()
                .HasMany(e => e.BOTeamMembers)
                .WithRequired(e => e.BOCRMTeamRole)
                .HasForeignKey(e => e.RoleTypeCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOTeamInfo>()
                .HasMany(e => e.BOTeamPermissions)
                .WithRequired(e => e.BOTeamInfo)
                .HasForeignKey(e => e.TeamInfoCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOCRMPermissionType>()
                .HasMany(e => e.BOTeamPermissions)
                .WithRequired(e => e.BOCRMPermissionType)
                .HasForeignKey(e => e.PermissionTypeCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOPipeline>()
                .HasMany(e => e.BOTeamPermissions)
                .WithRequired(e => e.BOPipeline)
                .HasForeignKey(e => e.PipelineCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOPipeline>()
                .HasMany(e => e.BOPipelineDetail)
                .WithRequired(e => e.BOPipeline)
                .HasForeignKey(e => e.PipelineCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOCRMConfiguration>()
                .HasMany(e => e.BOPipelineDetail)
                .WithRequired(e => e.BOCRMConfiguration)
                .HasForeignKey(e => e.StageCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOLead>()
                .HasMany(e => e.BOLeadActivity)
                .WithRequired(e => e.BOLead)
                .HasForeignKey(e => e.LeadCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOCRMConfiguration>()
                .HasMany(e => e.BOLeadActivity)
                .WithRequired(e => e.BOCRMConfiguration)
                .HasForeignKey(e => e.ActivityTypeCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOCRMConfiguration>()
                .HasMany(e => e.BOLead)
                .WithRequired(e => e.BOCRMConfiguration)
                .HasForeignKey(e => e.ContactCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOCRMConfiguration>()
                .HasMany(e => e.BOLead1)
                .WithRequired(e => e.BOCRMConfiguration1)
                .HasForeignKey(e => e.ContactTypeCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOCRMConfiguration>()
                .HasMany(e => e.BOLead2)
                .WithRequired(e => e.BOCRMConfiguration2)
                .HasForeignKey(e => e.StatusCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOCRMConfiguration>()
                .HasMany(e => e.BOLead3)
                .WithRequired(e => e.BOCRMConfiguration3)
                .HasForeignKey(e => e.SourceCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOPartyOrCustomer>()
                .HasMany(e => e.BOLead)
                .WithRequired(e => e.BOPartyOrCustomer)
                .HasForeignKey(e => e.CustomerCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOStockRequisitionOrIssuance>()
                .HasMany(e => e.BOStockRequisitionOrIssuance1)
                .WithRequired(e => e.BOStockRequisitionOrIssuance2)
                .HasForeignKey(e => e.StockRequisitionOrIssuanceCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOStockRequisitionOrIssuance>()
                .HasMany(e => e.BOStockRequisitionOrIssuanceDetail)
                .WithRequired(e => e.BOStockRequisitionOrIssuance)
                .HasForeignKey(e => e.StockRequisitionOrIssuanceCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOCurrency>()
                .HasMany(e => e.BOStockRequisitionOrIssuanceDetail)
                .WithRequired(e => e.BOCurrency)
                .HasForeignKey(e => e.CurrencyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOStockRequisitionOrIssuanceDetail)
                .WithRequired(e => e.BOEmployeeInfo)
                .HasForeignKey(e => e.IssuanceToEmpCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeInfo>()
                .HasMany(e => e.BOStockRequisitionOrIssuanceDetail1)
                .WithRequired(e => e.BOEmployeeInfo1)
                .HasForeignKey(e => e.ReceivedByEmpCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEquipment>()
                .HasMany(e => e.BOStockRequisitionOrIssuanceDetail)
                .WithRequired(e => e.BOEquipment)
                .HasForeignKey(e => e.EquipmentCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEquipment>()
                .HasMany(e => e.BOStockRequisitionOrIssuanceDetail1)
                .WithRequired(e => e.BOEquipment1)
                .HasForeignKey(e => e.EquipmentReplacedCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOIMMOrEquipmentCondition>()
                .HasMany(e => e.BOStockRequisitionOrIssuanceDetail)
                .WithRequired(e => e.BOIMMOrEquipmentCondition)
                .HasForeignKey(e => e.IMMOrEquipmentConditionCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOIMMOrEquipmentCondition>()
                .HasMany(e => e.BOStockRequisitionOrIssuanceDetail1)
                .WithRequired(e => e.BOIMMOrEquipmentCondition1)
                .HasForeignKey(e => e.IMMOrEquipmentReplacedConditionCode)
                .WillCascadeOnDelete(false);           

            modelBuilder.Entity<BOItemPrice>()
                .HasMany(e => e.BOStockRequisitionOrIssuanceDetail)
                .WithRequired(e => e.BOItemPrice)
                .HasForeignKey(e => e.ItemPriceCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOItemProfile>()
                .HasMany(e => e.BOStockRequisitionOrIssuanceDetail)
                .WithRequired(e => e.BOItemProfile)
                .HasForeignKey(e => e.ItemProfileCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOItemProfile>()
                .HasMany(e => e.BOStockRequisitionOrIssuanceDetail1)
                .WithRequired(e => e.BOItemProfile1)
                .HasForeignKey(e => e.ItemProfileReplacedCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUOM>()
                .HasMany(e => e.BOStockRequisitionOrIssuanceDetail)
                .WithRequired(e => e.BOUOM)
                .HasForeignKey(e => e.StockUOMCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOVendorOrSupplier>()
                .HasMany(e => e.BOStockRequisitionOrIssuanceDetail)
                .WithRequired(e => e.BOVendorOrSupplier)
                .HasForeignKey(e => e.VendorOrSupplierCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOStockRequisitionOrIssuanceDetail>()
                .HasMany(e => e.BOStockRequisitionOrIssuanceDetail1)
                .WithRequired(e => e.BOStockRequisitionOrIssuanceDetail2)
                .HasForeignKey(e => e.StockRequisitionOrIssuanceDetailCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOOpportunity)
                .WithRequired(e => e.BOOrganizationCompany)
                .HasForeignKey(e => e.CompanyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOOrganizationCompany>()
                .HasMany(e => e.BOOpportunity1)
                .WithRequired(e => e.BOOrganizationCompany1)
                .HasForeignKey(e => e.ProfitCenterCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOPartyOrCustomer>()
               .HasMany(e => e.BOOpportunity)
               .WithRequired(e => e.BOPartyOrCustomer)
               .HasForeignKey(e => e.CustomerCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOPipeline>()
               .HasMany(e => e.BOOpportunity)
               .WithRequired(e => e.BOPipeline)
               .HasForeignKey(e => e.PipelineCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOCRMConfiguration>()
               .HasMany(e => e.BOOpportunity)
               .WithRequired(e => e.BOCRMConfiguration)
               .HasForeignKey(e => e.ContactCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOCRMConfiguration>()
               .HasMany(e => e.BOOpportunity1)
               .WithRequired(e => e.BOCRMConfiguration1)
               .HasForeignKey(e => e.StageCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOCRMConfiguration>()
               .HasMany(e => e.BOOpportunity2)
               .WithRequired(e => e.BOCRMConfiguration2)
               .HasForeignKey(e => e.StatusCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOCRMConfiguration>()
               .HasMany(e => e.BOOpportunity3)
               .WithRequired(e => e.BOCRMConfiguration3)
               .HasForeignKey(e => e.SourceCode)
               .WillCascadeOnDelete(false);


            modelBuilder.Entity<BOFlavor>()
               .HasMany(e => e.BOFlavorDetail)
               .WithRequired(e => e.BOFlavor)
               .HasForeignKey(e => e.FlavorCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOIMMOrEquipmentCondition>()
                .HasMany(e => e.BOGatePassDetail)
                .WithRequired(e => e.BOIMMOrEquipmentCondition)
                .HasForeignKey(e => e.IMMOrEquipmentConditionCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOPurchaseOrderAndReturn>()
               .HasMany(e => e.BOGatePassDetail)
               .WithRequired(e => e.BOPurchaseOrderAndReturn)
               .HasForeignKey(e => e.GatePassCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOGatePassDetail>()
               .HasMany(e => e.BOGatePassDetail1)
               .WithRequired(e => e.BOGatePassDetail2)
               .HasForeignKey(e => e.GatePassDetailCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOGatePass>()
               .HasMany(e => e.BOGatePass1)
               .WithRequired(e => e.BOGatePass2)
               .HasForeignKey(e => e.GatePassCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOPurchaseOrderAndReturn>()
               .HasMany(e => e.BOGatePass)
               .WithRequired(e => e.BOPurchaseOrderAndReturn)
               .HasForeignKey(e => e.POCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOItem>()
               .HasMany(e => e.BOVendorOrSupplierWiseItem)
               .WithRequired(e => e.BOItem)
               .HasForeignKey(e => e.ItemCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOItemProfile>()
               .HasMany(e => e.BOVendorOrSupplierWiseItem)
               .WithRequired(e => e.BOItemProfile)
               .HasForeignKey(e => e.ItemProfileCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOVendorOrSupplier>()
               .HasMany(e => e.BOVendorOrSupplierWiseItem)
               .WithRequired(e => e.BOVendorOrSupplier)
               .HasForeignKey(e => e.VendorOrSupplierCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEquipmentType>()
               .HasMany(e => e.BOVendorOrSupplierWiseItem)
               .WithRequired(e => e.BOEquipmentType)
               .HasForeignKey(e => e.EquipmentTypeCode)
               .WillCascadeOnDelete(false);



            modelBuilder.Entity<BOUOM>()
               .HasMany(e => e.BOGatePassDetail)
               .WithRequired(e => e.BOUOM)
               .HasForeignKey(e => e.POUOMCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUOM>()
               .HasMany(e => e.BOGatePassDetail1)
               .WithRequired(e => e.BOUOM1)
               .HasForeignKey(e => e.StockUOMCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEquipment>()
               .HasMany(e => e.BOGatePassDetail)
               .WithRequired(e => e.BOEquipment)
               .HasForeignKey(e => e.EquipmentCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeInfo>()
               .HasMany(e => e.BOGatePassDetail)
               .WithRequired(e => e.BOEmployeeInfo)
               .HasForeignKey(e => e.GeneratedByEmpCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeInfo>()
               .HasMany(e => e.BOGatePassDetail1)
               .WithRequired(e => e.BOEmployeeInfo1)
               .HasForeignKey(e => e.InspectedByEmpCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOGatePass>()
               .HasMany(e => e.BOGatePassDetail)
               .WithRequired(e => e.BOGatePass)
               .HasForeignKey(e => e.GatePassCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOItemProfile>()
               .HasMany(e => e.BOGatePassDetail)
               .WithRequired(e => e.BOItemProfile)
               .HasForeignKey(e => e.ItemProfileCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOCurrency>()
               .HasMany(e => e.BOGatePassDetail)
               .WithRequired(e => e.BOCurrency)
               .HasForeignKey(e => e.CurrencyCode)
               .WillCascadeOnDelete(false);
            //
            modelBuilder.Entity<BOCurrency>()
               .HasMany(e => e.BOGatePass)
               .WithRequired(e => e.BOCurrency)
               .HasForeignKey(e => e.CurrencyCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BODispatchReceiveMedium>()
               .HasMany(e => e.BOGatePass)
               .WithRequired(e => e.BODispatchReceiveMedium)
               .HasForeignKey(e => e.DispatchReceiveMediumCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOLocationSite>()
               .HasMany(e => e.BOGatePass)
               .WithRequired(e => e.BOLocationSite)
               .HasForeignKey(e => e.LocationSiteCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEquipment>()
               .HasMany(e => e.BOGatePass)
               .WithRequired(e => e.BOEquipment)
               .HasForeignKey(e => e.EquipmentCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOFiscalYear>()
               .HasMany(e => e.BOGatePass)
               .WithRequired(e => e.BOFiscalYear)
               .HasForeignKey(e => e.FiscalYearCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeInfo>()
               .HasMany(e => e.BOGatePass)
               .WithRequired(e => e.BOEmployeeInfo)
               .HasForeignKey(e => e.GeneratedByEmpCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeInfo>()
               .HasMany(e => e.BOGatePass1)
               .WithRequired(e => e.BOEmployeeInfo1)
               .HasForeignKey(e => e.InspectedByEmpCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOVendorOrSupplier>()
               .HasMany(e => e.BOGatePass)
               .WithRequired(e => e.BOVendorOrSupplier)
               .HasForeignKey(e => e.VendorOrSupplierCode)
               .WillCascadeOnDelete(false);

            ///////////////////////////////////////////

            modelBuilder.Entity<BOCurrency>()
               .HasMany(e => e.BOGRNandReturn)
               .WithRequired(e => e.BOCurrency)
               .HasForeignKey(e => e.CurrencyCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BODispatchReceiveMedium>()
               .HasMany(e => e.BOGRNandReturn)
               .WithRequired(e => e.BODispatchReceiveMedium)
               .HasForeignKey(e => e.DispatchReceiveMediumCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOLocationSite>()
               .HasMany(e => e.BOGRNandReturn)
               .WithRequired(e => e.BOLocationSite)
               .HasForeignKey(e => e.LocationSiteCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOIMMTaxGroup>()
               .HasMany(e => e.BOGRNandReturn)
               .WithRequired(e => e.BOIMMTaxGroup)
               .HasForeignKey(e => e.IMMTaxGroupCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOFiscalYear>()
               .HasMany(e => e.BOGRNandReturn)
               .WithRequired(e => e.BOFiscalYear)
               .HasForeignKey(e => e.FiscalYearCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOPaymentMode>()
               .HasMany(e => e.BOGRNandReturn)
               .WithRequired(e => e.BOPaymentMode)
               .HasForeignKey(e => e.PaymentModeCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeInfo>()
               .HasMany(e => e.BOGRNandReturn)
               .WithRequired(e => e.BOEmployeeInfo)
               .HasForeignKey(e => e.GeneratedByEmpCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOGatePass>()
               .HasMany(e => e.BOGRNandReturn)
               .WithRequired(e => e.BOGatePass)
               .HasForeignKey(e => e.GatePassCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOVendorOrSupplier>()
               .HasMany(e => e.BOGRNandReturn)
               .WithRequired(e => e.BOVendorOrSupplier)
               .HasForeignKey(e => e.VendorOrSupplierCode)
               .WillCascadeOnDelete(false);


            /////////////////////////////////////////////////

            modelBuilder.Entity<BOCurrency>()
               .HasMany(e => e.BOGRNandReturnDetail)
               .WithRequired(e => e.BOCurrency)
               .HasForeignKey(e => e.CurrencyCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOIMMTaxGroup>()
               .HasMany(e => e.BOGRNandReturnDetail)
               .WithRequired(e => e.BOIMMTaxGroup)
               .HasForeignKey(e => e.IMMTaxGroupCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOPaymentMode>()
               .HasMany(e => e.BOGRNandReturnDetail)
               .WithRequired(e => e.BOPaymentMode)
               .HasForeignKey(e => e.PaymentModeCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeInfo>()
               .HasMany(e => e.BOGRNandReturnDetail)
               .WithRequired(e => e.BOEmployeeInfo)
               .HasForeignKey(e => e.GeneratedByEmpCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUOM>()
               .HasMany(e => e.BOGRNandReturnDetail)
               .WithRequired(e => e.BOUOM)
               .HasForeignKey(e => e.StockUOMCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUOM>()
               .HasMany(e => e.BOGRNandReturnDetail1)
               .WithRequired(e => e.BOUOM1)
               .HasForeignKey(e => e.POandReturnUOMCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEquipment>()
               .HasMany(e => e.BOGRNandReturnDetail)
               .WithRequired(e => e.BOEquipment)
               .HasForeignKey(e => e.EquipmentCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOGatePassDetail>()
               .HasMany(e => e.BOGRNandReturnDetail)
               .WithRequired(e => e.BOGatePassDetail)
               .HasForeignKey(e => e.GatePassDetailCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOItemProfile>()
               .HasMany(e => e.BOGRNandReturnDetail)
               .WithRequired(e => e.BOItemProfile)
               .HasForeignKey(e => e.ItemProfileCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOItemPrice>()
               .HasMany(e => e.BOGRNandReturnDetail)
               .WithRequired(e => e.BOItemPrice)
               .HasForeignKey(e => e.ItemPriceCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOPurchaseOrderAndReturnDetail>()
               .HasMany(e => e.BOGRNandReturnDetail)
               .WithRequired(e => e.BOPurchaseOrderAndReturnDetail)
               .HasForeignKey(e => e.POandReturnDetailCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOVendorOrSupplier>()
               .HasMany(e => e.BOGRNandReturnDetail)
               .WithRequired(e => e.BOVendorOrSupplier)
               .HasForeignKey(e => e.VendorOrSupplierCode)
               .WillCascadeOnDelete(false);

            ///////////////////////////////////////////////////////////////

            modelBuilder.Entity<BOGatePass>()
               .HasMany(e => e.BOGRNandReturnCheckList)
               .WithRequired(e => e.BOGatePass)
               .HasForeignKey(e => e.GatePassCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOGatePassDetail>()
               .HasMany(e => e.BOGRNandReturnCheckList)
               .WithRequired(e => e.BOGatePassDetail)
               .HasForeignKey(e => e.GatePassDetailCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOGRNandReturnCheckList>()
               .HasMany(e => e.BOGRNandReturnCheckList1)
               .WithRequired(e => e.BOGRNandReturnCheckList2)
               .HasForeignKey(e => e.GRNandReturnCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOPurchaseOrderAndReturn>()
               .HasMany(e => e.BOGRNandReturnCheckList)
               .WithRequired(e => e.BOPurchaseOrderAndReturn)
               .HasForeignKey(e => e.POandReturnCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOPurchaseOrderAndReturnDetail>()
               .HasMany(e => e.BOGRNandReturnCheckList)
               .WithRequired(e => e.BOPurchaseOrderAndReturnDetail)
               .HasForeignKey(e => e.POandReturnDetailCode)
               .WillCascadeOnDelete(false);

            ///////////////////////////////////////////////////////////////////

            modelBuilder.Entity<BOVendorOrSupplier>()
               .HasMany(e => e.BOPurchaseOrderAndReturn)
               .WithRequired(e => e.BOVendorOrSupplier)
               .HasForeignKey(e => e.VendorOrSupplierCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOGRNandReturn>()
               .HasMany(e => e.BOPurchaseOrderAndReturn)
               .WithRequired(e => e.BOGRNandReturn1)
               .HasForeignKey(e => e.POandReturnCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOFiscalYear>()
               .HasMany(e => e.BOPurchaseOrderAndReturn)
               .WithRequired(e => e.BOFiscalYear)
               .HasForeignKey(e => e.FiscalYearCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOPaymentMode>()
               .HasMany(e => e.BOPurchaseOrderAndReturn)
               .WithRequired(e => e.BOPaymentMode)
               .HasForeignKey(e => e.PaymentModeCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOCurrency>()
               .HasMany(e => e.BOPurchaseOrderAndReturn)
               .WithRequired(e => e.BOCurrency)
               .HasForeignKey(e => e.CurrencyCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BODispatchReceiveMedium>()
               .HasMany(e => e.BOPurchaseOrderAndReturn)
               .WithRequired(e => e.BODispatchReceiveMedium)
               .HasForeignKey(e => e.DispatchReceiveMediumCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOIMMTaxGroup>()
               .HasMany(e => e.BOPurchaseOrderAndReturn)
               .WithRequired(e => e.BOIMMTaxGroup)
               .HasForeignKey(e => e.IMMTaxGroupCode)
               .WillCascadeOnDelete(false);

            ////////////////////////////////////////////////

            modelBuilder.Entity<BOVendorOrSupplier>()
               .HasMany(e => e.BOPurchaseOrderAndReturnDetail)
               .WithRequired(e => e.BOVendorOrSupplier)
               .HasForeignKey(e => e.VendorOrSupplierCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOPaymentMode>()
               .HasMany(e => e.BOPurchaseOrderAndReturnDetail)
               .WithRequired(e => e.BOPaymentMode)
               .HasForeignKey(e => e.PaymentModeCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOCurrency>()
               .HasMany(e => e.BOPurchaseOrderAndReturnDetail)
               .WithRequired(e => e.BOCurrency)
               .HasForeignKey(e => e.CurrencyCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOIMMTaxGroup>()
               .HasMany(e => e.BOPurchaseOrderAndReturnDetail)
               .WithRequired(e => e.BOIMMTaxGroup)
               .HasForeignKey(e => e.IMMTaxGroupCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEquipment>()
               .HasMany(e => e.BOPurchaseOrderAndReturnDetail)
               .WithRequired(e => e.BOEquipment)
               .HasForeignKey(e => e.EquipmentCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeInfo>()
               .HasMany(e => e.BOPurchaseOrderAndReturnDetail)
               .WithRequired(e => e.BOEmployeeInfo)
               .HasForeignKey(e => e.GeneratedByEmpCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOGRNandReturnDetail>()
               .HasMany(e => e.BOPurchaseOrderAndReturnDetail1)
               .WithRequired(e => e.BOGRNandReturnDetail1)
               .HasForeignKey(e => e.GRNandReturnDetailCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOItemProfile>()
               .HasMany(e => e.BOPurchaseOrderAndReturnDetail)
               .WithRequired(e => e.BOItemProfile)
               .HasForeignKey(e => e.ItemProfileCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUOM>()
               .HasMany(e => e.BOPurchaseOrderAndReturnDetail)
               .WithRequired(e => e.BOUOM)
               .HasForeignKey(e => e.POUOMCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUOM>()
               .HasMany(e => e.BOPurchaseOrderAndReturnDetail1)
               .WithRequired(e => e.BOUOM1)
               .HasForeignKey(e => e.StockUOMCode)
               .WillCascadeOnDelete(false);

            ///////////////////////BOItemOrProfileServiceType//////////////////////
            modelBuilder.Entity<BOServiceType>()
               .HasMany(e => e.BOItemOrProfileServiceType)
               .WithRequired(e => e.BOServiceType)
               .HasForeignKey(e => e.ServiceTypeCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOItem>()
               .HasMany(e => e.BOItemOrProfileServiceType)
               .WithRequired(e => e.BOItem)
               .HasForeignKey(e => e.ItemCode)
               .WillCascadeOnDelete(false);

            ///////////////////////BOServiceType//////////////////////
            modelBuilder.Entity<BOServiceType>()
               .HasMany(e => e.BOServiceType1)
               .WithRequired(e => e.BOServiceType2)
               .HasForeignKey(e => e.ServiceCode)
               .WillCascadeOnDelete(false);

            ///////////////////////BOPartyOrCustomerServiceType//////////////////////
            modelBuilder.Entity<BOServiceType>()
               .HasMany(e => e.BOPartyOrCustomerServiceType)
               .WithRequired(e => e.BOServiceType)
               .HasForeignKey(e => e.ServiceTypeCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOPartyOrCustomer>()
               .HasMany(e => e.BOPartyOrCustomerServiceType)
               .WithRequired(e => e.BOPartyOrCustomer)
               .HasForeignKey(e => e.PartyOrCustomerCode)
               .WillCascadeOnDelete(false);

            ///////////////////////BOProductionMaster//////////////////////

            modelBuilder.Entity<BOLocationSite>()
               .HasMany(e => e.BOProductionMaster)
               .WithRequired(e => e.BOLocationSite)
               .HasForeignKey(e => e.LocationSiteCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUOM>()
               .HasMany(e => e.BOProductionMaster)
               .WithRequired(e => e.BOUOM)
               .HasForeignKey(e => e.ProducedUOMCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUOM>()
               .HasMany(e => e.BOProductionMaster1)
               .WithRequired(e => e.BOUOM1)
               .HasForeignKey(e => e.ReceipeUOMCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOFiscalYear>()
               .HasMany(e => e.BOProductionMaster)
               .WithRequired(e => e.BOFiscalYear)
               .HasForeignKey(e => e.FiscalYearCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeInfo>()
               .HasMany(e => e.BOProductionMaster)
               .WithRequired(e => e.BOEmployeeInfo)
               .HasForeignKey(e => e.ProducedByEmpCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOItemProfile>()
               .HasMany(e => e.BOProductionMaster)
               .WithRequired(e => e.BOItemProfile)
               .HasForeignKey(e => e.ItemProfileCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOPurchaseOrderAndReturn>()
               .HasMany(e => e.BOProductionMaster)
               .WithRequired(e => e.BOPurchaseOrderAndReturn)
               .HasForeignKey(e => e.POandReturnCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOStockRequisitionOrIssuance>()
               .HasMany(e => e.BOProductionMaster)
               .WithRequired(e => e.BOStockRequisitionOrIssuance)
               .HasForeignKey(e => e.StockRequisitionOrIssuanceCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOReceipeMaster>()
               .HasMany(e => e.BOProductionMaster)
               .WithRequired(e => e.BOReceipeMaster)
               .HasForeignKey(e => e.ReceipeMasterCode)
               .WillCascadeOnDelete(false);

            ///////////////////////BOProductionDetail//////////////////////

            modelBuilder.Entity<BOUOM>()
               .HasMany(e => e.BOProductionDetail)
               .WithRequired(e => e.BOUOM)
               .HasForeignKey(e => e.ReceipeUOMCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUOM>()
               .HasMany(e => e.BOProductionDetail1)
               .WithRequired(e => e.BOUOM1)
               .HasForeignKey(e => e.StockUOMCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOItemProfile>()
               .HasMany(e => e.BOProductionDetail)
               .WithRequired(e => e.BOItemProfile)
               .HasForeignKey(e => e.ItemProfileCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOProductionMaster>()
               .HasMany(e => e.BOProductionDetail)
               .WithRequired(e => e.BOProductionMaster)
               .HasForeignKey(e => e.ProductionMasterCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOReceipeDetail>()
               .HasMany(e => e.BOProductionDetail)
               .WithRequired(e => e.BOReceipeDetail)
               .HasForeignKey(e => e.ReceipeMasterDetailCode)
               .WillCascadeOnDelete(false);

            ///////////////////////BOReceipeMaster//////////////////////

            modelBuilder.Entity<BOUOM>()
               .HasMany(e => e.BOReceipeMaster)
               .WithRequired(e => e.BOUOM)
               .HasForeignKey(e => e.ReceipeUOMCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUOM>()
               .HasMany(e => e.BOReceipeMaster1)
               .WithRequired(e => e.BOUOM1)
               .HasForeignKey(e => e.StockUOMCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOFiscalYear>()
               .HasMany(e => e.BOReceipeMaster)
               .WithRequired(e => e.BOFiscalYear)
               .HasForeignKey(e => e.FiscalYearCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOEmployeeInfo>()
               .HasMany(e => e.BOReceipeMaster)
               .WithRequired(e => e.BOEmployeeInfo)
               .HasForeignKey(e => e.ReceipeByEmpCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOItemPrice>()
               .HasMany(e => e.BOReceipeMaster)
               .WithRequired(e => e.BOItemPrice)
               .HasForeignKey(e => e.ItemProfileCode)
               .WillCascadeOnDelete(false);

            ///////////////////////BOReceipeDetail//////////////////////

            modelBuilder.Entity<BOUOM>()
               .HasMany(e => e.BOReceipeDetail)
               .WithRequired(e => e.BOUOM)
               .HasForeignKey(e => e.ReceipeUOMCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUOM>()
               .HasMany(e => e.BOReceipeDetail1)
               .WithRequired(e => e.BOUOM1)
               .HasForeignKey(e => e.StockUOMCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOItemProfile>()
               .HasMany(e => e.BOReceipeDetail)
               .WithRequired(e => e.BOItemProfile)
               .HasForeignKey(e => e.ItemProfileCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOReceipeMaster>()
               .HasMany(e => e.BOReceipeDetail)
               .WithRequired(e => e.BOReceipeMaster)
               .HasForeignKey(e => e.ReceipeMasterCode)
               .WillCascadeOnDelete(false);

            ///////////////////////BOVendorOrSupplierServiceType//////////////////////

            modelBuilder.Entity<BOServiceType>()
               .HasMany(e => e.BOVendorOrSupplierServiceType)
               .WithRequired(e => e.BOServiceType)
               .HasForeignKey(e => e.ServiceTypeCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOVendorOrSupplier>()
               .HasMany(e => e.BOVendorOrSupplierServiceType)
               .WithRequired(e => e.BOVendorOrSupplier)
               .HasForeignKey(e => e.VendorOrSupplierCode)
               .WillCascadeOnDelete(false);

            ////////////////////

            modelBuilder.Entity<BOIMMCheckList>()
               .HasMany(e => e.BOGRNandReturnCheckList)
               .WithRequired(e => e.BOIMMCheckList)
               .HasForeignKey(e => e.IMMCheckListCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOLocationSite>()
               .HasMany(e => e.BOPurchaseOrderAndReturn)
               .WithRequired(e => e.BOLocationSite)
               .HasForeignKey(e => e.LocationSiteCode)
               .WillCascadeOnDelete(false);

            ///////////////////////BOItemDeal//////////////////////
            modelBuilder.Entity<BOUOM>()
               .HasMany(e => e.BOItemDeal)
               .WithRequired(e => e.BOUOM)
               .HasForeignKey(e => e.ItemUOMCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOItem>()
               .HasMany(e => e.BOItemDeal)
               .WithRequired(e => e.BOItem)
               .HasForeignKey(e => e.ItemCode)
               .WillCascadeOnDelete(false);

            ///////////////////////BOItemDealAssignment//////////////////////

            modelBuilder.Entity<BOOrganizationCompany>()
               .HasMany(e => e.BOItemDealAssignment)
               .WithRequired(e => e.BOOrganizationCompany1)
               .HasForeignKey(e => e.PcOCcCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOItemDeal>()
               .HasMany(e => e.BOItemDealAssignment)
               .WithRequired(e => e.BOItemDeal)
               .HasForeignKey(e => e.ItemDealCode)
               .WillCascadeOnDelete(false);

            ///////////////////////BOItemDealDetail//////////////////////

            modelBuilder.Entity<BOUOM>()
               .HasMany(e => e.BOItemDealDetail)
               .WithRequired(e => e.BOUOM)
               .HasForeignKey(e => e.ItemModifierUOMCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUOM>()
               .HasMany(e => e.BOItemDealDetail1)
               .WithRequired(e => e.BOUOM1)
               .HasForeignKey(e => e.ItemProfileUOMCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOItemDeal>()
               .HasMany(e => e.BOItemDealDetail)
               .WithRequired(e => e.BOItemDeal)
               .HasForeignKey(e => e.ItemDealCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOItemModifier>()
               .HasMany(e => e.BOItemDealDetail)
               .WithRequired(e => e.BOItemModifier)
               .HasForeignKey(e => e.ItemModifierCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOItemProfile>()
               .HasMany(e => e.BOItemDealDetail)
               .WithRequired(e => e.BOItemProfile)
               .HasForeignKey(e => e.ItemProfileCode)
               .WillCascadeOnDelete(false);

            ///////////////////////BOItemModifier//////////////////////

            modelBuilder.Entity<BOUOM>()
               .HasMany(e => e.BOItemModifier)
               .WithRequired(e => e.BOUOM)
               .HasForeignKey(e => e.ItemUOMCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOUOM>()
               .HasMany(e => e.BOItemModifier1)
               .WithRequired(e => e.BOUOM1)
               .HasForeignKey(e => e.ItemProfileUOMCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOItem>()
               .HasMany(e => e.BOItemModifier)
               .WithRequired(e => e.BOItem)
               .HasForeignKey(e => e.ItemCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOItem>()
               .HasMany(e => e.BOItemModifier1)
               .WithRequired(e => e.BOItem1)
               .HasForeignKey(e => e.ItemModifierCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOItemProfile>()
               .HasMany(e => e.BOItemModifier)
               .WithRequired(e => e.BOItemProfile)
               .HasForeignKey(e => e.ItemProfileCode)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOItemProfile>()
               .HasMany(e => e.BOItemModifier1)
               .WithRequired(e => e.BOItemProfile1)
               .HasForeignKey(e => e.ItemModifierProfileCode)
               .WillCascadeOnDelete(false);


        }
    }
}

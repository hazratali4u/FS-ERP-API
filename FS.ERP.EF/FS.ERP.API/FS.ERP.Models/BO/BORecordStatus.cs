using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("AppCNF.tbl_RecordStatus")]
    public partial class BORecordStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BORecordStatus()
        {
            BOAllowanceOrBenefitType = new HashSet<BOAllowanceOrBenefitType>();
            BOAppConfiguration = new HashSet<BOAppConfiguration>();
            BOAppConfigurationDetail = new HashSet<BOAppConfigurationDetail>();
            BOApprovalAuthorityType = new HashSet<BOApprovalAuthorityType>();
            BOAttendanceMachineType = new HashSet<BOAttendanceMachineType>();
            BOBillOrInvoiceType = new HashSet<BOBillOrInvoiceType>();
            BOCulture = new HashSet<BOCulture>();
            BOCurrency = new HashSet<BOCurrency>();
            BODataType = new HashSet<BODataType>();
            BODiscrepancyType = new HashSet<BODiscrepancyType>();
            BOEmployeeRelation = new HashSet<BOEmployeeRelation>();
            BOEquipmentStatus = new HashSet<BOEquipmentStatus>();
            BOEquipmentType = new HashSet<BOEquipmentType>();
            BOExpenseType = new HashSet<BOExpenseType>();
            BOIMMAcquireType = new HashSet<BOIMMAcquireType>();
            BOIMMGender = new HashSet<BOIMMGender>();
            BOIMMGroup = new HashSet<BOIMMGroup>();
            BOIMMLifeType = new HashSet<BOIMMLifeType>();
            BOIMMManufacturedBy = new HashSet<BOIMMManufacturedBy>();
            BOIMMTaxGroup = new HashSet<BOIMMTaxGroup>();
            BOIMMTaxGroupDetail = new HashSet<BOIMMTaxGroupDetail>();
            BOIMMTransactionMethod = new HashSet<BOIMMTransactionMethod>();
            BOIncomeTaxSlab = new HashSet<BOIncomeTaxSlab>();
            BOInstrumentStatus = new HashSet<BOInstrumentStatus>();
            BOInstrumentType = new HashSet<BOInstrumentType>();
            BOLeaseType = new HashSet<BOLeaseType>();
            BOLoanType = new HashSet<BOLoanType>();
            BOLocationSite = new HashSet<BOLocationSite>();
            BOLocationSiteType = new HashSet<BOLocationSiteType>();
            BOOnwerShipType = new HashSet<BOOnwerShipType>();
            BOOrganizationCompany = new HashSet<BOOrganizationCompany>();
            BOPackingType = new HashSet<BOPackingType>();
            BOPaymentMode = new HashSet<BOPaymentMode>();
            BOPriority = new HashSet<BOPriority>();
            BOProcessApprovalWorkflow = new HashSet<BOProcessApprovalWorkflow>();
            BORebateType = new HashSet<BORebateType>();
            BOActionLogging = new HashSet<BOActionLogging>();
            BOAdditionType = new HashSet<BOAdditionType>();
            BOAllowancesOrBenefit = new HashSet<BOAllowancesOrBenefit>();
            BOAPPCNFDataLogging = new HashSet<BOAPPCNFDataLogging>();
            BOAreaOfDistrictWard = new HashSet<BOAreaOfDistrictWard>();
            BOAttendanceDiscrepancy = new HashSet<BOAttendanceDiscrepancy>();
            BOBank = new HashSet<BOBank>();
            BOBankAccount = new HashSet<BOBankAccount>();
            BOBankAccountInstrumentInfo = new HashSet<BOBankAccountInstrumentInfo>();
            BOBankBranch = new HashSet<BOBankBranch>();
            BOBillOrInvoiceMaster = new HashSet<BOBillOrInvoiceMaster>();
            BOBillOrInvoiceMasterDetail = new HashSet<BOBillOrInvoiceMasterDetail>();
            BOCalendar = new HashSet<BOCalendar>();
            BOCityTown = new HashSet<BOCityTown>();
            BOCOA = new HashSet<BOCOA>();
            BOCOAConfiguration = new HashSet<BOCOAConfiguration>();
            BOCOAMapping = new HashSet<BOCOAMapping>();
            BOCOAMappingForPCorCC = new HashSet<BOCOAMappingForPCorCC>();
            BOCOANature = new HashSet<BOCOANature>();
            BOCountryRegion = new HashSet<BOCountryRegion>();
            BOCRMDataLogging = new HashSet<BOCRMDataLogging>();
            BODeductionType = new HashSet<BODeductionType>();
            BODegree = new HashSet<BODegree>();
            BODegreeInstitute = new HashSet<BODegreeInstitute>();
            BODepartment = new HashSet<BODepartment>();
            BODesignation = new HashSet<BODesignation>();
            BODistrictWard = new HashSet<BODistrictWard>();
            BODocumentCheckList = new HashSet<BODocumentCheckList>();
            BODocumentDetailOfStatement = new HashSet<BODocumentDetailOfStatement>();
            BODocumentOfStatement = new HashSet<BODocumentOfStatement>();
            BODomainOfStatement = new HashSet<BODomainOfStatement>();
            BOEmpDocumentCheckList = new HashSet<BOEmpDocumentCheckList>();
            BOEmployeeAcademic = new HashSet<BOEmployeeAcademic>();
            BOEmployeeAllowanceOrBenefit = new HashSet<BOEmployeeAllowanceOrBenefit>();
            BOEmployeeAttendance = new HashSet<BOEmployeeAttendance>();
            BOEmployeeEmployment = new HashSet<BOEmployeeEmployment>();
            BOEmployeeFaceOrBiometric = new HashSet<BOEmployeeFaceOrBiometric>();
            BOEmployeeFamily = new HashSet<BOEmployeeFamily>();
            BOEmployeeIncrement = new HashSet<BOEmployeeIncrement>();
            BOEmployeeIncrementAllowanceOrBenefit = new HashSet<BOEmployeeIncrementAllowanceOrBenefit>();
            BOEmployeeInfo = new HashSet<BOEmployeeInfo>();
            BOEmployeeInfoHistory = new HashSet<BOEmployeeInfoHistory>();
            BOEmployeeInfoRevision = new HashSet<BOEmployeeInfoRevision>();
            BOEmployeeLease = new HashSet<BOEmployeeLease>();
            BOEmployeeLeaseInstallment = new HashSet<BOEmployeeLeaseInstallment>();
            BOEmployeeLeave = new HashSet<BOEmployeeLeave>();
            BOEmployeeLeaveBalance = new HashSet<BOEmployeeLeaveBalance>();
            BOEmployeeLoan = new HashSet<BOEmployeeLoan>();
            BOEmployeeLoanInstallment = new HashSet<BOEmployeeLoanInstallment>();
            BOEmployeeReference = new HashSet<BOEmployeeReference>();
            BOEmployeeSalary = new HashSet<BOEmployeeSalary>();
            BOEmployeeSalaryAddition = new HashSet<BOEmployeeSalaryAddition>();
            BOEmployeeSalaryAllowanceOrBenefit = new HashSet<BOEmployeeSalaryAllowanceOrBenefit>();
            BOEmployeeSalaryDeduction = new HashSet<BOEmployeeSalaryDeduction>();
            BOEmployeeSalaryReimbursement = new HashSet<BOEmployeeSalaryReimbursement>();
            BOEmployeeStatus = new HashSet<BOEmployeeStatus>();
            BOEquipment = new HashSet<BOEquipment>();
            BOErrorLogging = new HashSet<BOErrorLogging>();
            BOFICODataLogging = new HashSet<BOFICODataLogging>();
            BOFiscalYear = new HashSet<BOFiscalYear>();
            BOFiscalYearMonth = new HashSet<BOFiscalYearMonth>();
            BOFiscalYearMonthDetail = new HashSet<BOFiscalYearMonthDetail>();
            BOFundDemandRegister = new HashSet<BOFundDemandRegister>();
            BOFundDemandRegisterDetail = new HashSet<BOFundDemandRegisterDetail>();
            BOFundDemandRequest = new HashSet<BOFundDemandRequest>();
            BOFundDemandRequestDetail = new HashSet<BOFundDemandRequestDetail>();
            BOHireType = new HashSet<BOHireType>();
            BOHRMDataLogging = new HashSet<BOHRMDataLogging>();
            BOIMMConfiguration = new HashSet<BOIMMConfiguration>();
            BOIMMDataLogging = new HashSet<BOIMMDataLogging>();
            BOIMMSectionOrBrand = new HashSet<BOIMMSectionOrBrand>();
            BOItem = new HashSet<BOItem>();
            BOItemAspect = new HashSet<BOItemAspect>();
            BOItemAspectDetail = new HashSet<BOItemAspectDetail>();
            BOItemAttribute = new HashSet<BOItemAttribute>();
            BOItemAttributeAspect = new HashSet<BOItemAttributeAspect>();
            BOItemAttributeAspectDetail = new HashSet<BOItemAttributeAspectDetail>();
            BOItemAttributeDetail = new HashSet<BOItemAttributeDetail>();
            BOItemCategory = new HashSet<BOItemCategory>();
            BOItemCategoryAttributeAspect = new HashSet<BOItemCategoryAttributeAspect>();
            BOItemCategoryAttributeAspectDetail = new HashSet<BOItemCategoryAttributeAspectDetail>();
            BOItemPrice = new HashSet<BOItemPrice>();
            BOItemProfile = new HashSet<BOItemProfile>();
            BOJobProjectScheme = new HashSet<BOJobProjectScheme>();
            BOJobProjectSchemeDetail = new HashSet<BOJobProjectSchemeDetail>();
            BOJobRole = new HashSet<BOJobRole>();
            BOLeaveDeductionAgainstLate = new HashSet<BOLeaveDeductionAgainstLate>();
            BOLeavePolicy = new HashSet<BOLeavePolicy>();
            BOLeavePolicyDetail = new HashSet<BOLeavePolicyDetail>();
            BOLeaveType = new HashSet<BOLeaveType>();
            BOLinkToTransaction = new HashSet<BOLinkToTransaction>();
            BOLoggingInformation = new HashSet<BOLoggingInformation>();
            BOLoginAttempts = new HashSet<BOLoginAttempts>();
            BOMenu = new HashSet<BOMenu>();
            BOMenuControlInfo = new HashSet<BOMenuControlInfo>();
            BOModuleColInfo = new HashSet<BOModuleColInfo>();
            BOModuleParamInfo = new HashSet<BOModuleParamInfo>();
            BOPartyOrCustomer = new HashSet<BOPartyOrCustomer>();
            BOPayGrade = new HashSet<BOPayGrade>();
            BOPayGradeAllowanceOrBenefit = new HashSet<BOPayGradeAllowanceOrBenefit>();
            BOProcessApprovalAlert = new HashSet<BOProcessApprovalAlert>();
            BOProfileGroup = new HashSet<BOProfileGroup>();
            BOProfileGroupDetail = new HashSet<BOProfileGroupDetail>();
            BOReimbursement = new HashSet<BOReimbursement>();
            BOReimbursementType = new HashSet<BOReimbursementType>();
            BORemittanceAdvice = new HashSet<BORemittanceAdvice>();
            BORemittanceAdviceDetail = new HashSet<BORemittanceAdviceDetail>();
            BOReportDashboardInfo = new HashSet<BOReportDashboardInfo>();
            BOSalaryBreakUpPolicy = new HashSet<BOSalaryBreakUpPolicy>();
            BOSalaryBreakUpPolicyDetail = new HashSet<BOSalaryBreakUpPolicyDetail>();
            BOSalaryTransferMode = new HashSet<BOSalaryTransferMode>();
            BOSectorZone = new HashSet<BOSectorZone>();
            BOSecurityRight = new HashSet<BOSecurityRight>();
            BOShift = new HashSet<BOShift>();
            BOShiftDay = new HashSet<BOShiftDay>();
            BOSRMDataLogging = new HashSet<BOSRMDataLogging>();
            BOStateProvince = new HashSet<BOStateProvince>();
            BOSystemOrWebPool = new HashSet<BOSystemOrWebPool>();
            BOTaxAdjustmentType = new HashSet<BOTaxAdjustmentType>();
            BOTransactionDetail = new HashSet<BOTransactionDetail>();
            BOTransactionDocumentConfiguration = new HashSet<BOTransactionDocumentConfiguration>();
            BOTransactionDocumentProcess = new HashSet<BOTransactionDocumentProcess>();
            BOTransactionMaster = new HashSet<BOTransactionMaster>();
            BOUMSDataLogging = new HashSet<BOUMSDataLogging>();
            BOUOM = new HashSet<BOUOM>();
            BOUser3 = new HashSet<BOUser>();
            BOUserLocationSitePermission = new HashSet<BOUserLocationSitePermission>();
            BOUserMenuAdditionSubtraction = new HashSet<BOUserMenuAdditionSubtraction>();
            BOUserOrganizationCompanyPermission = new HashSet<BOUserOrganizationCompanyPermission>();
            BOUserPartyOrCustomerPermission = new HashSet<BOUserPartyOrCustomerPermission>();
            BOUserProfileGroup = new HashSet<BOUserProfileGroup>();
            BOUserSystemOrWebPermission = new HashSet<BOUserSystemOrWebPermission>();
            BOUserVendorOrSupplierPermission = new HashSet<BOUserVendorOrSupplierPermission>();
            BOVendorOrSupplier = new HashSet<BOVendorOrSupplier>();
            BOVoucherType = new HashSet<BOVoucherType>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte ID { get; set; }

        [StringLength(25)]
        public string ShortName { get; set; }

        [Required]
        [StringLength(50)]
        public string ColorCode { get; set; }

        [StringLength(50)]
        public string BGColorClass { get; set; }

        [StringLength(50)]
        public string FGCSSClass { get; set; }

        [StringLength(50)]
        public string CSSClass { get; set; }

        [StringLength(50)]
        public string IconClass { get; set; }

        [Required]
        [StringLength(255)]
        public string FullName { get; set; }

        [Required]
        [StringLength(510)]
        public string DisplayName { get; set; }

        [StringLength(1020)]
        public string Description { get; set; }

        public DateTime? dtmExported { get; set; }

        public DateTime? dtmImported { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOAllowanceOrBenefitType> BOAllowanceOrBenefitType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOAppConfiguration> BOAppConfiguration { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOAppConfigurationDetail> BOAppConfigurationDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOApprovalAuthorityType> BOApprovalAuthorityType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOAttendanceMachineType> BOAttendanceMachineType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOBillOrInvoiceType> BOBillOrInvoiceType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOCulture> BOCulture { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOCurrency> BOCurrency { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BODataType> BODataType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BODiscrepancyType> BODiscrepancyType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeRelation> BOEmployeeRelation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEquipmentStatus> BOEquipmentStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEquipmentType> BOEquipmentType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOExpenseType> BOExpenseType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOIMMAcquireType> BOIMMAcquireType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOIMMGender> BOIMMGender { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOIMMGroup> BOIMMGroup { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOIMMLifeType> BOIMMLifeType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOIMMManufacturedBy> BOIMMManufacturedBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOIMMTaxGroup> BOIMMTaxGroup { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOIMMTaxGroupDetail> BOIMMTaxGroupDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOIMMTransactionMethod> BOIMMTransactionMethod { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOIncomeTaxSlab> BOIncomeTaxSlab { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOInstrumentStatus> BOInstrumentStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOInstrumentType> BOInstrumentType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOLeaseType> BOLeaseType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOLoanType> BOLoanType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOLocationSite> BOLocationSite { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOLocationSiteType> BOLocationSiteType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOOnwerShipType> BOOnwerShipType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOOrganizationCompany> BOOrganizationCompany { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPackingType> BOPackingType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPaymentMode> BOPaymentMode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPriority> BOPriority { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOProcessApprovalWorkflow> BOProcessApprovalWorkflow { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BORebateType> BORebateType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOActionLogging> BOActionLogging { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOAdditionType> BOAdditionType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOAllowancesOrBenefit> BOAllowancesOrBenefit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOAPPCNFDataLogging> BOAPPCNFDataLogging { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOAreaOfDistrictWard> BOAreaOfDistrictWard { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOAttendanceDiscrepancy> BOAttendanceDiscrepancy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOBank> BOBank { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOBankAccount> BOBankAccount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOBankAccountInstrumentInfo> BOBankAccountInstrumentInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOBankBranch> BOBankBranch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOBillOrInvoiceMaster> BOBillOrInvoiceMaster { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOBillOrInvoiceMasterDetail> BOBillOrInvoiceMasterDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOCalendar> BOCalendar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOCityTown> BOCityTown { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOCOA> BOCOA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOCOAConfiguration> BOCOAConfiguration { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOCOAMapping> BOCOAMapping { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOCOAMappingForPCorCC> BOCOAMappingForPCorCC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOCOANature> BOCOANature { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOCountryRegion> BOCountryRegion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOCRMDataLogging> BOCRMDataLogging { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BODeductionType> BODeductionType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BODegree> BODegree { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BODegreeInstitute> BODegreeInstitute { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BODepartment> BODepartment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BODesignation> BODesignation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BODistrictWard> BODistrictWard { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BODocumentCheckList> BODocumentCheckList { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BODocumentDetailOfStatement> BODocumentDetailOfStatement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BODocumentOfStatement> BODocumentOfStatement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BODomainOfStatement> BODomainOfStatement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmpDocumentCheckList> BOEmpDocumentCheckList { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeAcademic> BOEmployeeAcademic { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeAllowanceOrBenefit> BOEmployeeAllowanceOrBenefit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeAttendance> BOEmployeeAttendance { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeEmployment> BOEmployeeEmployment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeFaceOrBiometric> BOEmployeeFaceOrBiometric { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeFamily> BOEmployeeFamily { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeIncrement> BOEmployeeIncrement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeIncrementAllowanceOrBenefit> BOEmployeeIncrementAllowanceOrBenefit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeInfo> BOEmployeeInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeInfoHistory> BOEmployeeInfoHistory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeInfoRevision> BOEmployeeInfoRevision { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeLease> BOEmployeeLease { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeLeaseInstallment> BOEmployeeLeaseInstallment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeLeave> BOEmployeeLeave { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeLeaveBalance> BOEmployeeLeaveBalance { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeLoan> BOEmployeeLoan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeLoanInstallment> BOEmployeeLoanInstallment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeReference> BOEmployeeReference { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeSalary> BOEmployeeSalary { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeSalaryAddition> BOEmployeeSalaryAddition { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeSalaryAllowanceOrBenefit> BOEmployeeSalaryAllowanceOrBenefit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeSalaryDeduction> BOEmployeeSalaryDeduction { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeSalaryReimbursement> BOEmployeeSalaryReimbursement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeStatus> BOEmployeeStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEquipment> BOEquipment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOErrorLogging> BOErrorLogging { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOFICODataLogging> BOFICODataLogging { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOFiscalYear> BOFiscalYear { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOFiscalYearMonth> BOFiscalYearMonth { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOFiscalYearMonthDetail> BOFiscalYearMonthDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOFundDemandRegister> BOFundDemandRegister { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOFundDemandRegisterDetail> BOFundDemandRegisterDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOFundDemandRequest> BOFundDemandRequest { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOFundDemandRequestDetail> BOFundDemandRequestDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOHireType> BOHireType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOHRMDataLogging> BOHRMDataLogging { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOIMMConfiguration> BOIMMConfiguration { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOIMMDataLogging> BOIMMDataLogging { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOIMMSectionOrBrand> BOIMMSectionOrBrand { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOItem> BOItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOItemAspect> BOItemAspect { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOItemAspectDetail> BOItemAspectDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOItemAttribute> BOItemAttribute { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOItemAttributeAspect> BOItemAttributeAspect { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOItemAttributeAspectDetail> BOItemAttributeAspectDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOItemAttributeDetail> BOItemAttributeDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOItemCategory> BOItemCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOItemCategoryAttributeAspect> BOItemCategoryAttributeAspect { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOItemCategoryAttributeAspectDetail> BOItemCategoryAttributeAspectDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOItemPrice> BOItemPrice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOItemProfile> BOItemProfile { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOJobProjectScheme> BOJobProjectScheme { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOJobProjectSchemeDetail> BOJobProjectSchemeDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOJobRole> BOJobRole { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOLeaveDeductionAgainstLate> BOLeaveDeductionAgainstLate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOLeavePolicy> BOLeavePolicy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOLeavePolicyDetail> BOLeavePolicyDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOLeaveType> BOLeaveType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOLinkToTransaction> BOLinkToTransaction { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOLoggingInformation> BOLoggingInformation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOLoginAttempts> BOLoginAttempts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOMenu> BOMenu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOMenuControlInfo> BOMenuControlInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOModuleColInfo> BOModuleColInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOModuleParamInfo> BOModuleParamInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPartyOrCustomer> BOPartyOrCustomer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPayGrade> BOPayGrade { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPayGradeAllowanceOrBenefit> BOPayGradeAllowanceOrBenefit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOProcessApprovalAlert> BOProcessApprovalAlert { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOProfileGroup> BOProfileGroup { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOProfileGroupDetail> BOProfileGroupDetail { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOReimbursement> BOReimbursement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOReimbursementType> BOReimbursementType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BORemittanceAdvice> BORemittanceAdvice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BORemittanceAdviceDetail> BORemittanceAdviceDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOReportDashboardInfo> BOReportDashboardInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOSalaryBreakUpPolicy> BOSalaryBreakUpPolicy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOSalaryBreakUpPolicyDetail> BOSalaryBreakUpPolicyDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOSalaryTransferMode> BOSalaryTransferMode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOSectorZone> BOSectorZone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOSecurityRight> BOSecurityRight { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOShift> BOShift { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOShiftDay> BOShiftDay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOSRMDataLogging> BOSRMDataLogging { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOStateProvince> BOStateProvince { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOSystemOrWebPool> BOSystemOrWebPool { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOTaxAdjustmentType> BOTaxAdjustmentType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOTransactionDetail> BOTransactionDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOTransactionDocumentConfiguration> BOTransactionDocumentConfiguration { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOTransactionDocumentProcess> BOTransactionDocumentProcess { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOTransactionMaster> BOTransactionMaster { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOUMSDataLogging> BOUMSDataLogging { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOUOM> BOUOM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOUser> BOUser3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOUserLocationSitePermission> BOUserLocationSitePermission { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOUserMenuAdditionSubtraction> BOUserMenuAdditionSubtraction { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOUserOrganizationCompanyPermission> BOUserOrganizationCompanyPermission { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOUserPartyOrCustomerPermission> BOUserPartyOrCustomerPermission { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOUserProfileGroup> BOUserProfileGroup { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOUserSystemOrWebPermission> BOUserSystemOrWebPermission { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOUserVendorOrSupplierPermission> BOUserVendorOrSupplierPermission { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOVendorOrSupplier> BOVendorOrSupplier { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOVoucherType> BOVoucherType { get; set; }
    }
}

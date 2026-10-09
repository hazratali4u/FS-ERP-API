using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("AppCNF.tbl_OrganizationCompany")]
    public partial class BOOrganizationCompany
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOOrganizationCompany()
        {
            BOAllowanceOrBenefitType = new HashSet<BOAllowanceOrBenefitType>();
            BOAppConfiguration = new HashSet<BOAppConfiguration>();
            BOAppConfigurationDetail = new HashSet<BOAppConfigurationDetail>();
            BOApprovalAuthorityType = new HashSet<BOApprovalAuthorityType>();
            BOAttendanceMachineType = new HashSet<BOAttendanceMachineType>();
            BOBillOrInvoiceType = new HashSet<BOBillOrInvoiceType>();
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
            BOOnwerShipType = new HashSet<BOOnwerShipType>();
            BOActionLogging = new HashSet<BOActionLogging>();
            BOAllowancesOrBenefit = new HashSet<BOAllowancesOrBenefit>();
            BOAPPCNFDataLogging = new HashSet<BOAPPCNFDataLogging>();
            BOAttendanceDiscrepancy = new HashSet<BOAttendanceDiscrepancy>();
            BOBank = new HashSet<BOBank>();
            BOBankAccount = new HashSet<BOBankAccount>();
            BOBankAccountInstrumentInfo = new HashSet<BOBankAccountInstrumentInfo>();
            BOBankAccountInstrumentInfo1 = new HashSet<BOBankAccountInstrumentInfo>();
            BOBankAccountInstrumentInfo2 = new HashSet<BOBankAccountInstrumentInfo>();
            BOBankBranch = new HashSet<BOBankBranch>();
            BOBillOrInvoiceMaster = new HashSet<BOBillOrInvoiceMaster>();
            BOBillOrInvoiceMaster1 = new HashSet<BOBillOrInvoiceMaster>();
            BOBillOrInvoiceMasterDetail = new HashSet<BOBillOrInvoiceMasterDetail>();
            BOCalendar = new HashSet<BOCalendar>();
            BOCOA = new HashSet<BOCOA>();
            BOCOAConfiguration = new HashSet<BOCOAConfiguration>();
            BOCOAMapping = new HashSet<BOCOAMapping>();
            BOCOAMappingForPCorCC = new HashSet<BOCOAMappingForPCorCC>();
            BOCOAMappingForPCorCC1 = new HashSet<BOCOAMappingForPCorCC>();
            BOCOANature = new HashSet<BOCOANature>();
            BOCRMDataLogging = new HashSet<BOCRMDataLogging>();
            BODeductionType = new HashSet<BODeductionType>();
            BODegree = new HashSet<BODegree>();
            BODegreeInstitute = new HashSet<BODegreeInstitute>();
            BODepartment = new HashSet<BODepartment>();
            BODesignation = new HashSet<BODesignation>();
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
            BOEmployeeIncrement1 = new HashSet<BOEmployeeIncrement>();
            BOEmployeeIncrement2 = new HashSet<BOEmployeeIncrement>();
            BOEmployeeIncrement3 = new HashSet<BOEmployeeIncrement>();
            BOEmployeeIncrementAllowanceOrBenefit = new HashSet<BOEmployeeIncrementAllowanceOrBenefit>();
            BOEmployeeInfo = new HashSet<BOEmployeeInfo>();
            BOEmployeeInfo1 = new HashSet<BOEmployeeInfo>();
            BOEmployeeInfo2 = new HashSet<BOEmployeeInfo>();
            BOEmployeeInfo3 = new HashSet<BOEmployeeInfo>();
            BOEmployeeInfoHistory = new HashSet<BOEmployeeInfoHistory>();
            BOEmployeeInfoRevision = new HashSet<BOEmployeeInfoRevision>();
            BOEmployeeInfoRevision1 = new HashSet<BOEmployeeInfoRevision>();
            BOEmployeeInfoRevision2 = new HashSet<BOEmployeeInfoRevision>();
            BOEmployeeInfoRevision3 = new HashSet<BOEmployeeInfoRevision>();
            BOEmployeeLease = new HashSet<BOEmployeeLease>();
            BOEmployeeLeaseInstallment = new HashSet<BOEmployeeLeaseInstallment>();
            BOEmployeeLeave = new HashSet<BOEmployeeLeave>();
            BOEmployeeLeaveBalance = new HashSet<BOEmployeeLeaveBalance>();
            BOEmployeeLoan = new HashSet<BOEmployeeLoan>();
            BOEmployeeLoanInstallment = new HashSet<BOEmployeeLoanInstallment>();
            BOEmployeeReference = new HashSet<BOEmployeeReference>();
            BOEmployeeSalary = new HashSet<BOEmployeeSalary>();
            BOEmployeeSalary1 = new HashSet<BOEmployeeSalary>();
            BOEmployeeSalary2 = new HashSet<BOEmployeeSalary>();
            BOEmployeeSalary3 = new HashSet<BOEmployeeSalary>();
            BOEmployeeSalaryAddition = new HashSet<BOEmployeeSalaryAddition>();
            BOEmployeeSalaryAllowanceOrBenefit = new HashSet<BOEmployeeSalaryAllowanceOrBenefit>();
            BOEmployeeSalaryDeduction = new HashSet<BOEmployeeSalaryDeduction>();
            BOEmployeeSalaryReimbursement = new HashSet<BOEmployeeSalaryReimbursement>();
            BOEmployeeStatus = new HashSet<BOEmployeeStatus>();
            BOEquipment = new HashSet<BOEquipment>();
            BOEquipment1 = new HashSet<BOEquipment>();
            BOEquipment2 = new HashSet<BOEquipment>();
            BOErrorLogging = new HashSet<BOErrorLogging>();
            BOFICODataLogging = new HashSet<BOFICODataLogging>();
            BOFiscalYear = new HashSet<BOFiscalYear>();
            BOFiscalYearMonth = new HashSet<BOFiscalYearMonth>();
            BOFiscalYearMonth1 = new HashSet<BOFiscalYearMonth>();
            BOFiscalYearMonthDetail = new HashSet<BOFiscalYearMonthDetail>();
            BOFiscalYearMonthDetail1 = new HashSet<BOFiscalYearMonthDetail>();
            BOFiscalYearMonthDetail2 = new HashSet<BOFiscalYearMonthDetail>();
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
            BOItemPrice1 = new HashSet<BOItemPrice>();
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
            BOOrganizationCompany1 = new HashSet<BOOrganizationCompany>();
            BOOpportunity = new HashSet<BOOpportunity>();
            BOOpportunity1 = new HashSet<BOOpportunity>();
            BOPackingType = new HashSet<BOPackingType>();
            BOPartyOrCustomer = new HashSet<BOPartyOrCustomer>();
            BOPayGrade = new HashSet<BOPayGrade>();
            BOPayGradeAllowanceOrBenefit = new HashSet<BOPayGradeAllowanceOrBenefit>();
            BOPaymentMode = new HashSet<BOPaymentMode>();
            BOPriority = new HashSet<BOPriority>();
            BOProcessApprovalWorkflow = new HashSet<BOProcessApprovalWorkflow>();
            BOProcessApprovalAlert = new HashSet<BOProcessApprovalAlert>();
            BOProcessApprovalWorkflow1 = new HashSet<BOProcessApprovalWorkflow>();
            BOProfileGroup = new HashSet<BOProfileGroup>();
            BOProfileGroupDetail = new HashSet<BOProfileGroupDetail>();
            BORebateType = new HashSet<BORebateType>();
            BOReimbursement = new HashSet<BOReimbursement>();
            BOReimbursementType = new HashSet<BOReimbursementType>();
            BORemittanceAdvice = new HashSet<BORemittanceAdvice>();
            BORemittanceAdvice1 = new HashSet<BORemittanceAdvice>();
            BORemittanceAdviceDetail = new HashSet<BORemittanceAdviceDetail>();
            BOSalaryBreakUpPolicy = new HashSet<BOSalaryBreakUpPolicy>();
            BOSalaryBreakUpPolicy1 = new HashSet<BOSalaryBreakUpPolicy>();
            BOSalaryBreakUpPolicyDetail = new HashSet<BOSalaryBreakUpPolicyDetail>();
            BOSalaryBreakUpPolicyDetail1 = new HashSet<BOSalaryBreakUpPolicyDetail>();
            BOSalaryTransferMode = new HashSet<BOSalaryTransferMode>();
            BOShift = new HashSet<BOShift>();
            BOShiftDay = new HashSet<BOShiftDay>();
            BOSRMDataLogging = new HashSet<BOSRMDataLogging>();
            BOSystemOrWebPool = new HashSet<BOSystemOrWebPool>();
            BOTaxAdjustmentType = new HashSet<BOTaxAdjustmentType>();
            BOTransactionDetail = new HashSet<BOTransactionDetail>();
            BOTransactionDocumentConfiguration = new HashSet<BOTransactionDocumentConfiguration>();
            BOTransactionDocumentProcess = new HashSet<BOTransactionDocumentProcess>();
            BOTransactionMaster = new HashSet<BOTransactionMaster>();
            BOUMSDataLogging = new HashSet<BOUMSDataLogging>();
            BOUser3 = new HashSet<BOUser>();
            BOUser4 = new HashSet<BOUser>();
            BOUserLocationSitePermission = new HashSet<BOUserLocationSitePermission>();
            BOUserMenuAdditionSubtraction = new HashSet<BOUserMenuAdditionSubtraction>();
            BOUserOrganizationCompanyPermission = new HashSet<BOUserOrganizationCompanyPermission>();
            BOUserOrganizationCompanyPermission1 = new HashSet<BOUserOrganizationCompanyPermission>();
            BOUserPartyOrCustomerPermission = new HashSet<BOUserPartyOrCustomerPermission>();
            BOUserProfileGroup = new HashSet<BOUserProfileGroup>();
            BOUserSystemOrWebPermission = new HashSet<BOUserSystemOrWebPermission>();
            BOUserVendorOrSupplierPermission = new HashSet<BOUserVendorOrSupplierPermission>();
            BOVendorOrSupplier = new HashSet<BOVendorOrSupplier>();
            BOVoucherType = new HashSet<BOVoucherType>();
            BOItemDealAssignment = new HashSet<BOItemDealAssignment>();
        }

        public int ID { get; set; }

        public int? ParentCode { get; set; }

        public byte? LevelCode { get; set; }

        public short SequenceNo { get; set; }

        [StringLength(25)]
        public string ShortName { get; set; }

        [Required]
        [StringLength(255)]
        public string FullName { get; set; }

        [Required]
        [StringLength(510)]
        public string DisplayName { get; set; }

        [StringLength(1020)]
        public string Description { get; set; }

        public byte[] OrganizationCompanyLogo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EstablishDate { get; set; }

        [StringLength(50)]
        public string UAN_No { get; set; }

        [StringLength(50)]
        public string URL_Name { get; set; }

        [StringLength(50)]
        public string SNS_RegNo { get; set; }

        [StringLength(50)]
        public string NTN_No { get; set; }

        [StringLength(50)]
        public string GST_No { get; set; }

        [StringLength(50)]
        public string IATACode { get; set; }

        [StringLength(50)]
        public string AgentCode { get; set; }

        [StringLength(50)]
        public string HouseNRCode { get; set; }

        public short? DefaultCultureCode { get; set; }

        public short? DefaultCurrencyCode { get; set; }

        public int? CityTownCode { get; set; }

        public int? DistrictWardCode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Longitude { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Latitude { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Altitude { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Radius { get; set; }

        [StringLength(15)]
        public string PostalZipCode { get; set; }

        [StringLength(510)]
        public string OfficialAddress { get; set; }

        [StringLength(50)]
        public string OfficialPhoneNo { get; set; }

        [StringLength(7)]
        public string PhoneExt { get; set; }

        [StringLength(50)]
        public string PersonalPhoneNo { get; set; }

        [StringLength(50)]
        public string EmergencyPhoneNo { get; set; }

        [StringLength(50)]
        public string FaxNo { get; set; }

        [StringLength(50)]
        public string OfficialEmail { get; set; }

        [StringLength(50)]
        public string EmailPersonal { get; set; }

        [StringLength(255)]
        public string ContactPerson { get; set; }

        [StringLength(50)]
        public string ContactPersonCNIC { get; set; }

        [StringLength(50)]
        public string ContactPersonEmail { get; set; }

        [StringLength(50)]
        public string PersonalMobileNo { get; set; }

        [StringLength(50)]
        public string OfficialMobileNo { get; set; }

        [StringLength(50)]
        public string EmergencyMobileNo { get; set; }

        public DateTime? dtmExported { get; set; }

        public DateTime? dtmImported { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        public byte RecordStatusCode { get; set; }

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
        public virtual ICollection<BOOnwerShipType> BOOnwerShipType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOActionLogging> BOActionLogging { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOAllowancesOrBenefit> BOAllowancesOrBenefit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOAPPCNFDataLogging> BOAPPCNFDataLogging { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOAttendanceDiscrepancy> BOAttendanceDiscrepancy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOBank> BOBank { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOBankAccount> BOBankAccount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOBankAccountInstrumentInfo> BOBankAccountInstrumentInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOBankAccountInstrumentInfo> BOBankAccountInstrumentInfo1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOBankAccountInstrumentInfo> BOBankAccountInstrumentInfo2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOBankBranch> BOBankBranch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOBillOrInvoiceMaster> BOBillOrInvoiceMaster { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOBillOrInvoiceMaster> BOBillOrInvoiceMaster1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOBillOrInvoiceMasterDetail> BOBillOrInvoiceMasterDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOCalendar> BOCalendar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOCOA> BOCOA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOCOAConfiguration> BOCOAConfiguration { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOCOAMapping> BOCOAMapping { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOCOAMappingForPCorCC> BOCOAMappingForPCorCC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOCOAMappingForPCorCC> BOCOAMappingForPCorCC1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOCOANature> BOCOANature { get; set; }

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
        public virtual ICollection<BOEmployeeIncrement> BOEmployeeIncrement1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeIncrement> BOEmployeeIncrement2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeIncrement> BOEmployeeIncrement3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeIncrementAllowanceOrBenefit> BOEmployeeIncrementAllowanceOrBenefit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeInfo> BOEmployeeInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeInfo> BOEmployeeInfo1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeInfo> BOEmployeeInfo2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeInfo> BOEmployeeInfo3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeInfoHistory> BOEmployeeInfoHistory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeInfoRevision> BOEmployeeInfoRevision { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeInfoRevision> BOEmployeeInfoRevision1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeInfoRevision> BOEmployeeInfoRevision2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeInfoRevision> BOEmployeeInfoRevision3 { get; set; }

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
        public virtual ICollection<BOEmployeeSalary> BOEmployeeSalary1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeSalary> BOEmployeeSalary2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeSalary> BOEmployeeSalary3 { get; set; }

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
        public virtual ICollection<BOEquipment> BOEquipment1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEquipment> BOEquipment2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOErrorLogging> BOErrorLogging { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOFICODataLogging> BOFICODataLogging { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOFiscalYear> BOFiscalYear { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOFiscalYearMonth> BOFiscalYearMonth { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOFiscalYearMonth> BOFiscalYearMonth1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOFiscalYearMonthDetail> BOFiscalYearMonthDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOFiscalYearMonthDetail> BOFiscalYearMonthDetail1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOFiscalYearMonthDetail> BOFiscalYearMonthDetail2 { get; set; }

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
        public virtual ICollection<BOItemPrice> BOItemPrice1 { get; set; }

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
        public virtual ICollection<BOOrganizationCompany> BOOrganizationCompany1 { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany2 { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPackingType> BOPackingType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPartyOrCustomer> BOPartyOrCustomer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPayGrade> BOPayGrade { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPayGradeAllowanceOrBenefit> BOPayGradeAllowanceOrBenefit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPaymentMode> BOPaymentMode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPriority> BOPriority { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOProcessApprovalWorkflow> BOProcessApprovalWorkflow { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOProcessApprovalAlert> BOProcessApprovalAlert { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOProcessApprovalWorkflow> BOProcessApprovalWorkflow1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOProfileGroup> BOProfileGroup { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOProfileGroupDetail> BOProfileGroupDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BORebateType> BORebateType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOReimbursement> BOReimbursement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOReimbursementType> BOReimbursementType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BORemittanceAdvice> BORemittanceAdvice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BORemittanceAdvice> BORemittanceAdvice1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BORemittanceAdviceDetail> BORemittanceAdviceDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOSalaryBreakUpPolicy> BOSalaryBreakUpPolicy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOSalaryBreakUpPolicy> BOSalaryBreakUpPolicy1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOSalaryBreakUpPolicyDetail> BOSalaryBreakUpPolicyDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOSalaryBreakUpPolicyDetail> BOSalaryBreakUpPolicyDetail1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOSalaryTransferMode> BOSalaryTransferMode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOShift> BOShift { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOShiftDay> BOShiftDay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOSRMDataLogging> BOSRMDataLogging { get; set; }

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
        public virtual ICollection<BOUser> BOUser3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOUser> BOUser4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOUserLocationSitePermission> BOUserLocationSitePermission { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOUserMenuAdditionSubtraction> BOUserMenuAdditionSubtraction { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOUserOrganizationCompanyPermission> BOUserOrganizationCompanyPermission { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOUserOrganizationCompanyPermission> BOUserOrganizationCompanyPermission1 { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOOpportunity> BOOpportunity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOOpportunity> BOOpportunity1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOItemDealAssignment> BOItemDealAssignment { get; set; }
    }
}

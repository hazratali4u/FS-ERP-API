using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("HRM.tbl_EmployeeInfo")]
    public partial class BOEmployeeInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOEmployeeInfo()
        {
            BOPayrollInputMaster = new HashSet<BOPayrollInputMaster>();
            BOEmployeeLoanPayment = new HashSet<BOEmployeeLoanPayment>();
            BOEmployeeLockedAttendanceDetails = new HashSet<BOEmployeeLockedAttendanceDetails>();
            BOEmployeeManualAllowanceOrBenefit = new HashSet<BOEmployeeManualAllowanceOrBenefit>();
            BOEmployeeManualOvertime = new HashSet<BOEmployeeManualOvertime>();
            BOEmployeeSalaryLoanLease = new HashSet<BOEmployeeSalaryLoanLease>();
            BODutyRoster = new HashSet<BODutyRoster>();
            BOEquipmentIssuedOrReturn = new HashSet<BOEquipmentIssuedOrReturn>();
            BOEmployeeTrackingDetail = new HashSet<BOEmployeeTrackingDetail>();
            BOEmployeeTrackingConfiguration = new HashSet<BOEmployeeTrackingConfiguration>();
            BODeliveryNoteMaster = new HashSet<BODeliveryNoteMaster>();
            BOSaleOrderMaster = new HashSet<BOSaleOrderMaster>();
            BOEmployeeOvertimeProcess = new HashSet<BOEmployeeOvertimeProcess>();
            BOEmployeeGeoRestrictions = new HashSet<BOEmployeeGeoRestrictions>();
            BOEmployeeDocuments = new HashSet<BOEmployeeDocuments>();
            BOLeaveEncashmentProcess = new HashSet<BOLeaveEncashmentProcess>();
            BOLeaveYearEndProcess = new HashSet<BOLeaveYearEndProcess>();
            BOExpenseClaim = new HashSet<BOExpenseClaim>();
            BOExpensePayment = new HashSet<BOExpensePayment>();
            BOBonusProcess = new HashSet<BOBonusProcess>();
            BOSeparationSubmission = new HashSet<BOSeparationSubmission>();
            BOSeparationSubmission1 = new HashSet<BOSeparationSubmission>();
            BOSeparationChecklistSetup = new HashSet<BOSeparationChecklistSetup>();
            BOSeparationCheckList = new HashSet<BOSeparationCheckList>();
            BOSeparationCheckList1 = new HashSet<BOSeparationCheckList>();
            BOEmployeeManagementRemarks = new HashSet<BOEmployeeManagementRemarks>();
            BOEmployeePersonalAttribute = new HashSet<BOEmployeePersonalAttribute>();
            BOEmployeeHiringReference = new HashSet<BOEmployeeHiringReference>();
            BOEmployeeIncident = new HashSet<BOEmployeeIncident>();
            BOEmployeeRelative = new HashSet<BOEmployeeRelative>();
            BOEmployeeRelative1 = new HashSet<BOEmployeeRelative>();
            BOEmployeeAward = new HashSet<BOEmployeeAward>();
            BOBillOrInvoiceMaster = new HashSet<BOBillOrInvoiceMaster>();
            BOJobProjectScheme = new HashSet<BOJobProjectScheme>();
            BOJobProjectScheme1 = new HashSet<BOJobProjectScheme>();
            BORemittanceAdvice = new HashSet<BORemittanceAdvice>();
            BORemittanceAdvice1 = new HashSet<BORemittanceAdvice>();
            BORemittanceAdvice2 = new HashSet<BORemittanceAdvice>();
            BOTransactionDetail = new HashSet<BOTransactionDetail>();
            BOTransactionMaster = new HashSet<BOTransactionMaster>();
            BOAttendanceDiscrepancy = new HashSet<BOAttendanceDiscrepancy>();
            BOEmpDocumentCheckList = new HashSet<BOEmpDocumentCheckList>();
            BOEmployeeAcademic = new HashSet<BOEmployeeAcademic>();
            BOEmployeeAllowanceOrBenefit = new HashSet<BOEmployeeAllowanceOrBenefit>();
            BOEmployeeAttendance = new HashSet<BOEmployeeAttendance>();
            BOEmployeeEmployment = new HashSet<BOEmployeeEmployment>();
            BOEmployeeFaceOrBiometric = new HashSet<BOEmployeeFaceOrBiometric>();
            BOEmployeeFamily = new HashSet<BOEmployeeFamily>();
            BOEmployeeIncrement = new HashSet<BOEmployeeIncrement>();
            BOEmployeeIncrementAllowanceOrBenefit = new HashSet<BOEmployeeIncrementAllowanceOrBenefit>();
            BOEmployeeInfo1 = new HashSet<BOEmployeeInfo>();
            BOEmployeeInfo11 = new HashSet<BOEmployeeInfo>();
            BOEmployeeInfo12 = new HashSet<BOEmployeeInfo>();
            BOEmployeeInfoRevision = new HashSet<BOEmployeeInfoRevision>();
            BOEmployeeLease = new HashSet<BOEmployeeLease>();
            BOEmployeeLeave = new HashSet<BOEmployeeLeave>();
            BOEmployeeLeave1 = new HashSet<BOEmployeeLeave>();
            BOEmployeeLeaveBalance = new HashSet<BOEmployeeLeaveBalance>();
            BOEmployeeLoan = new HashSet<BOEmployeeLoan>();
            BOEmployeeReference = new HashSet<BOEmployeeReference>();
            BOEmployeeSalary = new HashSet<BOEmployeeSalary>();
            BOEmployeeSalaryAddition = new HashSet<BOEmployeeSalaryAddition>();
            BOEmployeeSalaryAllowanceOrBenefit = new HashSet<BOEmployeeSalaryAllowanceOrBenefit>();
            BOEmployeeSalaryDeduction = new HashSet<BOEmployeeSalaryDeduction>();
            BOEmployeeSalaryReimbursement = new HashSet<BOEmployeeSalaryReimbursement>();
            BOFundDemandRegister = new HashSet<BOFundDemandRegister>();
            BOFundDemandRegister1 = new HashSet<BOFundDemandRegister>();
            BOFundDemandRequest = new HashSet<BOFundDemandRequest>();
            BOLeaveDeductionAgainstLate = new HashSet<BOLeaveDeductionAgainstLate>();
            BOProcessApprovalAlert = new HashSet<BOProcessApprovalAlert>();
            BOReimbursement = new HashSet<BOReimbursement>();
            BOUser3 = new HashSet<BOUser>();
            BOGatePassDetail = new HashSet<BOGatePassDetail>();
            BOGatePassDetail1 = new HashSet<BOGatePassDetail>();
            BOGatePass = new HashSet<BOGatePass>();
            BOGatePass1 = new HashSet<BOGatePass>();
            BOGRNandReturn = new HashSet<BOGRNandReturn>();
            BOGRNandReturnDetail = new HashSet<BOGRNandReturnDetail>();
            BOPurchaseOrderAndReturnDetail = new HashSet<BOPurchaseOrderAndReturnDetail>();
            BOReceipeMaster = new HashSet<BOReceipeMaster>();
            BOProductionMaster = new HashSet<BOProductionMaster>();
            BOGenerateLetter = new HashSet<BOGenerateLetter>();
            BOGenerateLetter1 = new HashSet<BOGenerateLetter>();
            BOBulletin = new HashSet<BOBulletin>();
            BOMassCommunication = new HashSet<BOMassCommunication>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public System.Guid UniqueID { get; set; }
        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string EmpImage { get; set; }
        public int EmpCompanyCode { get; set; }
        public Nullable<bool> IsGender { get; set; }
        public string EmpCode { get; set; }
        public string EmpExCode { get; set; }
        public Nullable<short> MaritalStatusCode { get; set; }
        public string HusbandName { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string NCNIC { get; set; }
        public Nullable<System.DateTime> NCNICExpiry { get; set; }
        public string FatherIDCardNo { get; set; }
        public string PassportNumber { get; set; }
        public Nullable<System.DateTime> PassportExpiry { get; set; }
        public string FamilyCardNo { get; set; }
        public Nullable<int> DomicileCountryCode { get; set; }
        public Nullable<int> DomicileCityCode { get; set; }
        public int ReligionCode { get; set; }
        public string EthnicOrigin { get; set; }
        public string NativeLanguage { get; set; }
        public string Nationality { get; set; }
        public Nullable<bool> IsPhysicallyChallenged { get; set; }
        public string BloodGroup { get; set; }
        public Nullable<int> CountryCode { get; set; }
        public Nullable<int> CityTownCode { get; set; }
        public Nullable<int> DistrictWardCode { get; set; }
        public string Mobile { get; set; }
        public string PersonalMobile { get; set; }
        public string OfficialEmail { get; set; }
        public string Email { get; set; }
        public string CurrentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string ContactPerson1 { get; set; }
        public string EmergencyMobile1 { get; set; }
        public Nullable<byte> RelationCode1 { get; set; }
        public string ContactPerson2 { get; set; }
        public string EmergencyMobile2 { get; set; }
        public Nullable<byte> RelationCode2 { get; set; }
        public string OtherInformation { get; set; }
        public int CostOrProfitCenterCode { get; set; }
        public Nullable<int> CurrentLocationCode { get; set; }
        public Nullable<int> ReportingLocationCode { get; set; }
        public int DeptCode { get; set; }
        public int DesignationCode { get; set; }
        public Nullable<int> TeamCode { get; set; }
        public Nullable<long> HODEmployeeCode { get; set; }
        public Nullable<long> ReportingEmployeeCode { get; set; }
        public Nullable<long> FunctionalEmployeeCode { get; set; }
        public byte HireTypeCode { get; set; }
        public string NatureOfVacancy { get; set; }
        public Nullable<short> LeavePolicyCode { get; set; }
        public short ShiftCode { get; set; }
        public Nullable<bool> IsMultipleShiftsAllowed { get; set; }
        public bool? IsVirtual { get; set; }
        public Nullable<System.DateTime> DOH { get; set; }
        public Nullable<System.DateTime> DOJ { get; set; }
        public Nullable<System.DateTime> DOC { get; set; }
        public Nullable<System.DateTime> DOCExtended { get; set; }
        public Nullable<System.DateTime> ContractExpiry { get; set; }
        public Nullable<System.DateTime> InternshipExpiry { get; set; }
        public Nullable<System.DateTime> LastPromotionDate { get; set; }
        public Nullable<System.DateTime> LastIncrementDate { get; set; }
        public Nullable<System.DateTime> NextIncrementDueDate { get; set; }
        public Nullable<int> NoticePeriod { get; set; }
        public Nullable<int> ProbationPeriod { get; set; }
        public Nullable<int> ContractPeriod { get; set; }
        public string Specialty { get; set; }
        public string EmpSource { get; set; }
        public string EmpSourceValue { get; set; }
        public Nullable<short> JobRoleCode { get; set; }
        public Nullable<long> RequsitionCode { get; set; }
        public string Requsition { get; set; }
        public string JobDescription { get; set; }
        public int? PayrollCostOrProfitCenterCode { get; set; }
        public Nullable<short> PayGradeCode { get; set; }
        public byte? SalaryTransferMode { get; set; }
        public short? CurrencyCode { get; set; }
        public string AccountNumber { get; set; }
        public string AccountTitle { get; set; }
        public Nullable<int> BankBranchCode { get; set; }
        public string BranchCode { get; set; }
        public string IBAN { get; set; }
        public string NTN { get; set; }
        public Nullable<int> PFNumber { get; set; }
        public string SocialSecurityNo { get; set; }
        public string EOBINo { get; set; }
        public Nullable<decimal> OpeningPF { get; set; }
        public Nullable<decimal> PFBalance { get; set; }
        public Nullable<System.DateTime> PFEffectiveDate { get; set; }
        public Nullable<System.DateTime> SocialSecurityDate { get; set; }
        public Nullable<System.DateTime> EOBIStartDate { get; set; }
        public string PermitNumber { get; set; }
        public string PermitProfession { get; set; }
        public Nullable<System.DateTime> PermitExpiry { get; set; }
        public Nullable<bool> IsValidLicenceHolder { get; set; }
        public Nullable<int> DrivingLicenceCountryCode { get; set; }
        public string PenaltiesHistory { get; set; }
        public string PendingCases { get; set; }
        public string SponsorName { get; set; }
        public Nullable<int> SponsorCountryCode { get; set; }
        public Nullable<int> SponsorCityCode { get; set; }
        public string SponsorBusiness { get; set; }
        public string SponsorContact { get; set; }
        public Nullable<int> SponsorsChangedUnderCurrentVisa { get; set; }
        public string SponsorDetails { get; set; }
        public string SponsorshipType { get; set; }
        public string SponsorshipCategory { get; set; }
        public Nullable<System.DateTime> SponsorshipExpiry { get; set; }
        public Nullable<bool> IsSponsorshipTransferable { get; set; }
        public Nullable<long> COACode { get; set; }
        public Nullable<decimal> BasicPay { get; set; }
        public Nullable<bool> IsOnProbation { get; set; }
        public Nullable<bool> IsContractual { get; set; }
        public int CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }



        public virtual BOCurrency BOCurrency { get; set; }

        public virtual BOLocationSite BOLocationSite { get; set; }

        public virtual BOLocationSite BOLocationSite1 { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany1 { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany2 { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany3 { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }


        public virtual BOSalaryTransferMode BOSalaryTransferMode { get; set; }

        public virtual BOBankBranch BOBankBranch { get; set; }

        public virtual BOMaritalStatus BOMaritalStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOBillOrInvoiceMaster> BOBillOrInvoiceMaster { get; set; }

        public virtual BOCOA BOCOA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOJobProjectScheme> BOJobProjectScheme { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOJobProjectScheme> BOJobProjectScheme1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BORemittanceAdvice> BORemittanceAdvice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BORemittanceAdvice> BORemittanceAdvice1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BORemittanceAdvice> BORemittanceAdvice2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOTransactionDetail> BOTransactionDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOTransactionMaster> BOTransactionMaster { get; set; }

        public virtual BOCityTown BOCityTown { get; set; }

        public virtual BODistrictWard BODistrictWard { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOAttendanceDiscrepancy> BOAttendanceDiscrepancy { get; set; }

        public virtual BODepartment BODepartment { get; set; }

        public virtual BODesignation BODesignation { get; set; }
        public virtual BOTeamInfo BOTeamInfo { get; set; }
        public virtual BOReligion BOReligion { get; set; }

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
        public virtual ICollection<BOEmployeeInfo> BOEmployeeInfo1 { get; set; }

        public virtual BOEmployeeInfo BOEmployeeInfo2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeInfo> BOEmployeeInfo11 { get; set; }

        public virtual BOEmployeeInfo BOEmployeeInfo3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeInfo> BOEmployeeInfo12 { get; set; }

        public virtual BOEmployeeInfo BOEmployeeInfo4 { get; set; }

        public virtual BOHireType BOHireType { get; set; }

        public virtual BOJobRole BOJobRole { get; set; }

        [ForeignKey("LeavePolicyCode")]
        public virtual BOLeavePolicy BOLeavePolicy { get; set; }

        [ForeignKey("PayGradeCode")]
        public virtual BOPayGrade BOPayGrade { get; set; }

        [ForeignKey("ShiftCode")]
        public virtual BOShift BOShift { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeInfoRevision> BOEmployeeInfoRevision { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeLease> BOEmployeeLease { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeLeave> BOEmployeeLeave { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeLeave> BOEmployeeLeave1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeLeaveBalance> BOEmployeeLeaveBalance { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeLoan> BOEmployeeLoan { get; set; }

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
        public virtual ICollection<BOFundDemandRegister> BOFundDemandRegister { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOFundDemandRegister> BOFundDemandRegister1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOFundDemandRequest> BOFundDemandRequest { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOLeaveDeductionAgainstLate> BOLeaveDeductionAgainstLate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOProcessApprovalAlert> BOProcessApprovalAlert { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOReimbursement> BOReimbursement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOUser> BOUser3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOStockRequisitionOrIssuanceDetail> BOStockRequisitionOrIssuanceDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOStockRequisitionOrIssuanceDetail> BOStockRequisitionOrIssuanceDetail1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOGatePassDetail> BOGatePassDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOGatePassDetail> BOGatePassDetail1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOGatePass> BOGatePass { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOGatePass> BOGatePass1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOGRNandReturn> BOGRNandReturn { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOGRNandReturnDetail> BOGRNandReturnDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPurchaseOrderAndReturnDetail> BOPurchaseOrderAndReturnDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOReceipeMaster> BOReceipeMaster { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOProductionMaster> BOProductionMaster { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOGenerateLetter> BOGenerateLetter { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOGenerateLetter> BOGenerateLetter1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOBulletin> BOBulletin { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOMassCommunication> BOMassCommunication { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeAward> BOEmployeeAward { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeRelative> BOEmployeeRelative { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeRelative> BOEmployeeRelative1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeIncident> BOEmployeeIncident { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeHiringReference> BOEmployeeHiringReference { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeePersonalAttribute> BOEmployeePersonalAttribute { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeManagementRemarks> BOEmployeeManagementRemarks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOSeparationCheckList> BOSeparationCheckList { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOSeparationCheckList> BOSeparationCheckList1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOSeparationChecklistSetup> BOSeparationChecklistSetup { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOSeparationSubmission> BOSeparationSubmission { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOSeparationSubmission> BOSeparationSubmission1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOBonusProcess> BOBonusProcess { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOExpensePayment> BOExpensePayment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOExpenseClaim> BOExpenseClaim { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOLeaveYearEndProcess> BOLeaveYearEndProcess { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOLeaveEncashmentProcess> BOLeaveEncashmentProcess { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeDocuments> BOEmployeeDocuments { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeGeoRestrictions> BOEmployeeGeoRestrictions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeOvertimeProcess> BOEmployeeOvertimeProcess { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOSaleOrderMaster> BOSaleOrderMaster { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BODeliveryNoteMaster> BODeliveryNoteMaster { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeTrackingConfiguration> BOEmployeeTrackingConfiguration { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeTrackingDetail> BOEmployeeTrackingDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEquipmentIssuedOrReturn> BOEquipmentIssuedOrReturn { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BODutyRoster> BODutyRoster { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeSalaryLoanLease> BOEmployeeSalaryLoanLease { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeManualOvertime> BOEmployeeManualOvertime { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeManualAllowanceOrBenefit> BOEmployeeManualAllowanceOrBenefit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeLockedAttendanceDetails> BOEmployeeLockedAttendanceDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeLoanPayment> BOEmployeeLoanPayment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPayrollInputMaster> BOPayrollInputMaster { get; set; }
    }
}

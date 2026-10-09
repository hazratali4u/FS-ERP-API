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
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public Guid UniqueID { get; set; }

        public int EmpCompanyCode { get; set; }

        public int PayrollCostOrProfitCenterCode { get; set; }

        public int CostOrProfitCenterCode { get; set; }

        public int? CurrentLocationCode { get; set; }

        public int? ReportingLocationCode { get; set; }

        public byte HireTypeCode { get; set; }

        public byte EmpStatusCode { get; set; }

        public byte SalaryTransferMode { get; set; }

        [StringLength(50)]
        public string EmpExCode { get; set; }

        [StringLength(50)]
        public string EmpCode { get; set; }

        [StringLength(255)]
        public string EmpAlias { get; set; }

        [Required]
        [StringLength(50)]
        public string Salutation { get; set; }

        [StringLength(50)]
        public string Suffix { get; set; }

        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }

        [StringLength(255)]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(255)]
        public string LastName { get; set; }

        public bool? IsGender { get; set; }

        [StringLength(255)]
        public string FatherName { get; set; }

        [StringLength(255)]
        public string HusbandName { get; set; }

        [Required]
        [StringLength(50)]
        public string NCNIC { get; set; }

        [StringLength(50)]
        public string NTN { get; set; }

        public byte[] EmpImage { get; set; }

        [StringLength(50)]
        public string NatureOfVacancy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DOB { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DOH { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DOJ { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DOC { get; set; }

        public double? ServiceOrContractPeriod { get; set; }

        [StringLength(255)]
        public string EmpSource { get; set; }

        [StringLength(255)]
        public string EmpSourceValue { get; set; }

        public long? COACode { get; set; }

        public int DeptCode { get; set; }

        public int DesignationCode { get; set; }

        public short? PayGradeCode { get; set; }

        public short CurrencyCode { get; set; }

        public short ShiftCode { get; set; }

        public short? JobRoleCode { get; set; }

        public long? RequsitionCode { get; set; }

        [StringLength(50)]
        public string Religion { get; set; }

        [StringLength(50)]
        public string EthnicOrigin { get; set; }

        public long? JobDescriptionCode { get; set; }

        public string JobDescription { get; set; }

        [StringLength(255)]
        public string ContactPerson { get; set; }

        [StringLength(255)]
        public string Mobile { get; set; }

        [StringLength(255)]
        public string EmergencyMobile { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(255)]
        public string OfficialEmail { get; set; }

        public int CityTownCode { get; set; }

        public int? DistrictWardCode { get; set; }

        [StringLength(4000)]
        public string Address { get; set; }

        [StringLength(4000)]
        public string OldAddress { get; set; }

        [StringLength(255)]
        public string Specialty { get; set; }

        public short? LeavePolicyCode { get; set; }

        public int? ProbationPeriod { get; set; }

        public int? ContractPeriod { get; set; }

        public int? NoticePeriod { get; set; }

        public int? SalaryBreakUpPolicyCode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BasicPay { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Salary { get; set; }

        [StringLength(1020)]
        public string AccountTitle { get; set; }

        public int? BankBranchCode { get; set; }

        [StringLength(255)]
        public string AccountNumber { get; set; }

        public long? ReportingEmployeeCode { get; set; }

        public long? FunctionalEmployeeCode { get; set; }

        public long? HODEmployeeCode { get; set; }

        public bool? IsInsuranceEnabled { get; set; }

        public int? InsurancePlanCode { get; set; }

        public bool? IsMaternityPlan { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EOBI { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? HospitalDeduction { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MaternityDeduction { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MonthlyTax { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AnnaulTax { get; set; }

        public bool? IsPFEnabled { get; set; }

        public int? PFPercentage { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PFEffectiveDate { get; set; }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? PFAmount { get; set; }

        public bool IsVirtual { get; set; }

        public bool? IsForceAttendance { get; set; }

        public bool? IsManualAttendance { get; set; }

        public bool? IsOnProbation { get; set; }

        public bool? IsContractual { get; set; }

        public bool? IsDisabled { get; set; }

        public bool? IsSendEmailNotification { get; set; }

        public bool? IsRotative { get; set; }

        public int? EmpSeparationStatusCode { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DOE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DOS { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DOSStatus { get; set; }

        [StringLength(50)]
        public string SeparationStatus { get; set; }

        [StringLength(2040)]
        public string SeparationReason { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DOL { get; set; }

        public int CompanyCode { get; set; }

        public DateTime? dtmExported { get; set; }

        public DateTime? dtmImported { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

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

        public virtual BOSalaryBreakUpPolicy BOSalaryBreakUpPolicy { get; set; }

        public virtual BOSalaryTransferMode BOSalaryTransferMode { get; set; }

        public virtual BOBankBranch BOBankBranch { get; set; }

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

        public virtual BOEmployeeStatus BOEmployeeStatus { get; set; }

        public virtual BOHireType BOHireType { get; set; }

        public virtual BOJobRole BOJobRole { get; set; }

        public virtual BOLeavePolicy BOLeavePolicy { get; set; }

        public virtual BOPayGrade BOPayGrade { get; set; }

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
    }
}

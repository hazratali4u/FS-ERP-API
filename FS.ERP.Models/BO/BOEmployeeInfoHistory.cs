using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("HRM.tbl_EmployeeInfoHistory")]
    public partial class BOEmployeeInfoHistory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public Guid UniqueID { get; set; }

        [StringLength(25)]
        public string EmpExCode { get; set; }

        public int? CurrentLocationCode { get; set; }

        public byte HireTypeCode { get; set; }

        public byte EmpStatusCode { get; set; }

        public byte? SalaryTransferMode { get; set; }

        [StringLength(25)]
        public string EmpCode { get; set; }

        [StringLength(50)]
        public string EmpAlias { get; set; }

        [Required]
        [StringLength(255)]
        public string EmpName { get; set; }

        [StringLength(255)]
        public string EmpFatherName { get; set; }

        [StringLength(255)]
        public string HusbandName { get; set; }

        [StringLength(50)]
        public string NCNIC { get; set; }

        [StringLength(50)]
        public string NTN { get; set; }

        public byte[] EmpImage { get; set; }

        public long? BiometricCode { get; set; }

        public long? COACode { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dtJoinning { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dtConfirmation { get; set; }

        [StringLength(255)]
        public string EmpSource { get; set; }

        [StringLength(255)]
        public string EmpSourceValue { get; set; }

        [StringLength(50)]
        public string NatureOfVacancy { get; set; }

        public byte? tintSeparationTypeCode { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dtJoinning1 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dtConfirmation1 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dtEffective { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dtResignDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dtSeperationStatus { get; set; }

        [StringLength(50)]
        public string strSeparationStatus { get; set; }

        [StringLength(1020)]
        public string strResignReason { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dtLeftDate { get; set; }

        public double? fltProbationPeriod { get; set; }

        public double? fltServiceOrContractPeriod { get; set; }

        public int? intReportingLocationCode { get; set; }

        public int intDeptCode { get; set; }

        public int? intDivisionCode { get; set; }

        public int? intClassificationCode { get; set; }

        public int intDesigCode { get; set; }

        public int? intGradeCode { get; set; }

        public short? sintCurrencyCode { get; set; }

        public double? fltSalary { get; set; }

        public int? intLocationPoolCode { get; set; }

        public int intShiftCode { get; set; }

        public int? intAccessLevelCode { get; set; }

        public int? intReportToEmpCode { get; set; }

        public int? intReportToEmp1Code { get; set; }

        public int? intReportToEmp2Code { get; set; }

        public int? intRequsitionCode { get; set; }

        public bool? bolIsActive { get; set; }

        public long? lngJobDescriptionCode { get; set; }

        public string strJobDescriptionFormatted { get; set; }

        public string strJobDescription { get; set; }

        public bool? IsSeperated { get; set; }

        public int? PortalID { get; set; }

        public long? EmployeeLetterID { get; set; }

        public long? EmployeeRequisitionID { get; set; }

        public int? CompanyID { get; set; }

        public int? DivisionID { get; set; }

        public int? BranchID { get; set; }

        public int? PayrollDivisionID { get; set; }

        public int? DepartmentID { get; set; }

        public int? DesignationID { get; set; }

        [StringLength(255)]
        public string Code { get; set; }

        public int? HireTypeID { get; set; }

        [StringLength(255)]
        public string Salutation { get; set; }

        [StringLength(255)]
        public string FirstName { get; set; }

        [StringLength(255)]
        public string MiddleName { get; set; }

        [StringLength(255)]
        public string LastName { get; set; }

        [StringLength(255)]
        public string FatherName { get; set; }

        public int? RelationID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DOB { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DOJ { get; set; }

        [StringLength(255)]
        public string CNIC { get; set; }

        [StringLength(255)]
        public string BloodGroup { get; set; }

        [StringLength(255)]
        public string Marital { get; set; }

        [StringLength(255)]
        public string ImageFileName { get; set; }

        [StringLength(255)]
        public string Religion { get; set; }

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

        [StringLength(4000)]
        public string Address { get; set; }

        [StringLength(4000)]
        public string OldAddress { get; set; }

        public int? AreaID { get; set; }

        public int? CityID { get; set; }

        public int? CountryID { get; set; }

        [StringLength(255)]
        public string VacancyNature { get; set; }

        [StringLength(255)]
        public string Specialty { get; set; }

        public bool? Gender { get; set; }

        public int? ShiftID { get; set; }

        public int? LeavePolicyID { get; set; }

        public int? BreakupPolicyID { get; set; }

        public int? ProbationPeriod { get; set; }

        public int? ContractPeriod { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PermanentDate { get; set; }

        public int? NoticePeriod { get; set; }

        public decimal? BasicPay { get; set; }

        public decimal? Salary { get; set; }

        [StringLength(4000)]
        public string AccountTitle { get; set; }

        [StringLength(255)]
        public string AccountNumber { get; set; }

        public long? ReportingEmployeeID { get; set; }

        public long? FunctionalEmployeeID { get; set; }

        public long? HODEmployeeID { get; set; }

        public long? ReportingLocationID { get; set; }

        public int? JobDescID { get; set; }

        public bool? IsInsuranceEnabled { get; set; }

        public int? InsurancePlanID { get; set; }

        public bool? IsMaternityPlan { get; set; }

        public decimal? EOBI { get; set; }

        public decimal? HospitalDeduction { get; set; }

        public decimal? MaternityDeduction { get; set; }

        public decimal? MonthlyTax { get; set; }

        public decimal? AnnaulTax { get; set; }

        public bool? IsPFEnabled { get; set; }

        public int? PFPercentage { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PFEffectiveDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? PFAmount { get; set; }

        public bool? IsForceAttendance { get; set; }

        public bool? IsManualAttendance { get; set; }

        public bool? IsOnProbation { get; set; }

        public bool? IsContractual { get; set; }

        public bool? IsDisabled { get; set; }

        public bool? IsSendEmailNotification { get; set; }

        public int? EmployeeStatusID { get; set; }

        [StringLength(255)]
        public string ReferenceName1 { get; set; }

        [StringLength(4000)]
        public string ReferenceAddress1 { get; set; }

        [StringLength(255)]
        public string ReferenceMobile1 { get; set; }

        [StringLength(255)]
        public string ReferenceName2 { get; set; }

        [StringLength(4000)]
        public string ReferenceAddress2 { get; set; }

        [StringLength(255)]
        public string ReferenceMobile2 { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsDeleted { get; set; }

        public long? CreatedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedOn { get; set; }

        public long? LastModifiedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LastModifiedOn { get; set; }

        public Guid? EmployeeGUID { get; set; }

        [StringLength(255)]
        public string ReferenceRelation1 { get; set; }

        [StringLength(255)]
        public string ReferenceRelation2 { get; set; }

        public int? SalaryTransferModeID { get; set; }

        public int? BankBranchID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LastImageUploadOn { get; set; }

        [StringLength(255)]
        public string OfficialMobile { get; set; }

        public bool? IsRotative { get; set; }

        public decimal? TempCurrentMonthAddition { get; set; }

        public int CompanyCode { get; set; }

        public DateTime? dtmExported { get; set; }

        public DateTime? dtmImported { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        public byte RecordStatusCode { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }
    }
}

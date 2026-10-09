using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("HRM.tbl_EmployeeInfoRevision")]
    public partial class BOEmployeeInfoRevision
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOEmployeeInfoRevision()
        {
            BOEmployeeIncrement = new HashSet<BOEmployeeIncrement>();
            BOEmployeeInfoRevision1 = new HashSet<BOEmployeeInfoRevision>();
            BOEmployeeInfoRevision11 = new HashSet<BOEmployeeInfoRevision>();
            BOEmployeeInfoRevision12 = new HashSet<BOEmployeeInfoRevision>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public Guid UniqueID { get; set; }

        public long EmpOldCode { get; set; }

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

        public bool? IsActive { get; set; }

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

        public virtual BOSalaryTransferMode BOSalaryTransferMode { get; set; }

        public virtual BOBankBranch BOBankBranch { get; set; }

        public virtual BOCOA BOCOA { get; set; }

        public virtual BOCityTown BOCityTown { get; set; }

        public virtual BODistrictWard BODistrictWard { get; set; }

        public virtual BODepartment BODepartment { get; set; }

        public virtual BODesignation BODesignation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeIncrement> BOEmployeeIncrement { get; set; }

        public virtual BOEmployeeInfo BOEmployeeInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeInfoRevision> BOEmployeeInfoRevision1 { get; set; }

        public virtual BOEmployeeInfoRevision BOEmployeeInfoRevision2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeInfoRevision> BOEmployeeInfoRevision11 { get; set; }

        public virtual BOEmployeeInfoRevision BOEmployeeInfoRevision3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeInfoRevision> BOEmployeeInfoRevision12 { get; set; }

        public virtual BOEmployeeInfoRevision BOEmployeeInfoRevision4 { get; set; }

        public virtual BOEmployeeStatus BOEmployeeStatus { get; set; }

        public virtual BOHireType BOHireType { get; set; }

        public virtual BOJobRole BOJobRole { get; set; }

        public virtual BOLeavePolicy BOLeavePolicy { get; set; }

        public virtual BOPayGrade BOPayGrade { get; set; }

        public virtual BOShift BOShift { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }
    }
}

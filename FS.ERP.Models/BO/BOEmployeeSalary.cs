using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("HRM.tbl_EmployeeSalary")]
    public partial class BOEmployeeSalary
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOEmployeeSalary()
        {
            BOEmployeeSalaryLoanLease = new HashSet<BOEmployeeSalaryLoanLease>();
            BOEmployeeSalaryDeduction = new HashSet<BOEmployeeSalaryDeduction>();
            BOEmployeeSalaryAddition = new HashSet<BOEmployeeSalaryAddition>();
            BOEmployeeSalaryAllowanceOrBenefit = new HashSet<BOEmployeeSalaryAllowanceOrBenefit>();
            BOEmployeeSalaryReimbursement = new HashSet<BOEmployeeSalaryReimbursement>();
            BOEmployeeIncomeTax = new HashSet<BOEmployeeIncomeTax>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        public Guid UniqueID { get; set; }

        public long? BaseCode { get; set; }

        [StringLength(50)]
        public string TransactionCode { get; set; }

        [StringLength(50)]
        public string RefNo { get; set; }

        public long EmpCode { get; set; }

        public int EmpCompanyCode { get; set; }

        public int PayrollCostOrProfitCenterCode { get; set; }

        public int CostOrProfitCenterCode { get; set; }

        public int? CurrentLocationCode { get; set; }

        public byte HireTypeCode { get; set; }

        public byte EmpStatusCode { get; set; }

        public byte SalaryTransferMode { get; set; }

        public long? COACode { get; set; }

        public short? PayGradeCode { get; set; }

        public short CurrencyCode { get; set; }

        public short ShiftCode { get; set; }

        public short? LeavePolicyCode { get; set; }
        public decimal? LeaveEncashmentDays { get; set; }
        public decimal? LeaveEncashmentAmount { get; set; }

        public short? FiscalYearCode { get; set; }

        public DateTime? SalaryDate { get; set; }

        public byte? MonthNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SalaryStartFrom { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SalaryStartTo { get; set; }

        public short? NoOfDays { get; set; }

        public short? WorkedOfDays { get; set; }

        public short? AllowanceDays { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BasicPay { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Salary { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OverTime { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Arears { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Bonus { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Incentive { get; set; }

        [StringLength(1020)]
        public string AccountTitle { get; set; }

        public int? BankBranchCode { get; set; }

        [StringLength(255)]
        public string AccountNumber { get; set; }

        public bool? IsInsuranceEnabled { get; set; }

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

        public decimal? PFPercentage { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PFAmount { get; set; }

        public bool? IsFinalized { get; set; }

        public bool? IsSendOrGiven { get; set; }

        [StringLength(2040)]
        public string Remarks { get; set; }

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

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany1 { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany2 { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany3 { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOSalaryTransferMode BOSalaryTransferMode { get; set; }

        public virtual BOBankBranch BOBankBranch { get; set; }

        public virtual BOCOA BOCOA { get; set; }

        public virtual BOFiscalYear BOFiscalYear { get; set; }

        public virtual BOEmployeeInfo BOEmployeeInfo { get; set; }

        public virtual BOEmployeeStatus BOEmployeeStatus { get; set; }

        public virtual BOHireType BOHireType { get; set; }

        public virtual BOLeavePolicy BOLeavePolicy { get; set; }

        public virtual BOPayGrade BOPayGrade { get; set; }

        public virtual BOShift BOShift { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeSalaryAddition> BOEmployeeSalaryAddition { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeSalaryDeduction> BOEmployeeSalaryDeduction { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeSalaryAllowanceOrBenefit> BOEmployeeSalaryAllowanceOrBenefit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeSalaryReimbursement> BOEmployeeSalaryReimbursement { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeSalaryLoanLease> BOEmployeeSalaryLoanLease { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeIncomeTax> BOEmployeeIncomeTax { get; set; }

    }
}

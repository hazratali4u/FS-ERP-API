using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("HRM.tbl_EmployeeIncrement")]
    public partial class BOEmployeeIncrement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOEmployeeIncrement()
        {
            BOEmployeeIncrementAllowanceOrBenefit = new HashSet<BOEmployeeIncrementAllowanceOrBenefit>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public Guid UniqueID { get; set; }

        public long? BaseCode { get; set; }

        [StringLength(50)]
        public string TransactionCode { get; set; }

        [StringLength(50)]
        public string RefNo { get; set; }

        public long EmpCode { get; set; }

        public long EmpRevisionCode { get; set; }

        public int EmpCompanyCode { get; set; }

        public int PayrollCostOrProfitCenterCode { get; set; }

        public int CostOrProfitCenterCode { get; set; }

        public int? LocationCode { get; set; }

        public byte HireTypeCode { get; set; }

        public byte EmpStatusCode { get; set; }

        public short? PayGradeCode { get; set; }

        public short CurrencyCode { get; set; }

        public short? FiscalYearCode { get; set; }

        public DateTime? TransactionDate { get; set; }

        public DateTime? EffectedDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BasicPay { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Salary { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IncrementPercentage { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IncrementAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Bonus { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Incentive { get; set; }

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

        public int? PFPercentage { get; set; }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? PFAmount { get; set; }

        public bool? IsApproved { get; set; }

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

        public virtual BOFiscalYear BOFiscalYear { get; set; }

        public virtual BOEmployeeInfo BOEmployeeInfo { get; set; }

        public virtual BOEmployeeInfoRevision BOEmployeeInfoRevision { get; set; }

        public virtual BOEmployeeStatus BOEmployeeStatus { get; set; }

        public virtual BOHireType BOHireType { get; set; }

        public virtual BOPayGrade BOPayGrade { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeIncrementAllowanceOrBenefit> BOEmployeeIncrementAllowanceOrBenefit { get; set; }
    }
}

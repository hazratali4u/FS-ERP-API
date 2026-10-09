using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("HRM.tbl_EmployeeLoan")]
    public partial class BOEmployeeLoan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOEmployeeLoan()
        {
            BOEmployeeLoanInstallment = new HashSet<BOEmployeeLoanInstallment>();
            BOReimbursement = new HashSet<BOReimbursement>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public Guid UniqueID { get; set; }

        public long EmpCode { get; set; }

        public short FiscalYearCode { get; set; }

        public byte LoanTypeCode { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AppliedOn { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ApplyAmount { get; set; }

        public bool? IsApproved { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ApprovedOn { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ApprovedAmount { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DeductionStartFrom { get; set; }

        public short? NoOfInstallment { get; set; }

        public bool? IsPayOff { get; set; }

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

        public virtual BOLoanType BOLoanType { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOFiscalYear BOFiscalYear { get; set; }

        public virtual BOEmployeeInfo BOEmployeeInfo { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeLoanInstallment> BOEmployeeLoanInstallment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOReimbursement> BOReimbursement { get; set; }
    }
}

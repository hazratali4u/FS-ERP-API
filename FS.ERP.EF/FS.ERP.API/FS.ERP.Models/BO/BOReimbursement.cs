using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("HRM.tbl_Reimbursement")]
    public partial class BOReimbursement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOReimbursement()
        {
            BOEmployeeSalaryReimbursement = new HashSet<BOEmployeeSalaryReimbursement>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public Guid UniqueID { get; set; }

        public long BaseCode { get; set; }

        public short? FiscalYearCode { get; set; }

        public long? EmpCode { get; set; }

        public byte ReimbursementTypeCode { get; set; }

        public long? EmployeeLoanCode { get; set; }

        public long? EmployeeLeaseCode { get; set; }

        public long? FundDemandRegisterCode { get; set; }

        public short? InstallmentNo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ActualAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TransactionAmount { get; set; }

        public bool? IsDeductFromSalary { get; set; }

        public bool? IsDisburseInSalary { get; set; }

        public byte[] SupportingDocument { get; set; }

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

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOReimbursementType BOReimbursementType { get; set; }

        public virtual BOEmployeeInfo BOEmployeeInfo { get; set; }

        public virtual BOEmployeeLease BOEmployeeLease { get; set; }

        public virtual BOEmployeeLoan BOEmployeeLoan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeSalaryReimbursement> BOEmployeeSalaryReimbursement { get; set; }

        public virtual BOFundDemandRequest BOFundDemandRequest { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }
    }
}

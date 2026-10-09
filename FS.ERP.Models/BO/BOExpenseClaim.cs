using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{
    [Table("AppCNF.tbl_ExpenseClaim")]
    public partial class BOExpenseClaim
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOExpenseClaim()
        {
            this.BOExpenseClaimDetails = new HashSet<BOExpenseClaimDetails>();
            //this.BOExpensePayment = new HashSet<BOExpensePayment>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public string FolioNumber { get; set; }
        public Int16? FiscalYearCode { get; set; }
        public int? TravelRequestCode { get; set; }
        public string ExpenseClaimType { get; set; }
        public Nullable<int> ReferenceCode { get; set; }
        public long EmpCode { get; set; }
        public Nullable<short> PaymentReference { get; set; }
        public System.DateTime ClaimDate { get; set; }
        public Nullable<bool> IsRequestedInAdvance { get; set; }
        public Nullable<bool> IsApproved { get; set; }
        public Nullable<bool> IsPaid { get; set; }
        public Nullable<bool> IsAdjusted { get; set; }
        public Nullable<long> ApprovedBy { get; set; }
        public bool? IsApprovedByAudit { get; set; }
        public long? ApprovedByAudit { get; set; }
        public DateTime? ApprovedByAuditOn { get; set; }
        public bool? IsVoid { get; set; }
        public Nullable<int> CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }

        public virtual BOEmployeeInfo BOEmployeeInfo { get; set; }
        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }
        public virtual BORecordStatus BORecordStatus { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOExpenseClaimDetails> BOExpenseClaimDetails { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<BOExpensePayment> BOExpensePayment { get; set; }
    }
}

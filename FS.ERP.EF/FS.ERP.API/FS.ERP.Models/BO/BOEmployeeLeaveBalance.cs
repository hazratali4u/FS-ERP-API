using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("HRM.tbl_EmployeeLeaveBalance")]
    public partial class BOEmployeeLeaveBalance
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public Guid UniqueID { get; set; }

        public long EmpCode { get; set; }

        public short FiscalYearCode { get; set; }

        public byte? LeaveTypeCode { get; set; }

        public short? LeavePolicyCode { get; set; }

        public DateTime? CreatedOn { get; set; }

        public byte? NoOfMonths { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AvailableQty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalQty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AvailedQty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PendingQty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LateDeductionQty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EncashableNoOfLeaves { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CompansationNoOfLeaves { get; set; }

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

        public virtual BOFiscalYear BOFiscalYear { get; set; }

        public virtual BOEmployeeInfo BOEmployeeInfo { get; set; }

        public virtual BOLeavePolicy BOLeavePolicy { get; set; }

        public virtual BOLeaveType BOLeaveType { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }
    }
}

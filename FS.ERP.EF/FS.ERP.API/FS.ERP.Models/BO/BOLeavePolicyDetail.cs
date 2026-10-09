using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("HRM.tbl_LeavePolicyDetail")]
    public partial class BOLeavePolicyDetail
    {
        public int ID { get; set; }

        public short LeavePolicyCode { get; set; }

        public byte LeaveTypeCode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Quantity { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ServiceInYear { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Minimum { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Maximum { get; set; }

        public bool? IsContractual { get; set; }

        public bool? IsSandwich { get; set; }

        public bool? IsLaps { get; set; }

        public bool? IsEncashable { get; set; }

        public bool? IsAfterProbabation { get; set; }

        public bool? IsUnPaid { get; set; }

        public bool? IsPermanent { get; set; }

        public bool? IsDeleted { get; set; }

        [StringLength(1020)]
        public string Description { get; set; }

        public int? CompanyCode { get; set; }

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

        public virtual BOLeavePolicy BOLeavePolicy { get; set; }

        public virtual BOLeaveType BOLeaveType { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }
    }
}

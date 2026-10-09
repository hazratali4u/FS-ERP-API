using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("HRM.tbl_EmployeeLeaseInstallment")]
    public partial class BOEmployeeLeaseInstallment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        public Guid UniqueID { get; set; }

        public long EmployeeLeaseCode { get; set; }

        public short? InstallmentNo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? InstallmentDueOn { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OpeningBalance { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PrincipalRePayment { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MarkupAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? InstallmentAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ClosingBalance { get; set; }

        public bool? IsReceived { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReceivedOn { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ReceivedAmount { get; set; }

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

        public virtual BOEmployeeLease BOEmployeeLease { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }
    }
}

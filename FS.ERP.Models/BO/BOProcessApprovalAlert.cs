using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("Notification.tbl_ProcessApprovalAlert")]
    public partial class BOProcessApprovalAlert
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public Guid UniqueID { get; set; }
        public long? SequenceNo { get; set; }

        public int TransactionDocumentProcessCode { get; set; }

        [Required]
        [StringLength(50)]
        public string RefCode { get; set; }

        public DateTime AlertDate { get; set; }

        [Required]
        [StringLength(510)]
        public string AlertSubject { get; set; }

        [Required]
        public string AlertContent { get; set; }

        [Required]
        public string AlertRichContent { get; set; }

        public bool? IsPending { get; set; }

        public bool? IsOnHold { get; set; }

        public bool? IsApproved { get; set; }

        public DateTime? AlertActionDate { get; set; }

        public long? ActionByEmpCode { get; set; }
        public long? RequestedByEmpCode { get; set; }

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

        public bool? IsResponse { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOTransactionDocumentProcess BOTransactionDocumentProcess { get; set; }

        public virtual BOEmployeeInfo BOEmployeeInfo { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("HRM.tbl_EmployeeEmployment")]
    public partial class BOEmployeeEmployment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public Guid UniqueID { get; set; }

        public long EmpCode { get; set; }

        [Required]
        [StringLength(255)]
        public string OrganizationName { get; set; }

        [StringLength(1020)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string URL { get; set; }

        [Required]
        [StringLength(255)]
        public string PositionOrTitle { get; set; }

        [Column(TypeName = "numeric")]
        public decimal BasicPay { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartFrom { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EndTo { get; set; }

        public byte[] DocCode { get; set; }

        [StringLength(1020)]
        public string EntitledBenifits { get; set; }

        [StringLength(2040)]
        public string ReasonforLeaving { get; set; }

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

        public virtual BOEmployeeInfo BOEmployeeInfo { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }
    }
}

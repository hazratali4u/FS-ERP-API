using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("MenuCNF.tbl_ProfileGroupDetail")]
    public partial class BOProfileGroupDetail
    {
        public long ID { get; set; }

        public int ProfileGroupCode { get; set; }

        public int MenuCode { get; set; }

        [Required]
        [StringLength(21)]
        public string SecurityRightCode { get; set; }

        public int CompanyCode { get; set; }

        public DateTime? dtmUpLoaded { get; set; }

        public DateTime? dtmDownLoaded { get; set; }

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

        public virtual BOMenu BOMenu { get; set; }

        public virtual BOProfileGroup BOProfileGroup { get; set; }

        public virtual BOSecurityRight BOSecurityRight { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }
    }
}

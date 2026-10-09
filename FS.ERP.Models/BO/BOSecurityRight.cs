using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("MenuCNF.tbl_SecurityRight")]
    public partial class BOSecurityRight
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOSecurityRight()
        {
            BOProfileGroupDetail = new HashSet<BOProfileGroupDetail>();
        }

        [Key]
        [StringLength(21)]
        public string RightSummary { get; set; }

        [StringLength(255)]
        public string RightCaption { get; set; }

        public bool? CanNew { get; set; }

        public bool? CanFind { get; set; }

        public bool? CanEdit { get; set; }

        public bool? CanDelete { get; set; }

        public bool? CanVoid { get; set; }

        public bool? CanPrint { get; set; }

        public bool? CanPreview { get; set; }

        public bool? CanExport { get; set; }

        public bool? CanEmail { get; set; }

        public bool? CanCall { get; set; }

        public bool? CanFax { get; set; }

        public bool? CanSMS { get; set; }

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

        public virtual BORecordStatus BORecordStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOProfileGroupDetail> BOProfileGroupDetail { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }
    }
}

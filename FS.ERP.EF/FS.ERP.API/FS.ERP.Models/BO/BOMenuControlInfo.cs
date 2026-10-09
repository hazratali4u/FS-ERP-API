using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("MenuCNF.tbl_MenuControlInfo")]
    public partial class BOMenuControlInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOMenuControlInfo()
        {
            BOModuleColInfo = new HashSet<BOModuleColInfo>();
        }

        public long ID { get; set; }

        public int MenuCode { get; set; }

        public int? MenuParamInfoCode { get; set; }

        [StringLength(255)]
        public string ControlCategory { get; set; }

        [StringLength(2040)]
        public string ControlType { get; set; }

        [StringLength(255)]
        public string ControlLinkName { get; set; }

        [StringLength(255)]
        public string ReferenceLinkName { get; set; }

        [StringLength(255)]
        public string ContainerID { get; set; }

        [StringLength(255)]
        public string ControlName { get; set; }

        [StringLength(1020)]
        public string ControlCaptionInEng { get; set; }

        [StringLength(1020)]
        public string ControlCaptionInUrdu { get; set; }

        [StringLength(1020)]
        public string ControlCaptionInArabic { get; set; }

        public short? DataTypeCode { get; set; }

        public short? TabOrSortOrder { get; set; }

        public bool? IsLeftToRight { get; set; }

        public bool? IsVertical { get; set; }

        public bool? IsFixed { get; set; }

        public bool? IsMandatory { get; set; }

        public bool? IsHidden { get; set; }

        public bool? IsRowCountRequire { get; set; }

        [StringLength(2040)]
        public string ControlErrorMsgInEng { get; set; }

        [StringLength(2040)]
        public string ControlErrorMsgInUrdu { get; set; }

        [StringLength(2040)]
        public string ControlErrorMsgInArabic { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? dtmExported { get; set; }

        public DateTime? dtmImported { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        public byte RecordStatusCode { get; set; }

        public virtual BODataType BODataType { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOMenu BOMenu { get; set; }

        public virtual BOModuleParamInfo BOModuleParamInfo { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOModuleColInfo> BOModuleColInfo { get; set; }
    }
}

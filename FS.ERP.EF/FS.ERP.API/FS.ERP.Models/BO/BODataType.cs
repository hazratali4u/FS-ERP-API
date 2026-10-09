using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("AppCNF.tbl_DataType")]
    public partial class BODataType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BODataType()
        {
            BOAppConfiguration = new HashSet<BOAppConfiguration>();
            BOAppConfigurationDetail = new HashSet<BOAppConfigurationDetail>();
            BOMenuControlInfo = new HashSet<BOMenuControlInfo>();
            BOModuleColInfo = new HashSet<BOModuleColInfo>();
        }

        public short ID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(25)]
        public string MySQL { get; set; }

        [StringLength(25)]
        public string MsSQL { get; set; }

        [StringLength(25)]
        public string Oracle { get; set; }

        [StringLength(25)]
        public string Php { get; set; }

        [StringLength(25)]
        public string Vb { get; set; }

        [StringLength(25)]
        public string CSharp { get; set; }

        [StringLength(25)]
        public string Java { get; set; }

        [StringLength(25)]
        public string CrystalReport { get; set; }

        [StringLength(25)]
        public string SSRS { get; set; }

        [StringLength(25)]
        public string Penthao { get; set; }

        [StringLength(25)]
        public string IBirt { get; set; }

        [StringLength(25)]
        public string Jasper { get; set; }

        public DateTime? dtmExported { get; set; }

        public DateTime? dtmImported { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        public byte RecordStatusCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOAppConfiguration> BOAppConfiguration { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOAppConfigurationDetail> BOAppConfigurationDetail { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOMenuControlInfo> BOMenuControlInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOModuleColInfo> BOModuleColInfo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("FICO.tbl_COAConfiguration")]
    public partial class BOCOAConfiguration
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOCOAConfiguration()
        {
            BOCOA = new HashSet<BOCOA>();
            BOCOAConfiguration1 = new HashSet<BOCOAConfiguration>();
            BOCOAMapping = new HashSet<BOCOAMapping>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte ID { get; set; }

        public byte? ParentCode { get; set; }

        public bool IsTransactional { get; set; }

        public short NoOfCOALevel { get; set; }

        public short LenghtOfCOA { get; set; }

        [StringLength(3)]
        public string DelimiterOrSplitter { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOCOA> BOCOA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOCOAConfiguration> BOCOAConfiguration1 { get; set; }

        public virtual BOCOAConfiguration BOCOAConfiguration2 { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOCOAMapping> BOCOAMapping { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("Geography.tbl_CountryRegion")]
    public partial class BOCountryRegion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOCountryRegion()
        {
            BOCityTown = new HashSet<BOCityTown>();
            BOStateProvince = new HashSet<BOStateProvince>();
        }

        public int ID { get; set; }

        public int SectorZoneCode { get; set; }

        [StringLength(25)]
        public string ShortName { get; set; }

        [Required]
        [StringLength(255)]
        public string FullName { get; set; }

        [Required]
        [StringLength(510)]
        public string DisplayName { get; set; }

        [StringLength(1020)]
        public string Description { get; set; }

        [Column(TypeName = "image")]
        public byte[] FlagImage { get; set; }

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
        public virtual ICollection<BOCityTown> BOCityTown { get; set; }

        public virtual BOSectorZone BOSectorZone { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOStateProvince> BOStateProvince { get; set; }
    }
}

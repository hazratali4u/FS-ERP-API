using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{
    [Table("HRM.tbl_TravellingMedium")]
    public class BOTravellingMedium
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOTravellingMedium()
        {
            this.BOTravelRequestDetails = new HashSet<BOTravelRequestDetails>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte ID { get; set; }
        public string TravellingMedium { get; set; }
        public byte SortOrder { get; set; }
        public Nullable<int> CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }
        public virtual BORecordStatus BORecordStatus { get; set; }
        public virtual BOUser BOUser { get; set; }
        public virtual BOUser BOUser1 { get; set; }
        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOTravelRequestDetails> BOTravelRequestDetails { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;
using System.Collections.Generic;

namespace FS.ERP.Models.BO
{
    [Table("HRM.tbl_IncidentType")]

    public partial class BOIncidentType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOIncidentType()
        {
            this.BOEmployeeIncident = new HashSet<BOEmployeeIncident>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long ID { get; set; }
        public string IncidentType { get; set; }
        public string Description { get; set; }
        public int CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeIncident> BOEmployeeIncident { get; set; }
        public virtual BOUser BOUser { get; set; }
        public virtual BOUser BOUser1 { get; set; }
        public virtual BOUser BOUser2 { get; set; }
    }
}

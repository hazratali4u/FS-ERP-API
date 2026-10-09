using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{
    [Table("HRM.tbl_SeparationTypeOrReason")]
    public partial class BOSeparationTypeOrReason
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOSeparationTypeOrReason()
        {
            this.BOSeparationSubmission = new HashSet<BOSeparationSubmission>();
            this.BOSeparationSubmission1 = new HashSet<BOSeparationSubmission>();
            this.BOSeparationTypeOrReason1 = new HashSet<BOSeparationTypeOrReason>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key]
        public int ID { get; set; }
        public bool IsExitType { get; set; }
        public Nullable<int> ExitTypeCode { get; set; }
        public string ExitTypeOrReason { get; set; }
        public int CompanyCode { get; set; }
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
        public virtual BOSeparationTypeOrReason BOSeparationTypeOrReason2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOSeparationSubmission> BOSeparationSubmission { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOSeparationSubmission> BOSeparationSubmission1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOSeparationTypeOrReason> BOSeparationTypeOrReason1 { get; set; }
        
    }
}

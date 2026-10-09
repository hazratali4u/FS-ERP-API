using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{
    [Table("HRM.tbl_IncrementOrDecrementType")]
    public partial class BOIncrementOrDecrementType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOIncrementOrDecrementType()
        {
            this.BOEmployeeIncrement = new HashSet<BOEmployeeIncrement>();
            this.BOIncrementOrDecrementRules = new HashSet<BOIncrementOrDecrementRules>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public long ID { get; set; }
        public string TypeName { get; set; }
        public Nullable<bool> IsDecrement { get; set; }
        public Nullable<bool> IsActive { get; set; }
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
        public virtual ICollection<BOEmployeeIncrement> BOEmployeeIncrement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOIncrementOrDecrementRules> BOIncrementOrDecrementRules { get; set; }
        
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;
using System.Collections.Generic;

namespace FS.ERP.Models.BO
{
    [Table("AppCNF.tbl_POSTableType")]
    public partial class BOPOSTableType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOPOSTableType()
        {
            this.BOTable = new HashSet<BOTable>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte ID { get; set; }
        public string Category { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public string DisplayName { get; set; }
        public Nullable<short> MinCapacity { get; set; }
        public Nullable<short> MaxCapacity { get; set; }
        public byte SortOrder { get; set; }
        public string Description { get; set; }
        public Nullable<int> CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOTable> BOTable { get; set; }
    }
}

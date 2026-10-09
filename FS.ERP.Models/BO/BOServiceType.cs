using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.Models.BO
{
    [Table("AppCNF.tbl_ServiceType")]
    public class BOServiceType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOServiceType()
        {
            BOVendorOrSupplierServiceType = new HashSet<BOVendorOrSupplierServiceType>();
            BOPartyOrCustomerServiceType = new HashSet<BOPartyOrCustomerServiceType>();
            BOItemOrProfileServiceType = new HashSet<BOItemOrProfileServiceType>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short ID { get; set; }
        public Nullable<short> ServiceCode { get; set; }
        public string LevelCode { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public string DisplayName { get; set; }
        public short SortOrder { get; set; }
        public string Description { get; set; }
        public bool IsCompanyBase { get; set; }
        public bool IsCustomerBase { get; set; }
        public bool IsVendorOrSupplierBase { get; set; }
        public bool IsActive { get; set; }
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
        public virtual ICollection<BOServiceType> BOServiceType1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOVendorOrSupplierServiceType> BOVendorOrSupplierServiceType { get; set; }
        public virtual BOServiceType BOServiceType2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPartyOrCustomerServiceType> BOPartyOrCustomerServiceType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOItemOrProfileServiceType> BOItemOrProfileServiceType { get; set; }

    }
}

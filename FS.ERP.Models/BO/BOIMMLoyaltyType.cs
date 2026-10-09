using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.Models.BO
{
    [Table("AppCNF.tbl_IMMLoyaltyType")]
    public class BOIMMLoyaltyType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOIMMLoyaltyType()
        {
            BOLoyaltyPcOrCc = new HashSet<BOLoyaltyPcOrCc>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte ID { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public string DisplayName { get; set; }
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
        public Nullable<short> MaxVisit { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> PointGain { get; set; }
        public Nullable<decimal> Purchasing { get; set; }
        public Nullable<decimal> AmountLimit { get; set; }
        public Nullable<bool> IsLocationBase { get; set; }
        public Nullable<bool> IsPcOCcBase { get; set; }
        public bool IsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOLoyaltyPcOrCc> BOLoyaltyPcOrCc { get; set; }
    }
}

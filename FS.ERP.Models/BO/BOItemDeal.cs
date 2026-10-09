using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.Models.BO
{
    [Table("IMM.tbl_ItemDeal")]
    public class BOItemDeal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOItemDeal()
        {
            this.BOItemDealAssignment = new HashSet<BOItemDealAssignment>();
            this.BOItemDealDetail = new HashSet<BOItemDealDetail>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public System.Guid UniqueID { get; set; }
        public long BaseCode { get; set; }
        public string DealCode { get; set; }
        public string DealName { get; set; }
        public string DealCategory { get; set; }
        public long ItemCode { get; set; }
        public decimal DefaultQty { get; set; }
        public short ItemUOMCode { get; set; }
        public Nullable<System.DateTime> DealStart { get; set; }
        public Nullable<System.DateTime> DealEnd { get; set; }
        public bool IsTimeBased { get; set; }
        public bool IsChoiceBased { get; set; }
        public bool IsActive { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }

        public virtual BOUOM BOUOM { get; set; }
        public virtual BOItem BOItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOItemDealAssignment> BOItemDealAssignment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOItemDealDetail> BOItemDealDetail { get; set; }
    }
}

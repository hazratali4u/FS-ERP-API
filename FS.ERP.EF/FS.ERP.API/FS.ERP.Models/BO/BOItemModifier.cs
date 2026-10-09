using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.Models.BO
{
    [Table("IMM.tbl_ItemModifier")]
    public class BOItemModifier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOItemModifier()
        {
            this.BOItemDealDetail = new HashSet<BOItemDealDetail>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }
        public long ItemCode { get; set; }
        public long ItemProfileCode { get; set; }
        public long ItemModifierCode { get; set; }
        public long ItemModifierProfileCode { get; set; }
        public decimal DefaultQty { get; set; }
        public short ItemUOMCode { get; set; }
        public short ItemProfileUOMCode { get; set; }
        public bool IsManadatory { get; set; }
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
        public virtual BOUOM BOUOM { get; set; }
        public virtual BOUOM BOUOM1 { get; set; }
        public virtual BOItem BOItem { get; set; }
        public virtual BOItem BOItem1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOItemDealDetail> BOItemDealDetail { get; set; }
        public virtual BOItemProfile BOItemProfile { get; set; }
        public virtual BOItemProfile BOItemProfile1 { get; set; }
    }
}

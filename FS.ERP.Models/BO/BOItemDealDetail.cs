using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.Models.BO
{
    [Table("IMM.tbl_ItemDealDetail")]
    public class BOItemDealDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public System.Guid UniqueID { get; set; }
        public long BaseCode { get; set; }
        public long ItemDealCode { get; set; }
        public long ItemProfileCode { get; set; }
        public long ItemModifierCode { get; set; }
        public decimal DefaultQty { get; set; }
        public short ItemProfileUOMCode { get; set; }
        public short ItemModifierUOMCode { get; set; }
        public bool IsOptional { get; set; }
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
        public virtual BOUOM BOUOM1 { get; set; }
        public virtual BOItemDeal BOItemDeal { get; set; }
        public virtual BOItemModifier BOItemModifier { get; set; }
        public virtual BOItemProfile BOItemProfile { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.Models.BO
{
    [Table("PPS.tbl_ReceipeDetail")]
    public class BOReceipeDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOReceipeDetail()
        {
            BOProductionDetail = new HashSet<BOProductionDetail>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public System.Guid UniqueID { get; set; }
        public long BaseCode { get; set; }
        public long ReceipeMasterCode { get; set; }
        public Nullable<long> ItemProfileCode { get; set; }
        public short TransactionLineNo { get; set; }
        public decimal ReceipeQty { get; set; }
        public Nullable<short> ReceipeUOMCode { get; set; }
        public decimal StockQty { get; set; }
        public Nullable<short> StockUOMCode { get; set; }
        public Nullable<bool> IsActive { get; set; }
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

        public virtual BOUOM BOUOM { get; set; }
        public virtual BOUOM BOUOM1 { get; set; }
        public virtual BOItemProfile BOItemProfile { get; set; }        
        public virtual BOReceipeMaster BOReceipeMaster { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOProductionDetail> BOProductionDetail { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.Models.BO
{
    [Table("PPS.tbl_ProductionDetail")]
    public class BOProductionDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOProductionDetail()
        {
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public System.Guid UniqueID { get; set; }
        public long BaseCode { get; set; }
        public long ProductionMasterCode { get; set; }
        public long ReceipeMasterDetailCode { get; set; }
        public Nullable<long> ItemProfileCode { get; set; }
        public short TransactionLineNo { get; set; }
        public decimal ReceipeQty { get; set; }
        public Nullable<short> ReceipeUOMCode { get; set; }
        public decimal StockQty { get; set; }
        public Nullable<short> StockUOMCode { get; set; }
        public string BatchNo { get; set; }
        public string SerialNo { get; set; }
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
        public virtual BOProductionMaster BOProductionMaster { get; set; }
        public virtual BOReceipeDetail BOReceipeDetail { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{
    [Table("IMM.tbl_StockTakingAdjustment")]

    public partial class BOStockTakingAdjustment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOStockTakingAdjustment()
        {
            this.BOStockTakingAdjustment1 = new HashSet<BOStockTakingAdjustment>();
            this.BOStockTakingAdjustmentDetail = new HashSet<BOStockTakingAdjustmentDetail>();
        }
    
        public long ID { get; set; }
        public System.Guid UniqueID { get; set; }
        public long BaseCode { get; set; }
        public Nullable<int> LocationSiteCode { get; set; }
        public Nullable<short> FiscalYearCode { get; set; }
        public Nullable<long> StockTakingAdjustmentCode { get; set; }
        public string TransactionCode { get; set; }
        public string TransactionNo { get; set; }
        public string ManualSerialNo { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public int PcOrCcCode { get; set; }
        public Nullable<bool> IsPhysicalAudit { get; set; }
        public Nullable<bool> IsAdjustment { get; set; }
        public Nullable<bool> IsExcess { get; set; }
        public long GeneratedByEmpCode { get; set; }
        public Nullable<bool> IsApproved { get; set; }
        public string Remarks { get; set; }
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
        public virtual ICollection<BOStockTakingAdjustment> BOStockTakingAdjustment1 { get; set; }
        public virtual BOStockTakingAdjustment BOStockTakingAdjustment2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOStockTakingAdjustmentDetail> BOStockTakingAdjustmentDetail { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{
    [Table("IMM.tbl_StockTakingAdjustmentDetail")]

    public partial class BOStockTakingAdjustmentDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOStockTakingAdjustmentDetail()
        {
            this.BOStockTakingAdjustmentDetail1 = new HashSet<BOStockTakingAdjustmentDetail>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public System.Guid UniqueID { get; set; }
        public long BaseCode { get; set; }
        public long StockTakingAdjustmentCode { get; set; }
        public Nullable<long> StockTakingAdjustmentDetailCode { get; set; }
        public string BatchNo { get; set; }
        public string SerialNo { get; set; }
        public System.DateTime InwardDate { get; set; }
        public Nullable<System.DateTime> MFGDate { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public Nullable<long> VendorOrSupplierCode { get; set; }
        public Nullable<long> ItemProfileCode { get; set; }
        public Nullable<long> EquipmentCode { get; set; }
        public byte IMMOrEquipmentConditionCode { get; set; }
        public string InventoryType { get; set; }
        public short TransactionLineNo { get; set; }
        public Nullable<short> StockUOMCode { get; set; }
        public decimal StockQty { get; set; }
        public Nullable<decimal> StockAuditQty { get; set; }
        public Nullable<decimal> StockAdjustedQty { get; set; }
        public Nullable<long> ItemPriceCode { get; set; }
        public Nullable<decimal> ItemOrEquipmentPrice { get; set; }
        public Nullable<bool> IsClose { get; set; }
        public Nullable<bool> IsComplete { get; set; }
        public Nullable<short> CurrencyCode { get; set; }
        public Nullable<decimal> ExchangeRate { get; set; }
        public Nullable<decimal> MiscExpense { get; set; }
        public long GeneratedByEmpCode { get; set; }
        public Nullable<long> AuditByEmpCode { get; set; }
        public Nullable<long> AdjustedByEmpCode { get; set; }
        public Nullable<bool> IsApproved { get; set; }
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
    
        public virtual BOIMMOrEquipmentCondition BOIMMOrEquipmentCondition { get; set; }
        public virtual BOStockTakingAdjustment BOStockTakingAdjustment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOStockTakingAdjustmentDetail> BOStockTakingAdjustmentDetail1 { get; set; }
        public virtual BOStockTakingAdjustmentDetail BOStockTakingAdjustmentDetail2 { get; set; }
    }
}

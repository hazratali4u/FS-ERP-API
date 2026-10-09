using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{
    [Table("IMM.tbl_GatePassDetail")]
    public partial class BOGatePassDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOGatePassDetail()
        {
            this.BOGatePassDetail1 = new HashSet<BOGatePassDetail>();
            this.BOGRNandReturnDetail = new HashSet<BOGRNandReturnDetail>();
            this.BOGRNandReturnCheckList = new HashSet<BOGRNandReturnCheckList>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }
        public System.Guid UniqueID { get; set; }
        public long BaseCode { get; set; }
        public long GatePassCode { get; set; }
        public Nullable<long> GatePassDetailCode { get; set; }
        public Nullable<long> POandReturnDetailCode { get; set; }
        public string BatchNo { get; set; }
        public string SerialNo { get; set; }
        public System.DateTime GatePassDate { get; set; }
        public Nullable<System.DateTime> InspectedDate { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
        public Nullable<System.DateTime> MFGDate { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public long VendorOrSupplierCode { get; set; }
        public Nullable<long> ItemProfileCode { get; set; }
        public Nullable<long> EquipmentCode { get; set; }
        public byte IMMOrEquipmentConditionCode { get; set; }
        public string InventoryType { get; set; }
        public short TransactionLineNo { get; set; }
        public Nullable<short> POUOMCode { get; set; }
        public decimal POQty { get; set; }
        public Nullable<decimal> ReceivedQty { get; set; }
        public Nullable<decimal> ReturnQty { get; set; }
        public Nullable<short> StockUOMCode { get; set; }
        public decimal StockQty { get; set; }
        public Nullable<decimal> StockReceivedQty { get; set; }
        public Nullable<decimal> StockReturnQty { get; set; }
        public Nullable<decimal> POPrice { get; set; }
        public Nullable<bool> IsClose { get; set; }
        public Nullable<bool> IsComplete { get; set; }
        public Nullable<short> CurrencyCode { get; set; }
        public Nullable<decimal> ExchangeRate { get; set; }
        public Nullable<decimal> MiscExpense { get; set; }
        public Nullable<decimal> AdvanceAmount { get; set; }
        public long GeneratedByEmpCode { get; set; }
        public Nullable<long> InspectedByEmpCode { get; set; }
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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOGatePassDetail> BOGatePassDetail1 { get; set; }
        public virtual BOGatePassDetail BOGatePassDetail2 { get; set; }
        public virtual BOPurchaseOrderAndReturn BOPurchaseOrderAndReturn { get; set; }
        public virtual BOUOM BOUOM { get; set; }
        public virtual BOUOM BOUOM1 { get; set; }
        public virtual BOEquipment BOEquipment { get; set; }
        public virtual BOEmployeeInfo BOEmployeeInfo { get; set; }
        public virtual BOEmployeeInfo BOEmployeeInfo1 { get; set; }
        public virtual BOGatePass BOGatePass { get; set; }
        public virtual BOItemProfile BOItemProfile { get; set; }
        public virtual BOCurrency BOCurrency { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOGRNandReturnDetail> BOGRNandReturnDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOGRNandReturnCheckList> BOGRNandReturnCheckList { get; set; }
    }
}

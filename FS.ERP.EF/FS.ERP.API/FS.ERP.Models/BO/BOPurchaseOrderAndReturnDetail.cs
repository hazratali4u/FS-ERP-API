using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{
    [Table("IMM.tbl_PurchaseOrderAndReturnDetail")]

    public partial class BOPurchaseOrderAndReturnDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOPurchaseOrderAndReturnDetail()
        {
            this.BOPurchaseOrderAndReturnDetail1 = new HashSet<BOPurchaseOrderAndReturnDetail>();
            this.BOGRNandReturnDetail = new HashSet<BOGRNandReturnDetail>();
            this.BOGRNandReturnCheckList = new HashSet<BOGRNandReturnCheckList>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }
        public System.Guid UniqueID { get; set; }
        public long BaseCode { get; set; }
        public Nullable<long> StockRequisitionOrIssuanceDetailCode { get; set; }
        public long POandReturnCode { get; set; }
        public Nullable<long> POandReturnDetailCode { get; set; }
        public string ManualSerialNo { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public Nullable<System.DateTime> ExpectedDeliveryorReturn { get; set; }
        public Nullable<System.DateTime> ActualDeliveryorReturn { get; set; }
        public long VendorOrSupplierCode { get; set; }
        public Nullable<long> ItemProfileCode { get; set; }
        public Nullable<long> EquipmentCode { get; set; }
        public byte IMMOrEquipmentConditionCode { get; set; }
        public string InventoryType { get; set; }
        public short TransactionLineNo { get; set; }
        public Nullable<short> POUOMCode { get; set; }
        public decimal POQty { get; set; }
        public Nullable<decimal> ReceivedQty { get; set; }
        public Nullable<short> StockUOMCode { get; set; }
        public decimal StockQty { get; set; }
        public Nullable<decimal> StockReceivedQty { get; set; }
        public Nullable<decimal> POPrice { get; set; }
        public Nullable<bool> IsClose { get; set; }
        public Nullable<bool> IsComplete { get; set; }
        public Nullable<short> CurrencyCode { get; set; }
        public Nullable<decimal> ExchangeRate { get; set; }
        public Nullable<decimal> MiscExpense { get; set; }
        public Nullable<decimal> AdvanceAmount { get; set; }
        public Nullable<decimal> DiscountAmount { get; set; }
        public Nullable<decimal> TransactionAmount { get; set; }
        public Nullable<decimal> AmountToBePaid { get; set; }
        public Nullable<int> IMMTaxGroupCode { get; set; }
        public Nullable<decimal> GSTRate { get; set; }
        public Nullable<decimal> GSTAmount { get; set; }
        public Nullable<decimal> WHTRate { get; set; }
        public Nullable<decimal> WHTAmount { get; set; }
        public Nullable<decimal> VATRate { get; set; }
        public Nullable<decimal> VATAmount { get; set; }
        public Nullable<decimal> OtherDeductionAmount { get; set; }
        public Nullable<bool> Is3Schedule { get; set; }
        public Nullable<byte> PaymentModeCode { get; set; }
        public Nullable<int> CreditDuration { get; set; }
        public long GeneratedByEmpCode { get; set; }
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
        public Nullable<long> GRNandReturnDetailCode { get; set; }

        public virtual BOIMMOrEquipmentCondition BOIMMOrEquipmentCondition { get; set; }
        public virtual BOPurchaseOrderAndReturn BOPurchaseOrderAndReturn { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPurchaseOrderAndReturnDetail> BOPurchaseOrderAndReturnDetail1 { get; set; }
        public virtual BOPurchaseOrderAndReturnDetail BOPurchaseOrderAndReturnDetail2 { get; set; }
        public virtual BOStockRequisitionOrIssuanceDetail BOStockRequisitionOrIssuanceDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOGRNandReturnDetail> BOGRNandReturnDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOGRNandReturnCheckList> BOGRNandReturnCheckList { get; set; }


        public virtual BOCurrency BOCurrency { get; set; }
        public virtual BOIMMTaxGroup BOIMMTaxGroup { get; set; }
        public virtual BOPaymentMode BOPaymentMode { get; set; }
        public virtual BOUOM BOUOM { get; set; }
        public virtual BOUOM BOUOM1 { get; set; }
        public virtual BOEquipment BOEquipment { get; set; }
        public virtual BOEmployeeInfo BOEmployeeInfo { get; set; }
        public virtual BOGRNandReturnDetail BOGRNandReturnDetail1 { get; set; }
        public virtual BOItemProfile BOItemProfile { get; set; }
        public virtual BOVendorOrSupplier BOVendorOrSupplier { get; set; }

    }
}

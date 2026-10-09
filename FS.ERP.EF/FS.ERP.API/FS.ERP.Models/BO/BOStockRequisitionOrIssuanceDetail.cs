using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{
    [Table("IMM.tbl_StockRequisitionOrIssuanceDetail")]

    public partial class BOStockRequisitionOrIssuanceDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOStockRequisitionOrIssuanceDetail()
        {
            this.BOPurchaseOrderAndReturnDetail = new HashSet<BOPurchaseOrderAndReturnDetail>();
            this.BOStockRequisitionOrIssuanceDetail1 = new HashSet<BOStockRequisitionOrIssuanceDetail>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public System.Guid UniqueID { get; set; }
        public long BaseCode { get; set; }
        public long StockRequisitionOrIssuanceCode { get; set; }
        public Nullable<long> StockRequisitionOrIssuanceDetailCode { get; set; }
        public string BatchNo { get; set; }
        public string SerialNo { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public Nullable<System.DateTime> IssuanceDate { get; set; }
        public Nullable<System.DateTime> ReceivedDate { get; set; }
        public Nullable<long> VendorOrSupplierCode { get; set; }
        public Nullable<long> ItemProfileCode { get; set; }
        public Nullable<long> ItemProfileReplacedCode { get; set; }
        public Nullable<long> EquipmentCode { get; set; }
        public Nullable<long> EquipmentReplacedCode { get; set; }
        public byte IMMOrEquipmentConditionCode { get; set; }
        public Nullable<byte> IMMOrEquipmentReplacedConditionCode { get; set; }
        public string InventoryType { get; set; }
        public short TransactionLineNo { get; set; }
        public Nullable<short> StockUOMCode { get; set; }
        public decimal StockQty { get; set; }
        public Nullable<decimal> StockIssuedQty { get; set; }
        public Nullable<decimal> StockReceivedQty { get; set; }
        public Nullable<long> ItemPriceCode { get; set; }
        public Nullable<decimal> ItemOrEquipmentPrice { get; set; }
        public Nullable<bool> IsInwardGPGenerated { get; set; }
        public Nullable<bool> IsOutwardGPGenerated { get; set; }
        public Nullable<bool> IsClose { get; set; }
        public Nullable<bool> IsComplete { get; set; }
        public Nullable<short> CurrencyCode { get; set; }
        public Nullable<decimal> ExchangeRate { get; set; }
        public Nullable<decimal> MiscExpense { get; set; }
        public long RequisitionByEmpCode { get; set; }
        public Nullable<long> IssuanceToEmpCode { get; set; }
        public Nullable<long> ReceivedByEmpCode { get; set; }
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
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPurchaseOrderAndReturnDetail> BOPurchaseOrderAndReturnDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOStockRequisitionOrIssuanceDetail> BOStockRequisitionOrIssuanceDetail1 { get; set; }

        public virtual BOStockRequisitionOrIssuance BOStockRequisitionOrIssuance { get; set; }

        public virtual BOCurrency BOCurrency { get; set; }

        public virtual BOEmployeeInfo BOEmployeeInfo { get; set; }

        public virtual BOEmployeeInfo BOEmployeeInfo1 { get; set; }

        public virtual BOEquipment BOEquipment { get; set; }

        public virtual BOEquipment BOEquipment1 { get; set; }

        public virtual BOIMMOrEquipmentCondition BOIMMOrEquipmentCondition { get; set; }

        public virtual BOIMMOrEquipmentCondition BOIMMOrEquipmentCondition1 { get; set; }

        public virtual BOItemPrice BOItemPrice { get; set; }

        public virtual BOItemProfile BOItemProfile { get; set; }

        public virtual BOItemProfile BOItemProfile1 { get; set; }

        public virtual BOStockRequisitionOrIssuanceDetail BOStockRequisitionOrIssuanceDetail2 { get; set; }

        public virtual BOUOM BOUOM { get; set; }

        public virtual BOVendorOrSupplier BOVendorOrSupplier { get; set; }











    }
}

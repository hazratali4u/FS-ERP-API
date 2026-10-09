using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{
    [Table("IMM.tbl_PurchaseOrderAndReturn")]

    public partial class BOPurchaseOrderAndReturn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOPurchaseOrderAndReturn()
        {
            BOPurchaseOrderAndReturnDetail = new HashSet<BOPurchaseOrderAndReturnDetail>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public System.Guid UniqueID { get; set; }
        public long BaseCode { get; set; }
        public Nullable<short> FiscalYearCode { get; set; }
        public byte DispatchReceiveMediumCode { get; set; }
        public Nullable<long> StockRequisitionOrIssuanceCode { get; set; }
        public Nullable<long> POandReturnCode { get; set; }
        public Nullable<int> LocationSiteCode { get; set; }
        public string TransactionCode { get; set; }
        public string TransactionNo { get; set; }
        public string ManualSerialNo { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public Nullable<System.DateTime> ExpectedDeliveryorReturn { get; set; }
        public Nullable<System.DateTime> ActualDeliveryorReturn { get; set; }
        public long VendorOrSupplierCode { get; set; }
        public Nullable<bool> IsReturn { get; set; }
        public Nullable<bool> IsClose { get; set; }
        public Nullable<bool> IsComplete { get; set; }
        public Nullable<short> CurrencyCode { get; set; }
        public Nullable<decimal> ExchangeRate { get; set; }
        public Nullable<decimal> MiscExpense { get; set; }
        public Nullable<decimal> AdvanceAmount { get; set; }
        public Nullable<decimal> DiscountAmount { get; set; }
        public Nullable<decimal> TransactionAmount { get; set; }
        public Nullable<decimal> AmountToBePaid { get; set; }
        public Nullable<long> IMMTaxGroupDetailCode { get; set; }
        public Nullable<decimal> GSTRate { get; set; }
        public Nullable<decimal> GSTAmount { get; set; }
        public Nullable<decimal> WHTRate { get; set; }
        public Nullable<decimal> WHTAmount { get; set; }
        public Nullable<decimal> OtherDeductionAmount { get; set; }
        public Nullable<bool> Is3Schedule { get; set; }
        public Nullable<byte> PaymentModeCode { get; set; }
        public Nullable<int> CreditDuration { get; set; }
        public long GeneratedByEmpCode { get; set; }
        public Nullable<bool> IsApproved { get; set; }
        public string ContactPerson { get; set; }
        public string ContactNo { get; set; }
        public string DeliveryAddress { get; set; }
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
        public Nullable<long> GRNandReturnCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPurchaseOrderAndReturnDetail> BOPurchaseOrderAndReturnDetail { get; set; }
    }
}

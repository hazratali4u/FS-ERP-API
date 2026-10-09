using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{
    [Table("IMM.tbl_GRNandReturn")]
    public partial class BOGRNandReturn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOGRNandReturn()
        {
            this.tbl_GRNandReturn1 = new HashSet<BOGRNandReturn>();
            this.tbl_GRNandReturnDetail = new HashSet<BOGRNandReturnDetail>();
            this.BOPurchaseOrderAndReturn = new HashSet<BOPurchaseOrderAndReturn>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }
        public System.Guid UniqueID { get; set; }
        public long BaseCode { get; set; }
        public Nullable<int> LocationSiteCode { get; set; }
        public Nullable<short> FiscalYearCode { get; set; }
        public byte DispatchReceiveMediumCode { get; set; }
        public Nullable<long> GatePassCode { get; set; }
        public Nullable<long> GRNandReturnCode { get; set; }
        public string TransactionCode { get; set; }
        public string TransactionNo { get; set; }
        public string ManualSerialNo { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public Nullable<System.DateTime> ReceivedDate { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
        public long VendorOrSupplierCode { get; set; }
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
        public Nullable<decimal> OtherDeductionAmount { get; set; }
        public Nullable<bool> Is3Schedule { get; set; }
        public Nullable<byte> PaymentModeCode { get; set; }
        public Nullable<int> CreditDuration { get; set; }
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
        public Nullable<long> POandReturnCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOGRNandReturn> tbl_GRNandReturn1 { get; set; }
        public virtual BOGRNandReturn tbl_GRNandReturn2 { get; set; }
        public virtual BOPurchaseOrderAndReturn tbl_PurchaseOrderAndReturn { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOGRNandReturnDetail> tbl_GRNandReturnDetail { get; set; }


        public virtual BOCurrency BOCurrency { get; set; }
        public virtual BODispatchReceiveMedium BODispatchReceiveMedium { get; set; }
        public virtual BOIMMTaxGroup BOIMMTaxGroup { get; set; }
        public virtual BOLocationSite BOLocationSite { get; set; }
        public virtual BOPaymentMode BOPaymentMode { get; set; }
        public virtual BOFiscalYear BOFiscalYear { get; set; }
        public virtual BOEmployeeInfo BOEmployeeInfo { get; set; }
        public virtual BOGatePass BOGatePass { get; set; }
        public virtual BOVendorOrSupplier BOVendorOrSupplier { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPurchaseOrderAndReturn> BOPurchaseOrderAndReturn { get; set; }
    }
}

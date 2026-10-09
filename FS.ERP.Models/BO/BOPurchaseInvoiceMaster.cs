using FS.ERP.Models.IdentityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.Models.BO
{
    [Table("IMM.tbl_PurchaseInvoiceMaster")]
    public class BOPurchaseInvoiceMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOPurchaseInvoiceMaster()
        {
            BOPurchaseInvoiceDetail = new HashSet<BOPurchaseInvoiceDetail>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public Nullable<int> BaseCode { get; set; }
        public Nullable<long> PurchaseOrderCode { get; set; }
        public string FolioNo { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public Int16 FiscalYearCode { get; set; }
        public string ReferenceNumber { get; set; }
        public Nullable<int> ProfitOrCostCenterCode { get; set; }
        public Nullable<long> VendorOrSupplierCode { get; set; }
        public Nullable<long> COACode { get; set; }
        public Nullable<System.DateTime> PaymentDueDate { get; set; }
        public Nullable<short> CurrencyCode { get; set; }
        public Nullable<decimal> ExchangeRate { get; set; }
        public Nullable<decimal> InvoiceAmount { get; set; }
        public Nullable<decimal> GrossAmount { get; set; }
        public Nullable<decimal> AmountToBePaid { get; set; }
        public Nullable<decimal> AdvanceAmount { get; set; }
        public Nullable<decimal> DiscountRatio { get; set; }
        public Nullable<decimal> DiscountAmount { get; set; }
        public Nullable<decimal> DeductionAmount { get; set; }
        public Nullable<long> TaxGroupDetailCode { get; set; }
        public Nullable<decimal> NetAmount { get; set; }
        public Nullable<int> Status { get; set; }
        public string Remarks { get; set; }
        public string Document { get; set; }
        public Nullable<decimal> PendingAmount { get; set; }
        public Nullable<bool> IsPaid { get; set; }
        public Nullable<bool> IsPartiallyPaid { get; set; }
        public Nullable<long> AdjustmentCode { get; set; }
        public Nullable<decimal> AdjustedAmount { get; set; }
        public int CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }


        public virtual BOVendorAdjustment BOVendorAdjustment { get; set; }
        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }
        public virtual BORecordStatus BORecordStatus { get; set; }
        public virtual BOUser BOUser { get; set; }
        public virtual BOUser BOUser1 { get; set; }
        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPurchaseInvoiceDetail> BOPurchaseInvoiceDetail { get; set; }

    }
}

using FS.ERP.Models.IdentityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.Models.BO
{
    [Table("SRM.tbl_VendorAdjustment")]
    public class BOVendorAdjustment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOVendorAdjustment()
        {
            BOVendorAdjustmentInvoiceMapping = new HashSet<BOVendorAdjustmentInvoiceMapping>();
            BOCommissionBooking = new HashSet<BOCommissionBooking>();
            BOPurchaseInvoiceMaster = new HashSet<BOPurchaseInvoiceMaster>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public Nullable<int> BaseCode { get; set; }
        public Nullable<int> AdjustmentType { get; set; }
        public string FolioNo { get; set; }
        public Int16 FiscalYearCode { get; set; }
        public string ReferenceNumber { get; set; }
        public Nullable<int> ProfitOrCostCenterCode { get; set; }
        public Nullable<long> VendorOrSupplierCode { get; set; }
        public Nullable<long> COACode { get; set; }
        public Nullable<decimal> Amount { get; set; }
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

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }
        public virtual BORecordStatus BORecordStatus { get; set; }
        public virtual BOUser BOUser { get; set; }
        public virtual BOUser BOUser1 { get; set; }
        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOCommissionBooking> BOCommissionBooking { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPurchaseInvoiceMaster> BOPurchaseInvoiceMaster { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOVendorAdjustmentInvoiceMapping> BOVendorAdjustmentInvoiceMapping { get; set; }

        
    }
}

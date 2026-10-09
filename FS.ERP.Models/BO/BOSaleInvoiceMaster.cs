using FS.ERP.Models.IdentityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.Models.BO
{
    [Table("SRM.tbl_SaleInvoiceMaster")]
    public class BOSaleInvoiceMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOSaleInvoiceMaster()
        {
            //BOSaleInvoiceDetail = new HashSet<BOSaleInvoiceDetail>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public Nullable<int> BaseCode { get; set; }
        public string FolioNo { get; set; }
        public string ReferenceNumber { get; set; }
        public Nullable<int> ProfitOrCostCenterCode { get; set; }
        public Nullable<long> CustomerCode { get; set; }
        public Nullable<long> SaleOrderCode { get; set; }
        public Nullable<long> DeliveryNoteCode { get; set; }
        public Nullable<decimal> DiscountRatio { get; set; }
        public Nullable<decimal> DiscountAmount { get; set; }
        public Nullable<int> TaxGroupCode { get; set; }
        public Nullable<decimal> TaxAmount { get; set; }
        public Nullable<long> AdjustmentCode { get; set; }
        public Nullable<decimal> AdjustedAmount { get; set; }
        public Nullable<decimal> PendingAmount { get; set; }
        public Nullable<bool> IsPaid { get; set; }
        public Nullable<bool> IsPartiallyPaid { get; set; }
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

        //public virtual BOCustomerAdjustment BOCustomerAdjustment { get; set; }
        //public virtual BODeliveryNoteMaster BODeliveryNoteMaster { get; set; }
        //public virtual BOSaleOrderMaster BOSaleOrderMaster { get; set; }
        //public virtual BOIMMTaxGroup BOIMMTaxGroup { get; set; }
        //public virtual BOPartyOrCustomer BOPartyOrCustomer { get; set; }
        //public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }
        //public virtual BOOrganizationCompany BOOrganizationCompany1 { get; set; }
        //public virtual BORecordStatus BORecordStatus { get; set; }
        //public virtual BOUser BOUser { get; set; }
        //public virtual BOUser BOUser1 { get; set; }
        //public virtual BOUser BOUser2 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<BOSaleInvoiceDetail> BOSaleInvoiceDetail { get; set; }

    } 
}

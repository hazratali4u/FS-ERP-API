using FS.ERP.Models.IdentityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.Models.BO
{
    [Table("SRM.tbl_SaleOrderMaster")]
    public class BOSaleOrderMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOSaleOrderMaster()
        {
            BOBillOrInvoiceMaster = new HashSet<BOBillOrInvoiceMaster>();
            BODeliveryNoteMaster = new HashSet<BODeliveryNoteMaster>();
            //BOSaleInvoiceMaster = new HashSet<BOSaleInvoiceMaster>();
            BOSaleOrderDetail = new HashSet<BOSaleOrderDetail>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public Nullable<int> TransactionNo { get; set; }
        public Int16 FiscalYearCode { get; set; }
        public string FolioNo { get; set; }
        public Nullable<long> EmpCode { get; set; }
        public string OrderNo { get; set; }
        public Nullable<System.DateTime> SalesOrderDate { get; set; }
        public string BookNo { get; set; }
        public Nullable<int> ProfitOrCostCenterCode { get; set; }
        public Nullable<long> CustomerCode { get; set; }
        public Nullable<int> SalesOrderType { get; set; }
        public Nullable<System.DateTime> OrderCompletionDate { get; set; }
        public Nullable<long> TaxGroupDetailCode { get; set; }
        public Nullable<decimal> TotalTax { get; set; }
        public Nullable<decimal> AdvanceAmount { get; set; }
        public Nullable<decimal> DiscountRatio { get; set; }
        public Nullable<decimal> DiscountAmount { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public string DeliveryAddress { get; set; }
        public Nullable<bool> IsClose { get; set; }
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
        public bool? IsVoid { get; set; }
        public bool? IsApproved { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ApprovedOn { get; set; }
        public Nullable<long> ApprovedBy { get; set; }

        public virtual BOEmployeeInfo BOEmployeeInfo { get; set; }
        public virtual BOIMMTaxGroupDetail BOIMMTaxGroupDetail { get; set; }
        public virtual BOPartyOrCustomer BOPartyOrCustomer { get; set; }
        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }
        public virtual BOOrganizationCompany BOOrganizationCompany1 { get; set; }
        public virtual BORecordStatus BORecordStatus { get; set; }
        public virtual BOUser BOUser { get; set; }
        public virtual BOUser BOUser1 { get; set; }
        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BODeliveryNoteMaster> BODeliveryNoteMaster { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<BOSaleInvoiceMaster> BOSaleInvoiceMaster { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOSaleOrderDetail> BOSaleOrderDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOBillOrInvoiceMaster> BOBillOrInvoiceMaster { get; set; }

        
    }
}

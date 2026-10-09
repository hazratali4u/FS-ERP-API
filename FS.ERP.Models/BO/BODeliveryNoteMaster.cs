using FS.ERP.Models.IdentityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.Models.BO
{
    [Table("SRM.tbl_DeliveryNoteMaster")]
    public class BODeliveryNoteMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BODeliveryNoteMaster()
        {
            BOBillOrInvoiceMaster = new HashSet<BOBillOrInvoiceMaster>();
            BODeliveryNoteDetail = new HashSet<BODeliveryNoteDetail>();
            BOFreightEntrySlip = new HashSet<BOFreightEntrySlip>();
            //BOSaleInvoiceMaster = new HashSet<BOSaleInvoiceMaster>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public Nullable<int> BaseCode { get; set; }
        public string FolioNo { get; set; }
        public string ReferenceNumber { get; set; }
        public Nullable<int> ProfitOrCostCenterCode { get; set; }
        public Nullable<long> SaleOrderCode { get; set; }
        public Nullable<long> CustomerCode { get; set; }
        public Nullable<System.DateTime> DeliveryNoteDate { get; set; }
        public Nullable<long> EmpCode { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<bool> IsApproved { get; set; }
        public Nullable<bool> IsClosedOrDelivered { get; set; }
        public string Remarks { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public short? FiscalYearCode { get; set; }
        public int CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }


        public virtual BOEmployeeInfo BOEmployeeInfo { get; set; } 
        public virtual BOPartyOrCustomer BOPartyOrCustomer { get; set; }
        public virtual BOSaleOrderMaster BOSaleOrderMaster { get; set; }
        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }
        public virtual BOOrganizationCompany BOOrganizationCompany1 { get; set; }
        public virtual BORecordStatus BORecordStatus { get; set; }
        public virtual BOUser BOUser { get; set; }
        public virtual BOUser BOUser1 { get; set; }
        public virtual BOUser BOUser2 { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BODeliveryNoteDetail> BODeliveryNoteDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOFreightEntrySlip> BOFreightEntrySlip { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<BOSaleInvoiceMaster> BOSaleInvoiceMaster { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOBillOrInvoiceMaster> BOBillOrInvoiceMaster { get; set; }
        

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("AppCNF.tbl_IMMTaxGroup")]
    public partial class BOIMMTaxGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOIMMTaxGroup()
        {
            //BOSaleInvoiceDetail = new HashSet<BOSaleInvoiceDetail>();
            //BOSaleInvoiceMaster = new HashSet<BOSaleInvoiceMaster>();
            //BODeliveryNoteDetail = new HashSet<BODeliveryNoteDetail>();
            //BOSaleOrderMaster = new HashSet<BOSaleOrderMaster>();
            //BOSaleOrderDetail = new HashSet<BOSaleOrderDetail>();
            BOIMMTaxGroupDetail = new HashSet<BOIMMTaxGroupDetail>();
            //BOItemCategory = new HashSet<BOItemCategory>();
            //BOItemPrice = new HashSet<BOItemPrice>();
            //BOGRNandReturn = new HashSet<BOGRNandReturn>();
            //BOGRNandReturnDetail = new HashSet<BOGRNandReturnDetail>();
            //BOPurchaseOrderAndReturnDetail = new HashSet<BOPurchaseOrderAndReturnDetail>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int? StateProvinceCode { get; set; }

        public short? FiscalYearCode { get; set; }

        [StringLength(25)]
        public string ShortName { get; set; }

        [Required]
        [StringLength(255)]
        public string FullName { get; set; }

        [Required]
        [StringLength(510)]
        public string DisplayName { get; set; }

        [StringLength(1020)]
        public string Description { get; set; }

        public bool IsFiscalYearBase { get; set; }

        public bool IsActive { get; set; }

        public int? CompanyCode { get; set; }

        public DateTime? dtmExported { get; set; }

        public DateTime? dtmImported { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        public byte RecordStatusCode { get; set; }

        public virtual BOFiscalYear BOFiscalYear { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOStateProvince BOStateProvince { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOIMMTaxGroupDetail> BOIMMTaxGroupDetail { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<BOItemCategory> BOItemCategory { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<BOItemPrice> BOItemPrice { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<BOGRNandReturn> BOGRNandReturn { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<BOGRNandReturnDetail> BOGRNandReturnDetail { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<BOPurchaseOrderAndReturnDetail> BOPurchaseOrderAndReturnDetail { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<BOSaleOrderDetail> BOSaleOrderDetail { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<BOSaleOrderMaster> BOSaleOrderMaster { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<BODeliveryNoteDetail> BODeliveryNoteDetail { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<BOSaleInvoiceMaster> BOSaleInvoiceMaster { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<BOSaleInvoiceDetail> BOSaleInvoiceDetail { get; set; }

        
    }
}

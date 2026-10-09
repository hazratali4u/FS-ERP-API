using System;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;
using System.Collections.Generic;

namespace FS.ERP.Models.BO
{
    [Table("IMM.tbl_ItemPrice")]
    public partial class BOItemPrice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOItemPrice()
        {
            this.BOGRNandReturnDetail = new HashSet<BOGRNandReturnDetail>();
            this.BOReceipeMaster = new HashSet<BOReceipeMaster>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        public long ItemCode { get; set; }

        public long? ItemProfileCode { get; set; }

        public int? PcOCcCode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CostPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TradePrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TradeDiscount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RetailPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RetailDiscount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DistributorPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DistributorDiscount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Commision { get; set; }

        public DateTime StartFrom { get; set; }

        public DateTime EndTo { get; set; }

        public bool? IsTaxExempted { get; set; }

        public int? IMMTaxGroupCode { get; set; }

        public bool IsDefault { get; set; }

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

        public virtual BOIMMTaxGroup BOIMMTaxGroup { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany1 { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOItem BOItem { get; set; }

        public virtual BOItemProfile BOItemProfile { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOStockRequisitionOrIssuanceDetail> BOStockRequisitionOrIssuanceDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOGRNandReturnDetail> BOGRNandReturnDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOReceipeMaster> BOReceipeMaster { get; set; }
    }
}

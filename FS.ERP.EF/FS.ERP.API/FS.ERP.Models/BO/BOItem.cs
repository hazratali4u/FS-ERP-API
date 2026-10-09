using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("IMM.tbl_Item")]
    public partial class BOItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOItem()
        {
            BOItemAttributeAspect = new HashSet<BOItemAttributeAspect>();
            BOItemAttributeAspectDetail = new HashSet<BOItemAttributeAspectDetail>();
            BOItemPrice = new HashSet<BOItemPrice>();
            BOItemProfile = new HashSet<BOItemProfile>();
            BOVendorOrSupplierWiseItem = new HashSet<BOVendorOrSupplierWiseItem>();
            BOItemOrProfileServiceType = new HashSet<BOItemOrProfileServiceType>();
            BOItemDeal = new HashSet<BOItemDeal>();
            BOItemModifier = new HashSet<BOItemModifier>();
            BOItemModifier1 = new HashSet<BOItemModifier>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        public int ItemCategoryCode { get; set; }

        [StringLength(25)]
        public string ItemShortName { get; set; }

        [Required]
        [StringLength(50)]
        public string ItemCode { get; set; }

        [Required]
        [StringLength(255)]
        public string ItemFullName { get; set; }

        public byte? IMMTransactionMethodCode { get; set; }

        public byte? IMMGroupCode { get; set; }

        public byte? IMMAcquireTypeCode { get; set; }

        public byte? IMMGenderCode { get; set; }

        public byte? IMMLifeTypeCode { get; set; }

        public byte? IMMManufacturedByCode { get; set; }

        public byte? OnwerShipTypeCode { get; set; }

        public byte? PackingTypeCode { get; set; }

        public short? StockUOMCode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DefaultQty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MinLevel { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ReOrderLevel { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MaxLevel { get; set; }

        public short? PurchaseUOMCode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PurchaseConversionFactor { get; set; }

        public short? SaleUOMCode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SaleConversionFactor { get; set; }

        public short? AssemblyUOMCode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AssemblyConversionFactor { get; set; }

        public bool? IsBatchItem { get; set; }

        public bool? IsOverSaleOrDispatchAllowed { get; set; }

        public bool? IsExpiryAllowed { get; set; }

        public short? LifeUOMCode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FullLife { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ShelfLife { get; set; }

        public bool? IsReplaceableItem { get; set; }

        public bool? IsOpenBoxAllowed { get; set; }

        public bool? IsDeal { get; set; }

        public bool? IsModifier { get; set; }

        public bool? IsHasModifier { get; set; }

        public bool? IsReceipeItem { get; set; }

        public bool IsActive { get; set; }

        public long SortOrder { get; set; }

        public int? IMMSectionOrBrandCode { get; set; }

        public int? CompanyCode { get; set; }

        public DateTime? dtmExported { get; set; }

        public DateTime? dtmImported { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        public byte RecordStatusCode { get; set; }

        public virtual BOIMMAcquireType BOIMMAcquireType { get; set; }

        public virtual BOIMMGender BOIMMGender { get; set; }

        public virtual BOIMMGroup BOIMMGroup { get; set; }

        public virtual BOIMMLifeType BOIMMLifeType { get; set; }

        public virtual BOIMMManufacturedBy BOIMMManufacturedBy { get; set; }

        public virtual BOIMMTransactionMethod BOIMMTransactionMethod { get; set; }

        public virtual BOOnwerShipType BOOnwerShipType { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BOPackingType BOPackingType { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOUOM BOUOM { get; set; }

        public virtual BOUOM BOUOM1 { get; set; }

        public virtual BOUOM BOUOM2 { get; set; }

        public virtual BOUOM BOUOM3 { get; set; }

        public virtual BOUOM BOUOM4 { get; set; }

        public virtual BOItemCategory BOItemCategory { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOItemAttributeAspect> BOItemAttributeAspect { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOItemAttributeAspectDetail> BOItemAttributeAspectDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOItemPrice> BOItemPrice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOItemProfile> BOItemProfile { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOVendorOrSupplierWiseItem> BOVendorOrSupplierWiseItem { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOItemOrProfileServiceType> BOItemOrProfileServiceType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOItemDeal> BOItemDeal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOItemModifier> BOItemModifier { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOItemModifier> BOItemModifier1 { get; set; }
    }
}

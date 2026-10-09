using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("IMM.tbl_ItemCategory")]
    public partial class BOItemCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOItemCategory()
        {
            BOItem = new HashSet<BOItem>();
            BOItemCategory1 = new HashSet<BOItemCategory>();
            BOItemCategoryAttributeAspect = new HashSet<BOItemCategoryAttributeAspect>();
            BOItemCategoryAttributeAspectDetail = new HashSet<BOItemCategoryAttributeAspectDetail>();
        }

        public int ID { get; set; }

        public int? ParentCode { get; set; }

        public byte IMMConfigurationCode { get; set; }

        [StringLength(25)]
        public string ItemCode { get; set; }

        [StringLength(25)]
        public string ShortName { get; set; }

        [Required]
        [StringLength(255)]
        public string FullName { get; set; }

        [Required]
        [StringLength(510)]
        public string DisplayName { get; set; }

        public Nullable<long> TaxGroupDetailCode { get; set; }

        public Nullable<byte> IMMTransactionMethodCode { get; set; }
        public Nullable<byte> IMMGroupCode { get; set; }

        public long? COACode { get; set; }

        public int? SortOrder { get; set; }

        public bool? IsActive { get; set; }

        [StringLength(1020)]
        public string Description { get; set; }

        public int? CompanyCode { get; set; }

        public DateTime? dtmExported { get; set; }

        public DateTime? dtmImported { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        public byte RecordStatusCode { get; set; }

        [StringLength(50)]
        public string CategoryColor { get; set; }

        public virtual BOIMMTaxGroupDetail BOIMMTaxGroupDetail { get; set; }


        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOCOA BOCOA { get; set; }

        public virtual BOIMMConfiguration BOIMMConfiguration { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOItem> BOItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOItemCategory> BOItemCategory1 { get; set; }

        public virtual BOItemCategory BOItemCategory2 { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOItemCategoryAttributeAspect> BOItemCategoryAttributeAspect { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOItemCategoryAttributeAspectDetail> BOItemCategoryAttributeAspectDetail { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("FICO.tbl_JobProjectSchemeDetail")]
    public partial class BOJobProjectSchemeDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOJobProjectSchemeDetail()
        {
            BOBillOrInvoiceMasterDetail = new HashSet<BOBillOrInvoiceMasterDetail>();
            BORemittanceAdviceDetail = new HashSet<BORemittanceAdviceDetail>();
            BOTransactionDetail = new HashSet<BOTransactionDetail>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        public Guid UniqueID { get; set; }

        public long BaseCode { get; set; }

        public long JobProjectSchemeCode { get; set; }

        public short? TransactionLineNo { get; set; }

        [Required]
        [StringLength(255)]
        public string ComodityName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Qty { get; set; }

        public byte? PackTypeCode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Weight { get; set; }

        public short? WeightUOMCode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Length { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Heigth { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Width { get; set; }

        public short? LWHUOMCode { get; set; }

        [StringLength(1020)]
        public string Description { get; set; }

        public int CompanyCode { get; set; }

        public DateTime? dtmExported { get; set; }

        public DateTime? dtmImported { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        public byte RecordStatusCode { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BOPackingType BOPackingType { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOUOM BOUOM { get; set; }

        public virtual BOUOM BOUOM1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOBillOrInvoiceMasterDetail> BOBillOrInvoiceMasterDetail { get; set; }

        public virtual BOJobProjectScheme BOJobProjectScheme { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BORemittanceAdviceDetail> BORemittanceAdviceDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOTransactionDetail> BOTransactionDetail { get; set; }
    }
}

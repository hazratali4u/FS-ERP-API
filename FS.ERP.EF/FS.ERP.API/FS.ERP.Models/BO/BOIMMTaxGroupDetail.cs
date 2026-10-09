using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("AppCNF.tbl_IMMTaxGroupDetail")]
    public partial class BOIMMTaxGroupDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOIMMTaxGroupDetail()
        {
            BOBillOrInvoiceMasterDetail = new HashSet<BOBillOrInvoiceMasterDetail>();
            BORemittanceAdviceDetail = new HashSet<BORemittanceAdviceDetail>();
            BOTransactionDetail = new HashSet<BOTransactionDetail>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public int IMMTaxGroupCode { get; set; }

        public int? StateProvinceCode { get; set; }

        public short? FiscalYearCode { get; set; }

        [Required]
        [StringLength(25)]
        public string TaxCode { get; set; }

        [StringLength(255)]
        public string ActRefNo { get; set; }

        [StringLength(510)]
        public string ActRefName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TaxPercentage { get; set; }

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

        public virtual BOIMMTaxGroup BOIMMTaxGroup { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOBillOrInvoiceMasterDetail> BOBillOrInvoiceMasterDetail { get; set; }

        public virtual BOFiscalYear BOFiscalYear { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOStateProvince BOStateProvince { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BORemittanceAdviceDetail> BORemittanceAdviceDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOTransactionDetail> BOTransactionDetail { get; set; }
    }
}

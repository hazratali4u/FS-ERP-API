using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;
using System.Collections.Generic;

namespace FS.ERP.Models.BO{
    [Table("AppCNF.tbl_IncomeTaxSlab")]
    public partial class BOIncomeTaxSlab
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOIncomeTaxSlab()
        {
            BOIncomeTaxSlabDetail = new HashSet<BOIncomeTaxSlabDetail>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string TaxSlabName { get; set; }
        public string DisplayName { get; set; }
        public short FiscalYearCode { get; set; }
        public System.DateTime EffectiveFrom { get; set; }
        public string SlabDescription { get; set; }
        public Nullable<decimal> TaxRebateMale { get; set; }
        public Nullable<decimal> TaxRebateFemale { get; set; }
        public decimal TaxRebateMinSlab { get; set; }
        public Nullable<decimal> EmployerPFLimit { get; set; }
        public decimal BenchmarkRate { get; set; }
        public decimal BenchmarkRateLoanAmount { get; set; }
        public int CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }

        public virtual BOFiscalYear BOFiscalYear { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOIncomeTaxSlabDetail> BOIncomeTaxSlabDetail { get; set; }
    }
}

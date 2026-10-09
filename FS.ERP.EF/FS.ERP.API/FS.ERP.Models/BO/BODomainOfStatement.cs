using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("FICO.tbl_DomainOfStatement")]
    public partial class BODomainOfStatement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BODomainOfStatement()
        {
            BODocumentDetailOfStatement = new HashSet<BODocumentDetailOfStatement>();
            BOFiscalYearMonthDetail = new HashSet<BOFiscalYearMonthDetail>();
        }

        public int ID { get; set; }

        public short FiscalYearCode { get; set; }

        [StringLength(25)]
        public string DomainOfStatementCode { get; set; }

        [Required]
        [StringLength(510)]
        public string DisplayTitle { get; set; }

        [Required]
        [StringLength(1020)]
        public string DisplayName { get; set; }

        public byte SortOrder { get; set; }

        public bool IsActive { get; set; }

        [StringLength(2040)]
        public string Remarks { get; set; }

        public int? CompanyCode { get; set; }

        public DateTime? dtmExported { get; set; }

        public DateTime? dtmImported { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        public byte RecordStatusCode { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BODocumentDetailOfStatement> BODocumentDetailOfStatement { get; set; }

        public virtual BOFiscalYear BOFiscalYear { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOFiscalYearMonthDetail> BOFiscalYearMonthDetail { get; set; }
    }
}

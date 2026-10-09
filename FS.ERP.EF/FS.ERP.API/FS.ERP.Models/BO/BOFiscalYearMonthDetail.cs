using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("FICO.tbl_FiscalYearMonthDetail")]
    public partial class BOFiscalYearMonthDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public Guid UniqueID { get; set; }

        public long BaseCode { get; set; }

        public short FiscalYearCode { get; set; }

        public int PcOrCcCode { get; set; }

        [StringLength(25)]
        public string ShortMonthName { get; set; }

        [StringLength(255)]
        public string MonthName { get; set; }

        public long FiscalYearMonthCode { get; set; }

        [StringLength(25)]
        public string ShortYearName { get; set; }

        [StringLength(255)]
        public string YearName { get; set; }

        [StringLength(25)]
        public string ShortPcOrCCName { get; set; }

        [StringLength(255)]
        public string PcOrCCName { get; set; }

        [StringLength(25)]
        public string ShortCompanyOrOrganizationCode { get; set; }

        [StringLength(25)]
        public string ShortCompanyOrOrganizationName { get; set; }

        [StringLength(255)]
        public string CompanyOrOrganizationName { get; set; }

        public int CompanyOrOrganizationCode { get; set; }

        [StringLength(25)]
        public string ShortDocName { get; set; }

        [StringLength(255)]
        public string YearDocName { get; set; }

        public int? DocumentOfStatementCode { get; set; }

        [StringLength(25)]
        public string ShortDomainName { get; set; }

        [StringLength(255)]
        public string YearDomainName { get; set; }

        public int? DomainofStatementCode { get; set; }

        public long? DocumentOfStatementDetailCode { get; set; }

        public long? CPValue { get; set; }

        public long? LMValue { get; set; }

        public long? YTDValue { get; set; }

        public long? OpeningValue { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OrderNo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? YearMonth { get; set; }

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

        public virtual BOOrganizationCompany BOOrganizationCompany1 { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany2 { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BODocumentDetailOfStatement BODocumentDetailOfStatement { get; set; }

        public virtual BODocumentOfStatement BODocumentOfStatement { get; set; }

        public virtual BODomainOfStatement BODomainOfStatement { get; set; }

        public virtual BOFiscalYear BOFiscalYear { get; set; }

        public virtual BOFiscalYearMonth BOFiscalYearMonth { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }
    }
}

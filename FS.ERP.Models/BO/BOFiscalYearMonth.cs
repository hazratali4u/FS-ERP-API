using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("FICO.tbl_FiscalYearMonth")]
    public partial class BOFiscalYearMonth
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOFiscalYearMonth()
        {
            BOFiscalYearMonthDetail = new HashSet<BOFiscalYearMonthDetail>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        public Guid UniqueID { get; set; }

        public long BaseCode { get; set; }

        public short FiscalYearCode { get; set; }

        public int PcOrCcCode { get; set; }

        [Column(TypeName = "date")]
        public DateTime? YearMonth { get; set; }

        [StringLength(25)]
        public string ShortName { get; set; }

        public byte MonthNo { get; set; }

        [Required]
        [StringLength(255)]
        public string MonthName { get; set; }

        public bool IsOpen { get; set; }

        public bool? IsOprOpen { get; set; }

        [StringLength(255)]
        public string UnLockPWD { get; set; }

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

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOFiscalYear BOFiscalYear { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOFiscalYearMonthDetail> BOFiscalYearMonthDetail { get; set; }
    }
}

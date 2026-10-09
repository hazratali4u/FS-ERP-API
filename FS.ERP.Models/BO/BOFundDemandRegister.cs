using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("HRM.tbl_FundDemandRegister")]
    public partial class BOFundDemandRegister
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOFundDemandRegister()
        {
            BOFundDemandRegisterDetail = new HashSet<BOFundDemandRegisterDetail>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        public Guid UniqueID { get; set; }

        public long BaseCode { get; set; }

        public short FiscalYearCode { get; set; }

        [Required]
        [StringLength(50)]
        public string TransactionCode { get; set; }

        [StringLength(50)]
        public string RefNo { get; set; }

        public DateTime TransactionDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalRequestedAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalIssuedAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalUsedAmount { get; set; }

        public long? RequestedByEmpCode { get; set; }

        public long? PaidByEmpCode { get; set; }

        public byte[] SupportingDocument { get; set; }

        [StringLength(2040)]
        public string Remarks { get; set; }

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

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOFiscalYear BOFiscalYear { get; set; }

        public virtual BOEmployeeInfo BOEmployeeInfo { get; set; }

        public virtual BOEmployeeInfo BOEmployeeInfo1 { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOFundDemandRegisterDetail> BOFundDemandRegisterDetail { get; set; }
    }
}

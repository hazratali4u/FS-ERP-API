using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;
using System.Collections.Generic;

namespace FS.ERP.Models.BO{
    [Table("FICO.tbl_BankAccountInstrumentInfo")]
    public partial class BOBankAccountInstrumentInfo
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOBankAccountInstrumentInfo()
        {
            BOVendorPayment = new HashSet<BOVendorPayment>();
        }


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int BankAccountCode { get; set; }

        public byte? InstrumentTypeCode { get; set; }

        public byte InstrumentStatusCode { get; set; }

        public int? PCorCCFromCode { get; set; }

        public int? PCorCCToCode { get; set; }

        [StringLength(50)]
        public string ChequeBookNo { get; set; }

        [StringLength(50)]
        public string ChequeNo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReceivedDate { get; set; }

        [StringLength(50)]
        public string ReferenceNo { get; set; }

        [StringLength(255)]
        public string NameOfCard { get; set; }

        [Column(TypeName = "date")]
        public DateTime? IssueDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExpiryDate { get; set; }

        public bool? IsCleared { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ClearedorReturned { get; set; }

        [StringLength(512)]
        public string GroupSignature1 { get; set; }

        [StringLength(512)]
        public string GroupSignature2 { get; set; }

        [StringLength(512)]
        public string GroupSignature3 { get; set; }

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

        public virtual BOInstrumentStatus BOInstrumentStatus { get; set; }

        public virtual BOInstrumentType BOInstrumentType { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany1 { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany2 { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOBankAccount BOBankAccount { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOVendorPayment> BOVendorPayment { get; set; }



    }
}

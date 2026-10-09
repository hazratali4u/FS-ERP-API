using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("FICO.tbl_BankAccount")]
    public partial class BOBankAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOBankAccount()
        {
            BOBankAccountInstrumentInfo = new HashSet<BOBankAccountInstrumentInfo>();
        }

        public int ID { get; set; }

        public int BankBranchCode { get; set; }

        public long? COACode { get; set; }

        [StringLength(255)]
        public string AccountType { get; set; }

        [StringLength(255)]
        public string AccountNature { get; set; }

        [StringLength(510)]
        public string AccountTitle { get; set; }

        [StringLength(50)]
        public string BankAccountNo { get; set; }

        [StringLength(50)]
        public string SwiftCode { get; set; }

        [StringLength(50)]
        public string SortCode { get; set; }

        [StringLength(50)]
        public string BACS { get; set; }

        [StringLength(50)]
        public string IBAC { get; set; }

        [StringLength(50)]
        public string BIN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OpenDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CloseDate { get; set; }

        public short? CurrencyCode { get; set; }

        [StringLength(25)]
        public string OperativeType { get; set; }

        [StringLength(512)]
        public string GroupSignature1 { get; set; }

        [StringLength(512)]
        public string GroupSignature2 { get; set; }

        [StringLength(512)]
        public string GroupSignature3 { get; set; }

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

        public virtual BOCurrency BOCurrency { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOBankBranch BOBankBranch { get; set; }

        public virtual BOCOA BOCOA { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOBankAccountInstrumentInfo> BOBankAccountInstrumentInfo { get; set; }
    }
}

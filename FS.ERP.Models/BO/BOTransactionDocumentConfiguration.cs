using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("AppCNF.tbl_TransactionDocumentConfiguration")]
    public partial class BOTransactionDocumentConfiguration
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOTransactionDocumentConfiguration()
        {
            BOTransactionDocumentProcess = new HashSet<BOTransactionDocumentProcess>();
        }

        public long ID { get; set; }

        [StringLength(510)]
        public string ModuleCode { get; set; }

        public byte NoOfLevel { get; set; }

        [Required]
        [StringLength(510)]
        public string TransactionName { get; set; }

        [StringLength(11)]
        public string PreFixFixed { get; set; }

        [StringLength(11)]
        public string PreFixCustom { get; set; }

        [StringLength(11)]
        public string SufFixFixed { get; set; }

        [StringLength(11)]
        public string SufFixCustom { get; set; }

        [StringLength(11)]
        public string SerialStartFrom { get; set; }

        public bool IsFinancialYearBase { get; set; }

        public bool IsIncludeLevelCode { get; set; }

        public bool IsDelimated { get; set; }

        [StringLength(3)]
        public string DelimiterOrSplitter { get; set; }

        public bool IsActive { get; set; }

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

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOTransactionDocumentProcess> BOTransactionDocumentProcess { get; set; }
    }
}

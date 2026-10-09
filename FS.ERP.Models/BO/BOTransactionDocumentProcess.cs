using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("AppCNF.tbl_TransactionDocumentProcess")]
    public partial class BOTransactionDocumentProcess
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOTransactionDocumentProcess()
        {
            BOProcessApprovalWorkflow = new HashSet<BOProcessApprovalWorkflow>();
            BOProcessApprovalAlert = new HashSet<BOProcessApprovalAlert>();
        }

        public int ID { get; set; }

        public long TransactionDocumentConfigurationCode { get; set; }

        public int? MenuCode { get; set; }

        [StringLength(50)]
        public string BGColorClass { get; set; }

        [StringLength(50)]
        public string FGCSSClass { get; set; }

        [StringLength(50)]
        public string CSSClass { get; set; }

        [StringLength(50)]
        public string IconClass { get; set; }

        [Required]
        [StringLength(25)]
        public string ModuleCode { get; set; }

        [Required]
        [StringLength(255)]
        public string CodeName { get; set; }

        [Required]
        [StringLength(510)]
        public string NotificationTitle { get; set; }

        [StringLength(1020)]
        public string NotificationDescription { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOProcessApprovalWorkflow> BOProcessApprovalWorkflow { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOTransactionDocumentConfiguration BOTransactionDocumentConfiguration { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOProcessApprovalAlert> BOProcessApprovalAlert { get; set; }

        public virtual BOMenu BOMenu { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }
    }
}

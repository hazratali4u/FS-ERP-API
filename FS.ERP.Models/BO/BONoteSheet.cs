using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO {
    [Table("HRM.tbl_NoteSheet")]
    public partial class BONoteSheet
    {
        public BONoteSheet()
        {
            BONoteSheetRemarks = new HashSet<BONoteSheetRemarks>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        [Required]
        public string FolioNo { get; set; }
        [Required]
        public int DeptCode { get; set; }
        [Required]
        public short FiscalYearCode { get; set; }

        public int? GeneratedByCode { get; set; }

        public long? BudgetPlanCode { get; set; }

        public decimal? Amount { get; set; }

        [Required]
        public string Subject { get; set; }

        public string Description { get; set; }
        public DateTime? RequiredBefore { get; set; }
        public bool? IsApproved { get; set; }
        public DateTime? ApprovedOn { get; set; }
        public int? ApprovedBy { get; set; }
        public int CompanyCode { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        public byte RecordStatusCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BONoteSheetRemarks> BONoteSheetRemarks { get; set; }

    }
}

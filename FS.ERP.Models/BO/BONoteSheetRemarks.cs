using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO {
    [Table("HRM.tbl_NoteSheetRemarks")]
    public partial class BONoteSheetRemarks
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public long? NoteSheetCode { get; set; }
        public int? AssignedTo { get; set; }
        public string Remarks { get; set; }
        public string Description { get; set; }
        public int? RemarksBy { get; set; }
        public int CompanyCode { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        public byte RecordStatusCode { get; set; }

        public virtual BONoteSheet BONoteSheet { get; set; }

    }
}

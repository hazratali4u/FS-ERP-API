using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("FICO.tbl_PayrollCOAMapping")]
    public partial class BOPayrollCOAMapping
    {
        public int ID { get; set; }

        public bool? COABehaviour { get; set; }
        public long? COACode { get; set; }
        public int? DeptCode { get; set; }

        [StringLength(255)]
        public string COATitle { get; set; }

        [Required]
        [StringLength(510)]
        public string MapText { get; set; }

        [StringLength(1020)]
        public string Description { get; set; }

        public bool IsActive { get; set; }

        public int? CompanyCode { get; set; }

        public DateTime? dtmExported { get; set; }

        public DateTime? dtmImported { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        public byte RecordStatusCode { get; set; }

        public virtual BODepartment BODepartment { get; set; }

        public virtual BOCOA BOCOA { get; set; }

    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("HRM.tbl_WorkFromHome")]
    public partial class BOWorkFromHome
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public string FolioNo { get; set; }
        public Int16? FiscalYearCode { get; set; }
        public long EmpCode { get; set; }
        public string Description { get; set; }
        public DateTime WorkFrom { get; set; }
        public DateTime WorkTo { get; set; }
        public bool? IsApproved { get; set; }
        public long? ApprovedBy { get; set; }
        public DateTime? ApprovedOn { get; set; }
        public int CompanyCode { get; set; }
        public DateTime dtmCreated { get; set; }
        public DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }

    }
}

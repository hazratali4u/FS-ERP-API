using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{
    [Table("HRM.tbl_LeaveYearEndProcess")]
    public partial class BOLeaveYearEndProcess
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public System.Guid UniqueID { get; set; }
        public int CompanyID { get; set; }
        public long EmpCode { get; set; }
        public Nullable<byte> LeaveTypeCode { get; set; }
        public Nullable<decimal> CurrentYearLeaves { get; set; }
        public Nullable<decimal> LapsedYearLeaves { get; set; }
        public Nullable<decimal> TotalLeaves { get; set; }
        public int CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }
        public virtual BOOrganizationCompany BOOrganizationCompany1 { get; set; }
        public virtual BORecordStatus BORecordStatus { get; set; }
        public virtual BOEmployeeInfo BOEmployeeInfo { get; set; }
        public virtual BOLeaveType BOLeaveType { get; set; }
    }
}

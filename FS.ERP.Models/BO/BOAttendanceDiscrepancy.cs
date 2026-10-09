using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("HRM.tbl_AttendanceDiscrepancy")]
    public partial class BOAttendanceDiscrepancy
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long ID { get; set; }
        public System.Guid UniqueID { get; set; }
        public byte DiscrepancyType { get; set; }
        public byte ActualDiscrepancyType { get; set; }
        public long EmpCode { get; set; }
        public short ShiftCode { get; set; }
        public short FiscalYearCode { get; set; }
        public Nullable<short> AttendanceMachineCode { get; set; }
        public Nullable<System.DateTime> ApplyDate { get; set; }
        public Nullable<System.DateTime> AttendanceDate { get; set; }
        public string Reason { get; set; }
        public Nullable<System.DateTime> AttendanceTimeIn { get; set; }
        public Nullable<System.DateTime> AttendanceTimeOut { get; set; }
        public Nullable<bool> IsApproved { get; set; }
        public Nullable<System.DateTime> ApprovedDate { get; set; }
        public string Remarks { get; set; }
        public int CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }

        public virtual BOAttendanceMachineType BOAttendanceMachineType { get; set; }

        public virtual BODiscrepancyType BODiscrepancyType { get; set; }

        public virtual BODiscrepancyType BODiscrepancyType1 { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOFiscalYear BOFiscalYear { get; set; }

        public virtual BOEmployeeInfo BOEmployeeInfo { get; set; }

        public virtual BOShift BOShift { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }
    }
}

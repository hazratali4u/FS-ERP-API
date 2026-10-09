using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("HRM.tbl_EmployeeAttendance")]
    public partial class BOEmployeeAttendance
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long ID { get; set; }
        public System.Guid UniqueID { get; set; }
        public long EmpCode { get; set; }
        public short ShiftCode { get; set; }
        public short FiscalYearCode { get; set; }
        public Nullable<short> AttendanceMachineCode { get; set; }
        public Nullable<System.DateTime> AttendanceTimeIn { get; set; }
        public Nullable<System.DateTime> AttendanceTimeOut { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public int CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }
        public Nullable<int> CalendarCode { get; set; }
        public string IdentificationType { get; set; }
        public Nullable<bool> AttendanceType { get; set; }

        public virtual BOAttendanceMachineType BOAttendanceMachineType { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOFiscalYear BOFiscalYear { get; set; }

        public virtual BOEmployeeInfo BOEmployeeInfo { get; set; }

        public virtual BOShift BOShift { get; set; }

        public virtual BOCalendar BOCalendar { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }
    }
}

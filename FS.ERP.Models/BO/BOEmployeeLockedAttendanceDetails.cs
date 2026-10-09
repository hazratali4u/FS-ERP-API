using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{
    [Table("HRM.tbl_EmployeeLockedAttendanceDetails")]
    public partial class BOEmployeeLockedAttendanceDetails
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public Nullable<System.DateTime> AttendanceDate { get; set; }
        public long EmpCode { get; set; }
        public Nullable<short> ShiftCode { get; set; }
        public Nullable<long> ShiftMinutes { get; set; }
        public Nullable<System.DateTime> CheckIn { get; set; }
        public Nullable<System.DateTime> CheckOut { get; set; }
        public Nullable<decimal> BreakHours { get; set; }
        public Nullable<decimal> TotalHours { get; set; }
        public Nullable<decimal> WorkingHours { get; set; }
        public Nullable<decimal> LabourDailyPay { get; set; }
        public Nullable<decimal> EarnedPay { get; set; }
        public Nullable<byte> OverTimeTypeCode { get; set; }
        public Nullable<decimal> OTDuration { get; set; }
        public Nullable<decimal> OTAmount { get; set; }
        public Nullable<bool> IsManualShortHours { get; set; }
        public Nullable<decimal> ShortHours { get; set; }
        public Nullable<decimal> ShortHoursDeduction { get; set; }
        public string Remarks { get; set; }
        public Nullable<decimal> NightAllowance { get; set; }
        public Nullable<bool> IsAbsent { get; set; }
        public Nullable<bool> IsOffDay { get; set; }
        public Nullable<bool> IsPublicHoliday { get; set; }
        public string Status { get; set; }
        public Nullable<bool> IsLocked { get; set; }
        public Nullable<bool> IsOnLeave { get; set; }
        public Nullable<byte> LeaveTypeCode { get; set; }
        public Nullable<bool> IsHalfLeave { get; set; }
        public int CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }


        public virtual BOEmployeeInfo BOEmployeeInfo { get; set; }
        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }
        public virtual BORecordStatus BORecordStatus { get; set; }
        public virtual BOUser BOUser { get; set; }
        public virtual BOUser BOUser1 { get; set; }
        public virtual BOUser BOUser2 { get; set; }
    }
}

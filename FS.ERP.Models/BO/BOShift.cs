using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("HRM.tbl_Shift")]
    public partial class BOShift
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOShift()
        {
            BODutyRoster = new HashSet<BODutyRoster>();
            BOAttendanceDiscrepancy = new HashSet<BOAttendanceDiscrepancy>();
            BOEmployeeAttendance = new HashSet<BOEmployeeAttendance>();
            BOEmployeeInfo = new HashSet<BOEmployeeInfo>();
            BOEmployeeHistory = new HashSet<BOEmployeeHistory>();
            BOEmployeeSalary = new HashSet<BOEmployeeSalary>();
            BOLeaveDeductionAgainstLate = new HashSet<BOLeaveDeductionAgainstLate>();
            BOShiftDay = new HashSet<BOShiftDay>();
            BOShiftOverTimeCriteria = new HashSet<BOShiftOverTimeCriteria>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public short ID { get; set; }
        public string ShiftName { get; set; }
        public string DisplayName { get; set; }
        public string ShiftCode { get; set; }
        public System.TimeSpan ShiftStartTime { get; set; }
        public System.TimeSpan ShiftEndTime { get; set; }
        public Nullable<decimal> ShiftInMinutes { get; set; }
        public Nullable<decimal> TotalPaidRestDays { get; set; }
        public Nullable<decimal> OTRatio { get; set; }
        public Nullable<decimal> OTAmount { get; set; }
        public Nullable<decimal> OTThresholdInMinutes { get; set; }
        public string OffDay1 { get; set; }
        public Nullable<bool> IsAlternateOffDay2 { get; set; }
        public string OffDay2 { get; set; }
        public bool IsNightShift { get; set; }
        public bool IsTemporaryShift { get; set; }
        public Nullable<System.DateTime> TempShiftStartDate { get; set; }
        public Nullable<System.DateTime> TempShiftEndDate { get; set; }
        public System.TimeSpan? ShiftPreGraceStart { get; set; }
        public System.TimeSpan? ShiftPostGraceStart { get; set; }
        public System.TimeSpan? ShiftPreGraceEnd { get; set; }
        public System.TimeSpan? ShiftPostGraceEnd { get; set; }
        public Nullable<byte> MaxLateInAllowedPerMonth { get; set; }
        public Nullable<byte> MaxEarlyLeftAllowedPerMonth { get; set; }
        public System.TimeSpan MarkLateTimeIn { get; set; }
        public System.TimeSpan MarkEarlyTimeOut { get; set; }
        public System.TimeSpan MarkHalfDayTimeIn { get; set; }
        public System.TimeSpan MarkHalfDayTimeOut { get; set; }
        public System.TimeSpan MarkAbsentTimeIn { get; set; }
        public System.TimeSpan MarkAbsentTimeOut { get; set; }
        public System.TimeSpan MarkEarlyOutWHLess { get; set; }
        public System.TimeSpan MarkHalfDayWHLess { get; set; }
        public System.TimeSpan MarkHalfDayBHGreater { get; set; }
        public System.TimeSpan MarkAbsentWHLess { get; set; }
        public System.TimeSpan MarkAbsentBHGreater { get; set; }
        public bool? CanbeStartedAnytime { get; set; }
        public bool? CheckInOutMissingFullDay { get; set; }
        public bool CalculateWHEmployeeTimeIn { get; set; }
        public bool DeductBreakHoursfromWH { get; set; }
        public bool DeductBreakHoursfromOT { get; set; }
        public Nullable<bool> IsRestDaysAllowed { get; set; }
        public bool? IsOvertimeEnabled { get; set; }
        public string ShiftDescription { get; set; }
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

        public virtual BORecordStatus BORecordStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOAttendanceDiscrepancy> BOAttendanceDiscrepancy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeAttendance> BOEmployeeAttendance { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeInfo> BOEmployeeInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeHistory> BOEmployeeHistory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeSalary> BOEmployeeSalary { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOLeaveDeductionAgainstLate> BOLeaveDeductionAgainstLate { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOShiftDay> BOShiftDay { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOShiftOverTimeCriteria> BOShiftOverTimeCriteria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BODutyRoster> BODutyRoster { get; set; }
    }
}

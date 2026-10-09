using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("HRM.tbl_ShiftDay")]
    public partial class BOShiftDay
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        public short ShiftCode { get; set; }
        public string DayName { get; set; }
        public Nullable<System.TimeSpan> MidShift { get; set; }
        public int CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }
        public Nullable<bool> IsBreakType { get; set; }
        public Nullable<decimal> BreakHours { get; set; }
        public Nullable<System.TimeSpan> BreakStart1 { get; set; }
        public Nullable<System.TimeSpan> BreakEnd1 { get; set; }
        public Nullable<System.TimeSpan> BreakStart2 { get; set; }
        public Nullable<System.TimeSpan> BreakEnd2 { get; set; }
        public Nullable<System.TimeSpan> BreakStart3 { get; set; }
        public Nullable<System.TimeSpan> BreakEnd3 { get; set; }
        public Nullable<System.TimeSpan> BreakStart4 { get; set; }
        public Nullable<System.TimeSpan> BreakEnd4 { get; set; }

        public Nullable<System.TimeSpan> ShiftStartTime { get; set; }
        public Nullable<System.TimeSpan> ShiftEndTime { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOShift BOShift { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }
    }
}

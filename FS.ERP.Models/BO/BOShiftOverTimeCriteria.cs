using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{
    [Table("HRM.tbl_ShiftOverTimeCriteria")]
    public partial class BOShiftOverTimeCriteria
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long ID { get; set; }
        public short ShiftCode { get; set; }
        public byte DayTypeCode { get; set; }
        public System.TimeSpan EligibleOTTimeOutAfter { get; set; }
        public System.TimeSpan EligibleOTTimeInBefore { get; set; }
        public System.TimeSpan EligibleOTTimeOutAfterWH { get; set; }
        public System.TimeSpan EligibleOTTimeInBeforeWH { get; set; }
        public System.TimeSpan OTNotApplicable { get; set; }
        public System.TimeSpan OTAutoApproval { get; set; }
        public Nullable<bool> IsOnTimeCalculateOT { get; set; }
        public Nullable<bool> IsLateInCalculateOT { get; set; }
        public Nullable<bool> IsEarlyOutCalculateOT { get; set; }
        public Nullable<bool> IsHalfDayCalculateOT { get; set; }
        public Nullable<bool> IsTimeInCalculateOT { get; set; }
        public Nullable<System.TimeSpan> EntitledOTPolicyTOAfter { get; set; }
        public Nullable<System.TimeSpan> EntitledOTPolicyWHGreater { get; set; }
        public string OverTimeDescription { get; set; }
        public int CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }

        public virtual BOOverTimeType BOOverTimeType { get; set; }
        public virtual BOShift BOShift { get; set; }
        public virtual BOUser BOUser { get; set; }
        public virtual BOUser BOUser1 { get; set; }
        public virtual BOUser BOUser2 { get; set; }
    }
}

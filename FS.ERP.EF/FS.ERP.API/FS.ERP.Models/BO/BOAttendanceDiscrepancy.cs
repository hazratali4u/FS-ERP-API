using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("HRM.tbl_AttendanceDiscrepancy")]
    public partial class BOAttendanceDiscrepancy
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public Guid UniqueID { get; set; }

        public byte DiscrepancyType { get; set; }

        public byte ActualDiscrepancyType { get; set; }

        public long EmpCode { get; set; }

        public short ShiftCode { get; set; }

        public short FiscalYearCode { get; set; }

        public short? AttendanceMachineCode { get; set; }

        public DateTime? ApplyDate { get; set; }

        public DateTime? AttendanceDate { get; set; }

        public string Reason { get; set; }

        public DateTime? ActualAttendanceTimeIn { get; set; }

        public DateTime? AttendanceTimeIn { get; set; }

        public DateTime? AttendanceTimeOut { get; set; }

        public DateTime? ActualAttendanceTimeOut { get; set; }

        public bool? IsApproved { get; set; }

        public DateTime? ApprovedDate { get; set; }

        [StringLength(2040)]
        public string Remarks { get; set; }

        public int CompanyCode { get; set; }

        public DateTime? dtmExported { get; set; }

        public DateTime? dtmImported { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

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

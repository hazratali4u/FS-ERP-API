using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("HRM.tbl_EmployeeLeave")]
    public partial class BOEmployeeLeave
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public System.Guid UniqueID { get; set; }
        public Int16 FiscalYearCode { get; set; }
        public Nullable<bool> IsApproved { get; set; }
        public string ReferenceNumber { get; set; }
        public long EmpCode { get; set; }
        public string ManualReferenceNumber { get; set; }
        public byte LeaveTypeCode { get; set; }
        public System.DateTime LeaveFrom { get; set; }
        public System.DateTime LeaveTo { get; set; }
        public string NoOfLeaves { get; set; }
        public string Remarks { get; set; }
        public Nullable<System.DateTime> ApplyOn { get; set; }
        public Nullable<short> LeavePolicyCode { get; set; }
        public Nullable<long> ApprovedBy { get; set; }
        public Nullable<System.DateTime> ApprovedOn { get; set; }
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

        //public virtual BOFiscalYear BOFiscalYear { get; set; }

        public virtual BOEmployeeInfo BOEmployeeInfo { get; set; }
        public virtual BOEmployeeInfo BOEmployeeInfo1 { get; set; }

        public virtual BOLeavePolicy BOLeavePolicy { get; set; }

        public virtual BOLeaveType BOLeaveType { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }
    }
}

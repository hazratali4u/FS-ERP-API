using FS.ERP.Models.IdentityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.Models.BO
{

    [Table("HRM.tbl_EmployeeOvertimeProcess")]
    public class BOEmployeeOvertimeProcess
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public Nullable<short> BaseCode { get; set; }
        public long EmpCode { get; set; }
        public Nullable<System.DateTime> CheckIn { get; set; }
        public Nullable<System.DateTime> CheckOut { get; set; }
        public Nullable<System.DateTime> BreakHours { get; set; }
        public Nullable<decimal> WorkingHours { get; set; }
        public Nullable<decimal> LabourDailyPay { get; set; }
        public Nullable<byte> OverTimeTypeCode { get; set; }
        public Nullable<decimal> OTDuration { get; set; }
        public Nullable<decimal> OTAmount { get; set; }
        public Nullable<decimal> NightAllowance { get; set; }
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
        public virtual BOOverTimeType BOOverTimeType { get; set; }
        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }
        public virtual BORecordStatus BORecordStatus { get; set; }
        public virtual BOUser BOUser { get; set; }
        public virtual BOUser BOUser1 { get; set; }
        public virtual BOUser BOUser2 { get; set; }

    }
}

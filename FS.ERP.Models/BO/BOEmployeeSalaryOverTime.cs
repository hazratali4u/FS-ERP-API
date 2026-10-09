using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.Models.BO
{
    [Table("HRM.tbl_EmployeeSalaryOverTime")]
    public class BOEmployeeSalaryOverTime
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public System.Guid UniqueID { get; set; }
        public long EmpCode { get; set; }
        public long EmpSalaryCode { get; set; }
        public long EmpOverTimeCode { get; set; }
        public Nullable<decimal> TotalHours { get; set; }
        public Nullable<decimal> WorkedHours { get; set; }
        public decimal OverTimeHours { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public int CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }

        public virtual BOEmployeeOverTime BOEmployeeOverTime { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.Models.BO
{
    [Table("HRM.tbl_EmployeeOverTime")]
    public class BOEmployeeOverTime
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOEmployeeOverTime()
        {
            this.BOEmployeeSalaryOverTime = new HashSet<BOEmployeeSalaryOverTime>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public byte OverTimeTypeCode { get; set; }
        public Nullable<int> CostOrProfitCenterCode { get; set; }
        public Nullable<int> DeptCode { get; set; }
        public Nullable<long> EmpCode { get; set; }
        public byte SortOrder { get; set; }
        public Nullable<int> CalendarCode { get; set; }
        public Nullable<decimal> AllowanceOrBenefitAmount { get; set; }
        public Nullable<decimal> AllowanceOrBenefitRatio { get; set; }
        public Nullable<long> COACode { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string Description { get; set; }
        public Nullable<int> CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeSalaryOverTime> BOEmployeeSalaryOverTime { get; set; }
    }
}

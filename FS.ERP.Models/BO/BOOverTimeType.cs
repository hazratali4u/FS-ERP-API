using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.Models.BO
{
    [Table("HRM.tbl_OverTimeType")]
    public class BOOverTimeType
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOOverTimeType()
        {
            BOEmployeeOvertimeProcess = new HashSet<BOEmployeeOvertimeProcess>();
            BOShiftOverTimeCriteria = new HashSet<BOShiftOverTimeCriteria>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte ID { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public string DisplayName { get; set; }
        public byte SortOrder { get; set; }
        public Nullable<int> CalendarCode { get; set; }
        public bool IsTaxable { get; set; }
        public bool IsTaxableFromSalary { get; set; }
        public Nullable<decimal> TaxPercentage { get; set; }
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
        public virtual ICollection<BOShiftOverTimeCriteria> BOShiftOverTimeCriteria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeOvertimeProcess> BOEmployeeOvertimeProcess { get; set; }

        

    }
}

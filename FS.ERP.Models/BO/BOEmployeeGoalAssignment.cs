using FS.ERP.Models.IdentityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.Models.BO
{
    [Table("HRM.tbl_EmployeeGoalAssignment")]
    public class BOEmployeeGoalAssignment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int GoalCode { get; set; }
        public Nullable<long> GoalAssignedTo { get; set; }
        public Nullable<long> GoalAssignedBy { get; set; }
        public Nullable<System.DateTime> GoalStartDate { get; set; }
        public Nullable<System.DateTime> GoalDueDate { get; set; }
        public string GoalStatus { get; set; }
        public Nullable<int> GoalCompletionPercentage { get; set; }
        public Nullable<short> FiscalYearCode { get; set; }
        public Nullable<int> CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }

        public virtual BOPerformanceGoal BOPerformanceGoal { get; set; }
        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }
        public virtual BORecordStatus BORecordStatus { get; set; }
        public virtual BOUser BOUser { get; set; }
        public virtual BOUser BOUser1 { get; set; }
        public virtual BOUser BOUser2 { get; set; }
    }
}

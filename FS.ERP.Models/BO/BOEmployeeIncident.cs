using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{
    [Table("HRM.tbl_EmployeeIncident")]

    public partial class BOEmployeeIncident
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long ID { get; set; }
        public long EmpCode { get; set; }
        public long IncidentCode { get; set; }
        public System.DateTime IncidentDate { get; set; }
        public string IncidentCause { get; set; }
        public string ActionTaken { get; set; }
        public System.DateTime ActionDate { get; set; }
        public Nullable<bool> IsWarningIssued { get; set; }
        public string IncidentDetails { get; set; }
        public string Remarks { get; set; }
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
        public virtual BOIncidentType BOIncidentType { get; set; }
        public virtual BOUser BOUser { get; set; }
        public virtual BOUser BOUser1 { get; set; }
        public virtual BOUser BOUser2 { get; set; }
    }
}

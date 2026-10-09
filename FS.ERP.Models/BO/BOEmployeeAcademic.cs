using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("HRM.tbl_EmployeeAcademic")]
    public partial class BOEmployeeAcademic
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long ID { get; set; }
        public System.Guid UniqueID { get; set; }
        public long EmpCode { get; set; }
        public int DegreeCode { get; set; }
        public string MajorSubjects { get; set; }
        public Nullable<int> DegreeInstituteCode { get; set; }
        public Nullable<System.DateTime> StartFrom { get; set; }
        public Nullable<System.DateTime> EndTo { get; set; }
        public Nullable<System.DateTime> PassingYear { get; set; }
        public string GradeOrDivision { get; set; }
        public string CGPA { get; set; }
        public string Marks { get; set; }
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
        public string SpecializationOrSubject { get; set; }


        public virtual BOEmployeeInfo BOEmployeeInfo { get; set; }
        public virtual BODegree BODegree { get; set; }
        public virtual BODegreeInstitute BODegreeInstitute { get; set; }
        public virtual BOUser BOUser { get; set; }
        public virtual BOUser BOUser1 { get; set; }
        public virtual BOUser BOUser2 { get; set; }
        public virtual BORecordStatus BORecordStatus { get; set; }
        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("HRM.tbl_EmployeeFamily")]
    public partial class BOEmployeeFamily
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long ID { get; set; }
        public System.Guid UniqueID { get; set; }
        public long EmpCode { get; set; }
        public byte RelationCode { get; set; }
        public string Occupation { get; set; }
        public string CNICNo { get; set; }
        public string BloodGroup { get; set; }
        public Nullable<decimal> Age { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public Nullable<System.DateTime> DOM { get; set; }
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
        public Nullable<bool> IsDependent { get; set; }
        public string PassportNo { get; set; }
        public Nullable<System.DateTime> PassportExpiryDate { get; set; }
        public string FamilyPersonName { get; set; }
        public string PhoneNo { get; set; }
        public Nullable<System.DateTime> VisaSponsorshipExpiryDate { get; set; }
        public Nullable<bool> IsNominee { get; set; }
        public Nullable<bool> IsCoveredUnderMedicalPolicy { get; set; }


        public virtual BOEmployeeInfo BOEmployeeInfo { get; set; }
        public virtual BOUser BOUser { get; set; }
        public virtual BOUser BOUser1 { get; set; }
        public virtual BOUser BOUser2 { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }
        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }
        public virtual BOEmployeeRelation BOEmployeeRelation { get; set; }
    }
}

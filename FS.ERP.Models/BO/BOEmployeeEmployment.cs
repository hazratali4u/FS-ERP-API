using FS.ERP.Models.IdentityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FS.ERP.Models.BO
{
   
    [Table("HRM.tbl_EmployeeEmployment")]
    public partial class BOEmployeeEmployment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long ID { get; set; }
        public System.Guid UniqueID { get; set; }
        public long EmpCode { get; set; }
        public string OrganizationName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string URL { get; set; }
        public string PositionOrTitle { get; set; }
        public decimal BasicPay { get; set; }
        public Nullable<System.DateTime> StartFrom { get; set; }
        public Nullable<System.DateTime> EndTo { get; set; }
        public string EntitledBenifits { get; set; }
        public string ReasonforLeaving { get; set; }
        public int CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }
        public string KeyResponsibilities { get; set; }


        public virtual BOEmployeeInfo BOEmployeeInfo { get; set; }
        public virtual BOUser BOUser { get; set; }
        public virtual BOUser BOUser1 { get; set; }
        public virtual BOUser BOUser2 { get; set; }
        public virtual BORecordStatus BORecordStatus { get; set; }
        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }
    }
}

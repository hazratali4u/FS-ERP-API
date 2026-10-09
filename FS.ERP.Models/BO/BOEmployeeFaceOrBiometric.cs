using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("HRM.tbl_EmployeeFaceOrBiometric")]
    public partial class BOEmployeeFaceOrBiometric
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        public long EmpCode { get; set; }

        public byte[] Face1 { get; set; }

        public byte[] Face2 { get; set; }

        public byte[] Face3 { get; set; }

        public byte[] Biometric1 { get; set; }

        public byte[] Biometric2 { get; set; }

        public byte[] Biometric3 { get; set; }

        public byte[] Biometric4 { get; set; }

        public byte[] Biometric5 { get; set; }

        public bool IsFace { get; set; }

        public bool IsLeftHand { get; set; }

        [StringLength(50)]
        public string BiometricType { get; set; }

        [StringLength(1020)]
        public string Description { get; set; }

        public int CompanyCode { get; set; }

        public DateTime? dtmExported { get; set; }

        public DateTime? dtmImported { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        public byte RecordStatusCode { get; set; }

        public string AccessCode { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOEmployeeInfo BOEmployeeInfo { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }
    }
}

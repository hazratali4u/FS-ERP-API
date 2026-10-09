using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("AuditLog.tbl_LoggingInformation")]
    public partial class BOLoggingInformation
    {
        public long ID { get; set; }

        [StringLength(255)]
        public string DatabaseName { get; set; }

        [Required]
        [StringLength(255)]
        public string LoginUserName { get; set; }

        [StringLength(25)]
        public string SessionIDOrPinCode { get; set; }

        public int LoginUserCode { get; set; }

        public DateTime? LoginDateTime { get; set; }

        public DateTime? LogoutDateTime { get; set; }

        public bool? IsLogIn { get; set; }

        [StringLength(50)]
        public string MacAddress { get; set; }

        [StringLength(50)]
        public string WMacAddress { get; set; }

        [Required]
        [StringLength(25)]
        public string LocalIP { get; set; }

        [StringLength(25)]
        public string LiveIP { get; set; }

        [StringLength(50)]
        public string LogStatus { get; set; }

        [StringLength(255)]
        public string SysName { get; set; }

        [StringLength(1020)]
        public string WebAddress { get; set; }

        public int CompanyCode { get; set; }

        public DateTime? dtmExported { get; set; }

        public DateTime? dtmImported { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        public byte RecordStatusCode { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("AuditLog.tbl_CRMDataLogging")]
    public partial class BOCRMDataLogging
    {
        public long ID { get; set; }

        public Guid UniqueID { get; set; }

        public int? MenuCode { get; set; }

        public long? ActionPK { get; set; }

        [StringLength(255)]
        public string ApplicationVersion { get; set; }

        [StringLength(255)]
        public string TblName { get; set; }

        [StringLength(255)]
        public string FormName { get; set; }

        [StringLength(255)]
        public string FunctionName { get; set; }

        public string SQLStatement { get; set; }

        public string LogDatainTxt { get; set; }

        [Column(TypeName = "xml")]
        public string LogDatainXML { get; set; }

        [StringLength(25)]
        public string ActionType { get; set; }

        public bool? ActionStatus { get; set; }

        [StringLength(1020)]
        public string ActionMessage { get; set; }

        [StringLength(50)]
        public string ServerName { get; set; }

        [StringLength(50)]
        public string SystemName { get; set; }

        [StringLength(50)]
        public string IPAddress { get; set; }

        [StringLength(50)]
        public string MacAddress { get; set; }

        public DateTime ActionDateTime { get; set; }

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

        public virtual BOMenu BOMenu { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }
    }
}

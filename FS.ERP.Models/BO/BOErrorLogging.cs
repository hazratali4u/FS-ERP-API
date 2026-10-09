using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("AuditLog.tbl_ErrorLogging")]
    public partial class BOErrorLogging
    {
        public long ID { get; set; }

        public long BaseCode { get; set; }

        public long? ErrorPK { get; set; }

        public int? MenuCode { get; set; }

        [StringLength(255)]
        public string ApplicationVersion { get; set; }

        [StringLength(255)]
        public string TblName { get; set; }

        [StringLength(255)]
        public string FormName { get; set; }

        [StringLength(255)]
        public string FunctionName { get; set; }

        public int? ErrorNumber { get; set; }

        public int? ErrorSeverity { get; set; }

        public int? ErrorState { get; set; }

        public int? ErrorLine { get; set; }

        [StringLength(125)]
        public string ErrorProcedure { get; set; }

        public string FunctionInfo { get; set; }

        public string ErrorTrace { get; set; }

        public string ErrorDetail { get; set; }

        public string ErrorType { get; set; }

        public string ErrorSource { get; set; }

        public string InnerException { get; set; }

        [StringLength(255)]
        public string ErrorStatus { get; set; }

        [StringLength(50)]
        public string ServerName { get; set; }

        [StringLength(50)]
        public string SystemName { get; set; }

        [StringLength(50)]
        public string IPAddress { get; set; }

        [StringLength(50)]
        public string MacAddress { get; set; }

        public DateTime ErrorDateTime { get; set; }

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

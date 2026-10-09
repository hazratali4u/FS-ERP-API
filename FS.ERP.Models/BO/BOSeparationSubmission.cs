using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{
    [Table("HRM.tbl_SeparationSubmission")]
    public partial class BOSeparationSubmission
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key]
        public int ID { get; set; }
        public long EmpCode { get; set; }
        public Nullable<bool> IsApproved { get; set; }
        public Nullable<long> ApprovedBy { get; set; }
        public Nullable<System.DateTime> ApprovedOn { get; set; }
        public Nullable<bool> IsBlackList { get; set; }
        public string BlackListRemarks { get; set; }
        public string ManagementComments { get; set; }
        public int? ExitTypeCode { get; set; }
        public int? ExitReasonCode { get; set; }
        public System.DateTime ResignationSubmissionDate { get; set; }
        public decimal NoticePeriod { get; set; }
        public System.DateTime LastWorkingDate { get; set; }
        public string Comments { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public string DocSource { get; set; }
        public string DocDetails { get; set; }
        public int CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }
        public virtual BORecordStatus BORecordStatus { get; set; }
        public virtual BOEmployeeInfo BOEmployeeInfo { get; set; }
        public virtual BOEmployeeInfo BOEmployeeInfo1 { get; set; }
        public virtual BOSeparationTypeOrReason BOSeparationTypeOrReason { get; set; }
        public virtual BOSeparationTypeOrReason BOSeparationTypeOrReason1 { get; set; }
    }
}

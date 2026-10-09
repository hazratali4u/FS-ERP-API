using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{
    [Table("AppCNF.tbl_SMSOrEmailDescription")]
    public class BOSMSOrEmailDescription
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public int MenuCode { get; set; }
        public Nullable<long> OperationCode { get; set; }
        public Nullable<bool> IsSMSEnable { get; set; }
        public Nullable<bool> IsEmailEnable { get; set; }
        public string SMSDescription { get; set; }
        public string EmailDescription { get; set; }
        public Nullable<int> LocationSiteCode { get; set; }
        public int CompanyCode1 { get; set; }
        public int CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }

        public virtual BOSMSOrEmailOperationsOrBehaviour BOSMSOrEmailOperationsOrBehaviour { get; set; }
        public virtual BOMenu BOMenu { get; set; }
        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }
        public virtual BORecordStatus BORecordStatus { get; set; }
        public virtual BOUser BOUser { get; set; }
        public virtual BOUser BOUser1 { get; set; }
        public virtual BOUser BOUser2 { get; set; }
    }
}

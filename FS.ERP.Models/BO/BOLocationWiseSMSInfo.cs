using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{
    [Table("AppCNF.tbl_LocationWiseSMSInfo")]
    public class BOLocationWiseSMSInfo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public System.Guid UniqueID { get; set; }
        public int LocationSiteCode { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PIN { get; set; }
        public string SMSAPIURL { get; set; }
        public string SMSInfoURL { get; set; }
        public string EmailUsername { get; set; }
        public string EmailPWD { get; set; }
        public string EmailURL { get; set; }
        public Nullable<long> EmailPort { get; set; }
        public string EmailFrom { get; set; }
        public string EmailReply { get; set; }
        public string EmailProtocol { get; set; }
        public string Mask1 { get; set; }
        public string Mask2 { get; set; }
        public string Mask3 { get; set; }
        public Nullable<bool> ISMSEnableForBilling { get; set; }
        public string Description { get; set; }
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
        public virtual BOUser BOUser { get; set; }
        public virtual BOUser BOUser1 { get; set; }
        public virtual BOUser BOUser2 { get; set; }
    }
}

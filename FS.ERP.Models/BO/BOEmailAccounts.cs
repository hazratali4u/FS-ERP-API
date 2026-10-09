using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{
    [Table("CRM.tbl_EmailAccounts")]
    public class BOEmailAccounts
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string EmailAddress { get; set; }
        public string EmailPassword { get; set; }
        public string APIKey { get; set; }
        public string SMTPOrIP { get; set; }
        public string APIUsername { get; set; }
        public string APIPassword { get; set; }
        public string Port { get; set; }
        public string DisplayName { get; set; }
        public Nullable<long> DailySendingLimit { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int? CompanyCode { get; set; }
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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{
    [Table("CORN.tbl_CafeOrRestaurantConfiguration")]
    public partial class BOCafeOrRestaurantConfiguration
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public Nullable<System.Guid> UniqueID { get; set; }
        public Nullable<int> LocationSiteCode { get; set; }
        public Nullable<bool> IsDeliverySMS { get; set; }
        public Nullable<bool> IsTakeAwaySMS { get; set; }
        public Nullable<bool> IsDayCloseSMS { get; set; }
        public Nullable<bool> IsRegistered { get; set; }
        public Nullable<bool> IsCoverTable { get; set; }
        public Nullable<bool> IsServiceCharges { get; set; }
        public Nullable<bool> DefaultBehaviour { get; set; }
        public Nullable<bool> DineInKOT { get; set; }
        public Nullable<bool> DeliveryKOT { get; set; }
        public Nullable<bool> TakeAwayKOT { get; set; }
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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{
    [Table("IMM.tbl_LocationSiteWiseItem")]
    public partial class BOLocationSiteWiseItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public System.Guid UniqueID { get; set; }
        public int LocationSiteCode { get; set; }
        public Nullable<long> ItemCode { get; set; }
        public Nullable<long> ItemProfileCode { get; set; }
        public Nullable<short> EquipmentTypeCode { get; set; }
        public int CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }

        public virtual BOLocationSite BOLocationSite { get; set; }
        public virtual BOItem BOItem { get; set; }
        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }
        public virtual BORecordStatus BORecordStatus { get; set; }
        public virtual BOUser BOUser { get; set; }
        public virtual BOUser BOUser1 { get; set; }
        public virtual BOUser BOUser2 { get; set; }
    }
}

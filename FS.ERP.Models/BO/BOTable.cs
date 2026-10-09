using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{
    [Table("POS.tbl_Table")]
    public partial class BOTable
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short ID { get; set; }
        public int PcOrCcCode { get; set; }
        public int LocationSiteCode { get; set; }
        public int HallCode { get; set; }
        public byte TableTypeCode { get; set; }
        public string TableNo { get; set; }
        public string TableAbbrivation { get; set; }
        public Nullable<short> SeatingCapacity { get; set; }
        public short SortOrder { get; set; }
        public string Description { get; set; }
        public Nullable<int> CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }
    
        public virtual BOPOSTableType BOPOSTableType { get; set; }
        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }
        public virtual BOLocationSite BOLocationSite { get; set; }
        public virtual BOLocationSite BOLocationSite1 { get; set; }

    }
}

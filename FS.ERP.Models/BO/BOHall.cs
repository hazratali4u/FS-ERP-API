using FS.ERP.Models.IdentityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.Models.BO
{
    [Table("POS.tbl_Hall")]
    public partial class BOHall
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short ID { get; set; }
        public int LocationSiteCode { get; set; }
        public string HallName { get; set; }
        public Nullable<int> CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }

        public virtual BOLocationSite BOLocationSite { get; set; }
    }
}

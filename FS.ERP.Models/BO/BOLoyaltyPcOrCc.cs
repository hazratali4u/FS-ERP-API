using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.Models.BO
{
    [Table("IMM.tbl_LoyaltyPcOrCc")]
    public class BOLoyaltyPcOrCc
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public System.Guid UniqueID { get; set; }
        public byte LoyaltyTypeCode { get; set; }
        public Nullable<int> PcOrCcCode { get; set; }
        public Nullable<int> LocationSiteCode { get; set; }
        public Nullable<short> MaxVisit { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> PointGain { get; set; }
        public Nullable<decimal> Purchasing { get; set; }
        public Nullable<decimal> AmountLimit { get; set; }
        public int CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }

        //public virtual BOLoyaltyCard BOLoyaltyCard { get; set; }
        public virtual BOIMMLoyaltyType BOIMMLoyaltyType { get; set; }
    }
}

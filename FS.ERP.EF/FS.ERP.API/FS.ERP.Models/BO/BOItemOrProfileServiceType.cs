using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.Models.BO
{
    [Table("IMM.tbl_ItemOrProfileServiceType")]
    public class BOItemOrProfileServiceType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOItemOrProfileServiceType()
        {
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }
        public long ItemCode { get; set; }
        public long ItemProfileCode { get; set; }
        public short ServiceTypeCode { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }
        public virtual BOServiceType BOServiceType { get; set; }
        public virtual BOItem BOItem { get; set; }
    }
}

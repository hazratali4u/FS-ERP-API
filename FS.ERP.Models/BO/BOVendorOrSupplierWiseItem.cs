using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.Models.BO
{
    [Table("SRM.tbl_VendorOrSupplierWiseItem")]
    public class BOVendorOrSupplierWiseItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public System.Guid UniqueID { get; set; }
        public long VendorOrSupplierCode { get; set; }
        public long ItemCode { get; set; }
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

        public virtual BOItem BOItem { get; set; }
        public virtual BOItemProfile BOItemProfile { get; set; }
        public virtual BOVendorOrSupplier BOVendorOrSupplier { get; set; }
        public virtual BOEquipmentType BOEquipmentType { get; set; }
    }
}

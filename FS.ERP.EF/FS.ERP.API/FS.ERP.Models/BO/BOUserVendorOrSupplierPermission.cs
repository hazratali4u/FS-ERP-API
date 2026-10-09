using System;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("UMS.tbl_UserVendorOrSupplierPermission")]
    public partial class BOUserVendorOrSupplierPermission
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public Guid UniqueID { get; set; }

        public int UserCode { get; set; }

        public long VendorOrSupplierCode { get; set; }

        public int CompanyCode { get; set; }

        public DateTime? dtmUpLoaded { get; set; }

        public DateTime? dtmDownLoaded { get; set; }

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

        public virtual BOVendorOrSupplier BOVendorOrSupplier { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        public virtual BOUser BOUser3 { get; set; }
    }
}

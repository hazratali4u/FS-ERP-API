using System;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{
    [Table("IMM.tbl_ItemAttributeAspectDetail")]
    public partial class BOItemAttributeAspectDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        public long ItemAttributeAspectCode { get; set; }

        public long ItemCode { get; set; }

        public int? ItemAttributeDetailCode { get; set; }

        public int? ItemAspectDetailCode { get; set; }

        public long SortOrder { get; set; }

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

        public virtual BOItem BOItem { get; set; }

        public virtual BOItemAspectDetail BOItemAspectDetail { get; set; }

        public virtual BOItemAttributeAspect BOItemAttributeAspect { get; set; }

        public virtual BOItemAttributeDetail BOItemAttributeDetail { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }
    }
}

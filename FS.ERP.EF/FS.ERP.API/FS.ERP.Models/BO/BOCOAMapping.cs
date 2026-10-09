using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("FICO.tbl_COAMapping")]
    public partial class BOCOAMapping
    {
        public short ID { get; set; }

        public byte? COAConfigurationCode { get; set; }

        public long? COACode { get; set; }

        [StringLength(255)]
        public string COATitle { get; set; }

        [Required]
        [StringLength(510)]
        public string MapText { get; set; }

        [StringLength(1020)]
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

        public virtual BOCOA BOCOA { get; set; }

        public virtual BOCOAConfiguration BOCOAConfiguration { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("IMM.tbl_ProductAssemblyDetail")]
    public partial class BOProductAssemblyDetail
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public long ProductAssemblyCode { get; set; }
        public long ItemProfileCode { get; set; }
        [Column(TypeName = "numeric")]
        public decimal? Qty { get; set; }
        [Column(TypeName = "numeric")]
        public decimal? TotalQty { get; set; }

        [StringLength(4000)]
        public string Description { get; set; }

        public int CompanyCode { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        public byte RecordStatusCode { get; set; }
        public virtual BOItemProfile BOItemProfile { get; set; }
        public virtual BOProductAssemblyMaster BOProductAssemblyMaster { get; set; }
    }
}

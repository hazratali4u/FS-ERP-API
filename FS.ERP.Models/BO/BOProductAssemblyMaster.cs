using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("IMM.tbl_ProductAssemblyMaster")]
    public partial class BOProductAssemblyMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOProductAssemblyMaster()
        {
            BOProductAssemblyDetail = new HashSet<BOProductAssemblyDetail>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        public short? FiscalYearCode { get; set; }

        [Required]
        [StringLength(50)]
        public string FolioNo { get; set; }
        public long? SaleOrderCode { get; set; }
        public long ItemProfileCode { get; set; }
        [Column(TypeName = "numeric")]
        public decimal? Qty { get; set; }

        [StringLength(4000)]
        public string Description { get; set; }

        public int CompanyCode { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        public byte RecordStatusCode { get; set; }

        public virtual BOFiscalYear BOFiscalYear { get; set; }
        public virtual BOItemProfile BOItemProfile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOProductAssemblyDetail> BOProductAssemblyDetail { get; set; }
    }
}

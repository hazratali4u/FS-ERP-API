using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.Models.BO
{
    [Table("IMM.tbl_JobCard")]
    public class BOJobCard
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOJobCard()
        {
            BOJobCardDetail = new HashSet<BOJobCardDetail>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public string FolioNo { get; set; }
        public long SaleOrderCode { get; set; }
        public long CustomerCode { get; set; }
        public DateTime? CreationDate { get; set; }
        public Int16? FiscalYearCode { get; set; }
        public bool? IsVoid { get; set; }
        public long? EmpCode { get; set; }
        public int CompanyCode { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        public byte RecordStatusCode { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOJobCardDetail> BOJobCardDetail { get; set; }
    }
}

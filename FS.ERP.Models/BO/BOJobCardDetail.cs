using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.Models.BO
{
    [Table("IMM.tbl_JobCardDetail")]
    public class BOJobCardDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOJobCardDetail()
        {
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        public long JobCardCode { get; set; }

        public long ItemProfileCode { get; set; }

        public decimal? Qty { get; set; }

        public DateTime? ScheduledDate { get; set; }
        public DateTime? ProductionDate { get; set; }
        public string MachineNo { get; set; }

        public decimal? ProducedQty { get; set; }
        public byte? Status { get; set; }

        public int CompanyCode { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        public byte RecordStatusCode { get; set; }
        public virtual BOJobCard BOJobCard { get; set; }
    }
}

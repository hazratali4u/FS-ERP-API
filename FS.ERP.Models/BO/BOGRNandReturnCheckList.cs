using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.Models.BO
{
    [Table("IMM.tbl_GRNandReturnCheckList")]
    public class BOGRNandReturnCheckList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOGRNandReturnCheckList()
        {
            this.BOGRNandReturnCheckList1 = new HashSet<BOGRNandReturnCheckList>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public System.Guid UniqueID { get; set; }
        public long BaseCode { get; set; }
        public Nullable<long> GatePassCode { get; set; }
        public Nullable<long> GatePassDetailCode { get; set; }
        public Nullable<long> POandReturnCode { get; set; }
        public Nullable<long> POandReturnDetailCode { get; set; }
        public Nullable<long> GRNandReturnCode { get; set; }
        public Nullable<long> GRNandReturnDetailCode { get; set; }
        public string Remarks { get; set; }
        public int CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }
        public int IMMCheckListCode { get; set; }
        public bool? Accepted { get; set; }

        public virtual BOGatePass BOGatePass { get; set; }
        public virtual BOIMMCheckList BOIMMCheckList { get; set; }
        public virtual BOGatePassDetail BOGatePassDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOGRNandReturnCheckList> BOGRNandReturnCheckList1 { get; set; }
        public virtual BOGRNandReturnCheckList BOGRNandReturnCheckList2 { get; set; }
        public virtual BOGRNandReturnDetail BOGRNandReturnDetail { get; set; }
        public virtual BOPurchaseOrderAndReturnDetail BOPurchaseOrderAndReturnDetail { get; set; }
       

    }
}

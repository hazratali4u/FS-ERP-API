using FS.ERP.Models.IdentityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.Models.BO
{
    [Table("IMM.tbl_PurchaseOrderAndReturnMapping")]
    public partial class BOPurchaseOrderAndReturnMapping
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public Nullable<long> BaseCode { get; set; }
        public Nullable<long> PurchaseRequisitionCode { get; set; }
        public Nullable<long> QuotationRequestCode { get; set; }
        public Nullable<long> QuotationInfoCode { get; set; }
        public Nullable<long> PurchaseOrderCode { get; set; }
        public Nullable<long> PurchaseReturnCode { get; set; }
        public Nullable<long> SaleReturnCode { get; set; }
        public Nullable<long> InwardCode { get; set; }
        public Nullable<long> OutwardCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }


        public virtual BORecordStatus BORecordStatus { get; set; }
        public virtual BOUser BOUser { get; set; }
        public virtual BOUser BOUser1 { get; set; }
        public virtual BOUser BOUser2 { get; set; }
    }
}

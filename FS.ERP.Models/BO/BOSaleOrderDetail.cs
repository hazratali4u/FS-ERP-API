using FS.ERP.Models.IdentityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.Models.BO
{
    [Table("SRM.tbl_SaleOrderDetail")]
    public class BOSaleOrderDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public long SaleOrderCode { get; set; }
        public Nullable<long> ItemProfileCode { get; set; }
        public Nullable<byte> IMMFinishTypeCode { get; set; }
        public Nullable<decimal> OrderQty { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<long> TaxGroupDetailCode { get; set; }
        public Nullable<decimal> DiscountRatio { get; set; }
        public Nullable<decimal> DiscountAmount { get; set; }
        public Nullable<decimal> DefaultProductPrice { get; set; }
        public string Description { get; set; }
        public DateTime? ProductionDate { get; set; }
        public int CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }

        public virtual BOSaleOrderMaster BOSaleOrderMaster { get; set; }
        public virtual BOIMMTaxGroupDetail BOIMMTaxGroupDetail { get; set; }
        public virtual BOItemProfile BOItemProfile { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }
        public virtual BORecordStatus BORecordStatus { get; set; }
        public virtual BOUser BOUser { get; set; }
        public virtual BOUser BOUser1 { get; set; }
        public virtual BOUser BOUser2 { get; set; }



    }
}

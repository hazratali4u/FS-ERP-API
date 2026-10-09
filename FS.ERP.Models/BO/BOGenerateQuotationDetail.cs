using FS.ERP.Models.IdentityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.Models.BO
{
    [Table("CRM.tbl_GenerateQuotationDetail")]
    public class BOGenerateQuotationDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public Nullable<long> GenerateQuotationCode { get; set; }
        public Nullable<long> QuotationParameterCode { get; set; }
        public Nullable<long> ItemProfileCode { get; set; }
        public Nullable<decimal> QuotedItemPrice { get; set; }
        public Nullable<int> Qty { get; set; }
        public Nullable<short> CurrencyCode { get; set; }
        public Nullable<decimal> ExchangeRate { get; set; }
        public Nullable<decimal> DiscountRatio { get; set; }
        public Nullable<decimal> DiscountAmount { get; set; }
        public int CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }

        public virtual BOGenerateQuotation BOGenerateQuotation { get; set; }
        public virtual BOQuotationParameter BOQuotationParameter { get; set; }
        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }
        public virtual BORecordStatus BORecordStatus { get; set; }
        public virtual BOUser BOUser { get; set; }
        public virtual BOUser BOUser1 { get; set; }
        public virtual BOUser BOUser2 { get; set; }
    }
}

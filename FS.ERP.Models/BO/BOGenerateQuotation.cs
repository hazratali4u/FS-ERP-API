using FS.ERP.Models.IdentityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.Models.BO
{
    [Table("CRM.tbl_GenerateQuotation")]
    public class BOGenerateQuotation
    {
        public BOGenerateQuotation()
        {
            BOGenerateQuotationDetail = new HashSet<BOGenerateQuotationDetail>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public string FolioNo { get; set; }
        public System.DateTime QuotationDate { get; set; }
        public Nullable<long> CustomerCode { get; set; }
        public Nullable<long> QuotationTemplateCode { get; set; }
        public Nullable<long> IMMTaxGroupDetailCode { get; set; }
        public short? FiscalYearCode { get; set; }
        public int CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }

        public virtual BOQuotationTemplate BOQuotationTemplate { get; set; }
        public virtual BOIMMTaxGroupDetail BOIMMTaxGroupDetail { get; set; }
        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }
        public virtual BORecordStatus BORecordStatus { get; set; }
        public virtual BOUser BOUser { get; set; }
        public virtual BOUser BOUser1 { get; set; }
        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOGenerateQuotationDetail> BOGenerateQuotationDetail { get; set; }

    }
}

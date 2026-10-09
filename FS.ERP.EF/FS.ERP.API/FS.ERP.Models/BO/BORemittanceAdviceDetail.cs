using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("FICO.tbl_RemittanceAdviceDetail")]
    public partial class BORemittanceAdviceDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BORemittanceAdviceDetail()
        {
            BOTransactionDetail = new HashSet<BOTransactionDetail>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public Guid UniqueID { get; set; }

        public long BaseCode { get; set; }

        public long RemittanceCode { get; set; }

        public long COACode { get; set; }

        public long BillOrInvoiceMasterCode { get; set; }

        public long BillOrInvoiceMasterDetailCode { get; set; }

        [StringLength(50)]
        public string DetailCode { get; set; }

        [StringLength(50)]
        public string DetailRefNo { get; set; }

        [StringLength(50)]
        public string InstrumentNo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? InstrumentDate { get; set; }

        public DateTime? InstrumentPresentedOn { get; set; }

        public DateTime? ActionOnInstrument { get; set; }

        public byte? InstrumentStatusCode { get; set; }

        [StringLength(510)]
        public string Narration { get; set; }

        public short? TransactionLineNo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PrvBalanceAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BillAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PaidAmount { get; set; }

        public short? CurrencyCode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ExchangeRate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ExchangeRateForMultiCurrency { get; set; }

        [StringLength(50)]
        public string DetailInvoiceNo { get; set; }

        public long? IMMTaxGroupDetailCode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? GSTRate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? GSTAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WHTRate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WHTAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OtherDeductionAmount { get; set; }

        public bool? Is3Schedule { get; set; }

        public long? JobProjectSchemeCode { get; set; }

        public long? JobProjectSchemeDetailCode { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ForeCastFrom { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ForecastTo { get; set; }

        public int? NoOfDays { get; set; }

        [StringLength(1020)]
        public string Description { get; set; }

        public int CompanyCode { get; set; }

        public DateTime? dtmExported { get; set; }

        public DateTime? dtmImported { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        public byte RecordStatusCode { get; set; }

        public virtual BOCurrency BOCurrency { get; set; }

        public virtual BOIMMTaxGroupDetail BOIMMTaxGroupDetail { get; set; }

        public virtual BOInstrumentStatus BOInstrumentStatus { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOBillOrInvoiceMaster BOBillOrInvoiceMaster { get; set; }

        public virtual BOBillOrInvoiceMasterDetail BOBillOrInvoiceMasterDetail { get; set; }

        public virtual BOCOA BOCOA { get; set; }

        public virtual BOJobProjectScheme BOJobProjectScheme { get; set; }

        public virtual BOJobProjectSchemeDetail BOJobProjectSchemeDetail { get; set; }

        public virtual BORemittanceAdvice BORemittanceAdvice { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOTransactionDetail> BOTransactionDetail { get; set; }
    }
}

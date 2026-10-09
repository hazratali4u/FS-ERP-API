using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("FICO.tbl_TransactionDetail")]
    public partial class BOTransactionDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        public Guid UniqueID { get; set; }

        public long BaseCode { get; set; }

        public long TransactionCode { get; set; }

        public long COACode { get; set; }

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
        public decimal? DrAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CrAmount { get; set; }

        public short? CurrencyCode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ExchangeRate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ExchangeRateForMultiCurrency { get; set; }

        [StringLength(50)]
        public string DetailInvoiceNo { get; set; }

        public long? IMMTaxGroupDetailCode { get; set; }

        public long? BillOrInvoiceCode { get; set; }

        public long? BillOrInvoiceDetailCode { get; set; }

        public long? RemittanceAdviceCode { get; set; }

        public long? RemittanceAdviceDetailCode { get; set; }

        public long? JobProjectSchemeCode { get; set; }

        public long? JobProjectSchemeDetailCode { get; set; }

        public long? BankReconcileCode { get; set; }

        public DateTime? BankReconcileDate { get; set; }

        public long? RecoveredByEmpCode { get; set; }

        [StringLength(1020)]
        public string Description { get; set; }

        public Nullable<int> CostOrProfitCenterCode { get; set; }

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

        public virtual BORemittanceAdviceDetail BORemittanceAdviceDetail { get; set; }

        public virtual BOEmployeeInfo BOEmployeeInfo { get; set; }

        public virtual BOTransactionMaster BOTransactionMaster { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }
    }
}

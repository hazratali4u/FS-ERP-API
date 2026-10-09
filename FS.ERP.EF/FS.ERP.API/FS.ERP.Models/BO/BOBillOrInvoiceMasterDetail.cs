using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("FICO.tbl_BillOrInvoiceMasterDetail")]
    public partial class BOBillOrInvoiceMasterDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOBillOrInvoiceMasterDetail()
        {
            BORemittanceAdviceDetail = new HashSet<BORemittanceAdviceDetail>();
            BOTransactionDetail = new HashSet<BOTransactionDetail>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public Guid UniqueID { get; set; }

        public long BaseCode { get; set; }

        public long BillOrInvoiceMasterCode { get; set; }

        [StringLength(50)]
        public string DetailCode { get; set; }

        [StringLength(50)]
        public string DetailRefNo { get; set; }

        [StringLength(50)]
        public string InstrumentNo { get; set; }

        [StringLength(510)]
        public string Narration { get; set; }

        public short? TransactionLineNo { get; set; }

        public long? IMMTaxGroupDetailCode { get; set; }

        public int? ItemCode { get; set; }

        public long? EquipmentCode { get; set; }

        [StringLength(50)]
        public string ItemOrEquipmentSerialNo { get; set; }

        [StringLength(50)]
        public string BatchNo { get; set; }

        [StringLength(50)]
        public string ItemOrEquipmentStatus { get; set; }

        public bool? IsFull { get; set; }

        public bool? IsFinal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SalePrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RetailPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PrvBalanceAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SaleAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RetailAmount { get; set; }

        public short? DueDays { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? GSTRate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? GSTAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FEDRate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FEDAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FTRate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FTAmount { get; set; }

        public bool? Is3Schedule { get; set; }

        public short? CurrencyCode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ExchangeRate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ExchangeRateForMultiCurrency { get; set; }

        public long? JobProjectSchemeCode { get; set; }

        public long? JobProjectSchemeDetailCode { get; set; }

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

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOEquipment BOEquipment { get; set; }

        public virtual BOBillOrInvoiceMaster BOBillOrInvoiceMaster { get; set; }

        public virtual BOJobProjectScheme BOJobProjectScheme { get; set; }

        public virtual BOJobProjectSchemeDetail BOJobProjectSchemeDetail { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BORemittanceAdviceDetail> BORemittanceAdviceDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOTransactionDetail> BOTransactionDetail { get; set; }
    }
}

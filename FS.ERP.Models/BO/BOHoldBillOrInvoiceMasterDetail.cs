using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{
    [Table("CORN.tbl_HoldBillOrInvoiceMasterDetail")]
    public partial class BOHoldBillOrInvoiceMasterDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public System.Guid UniqueID { get; set; }
        public long BaseCode { get; set; }
        public long BillOrInvoiceMasterCode { get; set; }
        public string DetailCode { get; set; }
        public string DetailRefNo { get; set; }
        public string InstrumentNo { get; set; }
        public string Narration { get; set; }
        public Nullable<short> TransactionLineNo { get; set; }
        public Nullable<long> IMMTaxGroupDetailCode { get; set; }
        public Nullable<long> ItemProfileCode { get; set; }
        public Nullable<long> EquipmentCode { get; set; }
        public string ItemOrEquipmentSerialNo { get; set; }
        public string BatchNo { get; set; }
        public string ItemOrEquipmentStatus { get; set; }
        public Nullable<bool> IsFull { get; set; }
        public Nullable<bool> IsFinal { get; set; }
        public Nullable<decimal> SalePrice { get; set; }
        public Nullable<decimal> RetailPrice { get; set; }
        public Nullable<decimal> PrvBalanceAmount { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> SaleAmount { get; set; }
        public Nullable<decimal> RetailAmount { get; set; }
        public Nullable<short> DueDays { get; set; }
        public Nullable<decimal> GSTRate { get; set; }
        public Nullable<decimal> GSTAmount { get; set; }
        public Nullable<decimal> FEDRate { get; set; }
        public Nullable<decimal> FEDAmount { get; set; }
        public Nullable<decimal> FTRate { get; set; }
        public Nullable<decimal> FTAmount { get; set; }
        public Nullable<decimal> DiscountRatio { get; set; }
        public Nullable<decimal> DiscountAmount { get; set; }
        public Nullable<bool> Is3Schedule { get; set; }
        public Nullable<short> CurrencyCode { get; set; }
        public Nullable<decimal> ExchangeRate { get; set; }
        public Nullable<decimal> ExchangeRateForMultiCurrency { get; set; }
        public Nullable<long> JobProjectSchemeCode { get; set; }
        public Nullable<long> JobProjectSchemeDetailCode { get; set; }
        public string Description { get; set; }
        public int CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }

        public virtual BOHoldBillOrInvoiceMaster BOHoldBillOrInvoiceMaster { get; set; }
        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }
        public virtual BORecordStatus BORecordStatus { get; set; }
        public virtual BOUser BOUser { get; set; }
        public virtual BOUser BOUser1 { get; set; }
        public virtual BOUser BOUser2 { get; set; }
    }
}

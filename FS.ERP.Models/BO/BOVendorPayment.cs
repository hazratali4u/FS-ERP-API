using FS.ERP.Models.IdentityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.Models.BO
{
    [Table("SRM.tbl_VendorPayment")]
    public class BOVendorPayment
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public Nullable<int> BaseCode { get; set; }
        public string FolioNo { get; set; }
        public Int16 FiscalYearCode { get; set; }
        public string ReferenceNumber { get; set; }
        public Nullable<int> ProfitOrCostCenterCode { get; set; }
        public Nullable<long> VendorOrSupplierCode { get; set; }
        public Nullable<long> COACode { get; set; }
        public Nullable<byte> PaymentMode { get; set; }
        public Nullable<int> ChequeCode { get; set; }
        public Nullable<System.DateTime> ChequeDate { get; set; }
        public Nullable<System.DateTime> ChequeRealizationDate { get; set; }
        public Nullable<short> CurrencyCode { get; set; }
        public Nullable<int> ExchangeRate { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<System.DateTime> ClearanceDate { get; set; }
        public Nullable<decimal> BankCharges { get; set; }
        public Nullable<decimal> WithheldIncomeTaxRatio { get; set; }
        public Nullable<decimal> WithheldIncomeTax { get; set; }
        public Nullable<decimal> WithheldSalesTaxRatio { get; set; }
        public Nullable<decimal> WithheldSalesTax { get; set; }
        public Nullable<int> Status { get; set; }
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


        public virtual BOBankAccountInstrumentInfo BOBankAccountInstrumentInfo { get; set; }
        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }
        public virtual BORecordStatus BORecordStatus { get; set; }
        public virtual BOUser BOUser { get; set; }
        public virtual BOUser BOUser1 { get; set; }
        public virtual BOUser BOUser2 { get; set; }
    }
}

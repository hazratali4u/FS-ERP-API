using FS.ERP.Models.IdentityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.Models.BO
{
    [Table("SRM.tbl_CommissionReceipt")]
    public class BOCommissionReceipt
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        //public Nullable<long> CommissionBookingCode { get; set; }
        public string FolioNo { get; set; }
        public string ReferenceNumber { get; set; }
        public Nullable<int> ProfitOrCostCenterCode { get; set; }
        public Nullable<long> VendorOrSupplierCode { get; set; }
        public Nullable<long> COACode { get; set; }
        public Nullable<byte> PaymentMode { get; set; }
        public string ChequeNumber { get; set; }
        public Nullable<System.DateTime> ChequeOrPaymentDate { get; set; }
        public Nullable<System.DateTime> ChequeRealizationDate { get; set; }
        public Nullable<short> CurrencyCode { get; set; }
        public Nullable<int> ExchangeRate { get; set; }
        public Nullable<decimal> DeductionAmount { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<int> Status { get; set; }
        public string Document { get; set; }
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

        //public virtual BOCommissionBooking BOCommissionBooking { get; set; }
        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }
        public virtual BORecordStatus BORecordStatus { get; set; }
        public virtual BOUser BOUser { get; set; }
        public virtual BOUser BOUser1 { get; set; }
        public virtual BOUser BOUser2 { get; set; }
    }
}

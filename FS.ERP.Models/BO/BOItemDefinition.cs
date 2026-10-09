using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{
    [Table("IMM.tbl_ItemDefinition")]
    public class BOItemDefinition
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public Nullable<long> CustomerCode { get; set; }
        public Nullable<int> PCorCCCode { get; set; }
        public string URLPath { get; set; }
        public long ItemProfileCode { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> UnitRate { get; set; }
        public Nullable<long> IMMTaxGroupDetailCode { get; set; }
        public Nullable<short> CurrencyCode { get; set; }
        public string Status { get; set; }
        public string PaymentPlan { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> SubscriptionStartDate { get; set; }
        public Nullable<System.DateTime> RenewalDate { get; set; }
        public Nullable<System.DateTime> ActualRenewalDate { get; set; }
        public Nullable<System.DateTime> ReminderDate { get; set; }
        public string AccountRef { get; set; }
        public Nullable<long> VendorOrSupplierCode { get; set; }
        public string ValueDefinition { get; set; }
        public string Remarks { get; set; }
        public string Description { get; set; }
        public decimal? OTC { get; set; }
        public decimal? MRC { get; set; }
        public string EmpCodeStr { get; set; }
        public string CancelledSuspendReason { get; set; }
        public Nullable<int> CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }
        public virtual BORecordStatus BORecordStatus { get; set; }
        public virtual BOIMMTaxGroupDetail BOIMMTaxGroupDetail { get; set; }
        public virtual BOUser BOUser { get; set; }
        public virtual BOUser BOUser1 { get; set; }
        public virtual BOUser BOUser2 { get; set; }
    }
}

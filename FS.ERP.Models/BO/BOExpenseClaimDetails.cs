using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{
    [Table("AppCNF.tbl_ExpenseClaimDetails")]
    public partial class BOExpenseClaimDetails
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short ID { get; set; }
        public Nullable<bool> IsFieldExpense { get; set; }
        public Nullable<bool> IsApproved { get; set; }
        public long ExpenseClaimCode { get; set; }
        public short ExpenseTypeCode { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<System.DateTime> ExpenseDate { get; set; }
        public string DocReferenceNo { get; set; }
        public string DocPath { get; set; }
        public Nullable<int> StartingCityCode { get; set; }
        public Nullable<int> StartingAreaCode { get; set; }
        public Nullable<int> EndingCityCode { get; set; }
        public Nullable<int> EndingAreaCode { get; set; }
        public Nullable<decimal> AdvanceOrClaimAmount { get; set; }
        public string ExpensePurpose { get; set; }
        public Nullable<int> CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }

        public Nullable<System.DateTime> TripStartDate { get; set; }
        public Nullable<System.DateTime> TripEndDate { get; set; }

        public virtual BOExpenseClaim BOExpenseClaim { get; set; }
        public virtual BOExpenseType BOExpenseType { get; set; }
        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }
        public virtual BORecordStatus BORecordStatus { get; set; }
    }
}

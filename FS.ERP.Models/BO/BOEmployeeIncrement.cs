using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("HRM.tbl_EmployeeIncrement")]
    public partial class BOEmployeeIncrement
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public System.Guid UniqueID { get; set; }
        public Nullable<short> FiscalYearCode { get; set; }
        public long EmpCode { get; set; }
        public long IncrementDecrementTypeCode { get; set; }
        public string TransactionNo { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
        public Nullable<bool> IsApproved { get; set; }
        public Nullable<long> ApprovedBy { get; set; }
        public Nullable<System.DateTime> ApprovalDate { get; set; }
        public Nullable<System.DateTime> EffectiveFrom { get; set; }
        public Nullable<decimal> IncrementRatio { get; set; }
        public Nullable<decimal> IncrementAmount { get; set; }
        public Nullable<decimal> SalaryBeforeIncrement { get; set; }
        public Nullable<decimal> BasicPayAfterIncrement { get; set; }
        public int CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }

        public virtual BOIncrementOrDecrementType BOIncrementOrDecrementType { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOFiscalYear BOFiscalYear { get; set; }

        public virtual BOEmployeeInfo BOEmployeeInfo { get; set; }
        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        
    }
}

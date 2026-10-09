using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{
    [Table("HRM.tbl_IncrementOrDecrementRules")]
    public partial class BOIncrementOrDecrementRules
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public int CompanyID { get; set; }
        public Nullable<short> FiscalYearCode { get; set; }
        public long IncrementDecrementTypeCode { get; set; }
        public int DeptCode { get; set; }
        public Nullable<bool> OverallIncrementShouldBe { get; set; }
        public Nullable<decimal> OverallIncrementAmount { get; set; }
        public Nullable<bool> IsMaxIncrementRatio { get; set; }
        public Nullable<decimal> MaxIncrementRatio { get; set; }
        public Nullable<bool> IsMinIncrementRatio { get; set; }
        public Nullable<decimal> MinIncrementRatio { get; set; }
        public Nullable<bool> IsMaxIncrementAmount { get; set; }
        public Nullable<decimal> MaxIncrementAmount { get; set; }
        public Nullable<bool> IsMinIncrementAmount { get; set; }
        public Nullable<decimal> MinIncrementAmount { get; set; }
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
        public virtual BOFiscalYear BOFiscalYear { get; set; }
    }

}

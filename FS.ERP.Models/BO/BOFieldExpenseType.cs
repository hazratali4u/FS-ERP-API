using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{
    [Table("AppCNF.tbl_FieldExpenseType")]
    public partial class BOFieldExpenseType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short ID { get; set; }
        public short ExpenseTypeCode { get; set; }
        public int StartingCountryCode { get; set; }
        public int StartingCityCode { get; set; }
        public Nullable<int> StartingAreaCode { get; set; }
        public int EndingCountryCode { get; set; }
        public int EndingCityCode { get; set; }
        public Nullable<int> EndingAreaCode { get; set; }
        public Nullable<decimal> DistanceInKM { get; set; }
        public string CalculationBehaviour { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<int> CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }

        public virtual BOExpenseType BOExpenseType { get; set; }
        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }
        public virtual BORecordStatus BORecordStatus { get; set; }
    }
}

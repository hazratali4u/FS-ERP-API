using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{
    [Table("HRM.tbl_BonusPolicy")]

    public partial class BOBonusPolicy
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int BonusTypeCode { get; set; }
        public Nullable<bool> IsEligibleForPermanentEmployees { get; set; }
        public Nullable<bool> IsEligibleForContractualEmployees { get; set; }
        public Nullable<bool> IsEligibleForSeparateEmployees { get; set; }
        public Nullable<System.DateTime> LastWorkingDayStartDate { get; set; }
        public Nullable<System.DateTime> LastWorkingDayEndingDate { get; set; }
        public Nullable<System.DateTime> ConfirmationDateBefore { get; set; }
        public Nullable<System.DateTime> JoiningDateBefore { get; set; }
        public Nullable<System.DateTime> AvgSalaryStartDate { get; set; }
        public Nullable<System.DateTime> AvgSalaryEndDate { get; set; }
        public Nullable<System.DateTime> ServiceInYearsFrom { get; set; }
        public Nullable<System.DateTime> ServiceInYearsTo { get; set; }
        public Nullable<bool> IsCalculateFullBonus { get; set; }
        public Nullable<bool> IsCalculateZeroBonus { get; set; }
        public Nullable<bool> IsProrateAsPerJoiningDate { get; set; }
        public Nullable<bool> IsProrateAsPerConfirmationDate { get; set; }
        public System.DateTime BonusPeriodEnds { get; set; }
        public Nullable<int> DaysToDivide { get; set; }
        public Nullable<int> DaysToMultiply { get; set; }
        public int CompanyCode { get; set; }
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
        public virtual BOBonusType BOBonusType { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("HRM.tbl_LeavePolicyDetail")]
    public partial class BOLeavePolicyDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public short LeavePolicyCode { get; set; }
        public byte LeaveTypeCode { get; set; }
        public Nullable<decimal> ServiceInYear { get; set; }
        public Nullable<bool> IsSandwich { get; set; }
        public Nullable<bool> ApplicableForPermanentEmployees { get; set; }
        public Nullable<bool> ApplicableForContractualEmployees { get; set; }
        public Nullable<bool> ApplicableForProbationaryEmployees { get; set; }
        public Nullable<bool> ApplicableForResignedEmployees { get; set; }
        public Nullable<bool> IsLaps { get; set; }
        public Nullable<bool> IsEncashable { get; set; }
        public Nullable<bool> IsUnPaid { get; set; }
        public Nullable<int> CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }
        public byte? CalculationCriteria { get; set; }
        public decimal TotalDays { get; set; }
        public decimal MinimumDays { get; set; }
        public decimal MaximumDays { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public decimal BalanceAccumulationLimit { get; set; }
        public decimal BalanceMaxYear { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOLeavePolicy BOLeavePolicy { get; set; }

        public virtual BOLeaveType BOLeaveType { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }
    }
}

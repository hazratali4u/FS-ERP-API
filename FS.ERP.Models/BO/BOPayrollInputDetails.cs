using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{
    [Table("HRM.tbl_PayrollInputDetails")]
    public partial class BOPayrollInputDetails
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int PayrollInputCode { get; set; }
        public Nullable<short> AllowanceOrBenefitTypeCode { get; set; }
        public Nullable<decimal> AllowanceOrBenefitAmount { get; set; }
        public string Description { get; set; }
        public Nullable<bool> IsLocked { get; set; }
        public Nullable<int> CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }


        //public virtual BOPayrollInputMaster BOPayrollInputMaster { get; set; }
        //public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }
        //public virtual BORecordStatus BORecordStatus { get; set; }
        //public virtual BOUser BOUser { get; set; }
        //public virtual BOUser BOUser1 { get; set; }
        //public virtual BOUser BOUser2 { get; set; }
    }
}

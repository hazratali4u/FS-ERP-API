using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.BO;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{

    [Table("HRM.tbl_PayGradeEarningsAllocation")]
    public partial class BOPayGradeEarningsAllocation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        public short PayGradeCode { get; set; }
        public short AllowanceOrBenefitCode { get; set; }
        public Nullable<decimal> AllowanceOrBenefitAmount { get; set; }
        public Nullable<decimal> AllowanceOrBenefitRatio { get; set; }
        public string Description { get; set; }
        public Nullable<int> CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }
    
        [ForeignKey("AllowanceOrBenefitCode")]
        public virtual BOAllowanceOrBenefitType BOAllowanceOrBenefitType { get; set; }
        public virtual BOPayGrade BOPayGrade { get; set; }
        public virtual BOUser BOUser { get; set; }
        public virtual BOUser BOUser1 { get; set; }
        public virtual BOUser BOUser2 { get; set; }
    }
}

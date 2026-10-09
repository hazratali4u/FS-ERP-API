using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.BO;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{

    [Table("HRM.tbl_PayGradeGratuityCriteria")]
    public partial class BOPayGradeGratuityCriteria
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        public short PayGradeCode { get; set; }
        public byte EmployeeTypeCode { get; set; }
        public decimal MinServiceDuration { get; set; }
        public decimal MaxServiceDuration { get; set; }
        public decimal DaysToBePaid { get; set; }
        public byte SeparationTypeCode { get; set; }
        public Nullable<bool> IsCalculationPerSlab { get; set; }
        public Nullable<bool> IsCalculationPerDuration { get; set; }
        public Nullable<decimal> MaxGratuityNumber { get; set; }
        public Nullable<decimal> MaxGratuityAmount { get; set; }
        public Nullable<int> CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }
        public string PayGrade { get; set; }

        public virtual BOEmployeeStatus BOEmployeeStatus { get; set; }
        public virtual BOPayGrade BOPayGrade { get; set; }
        public virtual BOUser BOUser { get; set; }
        public virtual BOUser BOUser1 { get; set; }
        public virtual BOUser BOUser2 { get; set; }
    }
}

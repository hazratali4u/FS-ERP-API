using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("HRM.tbl_PayGradeAllowanceOrBenefit")]
    public partial class BOPayGradeAllowanceOrBenefit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOPayGradeAllowanceOrBenefit()
        {

        }

        public int ID { get; set; }

        public short PayGradeCode { get; set; }

        public int AllowanceOrBenefitAmountCode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AllowanceOrBenefitAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AllowanceOrBenefitRatio { get; set; }

        [StringLength(1020)]
        public string Description { get; set; }

        public int? CompanyCode { get; set; }

        public DateTime? dtmExported { get; set; }

        public DateTime? dtmImported { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        public byte RecordStatusCode { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOAllowancesOrBenefit BOAllowancesOrBenefit { get; set; }

        public virtual BOPayGrade BOPayGrade { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("HRM.tbl_EmployeeAllowanceOrBenefit")]
    public partial class BOEmployeeAllowanceOrBenefit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOEmployeeAllowanceOrBenefit()
        {
            BOEmployeeManualAllowanceOrBenefit = new HashSet<BOEmployeeManualAllowanceOrBenefit>();
            BOEmployeeIncrementAllowanceOrBenefit = new HashSet<BOEmployeeIncrementAllowanceOrBenefit>();
            BOEmployeeSalaryAllowanceOrBenefit = new HashSet<BOEmployeeSalaryAllowanceOrBenefit>();
        }

        public int ID { get; set; }

        public short? AllowanceOrBenefitTypeCode { get; set; }

        public long EmpCode { get; set; }

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

        public virtual BOEmployeeInfo BOEmployeeInfo { get; set; }

        public virtual BOAllowanceOrBenefitType BOAllowanceOrBenefitType { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeIncrementAllowanceOrBenefit> BOEmployeeIncrementAllowanceOrBenefit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeSalaryAllowanceOrBenefit> BOEmployeeSalaryAllowanceOrBenefit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeManualAllowanceOrBenefit> BOEmployeeManualAllowanceOrBenefit { get; set; }

        
    }
}

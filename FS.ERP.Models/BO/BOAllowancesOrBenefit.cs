using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("HRM.tbl_AllowancesOrBenefit")]
    public partial class BOAllowancesOrBenefit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOAllowancesOrBenefit()
        {
            BOPayGradeAllowanceOrBenefit = new HashSet<BOPayGradeAllowanceOrBenefit>();
        }

        public int ID { get; set; }

        public short AllowanceOrBenefitTypeCode { get; set; }

        [StringLength(25)]
        public string ShortName { get; set; }

        [Required]
        [StringLength(255)]
        public string FullName { get; set; }

        [Required]
        [StringLength(510)]
        public string DisplayName { get; set; }

        public bool IsTaxable { get; set; }

        public bool IsTaxableFromSalary { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TaxPercentage { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AllowanceOrBenefitAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AllowanceOrBenefitRatio { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EmployeerContributionAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EmployeerContributionPercentage { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EmployeeContributionAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EmployeeContributionPercentage { get; set; }

        public long? AllowanceOrBenefitCOACode { get; set; }

        public long? DeductionCOACode { get; set; }

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

        public virtual BOAllowanceOrBenefitType BOAllowanceOrBenefitType { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOCOA BOCOA { get; set; }

        public virtual BOCOA BOCOA1 { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPayGradeAllowanceOrBenefit> BOPayGradeAllowanceOrBenefit { get; set; }
        
       
       

        
    }
}

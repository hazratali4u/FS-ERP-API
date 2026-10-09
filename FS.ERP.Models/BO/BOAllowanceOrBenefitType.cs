using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("AppCNF.tbl_AllowanceOrBenefitType")]
    public partial class BOAllowanceOrBenefitType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOAllowanceOrBenefitType()
        {
            BOPayGradeDeductionAllocation = new HashSet<BOPayGradeDeductionAllocation>();
            BOBonusAllowancesMapping = new HashSet<BOBonusAllowancesMapping>();
            BOAllowancesOrBenefit = new HashSet<BOAllowancesOrBenefit>();
            BOEmployeeAllowanceOrBenefit = new HashSet<BOEmployeeAllowanceOrBenefit>();
            BOPayGradeEOBIAllowanceDetail = new HashSet<BOPayGradeEOBIAllowanceDetail>();
            BOPayGradeProvidentFundAllowanceDetail = new HashSet<BOPayGradeProvidentFundAllowanceDetail>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short ID { get; set; }

        [Required]
        [StringLength(255)]
        public string FullName { get; set; }

        [Required]
        [StringLength(510)]
        public string DisplayName { get; set; }

        [StringLength(1020)]
        public string Description { get; set; }

        public bool IsTaxable { get; set; }

        public bool IsShowOnPaySlip { get; set; }

        public bool? IsContributionBase { get; set; }

        public int? CompanyCode { get; set; }

        public DateTime? dtmExported { get; set; }

        public DateTime? dtmImported { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        public byte RecordStatusCode { get; set; }

        public Nullable<long> BaseCode { get; set; }
        public Nullable<bool> AllowaceCalculation { get; set; }
        public bool IsProratePaidDays { get; set; }
        public bool EmployeePresentOnTime { get; set; }
        public bool EmployeePresentLateIn { get; set; }
        public bool EmployeePresentEarlyOut { get; set; }
        public bool EmployeePresentHalfDay { get; set; }
        public Nullable<bool> EmployeePresent { get; set; }
        public Nullable<bool> EmployeeCompleteWH { get; set; }
        public Nullable<bool> PayOnWD { get; set; }
        public Nullable<bool> PayOnHD { get; set; }
        public Nullable<System.TimeSpan> CheckOutAfter { get; set; }
        public Nullable<bool> IsNightAllowance { get; set; }
        public bool IsFixedAllowance { get; set; }
        public bool IsFlexibleAllowance { get; set; }
        public bool IsMandatoryAllowance { get; set; }

        //public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        //public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOAllowancesOrBenefit> BOAllowancesOrBenefit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOBonusAllowancesMapping> BOBonusAllowancesMapping { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPayGradeEarningsAllocation> BOPayGradeEarningsAllocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPayGradeDeductionAllocation> BOPayGradeDeductionAllocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeAllowanceOrBenefit> BOEmployeeAllowanceOrBenefit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPayGradeProvidentFundAllowanceDetail> BOPayGradeProvidentFundAllowanceDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPayGradeEOBIAllowanceDetail> BOPayGradeEOBIAllowanceDetail { get; set; }
    }
}

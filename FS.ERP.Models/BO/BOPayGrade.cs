using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("HRM.tbl_PayGrade")]
    public partial class BOPayGrade
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOPayGrade()
        {
            BOPayGradeBonusAllocation = new HashSet<BOPayGradeBonusAllocation>();
            //BOEmployeeIncrement = new HashSet<BOEmployeeIncrement>();
            BOEmployeeInfo = new HashSet<BOEmployeeInfo>();
            BOEmployeeInfoRevision = new HashSet<BOEmployeeInfoRevision>();
            BOEmployeeSalary = new HashSet<BOEmployeeSalary>();
            BOPayGradeAllowanceOrBenefit = new HashSet<BOPayGradeAllowanceOrBenefit>();
            BOPayGradeAssetsAllocation = new HashSet<BOPayGradeAssetsAllocation>();
            BOPayGradeDeductionAllocation = new HashSet<BOPayGradeDeductionAllocation>();
            BOPayGradeDocCheckListAllocation = new HashSet<BOPayGradeDocCheckListAllocation>();
            BOPayGradeEarningsAllocation = new HashSet<BOPayGradeEarningsAllocation>();
            BOPayGradeEOBIAllocation = new HashSet<BOPayGradeEOBIAllocation>();
            BOPayGradeExpenseLimitAllocation = new HashSet<BOPayGradeExpenseLimitAllocation>();
            BOPayGradeGratuityCriteria = new HashSet<BOPayGradeGratuityCriteria>();
            BOPayGradePayrollGroup = new HashSet<BOPayGradePayrollGroup>();
            BOPayGradeProvidentFundAllocation = new HashSet<BOPayGradeProvidentFundAllocation>();
        }

        public short ID { get; set; }
        public string FullName { get; set; }
        public string DisplayName { get; set; }
        public decimal SalaryFrom { get; set; }
        public decimal SalaryTo { get; set; }
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
        public Nullable<bool> IsExceedingAllowed { get; set; }
        public Nullable<byte> ApprovalWorkFlow { get; set; }
        public string NotificationEmailIds { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<BOEmployeeIncrement> BOEmployeeIncrement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeInfo> BOEmployeeInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeInfoRevision> BOEmployeeInfoRevision { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeSalary> BOEmployeeSalary { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPayGradeAllowanceOrBenefit> BOPayGradeAllowanceOrBenefit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPayGradeAssetsAllocation> BOPayGradeAssetsAllocation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPayGradeDeductionAllocation> BOPayGradeDeductionAllocation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPayGradeDocCheckListAllocation> BOPayGradeDocCheckListAllocation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPayGradeEarningsAllocation> BOPayGradeEarningsAllocation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPayGradeEOBIAllocation> BOPayGradeEOBIAllocation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPayGradeExpenseLimitAllocation> BOPayGradeExpenseLimitAllocation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPayGradeGratuityCriteria> BOPayGradeGratuityCriteria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPayGradePayrollGroup> BOPayGradePayrollGroup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPayGradeProvidentFundAllocation> BOPayGradeProvidentFundAllocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPayGradeBonusAllocation> BOPayGradeBonusAllocation { get; set; }

        

    }
}



using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("HRM.tbl_LeavePolicy")]
    public partial class BOLeavePolicy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOLeavePolicy()
        {
            BOEmployeeInfo = new HashSet<BOEmployeeInfo>();
            BOEmployeeHistory = new HashSet<BOEmployeeHistory>();
            BOEmployeeLeave = new HashSet<BOEmployeeLeave>();
            //BOEmployeeLeaveBalance = new HashSet<BOEmployeeLeaveBalance>();
            BOEmployeeSalary = new HashSet<BOEmployeeSalary>();
            BOLeaveDeductionAgainstLate = new HashSet<BOLeaveDeductionAgainstLate>();
            BOLeavePolicyDetail = new HashSet<BOLeavePolicyDetail>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short ID { get; set; }

        [Required]
        [StringLength(510)]
        public string DisplayName { get; set; }

        [StringLength(1020)]
        public string Description { get; set; }

        public bool? IsActive { get; set; }

        public int? CompanyCode { get; set; }

        public DateTime? dtmExported { get; set; }

        public DateTime? dtmImported { get; set; }

        public DateTime dtmCreated { get; set; }

        public DateTime dtmLastM { get; set; }

        public int OwnerCode { get; set; }

        public int CreatedByCode { get; set; }

        public int AlteredByCode { get; set; }

        public byte RecordStatusCode { get; set; }
        public string PolicyName { get; set; }
        public Nullable<bool> IsMaintainBalanceHistory { get; set; }
        public Nullable<decimal> ProcessDaysBeforeNextYear { get; set; }
        public Nullable<bool> IsMarkHoliday { get; set; }
        public Nullable<bool> IsEncashmentBasedOnGrossSalary { get; set; }
        public Nullable<bool> IsIncludeHolidaySandwich { get; set; }
        public Nullable<bool> IsIncludeOffDaySandwich { get; set; }
        public Nullable<bool> IsMarkAbsent { get; set; }

        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeInfo> BOEmployeeInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeHistory> BOEmployeeHistory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeLeave> BOEmployeeLeave { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<BOEmployeeLeaveBalance> BOEmployeeLeaveBalance { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOEmployeeSalary> BOEmployeeSalary { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOLeaveDeductionAgainstLate> BOLeaveDeductionAgainstLate { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOLeavePolicyDetail> BOLeavePolicyDetail { get; set; }
    }
}

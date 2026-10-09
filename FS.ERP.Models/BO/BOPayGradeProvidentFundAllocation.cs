using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.BO;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{

    [Table("HRM.tbl_PayGradeProvidentFundAllocation")]

    public partial class BOPayGradeProvidentFundAllocation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOPayGradeProvidentFundAllocation()
        {
            this.BOPayGradeProvidentFundAllowanceDetail = new HashSet<BOPayGradeProvidentFundAllowanceDetail>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        public short PayGradeCode { get; set; }
        public byte EmployeeTypeCode { get; set; }
        public decimal EmployeeContribution { get; set; }
        public decimal? EmployeeMaxContributionLimit { get; set; }
        public decimal? EmployerMaxContributionLimit { get; set; }
        public decimal EmployerContribution { get; set; }
        public Nullable<bool> IsTaxDeduction { get; set; }
        public Nullable<decimal> ZakatDeduction { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> MaxWithdrawlPFNumber { get; set; }
        public Nullable<decimal> MaxWithdrawlPFAmount { get; set; }
        public Nullable<bool> IsCalculatePFFromEffectiveDate { get; set; }
        public Nullable<bool> IsPFRuleEmployeeContribution { get; set; }
        public Nullable<bool> IsPFRuleEmployerContribution { get; set; }
        public Nullable<bool> IsPFRuleEmployeeProfit { get; set; }
        public Nullable<bool> IsPFRuleEmployerProfit { get; set; }
        public Nullable<int> CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }
    
        public virtual BOPayGrade BOPayGrade { get; set; }
        public virtual BOUser BOUser { get; set; }
        public virtual BOUser BOUser1 { get; set; }
        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPayGradeProvidentFundAllowanceDetail> BOPayGradeProvidentFundAllowanceDetail { get; set; }
    }
}

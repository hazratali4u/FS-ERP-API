using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO{
    [Table("AppCNF.tbl_ExpenseType")]
    public partial class BOExpenseType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOExpenseType()
        {
            BOFieldExpenseType = new HashSet<BOFieldExpenseType>();
            BOExpenseClaimDetails = new HashSet<BOExpenseClaimDetails>();
            BOFieldExpensePolicy = new HashSet<BOFieldExpensePolicy>();
            BOFundDemandRegisterDetail = new HashSet<BOFundDemandRegisterDetail>();
            BOFundDemandRequestDetail = new HashSet<BOFundDemandRequestDetail>();
            BOPayGradeExpenseLimitAllocation = new HashSet<BOPayGradeExpenseLimitAllocation>();
        }

        public short ID { get; set; }
        public string ExpenseTypeName { get; set; }
        public string DisplayName { get; set; }
        public bool ExpenseNature { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string Description { get; set; }
        public Nullable<bool> IsLimitBased { get; set; }
        public Nullable<decimal> MaxAmount { get; set; }
        public Nullable<decimal> AdvanceAmount { get; set; }
        public Nullable<bool> ExpenseCalculationMode { get; set; }
        public Nullable<bool> IsDistanceBasedCalculation { get; set; }
        public Nullable<bool> IsApplicableIfPresent { get; set; }
        public Nullable<int> CompanyCode { get; set; }
        public Nullable<System.DateTime> dtmExported { get; set; }
        public Nullable<System.DateTime> dtmImported { get; set; }
        public System.DateTime dtmCreated { get; set; }
        public System.DateTime dtmLastM { get; set; }
        public int OwnerCode { get; set; }
        public int CreatedByCode { get; set; }
        public int AlteredByCode { get; set; }
        public byte RecordStatusCode { get; set; }


        
        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }

        public virtual BORecordStatus BORecordStatus { get; set; }

        public virtual BOUser BOUser { get; set; }

        public virtual BOUser BOUser1 { get; set; }

        public virtual BOUser BOUser2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOFundDemandRegisterDetail> BOFundDemandRegisterDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOFundDemandRequestDetail> BOFundDemandRequestDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPayGradeExpenseLimitAllocation> BOPayGradeExpenseLimitAllocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOFieldExpensePolicy> BOFieldExpensePolicy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOExpenseClaimDetails> BOExpenseClaimDetails { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOFieldExpenseType> BOFieldExpenseType { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual BOPaymentMode BOPaymentMode { get; set; }


    }
}

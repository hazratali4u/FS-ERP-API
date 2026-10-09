using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FS.ERP.Models.IdentityModel;

namespace FS.ERP.Models.BO
{
    [Table("AppCNF.tbl_FieldExpensePolicy")]
    public partial class BOFieldExpensePolicy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOFieldExpensePolicy()
        {
            this.BOFieldExpensePolicyDetail = new HashSet<BOFieldExpensePolicyDetail>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short ID { get; set; }
        public short ExpenseTypeCode { get; set; }
        public string PolicyName { get; set; }
        public System.DateTime EffectiveFrom { get; set; }
        public Nullable<decimal> PerKMRate { get; set; }
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

        public virtual BOExpenseType BOExpenseType { get; set; }
        public virtual BOOrganizationCompany BOOrganizationCompany { get; set; }
        public virtual BORecordStatus BORecordStatus { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOFieldExpensePolicyDetail> BOFieldExpensePolicyDetail { get; set; }
    }
}

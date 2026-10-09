using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class AllowancesOrBenefitConfiguration : EntityTypeConfiguration<BOAllowancesOrBenefit>
    {
        public AllowancesOrBenefitConfiguration()
        {
            this.HasMany(e => e.BOPayGradeAllowanceOrBenefit)
            .WithRequired(e => e.BOAllowancesOrBenefit)
            .HasForeignKey(e => e.AllowanceOrBenefitAmountCode)
            .WillCascadeOnDelete(false);
        }
    }
}

using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class PayGradeAllowancesOrBenefitConfiguration : EntityTypeConfiguration<BOPayGradeAllowanceOrBenefit>
    {
        public PayGradeAllowancesOrBenefitConfiguration()
        {
                this.Property(e => e.AllowanceOrBenefitAmount)
                .HasPrecision(18, 7);
        }
    }
}

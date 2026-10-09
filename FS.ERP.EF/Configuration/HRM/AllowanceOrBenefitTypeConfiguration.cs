using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class AllowanceOrBenefitTypeConfiguration : EntityTypeConfiguration<BOAllowanceOrBenefitType>
    {
        public AllowanceOrBenefitTypeConfiguration()
        {
               this.HasMany(e => e.BOEmployeeAllowanceOrBenefit)
               .WithOptional(e => e.BOAllowanceOrBenefitType)
               .HasForeignKey(e => e.AllowanceOrBenefitTypeCode)
               .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOPayGradeDeductionAllocation)
            .WithRequired(e => e.BOAllowanceOrBenefitType)
            .HasForeignKey(e => e.DeductionTypeCode)
            .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOPayGradeEarningsAllocation)
           .WithRequired(e => e.BOAllowanceOrBenefitType)
           .HasForeignKey(e => e.AllowanceOrBenefitCode)
           .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOPayGradeEOBIAllowanceDetail)
               .WithRequired(e => e.BOAllowanceOrBenefitType)
               .HasForeignKey(e => e.AllowanceOrBenefitCode)
               .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOPayGradeProvidentFundAllowanceDetail)
                 .WithRequired(e => e.BOAllowanceOrBenefitType)
                 .HasForeignKey(e => e.AllowanceOrBenefitCode)
                 .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOBonusAllowancesMapping)
            .WithRequired(e => e.BOAllowanceOrBenefitType)
            .HasForeignKey(e => e.AllowanceTypeCode)
            .WillCascadeOnDelete(false);
        }
    }
}

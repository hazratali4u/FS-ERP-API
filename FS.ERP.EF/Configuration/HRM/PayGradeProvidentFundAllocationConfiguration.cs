using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class PayGradeProvidentFundAllocationConfiguration : EntityTypeConfiguration<BOPayGradeProvidentFundAllocation>
    {
        public PayGradeProvidentFundAllocationConfiguration()
        {
                this.HasMany(e => e.BOPayGradeProvidentFundAllowanceDetail)
                .WithRequired(e => e.BOPayGradeProvidentFundAllocation)
                .HasForeignKey(e => e.PFCode)
                .WillCascadeOnDelete(false);
        }
    }
}

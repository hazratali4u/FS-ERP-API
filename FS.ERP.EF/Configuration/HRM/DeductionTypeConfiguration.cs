using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class DeductionTypeConfiguration : EntityTypeConfiguration<BODeductionType>
    {
        public DeductionTypeConfiguration()
        {
                this.HasMany(e => e.BOEmployeeSalaryDeduction)
                .WithRequired(e => e.BODeductionType)
                .HasForeignKey(e => e.DeductionTypeCode)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOEmployeeSalaryDeduction)
                .WithRequired(e => e.BODeductionType)
                .HasForeignKey(e => e.DeductionTypeCode)
                .WillCascadeOnDelete(false);
        }
    }
}

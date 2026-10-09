using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class PayrollGroupConfiguration : EntityTypeConfiguration<BOPayrollGroup>
    {
        public PayrollGroupConfiguration()
        {
           this.HasMany(e => e.BOPayGradePayrollGroup)
           .WithRequired(e => e.BOPayrollGroup)
           .HasForeignKey(e => e.PayrollGroupCode)
           .WillCascadeOnDelete(false);
        }
    }
}

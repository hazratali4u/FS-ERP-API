using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class EmployeeLoanConfiguration : EntityTypeConfiguration<BOEmployeeLoan>
    {
        public EmployeeLoanConfiguration()
        {
               this.HasMany(e => e.BOEmployeeLoanInstallment)
               .WithRequired(e => e.BOEmployeeLoan)
               .HasForeignKey(e => e.EmployeeLoanCode)
               .WillCascadeOnDelete(false);

                this.HasMany(e => e.BOReimbursement)
                .WithOptional(e => e.BOEmployeeLoan)
                .HasForeignKey(e => e.EmployeeLoanCode);
        }
    }
}

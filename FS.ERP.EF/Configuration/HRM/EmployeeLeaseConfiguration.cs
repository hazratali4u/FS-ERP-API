using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class EmployeeLeaseConfiguration : EntityTypeConfiguration<BOEmployeeLease>
    {
        public EmployeeLeaseConfiguration()
        {
                this.HasMany(e => e.BOEmployeeLeaseInstallment)
                .WithRequired(e => e.BOEmployeeLease)
                .HasForeignKey(e => e.EmployeeLeaseCode)
                .WillCascadeOnDelete(false);

                this.HasMany(e => e.BOReimbursement)
                .WithOptional(e => e.BOEmployeeLease)
                .HasForeignKey(e => e.EmployeeLeaseCode);
        }
    }
}

using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class EmployeeInfoRevisionConfiguration : EntityTypeConfiguration<BOEmployeeInfoRevision>
    {
        public EmployeeInfoRevisionConfiguration()
        {
                this.Property(e => e.PFAmount)
                .HasPrecision(33, 6);

            this.HasMany(e => e.BOEmployeeInfoRevision1)
                .WithOptional(e => e.BOEmployeeInfoRevision2)
                .HasForeignKey(e => e.FunctionalEmployeeCode);

            this.HasMany(e => e.BOEmployeeInfoRevision11)
                .WithOptional(e => e.BOEmployeeInfoRevision3)
                .HasForeignKey(e => e.ReportingEmployeeCode);

            this.HasMany(e => e.BOEmployeeInfoRevision12)
                .WithOptional(e => e.BOEmployeeInfoRevision4)
                .HasForeignKey(e => e.HODEmployeeCode);
        }
    }
}

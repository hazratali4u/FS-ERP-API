using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class JobRoleConfiguration : EntityTypeConfiguration<BOJobRole>
    {
        public JobRoleConfiguration()
        {
                this.HasMany(e => e.BOEmployeeInfo)
                .WithOptional(e => e.BOJobRole)
                .HasForeignKey(e => e.JobRoleCode);

                this.HasMany(e => e.BOEmployeeInfoRevision)
                .WithOptional(e => e.BOJobRole)
                .HasForeignKey(e => e.JobRoleCode);
        }
    }
}

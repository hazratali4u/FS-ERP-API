using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class TeamInfoConfiguration : EntityTypeConfiguration<BOTeamInfo>
    {
        public TeamInfoConfiguration()
        {
                this.HasMany(e => e.BOEmployeeInfo)
                .WithOptional(e => e.BOTeamInfo)
                .HasForeignKey(e => e.TeamCode)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOTeamMembers)
               .WithRequired(e => e.BOTeamInfo)
               .HasForeignKey(e => e.TeamInfoCode)
               .WillCascadeOnDelete(false);

                this.HasMany(e => e.BOTeamPermissions)
                .WithRequired(e => e.BOTeamInfo)
                .HasForeignKey(e => e.TeamInfoCode)
                .WillCascadeOnDelete(false);
        }
    }
}

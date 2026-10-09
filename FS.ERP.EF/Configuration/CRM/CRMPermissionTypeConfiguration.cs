using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class CRMPermissionTypeConfiguration : EntityTypeConfiguration<BOCRMPermissionType>
    {
        public CRMPermissionTypeConfiguration()
        {
            this.HasMany(e => e.BOTeamPermissions)
            .WithRequired(e => e.BOCRMPermissionType)
            .HasForeignKey(e => e.PermissionTypeCode)
            .WillCascadeOnDelete(false);
        }
    }
}

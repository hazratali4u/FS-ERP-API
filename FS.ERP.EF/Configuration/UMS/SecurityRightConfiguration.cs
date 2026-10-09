using FS.ERP.Models.BO;
using FS.ERP.Models.IdentityModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class SecurityRightConfiguration : EntityTypeConfiguration<BOSecurityRight>
    {
        public SecurityRightConfiguration()
        {
            this.HasMany(e => e.BOProfileGroupDetail)
            .WithRequired(e => e.BOSecurityRight)
            .HasForeignKey(e => e.SecurityRightCode)
            .WillCascadeOnDelete(false);
        }
    }
}

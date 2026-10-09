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
    public class ProfileGroupConfiguration : EntityTypeConfiguration<BOProfileGroup>
    {
        public ProfileGroupConfiguration()
        {
                this.HasMany(e => e.BOProfileGroupDetail)
                .WithRequired(e => e.BOProfileGroup)
                .HasForeignKey(e => e.ProfileGroupCode)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOUser3)
                .WithOptional(e => e.BOProfileGroup3)
                .HasForeignKey(e => e.DefaultProfileGroupCode);

            this.HasMany(e => e.BOUserProfileGroup)
                .WithRequired(e => e.BOProfileGroup)
                .HasForeignKey(e => e.ProfileGroupCode)
                .WillCascadeOnDelete(false);
        }
    }
}

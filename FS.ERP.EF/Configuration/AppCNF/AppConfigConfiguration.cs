using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class AppConfigConfiguration : EntityTypeConfiguration<BOAppConfiguration>
    {
        public AppConfigConfiguration()
        {
               this.HasMany(e => e.BOAppConfiguration1)
               .WithOptional(e => e.BOAppConfiguration2)
               .HasForeignKey(e => e.TemplateCode);

                this.HasMany(e => e.BOAppConfigurationDetail)
                .WithRequired(e => e.BOAppConfiguration)
                .HasForeignKey(e => e.ApplicationConfigurationCode)
                .WillCascadeOnDelete(false);
        }
    }
}

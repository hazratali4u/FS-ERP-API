using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class AppConfigDetailConfiguration : EntityTypeConfiguration<BOAppConfigurationDetail>
    {
        public AppConfigDetailConfiguration()
        {
             this.HasMany(e => e.BOAppConfigurationDetail1)
             .WithOptional(e => e.BOAppConfigurationDetail2)
             .HasForeignKey(e => e.TemplateDetailCode);
        }
    }
}

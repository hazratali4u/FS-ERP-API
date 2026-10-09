using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class ModuleParamInfoConfiguration : EntityTypeConfiguration<BOModuleParamInfo>
    {
        public ModuleParamInfoConfiguration()
        {
                  this.HasMany(e => e.BOMenuControlInfo)
                  .WithOptional(e => e.BOModuleParamInfo)
                  .HasForeignKey(e => e.MenuParamInfoCode);

                this.HasMany(e => e.BOModuleColInfo)
                .WithOptional(e => e.BOModuleParamInfo)
                .HasForeignKey(e => e.MenuParamInfoCode);
        }
    }
}

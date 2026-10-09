using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class MenuControlInfoConfiguration : EntityTypeConfiguration<BOMenuControlInfo>
    {
        public MenuControlInfoConfiguration()
        {
          this.HasMany(e => e.BOModuleColInfo)
          .WithOptional(e => e.BOMenuControlInfo)
          .HasForeignKey(e => e.MenuControlInfoCode);
        }
    }
}

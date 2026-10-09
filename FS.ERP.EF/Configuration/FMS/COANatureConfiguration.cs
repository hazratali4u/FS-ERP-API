using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class COANatureConfiguration : EntityTypeConfiguration<BOCOANature>
    {
        public COANatureConfiguration()
        {
               this.HasMany(e => e.BOCOA)
               .WithOptional(e => e.BOCOANature)
               .HasForeignKey(e => e.COANatureCode);
        }
    }
}

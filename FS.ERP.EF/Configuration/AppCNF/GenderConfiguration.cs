using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class GenderConfiguration : EntityTypeConfiguration<BOIMMGender>
    {
        public GenderConfiguration()
        {
               this.HasMany(e => e.BOItem)
               .WithOptional(e => e.BOIMMGender)
               .HasForeignKey(e => e.IMMGenderCode);
        }
    }
}

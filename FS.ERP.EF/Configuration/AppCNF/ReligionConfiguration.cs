using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class ReligionConfiguration : EntityTypeConfiguration<BOReligion>
    {
        public ReligionConfiguration()
        {
               this.HasMany(e => e.BOEmployeeInfo)
               .WithRequired(e => e.BOReligion)
               .HasForeignKey(e => e.ReligionCode)
               .WillCascadeOnDelete(false);

               this.HasMany(e => e.BOEmployeeHistory)
               .WithOptional(e => e.BOReligion)
               .HasForeignKey(e => e.ReligionCode);

               this.HasMany(e => e.BOCalendar)
               .WithRequired(e => e.BOReligion)
               .HasForeignKey(e => e.EffectedReligion)
               .WillCascadeOnDelete(false);
        }
    }
}

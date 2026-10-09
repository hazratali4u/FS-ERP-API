using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class LoyaltyTypeConfiguration : EntityTypeConfiguration<BOIMMLoyaltyType>
    {
        public LoyaltyTypeConfiguration()
        {
               this.HasMany(e => e.BOLoyaltyPcOrCc)
               .WithRequired(e => e.BOIMMLoyaltyType)
               .HasForeignKey(e => e.LoyaltyTypeCode)
               .WillCascadeOnDelete(false);
        }
    }
}

using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class LoyaltyCardConfiguration : EntityTypeConfiguration<BOLoyaltyCard>
    {
        public LoyaltyCardConfiguration()
        {
               this.HasMany(e => e.BOPartyOrCustomerLoyalty)
               .WithRequired(e => e.BOLoyaltyCard)
               .HasForeignKey(e => e.LoyaltyCardCode)
               .WillCascadeOnDelete(false);
        }
    }
}

using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class DispatchReceiveMediumConfiguration : EntityTypeConfiguration<BODispatchReceiveMedium>
    {
        public DispatchReceiveMediumConfiguration()
        {
                this.HasMany(e => e.BOGRNandReturn)
                .WithRequired(e => e.BODispatchReceiveMedium)
                .HasForeignKey(e => e.DispatchReceiveMediumCode)
                .WillCascadeOnDelete(false);

               this.HasMany(e => e.BOGatePass)
               .WithRequired(e => e.BODispatchReceiveMedium)
               .HasForeignKey(e => e.DispatchReceiveMediumCode)
               .WillCascadeOnDelete(false);
        }
    }
}

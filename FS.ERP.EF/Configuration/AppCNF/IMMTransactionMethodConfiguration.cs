using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class IMMTransactionMethodConfiguration : EntityTypeConfiguration<BOIMMTransactionMethod>
    {
        public IMMTransactionMethodConfiguration()
        {
                this.HasMany(e => e.BOItem)
                .WithOptional(e => e.BOIMMTransactionMethod)
                .HasForeignKey(e => e.IMMTransactionMethodCode);
        }
    }
}

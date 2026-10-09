using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class AcquireTypeConfiguration : EntityTypeConfiguration<BOIMMAcquireType>
    {
        public AcquireTypeConfiguration()
        {
             this.HasMany(e => e.BOItem)
             .WithOptional(e => e.BOIMMAcquireType)
             .HasForeignKey(e => e.IMMAcquireTypeCode);
        }
    }
}

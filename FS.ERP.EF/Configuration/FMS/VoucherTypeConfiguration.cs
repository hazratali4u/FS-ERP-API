using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class VoucherTypeConfiguration : EntityTypeConfiguration<BOVoucherType>
    {
        public VoucherTypeConfiguration()
        {
               this.HasMany(e => e.BOTransactionMaster)
               .WithRequired(e => e.BOVoucherType)
               .HasForeignKey(e => e.VoucherTypeCode)
               .WillCascadeOnDelete(false);
        }
    }
}

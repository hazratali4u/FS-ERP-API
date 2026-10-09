using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class TransactionMasterConfiguration : EntityTypeConfiguration<BOTransactionMaster>
    {
        public TransactionMasterConfiguration()
        {
             this.HasMany(e => e.BOTransactionDetail)
             .WithRequired(e => e.BOTransactionMaster)
             .HasForeignKey(e => e.TransactionCode)
             .WillCascadeOnDelete(false);
        }
    }
}

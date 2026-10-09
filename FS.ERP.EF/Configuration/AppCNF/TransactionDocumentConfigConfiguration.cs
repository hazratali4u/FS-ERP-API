using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class TransactionDocumentConfigConfiguration : EntityTypeConfiguration<BOTransactionDocumentConfiguration>
    {
        public TransactionDocumentConfigConfiguration()
        {
               this.HasMany(e => e.BOTransactionDocumentProcess)
               .WithRequired(e => e.BOTransactionDocumentConfiguration)
               .HasForeignKey(e => e.TransactionDocumentConfigurationCode)
               .WillCascadeOnDelete(false);
        }
    }
}

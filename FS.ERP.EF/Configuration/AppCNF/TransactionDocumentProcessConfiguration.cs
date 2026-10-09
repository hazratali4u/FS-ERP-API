using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class TransactionDocumentProcessConfiguration : EntityTypeConfiguration<BOTransactionDocumentProcess>
    {
        public TransactionDocumentProcessConfiguration()
        {
             this.HasMany(e => e.BOProcessApprovalWorkflow)
             .WithRequired(e => e.BOTransactionDocumentProcess)
             .HasForeignKey(e => e.TransactionDocumentProcessCode)
             .WillCascadeOnDelete(false);

                this.HasMany(e => e.BOProcessApprovalAlert)
                .WithRequired(e => e.BOTransactionDocumentProcess)
                .HasForeignKey(e => e.TransactionDocumentProcessCode)
                .WillCascadeOnDelete(false);
        }
    }
}

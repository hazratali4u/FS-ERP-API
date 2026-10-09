using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class DocumentOfStatementConfiguration : EntityTypeConfiguration<BODocumentOfStatement>
    {
        public DocumentOfStatementConfiguration()
        {
           this.HasMany(e => e.BODocumentDetailOfStatement)
           .WithRequired(e => e.BODocumentOfStatement)
           .HasForeignKey(e => e.DocumentOfStatementCode)
           .WillCascadeOnDelete(false);

                this.HasMany(e => e.BOFiscalYearMonthDetail)
                .WithOptional(e => e.BODocumentOfStatement)
                .HasForeignKey(e => e.DocumentOfStatementCode);
        }
    }
}

using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class DocumentDetailOfStatementConfiguration : EntityTypeConfiguration<BODocumentDetailOfStatement>
    {
        public DocumentDetailOfStatementConfiguration()
        {
                this.HasMany(e => e.BOFiscalYearMonthDetail)
                .WithOptional(e => e.BODocumentDetailOfStatement)
                .HasForeignKey(e => e.DocumentOfStatementDetailCode);
        }
    }
}

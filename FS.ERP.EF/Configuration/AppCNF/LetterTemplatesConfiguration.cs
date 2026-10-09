using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class LetterTemplatesConfiguration : EntityTypeConfiguration<BOLetterTemplates>
    {
        public LetterTemplatesConfiguration()
        {
               this.HasMany(e => e.BOGenerateLetter)
               .WithRequired(e => e.BOLetterTemplates)
               .HasForeignKey(e => e.LetterTemplateCode)
               .WillCascadeOnDelete(false);
        }
    }
}

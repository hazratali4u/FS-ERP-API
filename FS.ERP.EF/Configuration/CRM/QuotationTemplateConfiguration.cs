using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class QuotationTemplateConfiguration : EntityTypeConfiguration<BOQuotationTemplate>
    {
        public QuotationTemplateConfiguration()
        {
             this.HasMany(e => e.BOQuotationParameterMapping)
             .WithOptional(e => e.BOQuotationTemplate)
             .HasForeignKey(e => e.QuotationTemplateCode)
             .WillCascadeOnDelete(false);

             this.HasMany(e => e.BOGenerateQuotation)
             .WithOptional(e => e.BOQuotationTemplate)
             .HasForeignKey(e => e.QuotationTemplateCode)
             .WillCascadeOnDelete(false);
        }
    }
}

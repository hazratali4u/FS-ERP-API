using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class QuotationParameterConfiguration : EntityTypeConfiguration<BOQuotationParameter>
    {
        public QuotationParameterConfiguration()
        {
            this
             .HasMany(e => e.BOQuotationParameterMapping)
             .WithOptional(e => e.BOQuotationParameter)
             .HasForeignKey(e => e.QuotationParameterCode)
             .WillCascadeOnDelete(false);

            this
             .HasMany(e => e.BOGenerateQuotationDetail)
             .WithOptional(e => e.BOQuotationParameter)
             .HasForeignKey(e => e.QuotationParameterCode)
             .WillCascadeOnDelete(false);

            this
             .HasMany(e => e.BOQuotationParameterDetail)
             .WithOptional(e => e.BOQuotationParameter)
             .HasForeignKey(e => e.QuotationParameterCode)
             .WillCascadeOnDelete(false);
        }
    }
}

using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class QuotationParameterMappingConfiguration : EntityTypeConfiguration<BOQuotationParameterMapping>
    {
        public QuotationParameterMappingConfiguration()
        {
             this.HasMany(e => e.BOQuotationParameterItemDetail)
             .WithOptional(e => e.BOQuotationParameterMapping)
             .HasForeignKey(e => e.QuotationParameterMappingCode)
             .WillCascadeOnDelete(false);
        }
    }
}

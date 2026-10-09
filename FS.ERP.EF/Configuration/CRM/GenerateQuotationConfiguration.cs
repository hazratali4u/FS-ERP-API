using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class GenerateQuotationConfiguration : EntityTypeConfiguration<BOGenerateQuotation>
    {
        public GenerateQuotationConfiguration()
        {
             this.HasMany(e => e.BOGenerateQuotationDetail)
             .WithOptional(e => e.BOGenerateQuotation)
             .HasForeignKey(e => e.GenerateQuotationCode)
             .WillCascadeOnDelete(false);
        }
    }
}

using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class ReceipeDetailConfiguration : EntityTypeConfiguration<BOReceipeDetail>
    {
        public ReceipeDetailConfiguration()
        {
               this.HasMany(e => e.BOProductionDetail)
               .WithRequired(e => e.BOReceipeDetail)
               .HasForeignKey(e => e.ReceipeMasterDetailCode)
               .WillCascadeOnDelete(false);
        }
    }
}

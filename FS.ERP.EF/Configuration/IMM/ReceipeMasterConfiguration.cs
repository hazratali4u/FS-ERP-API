using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class ReceipeMasterConfiguration : EntityTypeConfiguration<BOReceipeMaster>
    {
        public ReceipeMasterConfiguration()
        {
                this.HasMany(e => e.BOProductionMaster)
                .WithRequired(e => e.BOReceipeMaster)
                .HasForeignKey(e => e.ReceipeMasterCode)
                .WillCascadeOnDelete(false);

               this.HasMany(e => e.BOReceipeDetail)
               .WithRequired(e => e.BOReceipeMaster)
               .HasForeignKey(e => e.ReceipeMasterCode)
               .WillCascadeOnDelete(false);
        }
    }
}

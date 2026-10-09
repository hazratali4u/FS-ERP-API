using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class PipeLineConfiguration : EntityTypeConfiguration<BOPipeline>
    {
        public PipeLineConfiguration()
        {
                this.HasMany(e => e.BOTeamPermissions)
                .WithRequired(e => e.BOPipeline)
                .HasForeignKey(e => e.PipelineCode)
                .WillCascadeOnDelete(false);

                this.HasMany(e => e.BOPipelineDetail)
                .WithRequired(e => e.BOPipeline)
                .HasForeignKey(e => e.PipelineCode)
                .WillCascadeOnDelete(false);

               this.HasMany(e => e.BOOpportunity)
               .WithRequired(e => e.BOPipeline)
               .HasForeignKey(e => e.PipelineCode)
               .WillCascadeOnDelete(false);
        }
    }
}

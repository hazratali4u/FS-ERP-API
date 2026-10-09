using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class JobCardConfiguration : EntityTypeConfiguration<BOJobCard>
    {
        public JobCardConfiguration()
        {
            this.HasMany(e => e.BOJobCardDetail)
            .WithRequired(e => e.BOJobCard)
            .HasForeignKey(e => e.JobCardCode)
            .WillCascadeOnDelete(false);
        }
    }
}

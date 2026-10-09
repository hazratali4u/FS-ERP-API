using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class LeadConfiguration : EntityTypeConfiguration<BOLead>
    {
        public LeadConfiguration()
        {
                this.HasMany(e => e.BOLeadActivity)
                .WithRequired(e => e.BOLead)
                .HasForeignKey(e => e.LeadCode)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOLeadTask)
               .WithRequired(e => e.BOLead)
               .HasForeignKey(e => e.LeadCode)
               .WillCascadeOnDelete(false);
        }
    }
}

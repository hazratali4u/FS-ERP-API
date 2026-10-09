using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class IMMFinishTypeOptionsConfiguration : EntityTypeConfiguration<BOIMMFinishTypeOptions>
    {
        public IMMFinishTypeOptionsConfiguration()
        {
            this.HasMany(e => e.BOSubjectToDeliver)
            .WithRequired(e => e.BOIMMFinishTypeOptions)
            .HasForeignKey(e => e.IMMFinishTypeCode)
            .WillCascadeOnDelete(false);
        }
    }
}

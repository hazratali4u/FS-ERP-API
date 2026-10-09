using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class SeparationTypeOrReasonConfiguration : EntityTypeConfiguration<BOSeparationTypeOrReason>
    {
        public SeparationTypeOrReasonConfiguration()
        {
          this.HasMany(e => e.BOSeparationSubmission)
          .WithRequired(e => e.BOSeparationTypeOrReason)
          .HasForeignKey(e => e.ExitTypeCode)
          .WillCascadeOnDelete(false);

                this.HasMany(e => e.BOSeparationSubmission1)
                .WithRequired(e => e.BOSeparationTypeOrReason1)
                .HasForeignKey(e => e.ExitReasonCode)
                .WillCascadeOnDelete(false);

             this.HasMany(e => e.BOSeparationTypeOrReason1)
             .WithOptional(e => e.BOSeparationTypeOrReason2)
             .HasForeignKey(e => e.ExitTypeCode)
             .WillCascadeOnDelete(false);
        }
    }
}

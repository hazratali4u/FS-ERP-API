using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class ReimbursementTypeConfiguration : EntityTypeConfiguration<BOReimbursementType>
    {
        public ReimbursementTypeConfiguration()
        {
                this.HasMany(e => e.BOReimbursement)
                .WithRequired(e => e.BOReimbursementType)
                .HasForeignKey(e => e.ReimbursementTypeCode)
                .WillCascadeOnDelete(false);
        }
    }
}

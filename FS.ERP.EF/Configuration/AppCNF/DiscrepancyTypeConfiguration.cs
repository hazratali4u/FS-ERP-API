using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class DiscrepancyTypeConfiguration : EntityTypeConfiguration<BODiscrepancyType>
    {
        public DiscrepancyTypeConfiguration()
        {
                this.Property(e => e.IsForAttendance)
                .IsFixedLength();

                this.HasMany(e => e.BOAttendanceDiscrepancy)
                .WithRequired(e => e.BODiscrepancyType)
                .HasForeignKey(e => e.DiscrepancyType)
                .WillCascadeOnDelete(false);

                 this.HasMany(e => e.BOAttendanceDiscrepancy1)
                .WithRequired(e => e.BODiscrepancyType1)
                .HasForeignKey(e => e.ActualDiscrepancyType)
                .WillCascadeOnDelete(false);
        }
    }
}

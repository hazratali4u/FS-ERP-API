using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class IncrementOrDecrementTypeConfiguration : EntityTypeConfiguration<BOIncrementOrDecrementType>
    {
        public IncrementOrDecrementTypeConfiguration()
        {
            this.HasMany(e => e.BOEmployeeIncrement)
            .WithRequired(e => e.BOIncrementOrDecrementType)
            .HasForeignKey(e => e.IncrementDecrementTypeCode)
            .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOIncrementOrDecrementRules)
            .WithRequired(e => e.BOIncrementOrDecrementType)
            .HasForeignKey(e => e.IncrementDecrementTypeCode)
            .WillCascadeOnDelete(false);
        }
    }
}

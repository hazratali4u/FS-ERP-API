using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class EmployeeRelationConfiguration : EntityTypeConfiguration<BOEmployeeRelation>
    {
        public EmployeeRelationConfiguration()
        {
            this.HasMany(e => e.BOEmployeeReference)
            .WithRequired(e => e.BOEmployeeRelation)
            .HasForeignKey(e => e.EmployeeRelationCode)
            .WillCascadeOnDelete(false);

              this.HasMany(e => e.BOEmployeeFamily)
              .WithRequired(e => e.BOEmployeeRelation)
              .HasForeignKey(e => e.RelationCode)
              .WillCascadeOnDelete(false);
        }
    }
}

using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class DegreeConfiguration : EntityTypeConfiguration<BODegree>
    {
        public DegreeConfiguration()
        {
            this.HasMany(e => e.BOEmployeeAcademic)
            .WithRequired(e => e.BODegree)
            .HasForeignKey(e => e.DegreeCode)
            .WillCascadeOnDelete(false);
        }
    }
}

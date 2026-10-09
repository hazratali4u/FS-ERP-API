using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class DegreeInstituteConfiguration : EntityTypeConfiguration<BODegreeInstitute>
    {
        public DegreeInstituteConfiguration()
        {
            this.Property(e => e.Longitude)
            .HasPrecision(18, 7);

            this.Property(e => e.Latitude)
                .HasPrecision(18, 7);

            this.Property(e => e.Altitude)
                .HasPrecision(18, 7);

            this.Property(e => e.Radius)
                .HasPrecision(18, 7);

            this.HasMany(e => e.BOEmployeeAcademic)
               .WithRequired(e => e.BODegreeInstitute)
               .HasForeignKey(e => e.DegreeInstituteCode)
               .WillCascadeOnDelete(false);
        }
    }
}

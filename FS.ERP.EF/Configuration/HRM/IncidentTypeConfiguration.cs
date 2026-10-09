using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class IncidentTypeConfiguration : EntityTypeConfiguration<BOIncidentType>
    {
        public IncidentTypeConfiguration()
        {
            this.HasMany(e => e.BOEmployeeIncident)
            .WithRequired(e => e.BOIncidentType)
            .HasForeignKey(e => e.IncidentCode)
            .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOEmployeeIncident)
            .WithRequired(e => e.BOIncidentType)
            .HasForeignKey(e => e.IncidentCode)
            .WillCascadeOnDelete(false);
        }
    }
}

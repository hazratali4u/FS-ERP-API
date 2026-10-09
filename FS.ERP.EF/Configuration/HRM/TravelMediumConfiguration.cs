using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class TravelMediumConfiguration : EntityTypeConfiguration<BOTravellingMedium>
    {
        public TravelMediumConfiguration()
        {
            this.HasMany(e => e.BOTravelRequestDetails)
            .WithOptional(e => e.BOTravellingMedium)
            .HasForeignKey(e => e.TravelMediumCode)
            .WillCascadeOnDelete(false);
        }
    }
}

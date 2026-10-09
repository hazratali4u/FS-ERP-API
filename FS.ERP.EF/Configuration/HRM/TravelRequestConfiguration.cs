using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class TravelRequestConfiguration : EntityTypeConfiguration<BOTravelRequest>
    {
        public TravelRequestConfiguration()
        {
             this.HasMany(e => e.BOTravelRequestDetails)
             .WithRequired(e => e.BOTravelRequest)
             .HasForeignKey(e => e.TravelRequestCode)
             .WillCascadeOnDelete(false);
        }
    }
}

using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class LeavePolicyDetailConfiguration : EntityTypeConfiguration<BOLeavePolicyDetail>
    {
        public LeavePolicyDetailConfiguration()
        {
            this.Property(e => e.ServiceInYear)
            .HasPrecision(18, 7);
        }
    }
}

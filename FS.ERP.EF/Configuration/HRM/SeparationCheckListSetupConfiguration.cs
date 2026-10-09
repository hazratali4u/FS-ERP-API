using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class SeparationCheckListSetupConfiguration : EntityTypeConfiguration<BOSeparationChecklistSetup>
    {
        public SeparationCheckListSetupConfiguration()
        {
                 this.HasMany(e => e.BOSeparationCheckList)
                 .WithRequired(e => e.BOSeparationChecklistSetup)
                 .HasForeignKey(e => e.ClearanceID)
                 .WillCascadeOnDelete(false);
        }
    }
}

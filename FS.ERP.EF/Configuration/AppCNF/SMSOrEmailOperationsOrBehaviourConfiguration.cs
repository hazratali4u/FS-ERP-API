using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class SMSOrEmailOperationsOrBehaviourConfiguration : EntityTypeConfiguration<BOSMSOrEmailOperationsOrBehaviour>
    {
        public SMSOrEmailOperationsOrBehaviourConfiguration()
        {
           this.HasMany(e => e.BOSMSOrEmailDescription)
           .WithOptional(e => e.BOSMSOrEmailOperationsOrBehaviour)
           .HasForeignKey(e => e.OperationCode)
           .WillCascadeOnDelete(false);
        }
    }
}

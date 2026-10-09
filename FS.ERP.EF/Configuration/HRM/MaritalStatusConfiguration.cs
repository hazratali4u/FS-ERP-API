using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class MaritalStatusConfiguration : EntityTypeConfiguration<BOMaritalStatus>
    {
        public MaritalStatusConfiguration()
        {
                 this.HasMany(e => e.BOEmployeeInfo)
                 .WithRequired(e => e.BOMaritalStatus)
                 .HasForeignKey(e => e.MaritalStatusCode)
                 .WillCascadeOnDelete(false);
        }
    }
}

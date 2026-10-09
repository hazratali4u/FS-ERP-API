using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class DesignationConfiguration : EntityTypeConfiguration<BODesignation>
    {
        public DesignationConfiguration()
        {
                this.HasMany(e => e.BOProcessApprovalWorkflow)
                .WithOptional(e => e.BODesignation)
                .HasForeignKey(e => e.DesignationCode)
                .WillCascadeOnDelete(false);

               this.HasMany(e => e.BOEmployeeInfo)
               .WithRequired(e => e.BODesignation)
               .HasForeignKey(e => e.DesignationCode)
               .WillCascadeOnDelete(false);

                this.HasMany(e => e.BOEmployeeInfoRevision)
                .WithRequired(e => e.BODesignation)
                .HasForeignKey(e => e.DesignationCode)
                .WillCascadeOnDelete(false);
        }
    }
}

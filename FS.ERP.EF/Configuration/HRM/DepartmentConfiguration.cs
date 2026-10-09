using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class DepartmentConfiguration : EntityTypeConfiguration<BODepartment>
    {
        public DepartmentConfiguration()
        {
                this.HasMany(e => e.BOProcessApprovalWorkflow)
                .WithOptional(e => e.BODepartment)
                .HasForeignKey(e => e.DeptCode);

            this.HasMany(e => e.BODepartment1)
                .WithOptional(e => e.BODepartment2)
                .HasForeignKey(e => e.ParentCode);

            this.HasMany(e => e.BODesignation)
                .WithOptional(e => e.BODepartment)
                .HasForeignKey(e => e.DepartmentCode);

            this.HasMany(e => e.BODocumentCheckList)
                .WithOptional(e => e.BODepartment)
                .HasForeignKey(e => e.DepartmentCode);

            this.HasMany(e => e.BOEmployeeInfo)
                .WithRequired(e => e.BODepartment)
                .HasForeignKey(e => e.DeptCode)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOEmployeeInfoRevision)
                .WithRequired(e => e.BODepartment)
                .HasForeignKey(e => e.DeptCode)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOSeparationChecklistSetup)
           .WithRequired(e => e.BODepartment)
           .HasForeignKey(e => e.DeptCode)
           .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOSeparationChecklistSetup1)
                .WithRequired(e => e.BODepartment1)
                .HasForeignKey(e => e.DeptID)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOPayrollCOAMapping)
                .WithOptional(e => e.BODepartment)
                .HasForeignKey(e => e.DeptCode)
                .WillCascadeOnDelete(false);
        }
    }
}

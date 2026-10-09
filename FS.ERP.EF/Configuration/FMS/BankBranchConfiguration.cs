using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class BankBranchConfiguration : EntityTypeConfiguration<BOBankBranch>
    {
        public BankBranchConfiguration()
        {
             this.HasMany(e => e.BOBankAccount)
             .WithRequired(e => e.BOBankBranch)
             .HasForeignKey(e => e.BankBranchCode)
             .WillCascadeOnDelete(false);

                this.HasMany(e => e.BOEmployeeInfo)
                .WithOptional(e => e.BOBankBranch)
                .HasForeignKey(e => e.BankBranchCode);

                this.HasMany(e => e.BOEmployeeInfoRevision)
                .WithOptional(e => e.BOBankBranch)
                .HasForeignKey(e => e.BankBranchCode);

                this.HasMany(e => e.BOEmployeeSalary)
                .WithOptional(e => e.BOBankBranch)
                .HasForeignKey(e => e.BankBranchCode);
        }
    }
}

using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class ExpenseTypeConfiguration : EntityTypeConfiguration<BOExpenseType>
    {
        public ExpenseTypeConfiguration()
        {
                this.HasMany(e => e.BOFundDemandRegisterDetail)
                .WithOptional(e => e.BOExpenseType)
                .HasForeignKey(e => e.ExpenseTypeCode);

                this.HasMany(e => e.BOFundDemandRequestDetail)
                .WithOptional(e => e.BOExpenseType)
                .HasForeignKey(e => e.ExpenseTypeCode);

               this.HasMany(e => e.BOPayGradeExpenseLimitAllocation)
               .WithRequired(e => e.BOExpenseType)
               .HasForeignKey(e => e.ExpenseTypeCode)
               .WillCascadeOnDelete(false);

           this.HasMany(e => e.BOFieldExpensePolicy)
           .WithRequired(e => e.BOExpenseType)
           .HasForeignKey(e => e.ExpenseTypeCode)
           .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOExpenseClaimDetails)
            .WithRequired(e => e.BOExpenseType)
            .HasForeignKey(e => e.ExpenseTypeCode)
            .WillCascadeOnDelete(false);

           this.HasMany(e => e.BOFieldExpenseType)
           .WithRequired(e => e.BOExpenseType)
           .HasForeignKey(e => e.ExpenseTypeCode)
           .WillCascadeOnDelete(false);

        }
    }
}

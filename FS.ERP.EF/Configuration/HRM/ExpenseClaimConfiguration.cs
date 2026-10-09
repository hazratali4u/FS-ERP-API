using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class ExpenseClaimConfiguration : EntityTypeConfiguration<BOExpenseClaim>
    {
        public ExpenseClaimConfiguration()
        {
         this.HasMany(e => e.BOExpenseClaimDetails)
         .WithRequired(e => e.BOExpenseClaim)
         .HasForeignKey(e => e.ExpenseClaimCode)
         .WillCascadeOnDelete(false);
        }
    }
}

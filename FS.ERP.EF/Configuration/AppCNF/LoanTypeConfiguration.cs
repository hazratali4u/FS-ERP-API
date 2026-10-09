using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class LoanTypeConfiguration : EntityTypeConfiguration<BOLoanType>
    {
        public LoanTypeConfiguration()
        {
             this.HasMany(e => e.BOEmployeeLoan)
             .WithRequired(e => e.BOLoanType)
             .HasForeignKey(e => e.LoanTypeCode)
             .WillCascadeOnDelete(false);
        }
    }
}

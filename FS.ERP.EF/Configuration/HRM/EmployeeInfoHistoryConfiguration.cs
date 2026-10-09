using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class EmployeeInfoHistoryConfiguration : EntityTypeConfiguration<BOEmployeeInfoHistory>
    {
        public EmployeeInfoHistoryConfiguration()
        {
            this
                .Property(e => e.BasicPay)
                .HasPrecision(38, 2);

            this
                .Property(e => e.Salary)
                .HasPrecision(38, 2);

            this
                .Property(e => e.EOBI)
                .HasPrecision(38, 2);

            this
                .Property(e => e.HospitalDeduction)
                .HasPrecision(38, 2);

            this
                .Property(e => e.MaternityDeduction)
                .HasPrecision(38, 2);

            this
                .Property(e => e.MonthlyTax)
                .HasPrecision(38, 2);

            this
                .Property(e => e.AnnaulTax)
                .HasPrecision(38, 2);

            this
                .Property(e => e.PFAmount)
                .HasPrecision(38, 6);
        }
    }
}

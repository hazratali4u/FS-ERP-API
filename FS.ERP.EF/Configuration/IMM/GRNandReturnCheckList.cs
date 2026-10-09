using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class GRNandReturnCheckList : EntityTypeConfiguration<BOGRNandReturnCheckList>
    {
        public GRNandReturnCheckList()
        {
            this.HasMany(e => e.BOGRNandReturnCheckList1)
            .WithRequired(e => e.BOGRNandReturnCheckList2)
            .HasForeignKey(e => e.GRNandReturnCode)
            .WillCascadeOnDelete(false);
        }
    }
}

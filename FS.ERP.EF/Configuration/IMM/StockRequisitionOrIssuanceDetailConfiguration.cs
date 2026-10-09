using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class StockRequisitionOrIssuanceDetailConfiguration : EntityTypeConfiguration<BOStockRequisitionOrIssuanceDetail>
    {
        public StockRequisitionOrIssuanceDetailConfiguration()
        {
            this.HasMany(e => e.BOStockRequisitionOrIssuanceDetail1)
            .WithOptional(e => e.BOStockRequisitionOrIssuanceDetail2)
            .HasForeignKey(e => e.StockRequisitionOrIssuanceDetailCode)
            .WillCascadeOnDelete(false);
        }
    }
}

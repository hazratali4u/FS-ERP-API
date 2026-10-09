using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class StockRequisitionOrIssuanceConfiguration : EntityTypeConfiguration<BOStockRequisitionOrIssuance>
    {
        public StockRequisitionOrIssuanceConfiguration()
        {
                this.HasMany(e => e.BOStockRequisitionOrIssuance1)
                .WithRequired(e => e.BOStockRequisitionOrIssuance2)
                .HasForeignKey(e => e.StockRequisitionOrIssuanceCode)
                .WillCascadeOnDelete(false);

                this.HasMany(e => e.BOStockRequisitionOrIssuanceDetail)
                .WithRequired(e => e.BOStockRequisitionOrIssuance)
                .HasForeignKey(e => e.StockRequisitionOrIssuanceCode)
                .WillCascadeOnDelete(false);

               this.HasMany(e => e.BOProductionMaster)
               .WithRequired(e => e.BOStockRequisitionOrIssuance)
               .HasForeignKey(e => e.StockRequisitionOrIssuanceCode)
               .WillCascadeOnDelete(false);
        }
    }
}

using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class ProductionMasterConfiguration : EntityTypeConfiguration<BOProductionMaster>
    {
        public ProductionMasterConfiguration()
        {
                this.HasMany(e => e.BOProductionDetail)
                .WithRequired(e => e.BOProductionMaster)
                .HasForeignKey(e => e.ProductionMasterCode)
                .WillCascadeOnDelete(false);
        }
    }
}

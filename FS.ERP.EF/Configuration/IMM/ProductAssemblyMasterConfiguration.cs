using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class ProductAssemblyMasterConfiguration : EntityTypeConfiguration<BOProductAssemblyMaster>
    {
        public ProductAssemblyMasterConfiguration()
        {
            this
                 .HasMany(e => e.BOProductAssemblyDetail)
                 .WithRequired(e => e.BOProductAssemblyMaster)
                 .HasForeignKey(e => e.ProductAssemblyCode)
                 .WillCascadeOnDelete(false);
        }
    }
}

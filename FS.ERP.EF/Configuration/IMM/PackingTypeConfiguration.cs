using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class PackingTypeConfiguration : EntityTypeConfiguration<BOPackingType>
    {
        public PackingTypeConfiguration()
        {
               this.HasMany(e => e.BOItem)
               .WithOptional(e => e.BOPackingType)
               .HasForeignKey(e => e.PackingTypeCode);

                this.HasMany(e => e.BOJobProjectSchemeDetail)
                .WithOptional(e => e.BOPackingType)
                .HasForeignKey(e => e.PackTypeCode);
        }
    }
}

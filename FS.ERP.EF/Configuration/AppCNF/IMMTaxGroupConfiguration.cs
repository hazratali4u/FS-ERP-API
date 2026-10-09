using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class IMMTaxGroupConfiguration : EntityTypeConfiguration<BOIMMManufacturedBy>
    {
        public IMMTaxGroupConfiguration()
        {
            this.HasMany(e => e.BOItem)
            .WithOptional(e => e.BOIMMManufacturedBy)
            .HasForeignKey(e => e.IMMManufacturedByCode);
        }
    }
}

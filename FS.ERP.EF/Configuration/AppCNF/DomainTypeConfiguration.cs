using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class DomainTypeConfiguration : EntityTypeConfiguration<BODomainType>
    {
        public DomainTypeConfiguration()
        {
            this.HasMany(e => e.BOAppConfiguration)
            .WithOptional(e => e.BODomainType)
            .HasForeignKey(e => e.DomainTypeCode);
        }
    }
}

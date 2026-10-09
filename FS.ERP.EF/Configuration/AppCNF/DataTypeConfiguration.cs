using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class DataTypeConfiguration : EntityTypeConfiguration<BODataType>
    {
        public DataTypeConfiguration()
        {
            this.HasMany(e => e.BOAppConfiguration)
            .WithRequired(e => e.BODataType)
            .HasForeignKey(e => e.DataTypeCode)
            .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOAppConfigurationDetail)
                .WithRequired(e => e.BODataType)
                .HasForeignKey(e => e.DataTypeCode)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOMenuControlInfo)
                .WithOptional(e => e.BODataType)
                .HasForeignKey(e => e.DataTypeCode);

            this.HasMany(e => e.BOModuleColInfo)
                .WithOptional(e => e.BODataType)
                .HasForeignKey(e => e.DataTypeCode);
        }
    }
}

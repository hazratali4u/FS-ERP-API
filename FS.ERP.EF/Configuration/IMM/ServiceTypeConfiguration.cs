using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class ServiceTypeConfiguration : EntityTypeConfiguration<BOServiceType>
    {
        public ServiceTypeConfiguration()
        {
            this
           .HasMany(e => e.BOItemOrProfileServiceType)
           .WithRequired(e => e.BOServiceType)
           .HasForeignKey(e => e.ServiceTypeCode)
           .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOServiceType1)
               .WithRequired(e => e.BOServiceType2)
               .HasForeignKey(e => e.ServiceCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOPartyOrCustomerServiceType)
               .WithRequired(e => e.BOServiceType)
               .HasForeignKey(e => e.ServiceTypeCode)
               .WillCascadeOnDelete(false);

            this
              .HasMany(e => e.BOVendorOrSupplierServiceType)
              .WithRequired(e => e.BOServiceType)
              .HasForeignKey(e => e.ServiceTypeCode)
              .WillCascadeOnDelete(false);
        }
    }
}

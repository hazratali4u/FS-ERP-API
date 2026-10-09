using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class VendorOrSupplierConfiguration : EntityTypeConfiguration<BOVendorOrSupplier>
    {
        public VendorOrSupplierConfiguration()
        {
            this.Property(e => e.Longitude)
               .HasPrecision(18, 7);

            this.Property(e => e.Latitude)
                .HasPrecision(18, 7);

            this.Property(e => e.Altitude)
                .HasPrecision(18, 7);

            this.Property(e => e.Radius)
                .HasPrecision(18, 7);

            this.HasMany(e => e.BORemittanceAdvice)
                .WithOptional(e => e.BOVendorOrSupplier)
                .HasForeignKey(e => e.VendorSupplierCode);

            this.HasMany(e => e.BOUserVendorOrSupplierPermission)
                .WithRequired(e => e.BOVendorOrSupplier)
                .HasForeignKey(e => e.VendorOrSupplierCode)
                .WillCascadeOnDelete(false);

                this.HasMany(e => e.BOVendorOrSupplier1)
                .WithOptional(e => e.BOVendorOrSupplier2)
                .HasForeignKey(e => e.ParentCode);

            this
                .HasMany(e => e.BOStockRequisitionOrIssuanceDetail)
                .WithRequired(e => e.BOVendorOrSupplier)
                .HasForeignKey(e => e.VendorOrSupplierCode)
                .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOVendorOrSupplierWiseItem)
               .WithRequired(e => e.BOVendorOrSupplier)
               .HasForeignKey(e => e.VendorOrSupplierCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOGatePass)
               .WithRequired(e => e.BOVendorOrSupplier)
               .HasForeignKey(e => e.VendorOrSupplierCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOGRNandReturn)
               .WithOptional(e => e.BOVendorOrSupplier)
               .HasForeignKey(e => e.VendorOrSupplierCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOGRNandReturnDetail)
               .WithRequired(e => e.BOVendorOrSupplier)
               .HasForeignKey(e => e.VendorOrSupplierCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOPurchaseOrderAndReturnDetail)
               .WithOptional(e => e.BOVendorOrSupplier)
               .HasForeignKey(e => e.VendorOrSupplierCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOVendorOrSupplierServiceType)
               .WithRequired(e => e.BOVendorOrSupplier)
               .HasForeignKey(e => e.VendorOrSupplierCode)
               .WillCascadeOnDelete(false);
        }
    }
}

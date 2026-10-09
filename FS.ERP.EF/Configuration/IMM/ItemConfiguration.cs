using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class ItemConfiguration : EntityTypeConfiguration<BOItem>
    {
        public ItemConfiguration()
        {
            this
                .Property(e => e.DefaultQty)
                .HasPrecision(18, 7);

            this
                .Property(e => e.MinLevel)
                .HasPrecision(18, 7);

            this
                .Property(e => e.ReOrderLevel)
                .HasPrecision(18, 7);

            this
                .Property(e => e.MaxLevel)
                .HasPrecision(18, 7);

            this
                .Property(e => e.PurchaseConversionFactor)
                .HasPrecision(18, 7);

            this
                .Property(e => e.SaleConversionFactor)
                .HasPrecision(18, 7);

            this
                .Property(e => e.AssemblyConversionFactor)
                .HasPrecision(18, 7);

            this
                .HasMany(e => e.BOItemAttributeAspect)
                .WithRequired(e => e.BOItem)
                .HasForeignKey(e => e.ItemCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOItemAttributeAspectDetail)
                .WithRequired(e => e.BOItem)
                .HasForeignKey(e => e.ItemCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOItemPrice)
                .WithRequired(e => e.BOItem)
                .HasForeignKey(e => e.ItemCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOItemProfile)
                .WithRequired(e => e.BOItem)
                .HasForeignKey(e => e.ItemCode)
                .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOVendorOrSupplierWiseItem)
               .WithRequired(e => e.BOItem)
               .HasForeignKey(e => e.ItemCode)
               .WillCascadeOnDelete(false);

            this
              .HasMany(e => e.BOItemOrProfileServiceType)
              .WithRequired(e => e.BOItem)
              .HasForeignKey(e => e.ItemCode)
              .WillCascadeOnDelete(false);

            this
              .HasMany(e => e.BOItemDeal)
              .WithRequired(e => e.BOItem)
              .HasForeignKey(e => e.ItemCode)
              .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOItemModifier)
               .WithRequired(e => e.BOItem)
               .HasForeignKey(e => e.ItemCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOItemModifier1)
               .WithRequired(e => e.BOItem1)
               .HasForeignKey(e => e.ItemModifierCode)
               .WillCascadeOnDelete(false);

            this
             .HasMany(e => e.BOItemImages)
             .WithRequired(e => e.BOItem)
             .HasForeignKey(e => e.ItemCode)
             .WillCascadeOnDelete(false);

            this
            .HasMany(e => e.BOLocationSiteWiseItem)
            .WithOptional(e => e.BOItem)
            .HasForeignKey(e => e.ItemCode)
            .WillCascadeOnDelete(false);

            this
             .HasMany(e => e.BOItemProfileBarCode)
             .WithRequired(e => e.BOItem)
             .HasForeignKey(e => e.ItemCode)
             .WillCascadeOnDelete(false);
        }
    }
}

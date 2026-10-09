using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class ItemProfileConfiguration : EntityTypeConfiguration<BOItemProfile>
    {
        public ItemProfileConfiguration()
        {
            this
            .HasMany(e => e.BOItemPrice)
            .WithOptional(e => e.BOItemProfile)
            .HasForeignKey(e => e.ItemProfileCode);

            this
                .HasMany(e => e.BOItemAttributeAspect)
                .WithOptional(e => e.BOItemProfile)
                .HasForeignKey(e => e.ItemProfileCode);

            this
                .HasMany(e => e.BOStockRequisitionOrIssuanceDetail)
                .WithRequired(e => e.BOItemProfile)
                .HasForeignKey(e => e.ItemProfileCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOStockRequisitionOrIssuanceDetail1)
                .WithRequired(e => e.BOItemProfile1)
                .HasForeignKey(e => e.ItemProfileReplacedCode)
                .WillCascadeOnDelete(false);

            this
   .HasMany(e => e.BOVendorOrSupplierWiseItem)
   .WithRequired(e => e.BOItemProfile)
   .HasForeignKey(e => e.ItemProfileCode)
   .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOGatePassDetail)
               .WithRequired(e => e.BOItemProfile)
               .HasForeignKey(e => e.ItemProfileCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOGRNandReturnDetail)
               .WithOptional(e => e.BOItemProfile)
               .HasForeignKey(e => e.ItemProfileCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOPurchaseOrderAndReturnDetail)
               .WithRequired(e => e.BOItemProfile)
               .HasForeignKey(e => e.ItemProfileCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOProductionMaster)
               .WithRequired(e => e.BOItemProfile)
               .HasForeignKey(e => e.ItemProfileCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOProductionDetail)
               .WithRequired(e => e.BOItemProfile)
               .HasForeignKey(e => e.ItemProfileCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOReceipeDetail)
               .WithRequired(e => e.BOItemProfile)
               .HasForeignKey(e => e.ItemProfileCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOItemDealDetail)
               .WithRequired(e => e.BOItemProfile)
               .HasForeignKey(e => e.ItemProfileCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOItemModifier)
               .WithRequired(e => e.BOItemProfile)
               .HasForeignKey(e => e.ItemProfileCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOItemModifier1)
               .WithRequired(e => e.BOItemProfile1)
               .HasForeignKey(e => e.ItemModifierProfileCode)
               .WillCascadeOnDelete(false);

            this
            .HasMany(e => e.BOSaleOrderDetail)
            .WithOptional(e => e.BOItemProfile)
            .HasForeignKey(e => e.ItemProfileCode)
            .WillCascadeOnDelete(false);

            this
            .HasMany(e => e.BODeliveryNoteDetail)
            .WithOptional(e => e.BOItemProfile)
            .HasForeignKey(e => e.ItemProfileCode)
            .WillCascadeOnDelete(false);

            this
             .HasMany(e => e.BOItemProfileBarCode)
             .WithRequired(e => e.BOItemProfile)
             .HasForeignKey(e => e.ItemProfileCode)
             .WillCascadeOnDelete(false);

            this
             .HasMany(e => e.BOSubjectToDeliver)
             .WithRequired(e => e.BOItemProfile)
             .HasForeignKey(e => e.ItemProfileCode)
             .WillCascadeOnDelete(false);

            this
             .HasMany(e => e.BOQuotationParameterItemDetail)
             .WithOptional(e => e.BOItemProfile)
             .HasForeignKey(e => e.ItemProfileCode)
             .WillCascadeOnDelete(false);

            this
             .HasMany(e => e.BOProductAssemblyMaster)
             .WithRequired(e => e.BOItemProfile)
             .HasForeignKey(e => e.ItemProfileCode)
             .WillCascadeOnDelete(false);

            this
             .HasMany(e => e.BOProductAssemblyDetail)
             .WithRequired(e => e.BOItemProfile)
             .HasForeignKey(e => e.ItemProfileCode)
             .WillCascadeOnDelete(false);
        }
    }
}

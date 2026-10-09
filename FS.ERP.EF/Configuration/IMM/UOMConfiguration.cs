using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class UOMConfiguration : EntityTypeConfiguration<BOUOM>
    {
        public UOMConfiguration()
        {
            this
             .HasMany(e => e.BOItem)
             .WithOptional(e => e.BOUOM)
             .HasForeignKey(e => e.StockUOMCode);

            this
                .HasMany(e => e.BOItem1)
                .WithOptional(e => e.BOUOM1)
                .HasForeignKey(e => e.PurchaseUOMCode);

            this
                .HasMany(e => e.BOItem2)
                .WithOptional(e => e.BOUOM2)
                .HasForeignKey(e => e.SaleUOMCode);

            this
                .HasMany(e => e.BOItem3)
                .WithOptional(e => e.BOUOM3)
                .HasForeignKey(e => e.AssemblyUOMCode);

            this
                .HasMany(e => e.BOItem4)
                .WithOptional(e => e.BOUOM4)
                .HasForeignKey(e => e.LifeUOMCode);

            this
                .HasMany(e => e.BOJobProjectSchemeDetail)
                .WithOptional(e => e.BOUOM)
                .HasForeignKey(e => e.WeightUOMCode);

            this
                .HasMany(e => e.BOJobProjectSchemeDetail1)
                .WithOptional(e => e.BOUOM1)
                .HasForeignKey(e => e.LWHUOMCode);

            this
               .HasMany(e => e.BOStockRequisitionOrIssuanceDetail)
               .WithRequired(e => e.BOUOM)
               .HasForeignKey(e => e.StockUOMCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOGatePassDetail)
               .WithRequired(e => e.BOUOM)
               .HasForeignKey(e => e.POUOMCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOGatePassDetail1)
               .WithRequired(e => e.BOUOM1)
               .HasForeignKey(e => e.StockUOMCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOGRNandReturnDetail)
               .WithOptional(e => e.BOUOM)
               .HasForeignKey(e => e.StockUOMCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOGRNandReturnDetail1)
               .WithOptional(e => e.BOUOM1)
               .HasForeignKey(e => e.POandReturnUOMCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOPurchaseOrderAndReturnDetail)
               .WithRequired(e => e.BOUOM)
               .HasForeignKey(e => e.POUOMCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOPurchaseOrderAndReturnDetail1)
               .WithRequired(e => e.BOUOM1)
               .HasForeignKey(e => e.StockUOMCode)
               .WillCascadeOnDelete(false);

            this
              .HasMany(e => e.BOProductionMaster)
              .WithRequired(e => e.BOUOM)
              .HasForeignKey(e => e.ProducedUOMCode)
              .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOProductionMaster1)
               .WithRequired(e => e.BOUOM1)
               .HasForeignKey(e => e.ReceipeUOMCode)
               .WillCascadeOnDelete(false);

            this
              .HasMany(e => e.BOProductionDetail)
              .WithRequired(e => e.BOUOM)
              .HasForeignKey(e => e.ReceipeUOMCode)
              .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOProductionDetail1)
               .WithRequired(e => e.BOUOM1)
               .HasForeignKey(e => e.StockUOMCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOReceipeMaster)
               .WithRequired(e => e.BOUOM)
               .HasForeignKey(e => e.ReceipeUOMCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOReceipeMaster1)
               .WithRequired(e => e.BOUOM1)
               .HasForeignKey(e => e.StockUOMCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOReceipeDetail)
               .WithRequired(e => e.BOUOM)
               .HasForeignKey(e => e.ReceipeUOMCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOReceipeDetail1)
               .WithRequired(e => e.BOUOM1)
               .HasForeignKey(e => e.StockUOMCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOItemDeal)
               .WithRequired(e => e.BOUOM)
               .HasForeignKey(e => e.ItemUOMCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOItemDealDetail)
               .WithRequired(e => e.BOUOM)
               .HasForeignKey(e => e.ItemModifierUOMCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOItemDealDetail1)
               .WithRequired(e => e.BOUOM1)
               .HasForeignKey(e => e.ItemProfileUOMCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOItemModifier)
               .WithRequired(e => e.BOUOM)
               .HasForeignKey(e => e.ItemUOMCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOItemModifier1)
               .WithRequired(e => e.BOUOM1)
               .HasForeignKey(e => e.ItemProfileUOMCode)
               .WillCascadeOnDelete(false);
        }
    }
}

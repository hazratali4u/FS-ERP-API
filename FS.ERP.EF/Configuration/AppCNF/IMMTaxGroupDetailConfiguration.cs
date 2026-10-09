using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class IMMTaxGroupDetailConfiguration : EntityTypeConfiguration<BOIMMTaxGroupDetail>
    {
        public IMMTaxGroupDetailConfiguration()
        {
                this.HasMany(e => e.BOItemCategory)
                .WithOptional(e => e.BOIMMTaxGroupDetail)
                .HasForeignKey(e => e.TaxGroupDetailCode);

            this.HasMany(e => e.BOItemPrice)
                .WithOptional(e => e.BOIMMTaxGroupDetail)
                .HasForeignKey(e => e.TaxGroupDetailCode);

            this.HasMany(e => e.BOBillOrInvoiceMasterDetail)
                .WithOptional(e => e.BOIMMTaxGroupDetail)
                .HasForeignKey(e => e.IMMTaxGroupDetailCode);

            this.HasMany(e => e.BORemittanceAdviceDetail)
                .WithOptional(e => e.BOIMMTaxGroupDetail)
                .HasForeignKey(e => e.IMMTaxGroupDetailCode);

            this.HasMany(e => e.BOTransactionDetail)
                .WithOptional(e => e.BOIMMTaxGroupDetail)
                .HasForeignKey(e => e.IMMTaxGroupDetailCode);

            this.HasMany(e => e.BOBillOrInvoiceMaster)
              .WithOptional(e => e.BOIMMTaxGroupDetail)
              .HasForeignKey(e => e.IMMTaxGroupDetailCode);

            this.HasMany(e => e.BOGRNandReturn)
               .WithOptional(e => e.BOIMMTaxGroupDetail)
               .HasForeignKey(e => e.TaxGroupDetailCode)
               .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOGRNandReturnDetail)
               .WithOptional(e => e.BOIMMTaxGroupDetail)
               .HasForeignKey(e => e.TaxGroupDetailCode)
               .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOPurchaseOrderAndReturnDetail)
               .WithOptional(e => e.BOIMMTaxGroupDetail)
               .HasForeignKey(e => e.IMMTaxGroupDetailCode)
               .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOSaleOrderDetail)
            .WithOptional(e => e.BOIMMTaxGroupDetail)
            .HasForeignKey(e => e.TaxGroupDetailCode)
            .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOSaleOrderMaster)
            .WithOptional(e => e.BOIMMTaxGroupDetail)
            .HasForeignKey(e => e.TaxGroupDetailCode)
            .WillCascadeOnDelete(false);

            this.HasMany(e => e.BODeliveryNoteDetail)
            .WithOptional(e => e.BOIMMTaxGroupDetail)
            .HasForeignKey(e => e.TaxGroupDetailCode)
            .WillCascadeOnDelete(false);

            this
            .HasMany(e => e.BOCommissionBooking)
            .WithOptional(e => e.BOIMMTaxGroupDetail)
            .HasForeignKey(e => e.TaxGroupDetailCode)
            .WillCascadeOnDelete(false);

            this
             .HasMany(e => e.BOItemDefinition)
             .WithOptional(e => e.BOIMMTaxGroupDetail)
             .HasForeignKey(e => e.IMMTaxGroupDetailCode)
             .WillCascadeOnDelete(false);

            this
             .HasMany(e => e.BOGenerateQuotation)
             .WithOptional(e => e.BOIMMTaxGroupDetail)
             .HasForeignKey(e => e.IMMTaxGroupDetailCode)
             .WillCascadeOnDelete(false);
        }
    }
}

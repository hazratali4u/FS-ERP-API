using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class EquipmentConfiguration : EntityTypeConfiguration<BOEquipment>
    {
        public EquipmentConfiguration()
        {
            this
            .HasMany(e => e.BOBillOrInvoiceMasterDetail)
            .WithOptional(e => e.BOEquipment)
            .HasForeignKey(e => e.EquipmentCode);

            this
                .HasMany(e => e.BOEmployeeLease)
                .WithRequired(e => e.BOEquipment)
                .HasForeignKey(e => e.EquipmentCode)
                .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOStockRequisitionOrIssuanceDetail)
               .WithRequired(e => e.BOEquipment)
               .HasForeignKey(e => e.EquipmentCode)
               .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOStockRequisitionOrIssuanceDetail1)
                .WithRequired(e => e.BOEquipment1)
                .HasForeignKey(e => e.EquipmentReplacedCode)
                .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOGatePassDetail)
               .WithRequired(e => e.BOEquipment)
               .HasForeignKey(e => e.EquipmentCode)
               .WillCascadeOnDelete(false);

            this
              .HasMany(e => e.BOGatePass)
              .WithRequired(e => e.BOEquipment)
              .HasForeignKey(e => e.EquipmentCode)
              .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOGRNandReturnDetail)
               .WithOptional(e => e.BOEquipment)
               .HasForeignKey(e => e.EquipmentCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOPurchaseOrderAndReturnDetail)
               .WithRequired(e => e.BOEquipment)
               .HasForeignKey(e => e.EquipmentCode)
               .WillCascadeOnDelete(false);

            this
             .HasMany(e => e.BOEquipmentIssuedOrReturn)
             .WithRequired(e => e.BOEquipment)
             .HasForeignKey(e => e.EquipmentCode)
             .WillCascadeOnDelete(false);
        }
    }
}

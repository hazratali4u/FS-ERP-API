using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class IMMOrEquipmentConditionConfiguration : EntityTypeConfiguration<BOIMMOrEquipmentCondition>
    {
        public IMMOrEquipmentConditionConfiguration()
        {
            this
               .HasMany(e => e.BOStockRequisitionOrIssuanceDetail)
               .WithRequired(e => e.BOIMMOrEquipmentCondition)
               .HasForeignKey(e => e.IMMOrEquipmentConditionCode)
               .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOStockRequisitionOrIssuanceDetail1)
                .WithRequired(e => e.BOIMMOrEquipmentCondition1)
                .HasForeignKey(e => e.IMMOrEquipmentReplacedConditionCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOGatePassDetail)
                .WithRequired(e => e.BOIMMOrEquipmentCondition)
                .HasForeignKey(e => e.IMMOrEquipmentConditionCode)
                .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOGRNandReturnDetail)
               .WithRequired(e => e.BOIMMOrEquipmentCondition)
               .HasForeignKey(e => e.IMMOrEquipmentConditionCode)
               .WillCascadeOnDelete(false);
        }
    }
}

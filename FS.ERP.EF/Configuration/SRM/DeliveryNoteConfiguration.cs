using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class DeliveryNoteConfiguration : EntityTypeConfiguration<BODeliveryNoteMaster>
    {
        public DeliveryNoteConfiguration()
        {
             this.HasMany(e => e.BOBillOrInvoiceMaster)
             .WithOptional(e => e.BODeliveryNoteMaster)
             .HasForeignKey(e => e.DeliveryNoteCode)
             .WillCascadeOnDelete(false);

            this.HasMany(e => e.BODeliveryNoteDetail)
            .WithRequired(e => e.BODeliveryNoteMaster)
            .HasForeignKey(e => e.DeliveryNoteCode)
            .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOFreightEntrySlip)
            .WithOptional(e => e.BODeliveryNoteMaster)
            .HasForeignKey(e => e.DeliveryNoteCode)
            .WillCascadeOnDelete(false);
        }
    }
}

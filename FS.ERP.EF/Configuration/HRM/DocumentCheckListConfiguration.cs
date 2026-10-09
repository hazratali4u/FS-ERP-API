using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class DocumentCheckListConfiguration : EntityTypeConfiguration<BODocumentCheckList>
    {
        public DocumentCheckListConfiguration()
        {
            this.HasMany(e => e.BOEmpDocumentCheckList)
            .WithRequired(e => e.BODocumentCheckList)
            .HasForeignKey(e => e.DocumentCheckListCode)
            .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOPayGradeDocCheckListAllocation)
         .WithRequired(e => e.BODocumentCheckList)
         .HasForeignKey(e => e.DocCode)
         .WillCascadeOnDelete(false);
        }
    }
}

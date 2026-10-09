using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class NoteSheetConfiguration : EntityTypeConfiguration<BONoteSheet>
    {
        public NoteSheetConfiguration()
        {
            this
               .HasMany(e => e.BONoteSheetRemarks)
               .WithOptional(e => e.BONoteSheet)
               .HasForeignKey(e => e.NoteSheetCode)
               .WillCascadeOnDelete(false);
        }
    }
}

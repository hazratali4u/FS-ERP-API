using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class BulletinBoardConfiguration : EntityTypeConfiguration<BOBulletinCommunicationCategory>
    {
        public BulletinBoardConfiguration()
        {
            this.HasMany(e => e.BOBulletin)
            .WithRequired(e => e.BOBulletinCommunicationCategory)
            .HasForeignKey(e => e.CategoryCode)
            .WillCascadeOnDelete(false);

               this.HasMany(e => e.BOMassCommunication)
               .WithRequired(e => e.BOBulletinCommunicationCategory)
               .HasForeignKey(e => e.CategoryCode)
               .WillCascadeOnDelete(false);
        }
    }
}

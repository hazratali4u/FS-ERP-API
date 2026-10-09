using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class IMMCheckListConfiguration : EntityTypeConfiguration<BOIMMCheckList>
    {
        public IMMCheckListConfiguration()
        {
               this.HasMany(e => e.BOGRNandReturnCheckList)
               .WithRequired(e => e.BOIMMCheckList)
               .HasForeignKey(e => e.IMMCheckListCode)
               .WillCascadeOnDelete(false);
        }
    }
}

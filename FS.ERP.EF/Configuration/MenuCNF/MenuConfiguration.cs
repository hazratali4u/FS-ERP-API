using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class MenuConfiguration : EntityTypeConfiguration<BOMenu>
    {
        public MenuConfiguration()
        {
           this
                 .HasMany(e => e.BOTransactionDocumentProcess)
                 .WithOptional(e => e.BOMenu)
                 .HasForeignKey(e => e.MenuCode);

           this
                .HasMany(e => e.BOActionLogging)
                .WithOptional(e => e.BOMenu)
                .HasForeignKey(e => e.MenuCode);

           this
                .HasMany(e => e.BOAPPCNFDataLogging)
                .WithOptional(e => e.BOMenu)
                .HasForeignKey(e => e.MenuCode);

           this
                .HasMany(e => e.BOCRMDataLogging)
                .WithOptional(e => e.BOMenu)
                .HasForeignKey(e => e.MenuCode);

           this
                .HasMany(e => e.BOErrorLogging)
                .WithOptional(e => e.BOMenu)
                .HasForeignKey(e => e.MenuCode);

           this
                .HasMany(e => e.BOFICODataLogging)
                .WithOptional(e => e.BOMenu)
                .HasForeignKey(e => e.MenuCode);

           this
                .HasMany(e => e.BOHRMDataLogging)
                .WithOptional(e => e.BOMenu)
                .HasForeignKey(e => e.MenuCode);

           this
                .HasMany(e => e.BOIMMDataLogging)
                .WithOptional(e => e.BOMenu)
                .HasForeignKey(e => e.MenuCode);

           this
                .HasMany(e => e.BOSRMDataLogging)
                .WithOptional(e => e.BOMenu)
                .HasForeignKey(e => e.MenuCode);

           this
                .HasMany(e => e.BOUMSDataLogging)
                .WithOptional(e => e.BOMenu)
                .HasForeignKey(e => e.MenuCode);

           this
                .HasMany(e => e.BOMenuControlInfo)
                .WithRequired(e => e.BOMenu)
                .HasForeignKey(e => e.MenuCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOModuleColInfo)
                .WithRequired(e => e.BOMenu)
                .HasForeignKey(e => e.MenuCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOModuleParamInfo)
                .WithRequired(e => e.BOMenu)
                .HasForeignKey(e => e.MenuCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOProfileGroupDetail)
                .WithRequired(e => e.BOMenu)
                .HasForeignKey(e => e.MenuCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOReportDashboardInfo)
                .WithRequired(e => e.BOMenu)
                .HasForeignKey(e => e.MenuCode)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.BOUser3)
                .WithOptional(e => e.BOMenu3)
                .HasForeignKey(e => e.DefaultMenuCode);


           this
            .HasMany(e => e.BOSMSOrEmailDescription)
            .WithRequired(e => e.BOMenu)
            .HasForeignKey(e => e.MenuCode)
            .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOSMSOrEmailOperationsOrBehaviour)
             .WithRequired(e => e.BOMenu)
             .HasForeignKey(e => e.MenuCode)
             .WillCascadeOnDelete(false);

           this
             .HasMany(e => e.BOSMSOrEmailTags)
             .WithRequired(e => e.BOMenu)
             .HasForeignKey(e => e.MenuCode)
             .WillCascadeOnDelete(false);
        }
    }
}

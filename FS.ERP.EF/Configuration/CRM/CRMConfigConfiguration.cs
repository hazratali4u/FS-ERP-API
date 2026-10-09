using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.HRM
{
    public class CRMConfigConfiguration : EntityTypeConfiguration<BOCRMConfiguration>
    {
        public CRMConfigConfiguration()
        {
            this
                .HasMany(e => e.BOPipelineDetail)
                .WithRequired(e => e.BOCRMConfiguration)
                .HasForeignKey(e => e.StageCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOLeadActivity)
                .WithRequired(e => e.BOCRMConfiguration)
                .HasForeignKey(e => e.ActivityTypeCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOLead)
                .WithRequired(e => e.BOCRMConfiguration)
                .HasForeignKey(e => e.ContactCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOLead1)
                .WithRequired(e => e.BOCRMConfiguration1)
                .HasForeignKey(e => e.ContactTypeCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOLead2)
                .WithRequired(e => e.BOCRMConfiguration2)
                .HasForeignKey(e => e.StatusCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOLead3)
                .WithRequired(e => e.BOCRMConfiguration3)
                .HasForeignKey(e => e.SourceCode)
                .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOOpportunity)
               .WithRequired(e => e.BOCRMConfiguration)
               .HasForeignKey(e => e.ContactCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOOpportunity1)
               .WithRequired(e => e.BOCRMConfiguration1)
               .HasForeignKey(e => e.StageCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOOpportunity2)
               .WithRequired(e => e.BOCRMConfiguration2)
               .HasForeignKey(e => e.StatusCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOOpportunity3)
               .WithRequired(e => e.BOCRMConfiguration3)
               .HasForeignKey(e => e.SourceCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOPartyOrCustomer)
               .WithRequired(e => e.BOCRMConfiguration)
               .HasForeignKey(e => e.CustomerTypeCode)
               .WillCascadeOnDelete(false);
        }
    }
}

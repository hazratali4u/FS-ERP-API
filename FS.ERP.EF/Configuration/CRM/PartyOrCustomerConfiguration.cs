using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class PartyOrCustomerConfiguration : EntityTypeConfiguration<BOPartyOrCustomer>
    {
        public PartyOrCustomerConfiguration()
        {
            this
                .Property(e => e.Longitude)
                .HasPrecision(18, 7);

            this
                .Property(e => e.Latitude)
                .HasPrecision(18, 7);

            this
                .Property(e => e.Altitude)
                .HasPrecision(18, 7);

            this
                .Property(e => e.Radius)
                .HasPrecision(18, 7);

            this
                .HasMany(e => e.BOLocationSite)
                .WithOptional(e => e.BOPartyOrCustomer)
                .HasForeignKey(e => e.PartyOrCustomerCode);

            this
                .HasMany(e => e.BOEquipment)
                .WithOptional(e => e.BOPartyOrCustomer)
                .HasForeignKey(e => e.SoldToCustomerCode);

            this
                .HasMany(e => e.BOBillOrInvoiceMaster)
                .WithOptional(e => e.BOPartyOrCustomer)
                .HasForeignKey(e => e.CustomerPartyCode);

            this
                .HasMany(e => e.BOFundDemandRegisterDetail)
                .WithOptional(e => e.BOPartyOrCustomer)
                .HasForeignKey(e => e.CustomerPartyCode);

            this
                .HasMany(e => e.BOFundDemandRequestDetail)
                .WithOptional(e => e.BOPartyOrCustomer)
                .HasForeignKey(e => e.CustomerPartyCode);

            this
                .HasMany(e => e.BOPartyOrCustomer1)
                .WithOptional(e => e.BOPartyOrCustomer2)
                .HasForeignKey(e => e.ParentCode);

            this
                .HasMany(e => e.BOUserPartyOrCustomerPermission)
                .WithRequired(e => e.BOPartyOrCustomer)
                .HasForeignKey(e => e.PartyOrCustomerCode)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BOLead)
                .WithRequired(e => e.BOPartyOrCustomer)
                .HasForeignKey(e => e.CustomerCode)
                .WillCascadeOnDelete(false);

            this
              .HasMany(e => e.BOOpportunity)
              .WithRequired(e => e.BOPartyOrCustomer)
              .HasForeignKey(e => e.CustomerCode)
              .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOPartyOrCustomerServiceType)
               .WithRequired(e => e.BOPartyOrCustomer)
               .HasForeignKey(e => e.PartyOrCustomerCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOContacts)
               .WithRequired(e => e.BOPartyOrCustomer)
               .HasForeignKey(e => e.CustomerCode)
               .WillCascadeOnDelete(false);

            this
           .HasMany(e => e.BOSaleOrderMaster)
           .WithOptional(e => e.BOPartyOrCustomer)
           .HasForeignKey(e => e.CustomerCode)
           .WillCascadeOnDelete(false);

            this
            .HasMany(e => e.BODeliveryNoteMaster)
            .WithOptional(e => e.BOPartyOrCustomer)
            .HasForeignKey(e => e.CustomerCode)
            .WillCascadeOnDelete(false);

            this
            .HasMany(e => e.BOCustomerAdjustment)
            .WithOptional(e => e.BOPartyOrCustomer)
            .HasForeignKey(e => e.CustomerCode)
            .WillCascadeOnDelete(false);

            this
            .HasMany(e => e.BOCustomerReceipt)
            .WithOptional(e => e.BOPartyOrCustomer)
            .HasForeignKey(e => e.CustomerCode)
            .WillCascadeOnDelete(false);

            this
            .HasMany(e => e.BOFreightEntrySlip)
            .WithOptional(e => e.BOPartyOrCustomer)
            .HasForeignKey(e => e.CustomerCode)
            .WillCascadeOnDelete(false);

            this
             .HasMany(e => e.BOPartyOrCustomerPlan)
             .WithRequired(e => e.BOPartyOrCustomer)
             .HasForeignKey(e => e.PartyOrCustomerCode)
             .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOPartyOrCustomer3)
               .WithOptional(e => e.BOPartyOrCustomer4)
               .HasForeignKey(e => e.BranchParentCode);
        }
    }
}

using FS.ERP.Models.BO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.ERP.EF.Configuration.AppCNF
{
    public class CurrencyConfiguration : EntityTypeConfiguration<BOCurrency>
    {
        public CurrencyConfiguration()
        {
            this.HasMany(e => e.BOBankAccount)
               .WithOptional(e => e.BOCurrency)
               .HasForeignKey(e => e.CurrencyCode);

            this.HasMany(e => e.BOBillOrInvoiceMaster)
                .WithOptional(e => e.BOCurrency)
                .HasForeignKey(e => e.CurrencyCode);

            this.HasMany(e => e.BOBillOrInvoiceMasterDetail)
                .WithOptional(e => e.BOCurrency)
                .HasForeignKey(e => e.CurrencyCode);

            this.HasMany(e => e.BOEmployeeInfo)
                .WithRequired(e => e.BOCurrency)
                .HasForeignKey(e => e.CurrencyCode)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOEmployeeInfoRevision)
                .WithRequired(e => e.BOCurrency)
                .HasForeignKey(e => e.CurrencyCode)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOEmployeeSalary)
                .WithRequired(e => e.BOCurrency)
                .HasForeignKey(e => e.CurrencyCode)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOPartyOrCustomer)
                .WithOptional(e => e.BOCurrency)
                .HasForeignKey(e => e.DefaultCurrencyCode);

            this.HasMany(e => e.BORemittanceAdvice)
                .WithOptional(e => e.BOCurrency)
                .HasForeignKey(e => e.CurrencyCode);

            this.HasMany(e => e.BORemittanceAdviceDetail)
                .WithOptional(e => e.BOCurrency)
                .HasForeignKey(e => e.CurrencyCode);

            this.HasMany(e => e.BOSalaryBreakUpPolicyDetail)
                .WithRequired(e => e.BOCurrency)
                .HasForeignKey(e => e.CurrencyCode)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.BOTransactionDetail)
                .WithOptional(e => e.BOCurrency)
                .HasForeignKey(e => e.CurrencyCode);

            this.HasMany(e => e.BOVendorOrSupplier)
                .WithOptional(e => e.BOCurrency)
                .HasForeignKey(e => e.DefaultCurrencyCode);

                this.HasMany(e => e.BOStockRequisitionOrIssuanceDetail)
                .WithRequired(e => e.BOCurrency)
                .HasForeignKey(e => e.CurrencyCode)
                .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOGatePassDetail)
               .WithRequired(e => e.BOCurrency)
               .HasForeignKey(e => e.CurrencyCode)
               .WillCascadeOnDelete(false);
            this
               .HasMany(e => e.BOGatePass)
               .WithRequired(e => e.BOCurrency)
               .HasForeignKey(e => e.CurrencyCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOGRNandReturn)
               .WithOptional(e => e.BOCurrency)
               .HasForeignKey(e => e.CurrencyCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOGRNandReturnDetail)
               .WithOptional(e => e.BOCurrency)
               .HasForeignKey(e => e.CurrencyCode)
               .WillCascadeOnDelete(false);

            this
               .HasMany(e => e.BOPurchaseOrderAndReturnDetail)
               .WithRequired(e => e.BOCurrency)
               .HasForeignKey(e => e.CurrencyCode)
               .WillCascadeOnDelete(false);

            this
            .HasMany(e => e.BOCustomerReceipt)
            .WithOptional(e => e.BOCurrency)
            .HasForeignKey(e => e.CurrencyCode)
            .WillCascadeOnDelete(false);
        }
    }
}

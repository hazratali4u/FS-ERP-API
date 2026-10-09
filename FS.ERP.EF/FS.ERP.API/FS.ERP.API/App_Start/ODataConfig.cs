using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Http;
using System.Web.Http.OData.Builder;
using System.Web.Http.OData.Extensions;
using FS.ERP.Models;
using FS.ERP.Models.BO;
using FS.ERP.Models.IdentityModel;
using Microsoft.Owin.Security.OAuth;

namespace FS.ERP.API.App_Start
{
    public class ODataConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var builder = new ODataConventionModelBuilder();

            builder.EntitySet<BOActionLogging>("ActionLogging");
            builder.EntitySet<BOAdditionType>("AdditionType");
            builder.EntitySet<BOAllowanceOrBenefitType>("AllowanceOrBenefitType");
            builder.EntitySet<BOAllowancesOrBenefit>("AllowancesOrBenefit");
            builder.EntitySet<BOAPPCNFDataLogging>("APPCNFDataLogging");
            builder.EntitySet<BOAppConfiguration>("AppConfiguration");
            builder.EntitySet<BOAppConfigurationDetail>("AppConfigurationDetail");
            builder.EntitySet<BOApprovalAuthorityType>("ApprovalAuthorityType");
            builder.EntitySet<BOAreaOfDistrictWard>("AreaOfDistrictWard");
            builder.EntitySet<BOAttendanceDiscrepancy>("AttendanceDiscrepancy");
            builder.EntitySet<BOAttendanceMachineType>("AttendanceMachineType");
            builder.EntitySet<BOBank>("Bank");
            builder.EntitySet<BOBankAccount>("BankAccount");
            builder.EntitySet<BOBankAccountInstrumentInfo>("BankAccountInstrumentInfo");
            builder.EntitySet<BOBankBranch>("BankBranch");
            builder.EntitySet<BOBillOrInvoiceMaster>("BillOrInvoiceMaster");
            builder.EntitySet<BOBillOrInvoiceMasterDetail>("BillOrInvoiceMasterDetail");
            builder.EntitySet<BOBillOrInvoiceType>("BillOrInvoiceType");
            builder.EntitySet<BOCalendar>("Calendar");
            builder.EntitySet<BOCityTown>("CityTown");
            builder.EntitySet<BOCOA>("COA");
            builder.EntitySet<BOCOAConfiguration>("COAConfiguration");
            builder.EntitySet<BOCOAMapping>("COAMapping");
            builder.EntitySet<BOCOANature>("COANature");
            builder.EntitySet<BOCOAAsset>("COAAsset");
            builder.EntitySet<BOCountryRegion>("CountryRegion");
            builder.EntitySet<BOCRMDataLogging>("CRMDataLogging");
            builder.EntitySet<BOCulture>("Culture");
            builder.EntitySet<BOCurrency>("Currency");
            builder.EntitySet<BODataType>("DataType");
            builder.EntitySet<BODeductionType>("DeductionType");
            builder.EntitySet<BODegree>("Degree");
            builder.EntitySet<BODegreeInstitute>("DegreeInstitute");
            builder.EntitySet<BODepartment>("Department");
            builder.EntitySet<BODesignation>("Designation");
            builder.EntitySet<BODiscrepancyType>("DiscrepancyType");
            builder.EntitySet<BODistrictWard>("DistrictWard");
            builder.EntitySet<BODocumentCheckList>("DocumentCheckList");
            builder.EntitySet<BODocumentDetailOfStatement>("DocumentDetailOfStatement");
            builder.EntitySet<BODocumentOfStatement>("DocumentOfStatement");
            builder.EntitySet<BODomainOfStatement>("DomainOfStatement");
            builder.EntitySet<BODomainType>("DomainType");
            builder.EntitySet<BOEmpDocumentCheckList>("EmpDocumentCheckList");
            builder.EntitySet<BOEmployeeAcademic>("EmployeeAcademic");
            builder.EntitySet<BOEmployeeAllowanceOrBenefit>("EmployeeAllowanceOrBenefit");
            builder.EntitySet<BOEmployeeAttendance>("EmployeeAttendance");
            builder.EntitySet<BOEmployeeEmployment>("EmployeeEmployment");
            builder.EntitySet<BOEmployeeFaceOrBiometric>("EmployeeFaceOrBiometric");
            builder.EntitySet<BOEmployeeFamily>("EmployeeFamily");
            builder.EntitySet<BOEmployeeInfo>("EmployeeInfo");
            builder.EntitySet<BOEmployeeInfoHistory>("EmployeeInfoHistory");
            builder.EntitySet<BOEmployeeInfoRevision>("EmployeeInfoRevision");
            builder.EntitySet<BOEmployeeLease>("EmployeeLease");
            builder.EntitySet<BOEmployeeLeaseInstallment>("EmployeeLeaseInstallment");
            builder.EntitySet<BOEmployeeLeave>("EmployeeLeave");
            builder.EntitySet<BOEmployeeLeaveBalance>("EmployeeLeaveBalance");
            builder.EntitySet<BOEmployeeLoan>("EmployeeLoan");
            builder.EntitySet<BOEmployeeLoanInstallment>("EmployeeLoanInstallment");
            builder.EntitySet<BOEmployeeReference>("EmployeeReference");
            builder.EntitySet<BOEmployeeRelation>("EmployeeRelation");
            builder.EntitySet<BOEmployeeStatus>("EmployeeStatus");
            builder.EntitySet<BOEquipment>("Equipment");
            builder.EntitySet<BOEquipmentStatus>("EquipmentStatus");
            builder.EntitySet<BOEquipmentType>("EquipmentType");
            builder.EntitySet<BOErrorLogging>("ErrorLogging");
            builder.EntitySet<BOExpenseType>("ExpenseType");
            builder.EntitySet<BOFICODataLogging>("FICODataLogging");
            builder.EntitySet<BOFiscalYear>("FiscalYear");
            builder.EntitySet<BOFiscalYearMonth>("FiscalYearMonth");
            builder.EntitySet<BOFiscalYearMonthDetail>("FiscalYearMonthDetail");
            builder.EntitySet<BOHireType>("HireType");
            builder.EntitySet<BOHRMDataLogging>("HRMDataLogging");
            builder.EntitySet<BOIMMAcquireType>("IMMAcquireType");
            builder.EntitySet<BOIMMConfiguration>("IMMConfiguration");
            builder.EntitySet<BOIMMDataLogging>("IMMDataLogging");
            builder.EntitySet<BOIMMGender>("IMMGender");
            builder.EntitySet<BOIMMLifeType>("IMMLifeType");
            builder.EntitySet<BOIMMManufacturedBy>("IMMManufacturedBy");
            builder.EntitySet<BOIMMSectionOrBrand>("IMMSectionOrBrand");
            builder.EntitySet<BOIMMTaxGroup>("IMMTaxGroup");
            builder.EntitySet<BOIMMTaxGroupDetail>("IMMTaxGroupDetail");
            builder.EntitySet<BOIncomeTaxSlab>("IncomeTaxSlab");
            builder.EntitySet<BOInstrumentStatus>("InstrumentStatus");
            builder.EntitySet<BOInstrumentType>("InstrumentType");
            builder.EntitySet<BOItemAspect>("ItemAspect");
            builder.EntitySet<BOItemAspectDetail>("ItemAspectDetail");
            builder.EntitySet<BOItemAttribute>("ItemAttribute");
            builder.EntitySet<BOItemAttributeDetail>("ItemAttributeDetail");
            builder.EntitySet<BOItemCategory>("ItemCategory");
            builder.EntitySet<BOItemCategoryAttributeAspect>("ItemCategoryAttributeAspect");
            builder.EntitySet<BOItemCategoryAttributeAspectDetail>("ItemCategoryAttributeAspectDetail");
            builder.EntitySet<BOJobRole>("JobRole");
            builder.EntitySet<BOLeaseType>("LeaseType");
            builder.EntitySet<BOLeaveDeductionAgainstLate>("LeaveDeductionAgainstLate");
            builder.EntitySet<BOLeavePolicy>("LeavePolicy");
            builder.EntitySet<BOLeavePolicyDetail>("LeavePolicyDetail");
            builder.EntitySet<BOLeaveType>("LeaveType");
            builder.EntitySet<BOLinkToTransaction>("LinkToTransaction");
            builder.EntitySet<BOLoanType>("LoanType");
            builder.EntitySet<BOLocationSite>("LocationSite");
            builder.EntitySet<BOLocationSiteType>("LocationSiteType");
            builder.EntitySet<BOLoggingInformation>("LoggingInformation");
            builder.EntitySet<BOLoginAttempts>("LoginAttempts");
            builder.EntitySet<BOMenu>("Menu");
            builder.EntitySet<BOMenuControlInfo>("MenuControlInfo");
            builder.EntitySet<BOModuleColInfo>("ModuleColInfo");
            builder.EntitySet<BOModuleParamInfo>("ModuleParamInfo");
            builder.EntitySet<BOOnwerShipType>("OnwerShipType");
            builder.EntitySet<BOOrganizationCompany>("OrganizationCompany");
            builder.EntitySet<BOPackingType>("PackingType");
            builder.EntitySet<BOPartyOrCustomer>("PartyOrCustomer");
            builder.EntitySet<BOPayGrade>("PayGrade");
            builder.EntitySet<BOPayGradeAllowanceOrBenefit>("PayGradeAllowanceOrBenefit");
            builder.EntitySet<BOPaymentMode>("PaymentMode");
            builder.EntitySet<BOPriority>("Priority");
            builder.EntitySet<BOProcessApprovalAlert>("ProcessApprovalAlert");
            builder.EntitySet<BOProcessApprovalWorkflow>("ProcessApprovalWorkflow");
            builder.EntitySet<BOProfileGroup>("ProfileGroup");
            builder.EntitySet<BOProfileGroupDetail>("ProfileGroupDetail");
            builder.EntitySet<BORebateType>("RebateType");
            builder.EntitySet<BORecordStatus>("RecordStatus");
            builder.EntitySet<BOReportDashboardInfo>("ReportDashardInfo");
            builder.EntitySet<BOSalaryBreakUpPolicy>("SalaryBreakUpPolicy");
            builder.EntitySet<BOSalaryBreakUpPolicyDetail>("SalaryBreakUpPolicyDetail");
            builder.EntitySet<BOSalaryTransferMode>("SalaryTransferMode");
            builder.EntitySet<BOSectorZone>("SectorZone");
            builder.EntitySet<BOSecurityRight>("SecurityRight");
            builder.EntitySet<BOShift>("Shift");
            builder.EntitySet<BOShiftDay>("ShiftDay");
            builder.EntitySet<BOSRMDataLogging>("SRMDataLogging");
            builder.EntitySet<BOStateProvince>("StateProvince");
            builder.EntitySet<BOSystemOrWebPool>("SystemOrWebPool");
            builder.EntitySet<BOTaxAdjustmentType>("TaxAdjustmentType");
            builder.EntitySet<BOTransactionDetail>("TransactionDetail");
            builder.EntitySet<BOTransactionDocumentConfiguration>("TransactionDocumentConfiguration");
            builder.EntitySet<BOTransactionDocumentProcess>("TransactionDocumentProcess");
            builder.EntitySet<BOTransactionMaster>("TransactionMaster");
            builder.EntitySet<BOUMSDataLogging>("UMSDataLogging");
            builder.EntitySet<BOUOM>("UOM");
            builder.EntitySet<BOUser>("User");
            builder.EntitySet<BOUserLocationSitePermission>("UserLocationSitePermission");
            builder.EntitySet<BOUserMenuAdditionSubtraction>("UserMenuAdditionSubtraction");
            builder.EntitySet<BOUserOrganizationCompanyPermission>("UserOrganizationCompanyPermission");
            builder.EntitySet<BOUserPartyOrCustomerPermission>("UserPartyOrCustomerPermission");
            builder.EntitySet<BOUserProfileGroup>("UserProfileGroup");
            builder.EntitySet<BOUserSystemOrWebPermission>("UserSystemOrWebPermission");
            builder.EntitySet<BOUserVendorOrSupplierPermission>("UserVendorOrSupplierPermission");
            builder.EntitySet<BOVendorOrSupplier>("VendorOrSupplier");
            builder.EntitySet<BOVoucherType>("VoucherType");

            builder.EntitySet<BOCOAMappingForPCorCC>("COAMappingForPCorCC");
            builder.EntitySet<BOEmployeeSalary>("EmployeeSalary");
            builder.EntitySet<BOEmployeeSalaryAddition>("EmployeeSalaryAddition");
            builder.EntitySet<BOEmployeeSalaryAllowanceOrBenefit>("EmployeeSalaryAllowanceOrBenefit");
            builder.EntitySet<BOEmployeeSalaryDeduction>("EmployeeSalaryDeduction");
            builder.EntitySet<BOEmployeeSalaryReimbursement>("EmployeeSalaryReimbursement");
            builder.EntitySet<BOFundDemandRegister>("FundDemandRegister");
            builder.EntitySet<BOFundDemandRegisterDetail>("FundDemandRegisterDetail");
            builder.EntitySet<BOFundDemandRequest>("FundDemandRequest");
            builder.EntitySet<BOFundDemandRequestDetail>("FundDemandRequestDetail");
            builder.EntitySet<BOItem>("Item");
            builder.EntitySet<BOJobProjectScheme>("JobProjectScheme");
            builder.EntitySet<BOJobProjectSchemeDetail>("JobProjectSchemeDetail");
            builder.EntitySet<BOReimbursement>("Reimbursement");
            builder.EntitySet<BOReimbursementType>("ReimbursementType");
            builder.EntitySet<BORemittanceAdvice>("RemittanceAdvice");
            builder.EntitySet<BORemittanceAdviceDetail>("RemittanceAdviceDetail");
            builder.EntitySet<BOEmployeeIncrement>("EmployeeIncrement");
            builder.EntitySet<BOEmployeeIncrementAllowanceOrBenefit>("EmployeeIncrementAllowanceOrBenefit");

            builder.EntitySet<BOIMMGroup>("IMMGroup");
            builder.EntitySet<BOIMMTransactionMethod>("IMMTransactionMethod");
            builder.EntitySet<BOItemAttributeAspect>("ItemAttributeAspect");
            builder.EntitySet<BOItemAttributeAspectDetail>("ItemAttributeAspectDetail");
            builder.EntitySet<BOItemPrice>("ItemPrice");
            builder.EntitySet<BOItemProfile>("ItemProfile");

            builder.EntitySet<BOGatePass>("GatePass");
            builder.EntitySet<BOGatePassDetail>("GatePassDetail");

            builder.EntitySet<BOStockTakingAdjustment>("StockTakingAdjustment");
            builder.EntitySet<BOStockTakingAdjustmentDetail>("StockTakingAdjustmentDetail");

            builder.EntitySet<BOStockRequisitionOrIssuance>("StockRequisitionOrIssuance");
            builder.EntitySet<BOStockRequisitionOrIssuanceDetail>("StockRequisitionOrIssuanceDetail");

            builder.EntitySet<BOPurchaseOrderAndReturn>("PurchaseOrderAndReturn");
            builder.EntitySet<BOPurchaseOrderAndReturnDetail>("PurchaseOrderAndReturnDetail");

            builder.EntitySet<BOGRNandReturn>("GRNandReturn");
            builder.EntitySet<BOGRNandReturnDetail>("GRNandReturnDetail");

            builder.EntitySet<BOIMMOrEquipmentCondition>("IMMOrEquipmentCondition");

            builder.EntitySet<BODispatchReceiveMedium>("DispatchReceiveMedium");

            builder.EntitySet<BOLeadActivity>("LeadActivity");
            builder.EntitySet<BOLead>("Lead");
            builder.EntitySet<BOOpportunity>("Opportunity");
            builder.EntitySet<BOPipeline>("Pipeline");
            builder.EntitySet<BOPipelineDetail>("PipelineDetail");
            builder.EntitySet<BOTeamInfo>("TeamInfo");
            builder.EntitySet<BOTeamMembers>("TeamMembers");
            builder.EntitySet<BOTeamPermissions>("TeamPermissions");
            builder.EntitySet<BOCRMConfiguration>("CRMConfiguration");
            builder.EntitySet<BOCRMPermissionType>("CRMPermissionType");
            builder.EntitySet<BOCRMTeamRole>("CRMTeamRole");
            builder.EntitySet<BOContacts>("Contacts");
            builder.EntitySet<BOVendorOrSupplierWiseItem>("VendorOrSupplierWiseItem");
            builder.EntitySet<BOIMMCheckList>("IMMCheckList");
            builder.EntitySet<BOGRNandReturnCheckList>("GRNandReturnCheckList");

            builder.EntitySet<BOItemOrProfileServiceType>("ItemOrProfileServiceType");
            builder.EntitySet<BOServiceType>("ServiceType");
            builder.EntitySet<BOPartyOrCustomerServiceType>("PartyOrCustomerServiceType");
            builder.EntitySet<BOProductionDetail>("ProductionDetail");
            builder.EntitySet<BOProductionMaster>("ProductionMaster");
            builder.EntitySet<BOReceipeDetail>("ReceipeDetail");
            builder.EntitySet<BOReceipeMaster>("ReceipeMaster");
            builder.EntitySet<BOVendorOrSupplierServiceType>("VendorOrSupplierServiceType");

            builder.EntitySet<BOItemDealDetail>("ItemDealDetail");
            builder.EntitySet<BOItemDealAssignment>("ItemDealAssignment");
            builder.EntitySet<BOItemDealDetail>("ItemDealDetail");
            builder.EntitySet<BOItemModifier>("ItemModifier");



            //builder.Entity<BOOrganizationCompany>()
            //    .Collection.Action("List")
            //    .CollectionParameter<BOOrganizationCompany>("data");

            config.Routes.MapODataServiceRoute("ODataRoute", "odata", builder.GetEdmModel());
            //config.Routes.MapODataServiceRoute("ODataRoute", "api", builder.GetEdmModel());
        }
    }
}
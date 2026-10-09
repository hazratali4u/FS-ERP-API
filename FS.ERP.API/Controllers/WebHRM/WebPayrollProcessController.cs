using CST.CCL.Helper;
using CST.CCL.Helper.Common;
using CST.CRY;
using FS.CAPI.BAL;
using FS.ERP.Models.BO;
using FS.ERP.Models.Custom;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Cors;

namespace FS.ERP.API.Controllers
{
    [Authorize]
    [EnableCors("*", "*", "*")]
    public class WebPayrollProcessController : ApiController
    {
        public string ConStr { get; set; }
        protected JsonMediaTypeFormatter formatter;

        protected override void Initialize(HttpControllerContext controllerContext)
        {
            string _connStr = controllerContext.Request.GetFirstHeaderValueOrDefault<string>("x-conn", x => "",
                Convert.ToString);
            if (string.IsNullOrEmpty(_connStr))
                throw new UnauthorizedAccessException(
                    "You are not authorized to access this link. Please contact administrator");

            ConStr = Encryptor.Decrypt(AppSettings.PrivateKey, _connStr);
            formatter = new JsonMediaTypeFormatter
            {
                SerializerSettings = { ReferenceLoopHandling = ReferenceLoopHandling.Ignore }
            };
            base.Initialize(controllerContext);
        }

        [HttpPost]
        [Route("~/Api/Payroll/FinalSettlementProcess")]
        public HttpResponseMessage FinalSettlementProcess(PayrollProcessModel model)
        {
            try
            {
                // ALREADY EXIST CHECK
                var dataExistListFirst = GetEmpSalaryExist(model.ProfitCenterCode, model.fromDate);

                if (dataExistListFirst != null && dataExistListFirst.Count() > 0)
                {
                    List<long> empCodesList = new List<long>();
                    empCodesList.Add(Convert.ToInt64(model.EmpCodes));
                    var finalList = dataExistListFirst.Where(p => empCodesList.Contains(p.EmpCode));
                    if (finalList != null && finalList.Count() > 0)
                    {
                        var ex = new Exception("Payroll already processed, you cannot process in these dates");
                        return Request.CreateResponse(HttpStatusCode.BadRequest, ex, formatter);
                    }
                }

                var firstStep = ExecuteFinalSettlementProcessSP(new PayrollProcessModel
                                {
                                    EmpCodes = model.EmpCodes,
                                    userCode = model.userCode,
                                    toDate = model.toDate,
                                    fromDate = model.fromDate,
                                    CompanyCode = model.CompanyCode,
                                    DeptCodes = model.DeptCodes,
                                    FinalSettlement = model.FinalSettlement,
                                    PayrollGroupCode = model.PayrollGroupCode,
                                    ProcessOrUnProcess = 3,
                                    ProfitCenterCode = model.ProfitCenterCode
                                });

               new WebProcessAttendanceController(ConStr, "NOO").ProcessAttendance(
                    new ProcessAttendanceModel
                    {
                        EmpCode = model.EmpCodes,
                        fromDate = model.fromDate,
                        toDate = model.toDate,
                        userCode = model.userCode

                    });

                var thirdStep = ExecuteFinalSettlementProcessSP(new PayrollProcessModel
                {
                    EmpCodes = model.EmpCodes,
                    userCode = model.userCode,
                    toDate = model.toDate,
                    fromDate = model.fromDate,
                    CompanyCode = model.CompanyCode,
                    DeptCodes = model.DeptCodes,
                    FinalSettlement = model.FinalSettlement,
                    PayrollGroupCode = model.PayrollGroupCode,
                    ProcessOrUnProcess = 4,
                    ProfitCenterCode = model.ProfitCenterCode
                });

                int count = 0;
                var msglist = new List<CustomMsg>();
                model.FinalSettlement = true;

                //DataSet getModel = ExecutePayrollSummarySPFinalSettlement(model);
                var getModel = ExecutePayrollSummarySP(model);

                if (getModel == null)
                {
                    //return Request.CreateResponse(HttpStatusCode.NotFound);
                    var ex = new Exception("No data found for payroll summary");
                    return Request.CreateResponse(HttpStatusCode.NotFound, ex, formatter);
                }
                else
                {
                    // CONVERT datatable to LIST 
                    List<VM_PayrollEmployeeSummary> payrollSummary = getModel.DataTableToList<VM_PayrollEmployeeSummary>();


                    // ALREADY EXIST CHECK AGAIN AFTER PAYROLL SUMMARY CALL -- IT MIGHT BE NOT NEEDED NOW AS WE CONFIRMED IT ON FIRST STEP NOW -- BUT FOR MORE SAFETY CALL IT AGAIN
                    var dataExistList = GetEmpSalaryExist(model.ProfitCenterCode, model.fromDate);

                    if (dataExistList != null && dataExistList.Count() > 0)
                    {
                        List<long> empCodesList = payrollSummary.Select(p => p.ID).ToList();
                        var finalList = dataExistList.Where(p => empCodesList.Contains(p.EmpCode));
                        if (finalList != null && finalList.Count() > 0)
                        {
                            //msglist.Add(new CustomMsg
                            //{
                            //    TotalRows = 0,
                            //    Msg = "Payroll already processed, you cannot process in these dates"
                            //});
                            //return Request.CreateResponse(HttpStatusCode.OK, msglist, new JsonMediaTypeFormatter());
                            var ex = new Exception("Payroll already processed, you cannot process in these dates");
                            return Request.CreateResponse(HttpStatusCode.BadRequest, ex, formatter);
                        }
                    }


                    decimal basicPay = 0;
                    decimal salary = 0;
                    decimal monthlyTax = 0;
                    int WorkedOfDays = 0;
                    int totalDays = 0;
                    decimal? pfAmount = null;
                    decimal? pfAmountEmployer = null;
                    decimal? leaveEncashmentDays = null;
                    decimal? leaveEncashmentAmount = null;
                    decimal? eobiAmount = null;
                    decimal? eobiEmployerContribution = null;
                    decimal? taxableIncome = 0;
                    decimal? grossSalary = 0;                    
                    decimal? ssAmount = null;
                    decimal benefits = 0;
                    decimal deductions = 0;
                    decimal loanDeduction = 0;
                    decimal leaseDedution = 0;
                    decimal? bonus = 0;

                    foreach (var payrollListEmp in payrollSummary)
                    {
                        //var empid = row["ID"].ToString();

                        if (payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault() != null)
                        {
                            basicPay = (decimal)payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().BasicPay;
                            salary = (decimal)payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().NetSalary;
                            monthlyTax = (decimal)payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().MonthlyTax;
                            WorkedOfDays = payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().TotalPresents;
                            totalDays = payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().TotalDays;
                            pfAmount = payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().PFAmount;
                            pfAmountEmployer = payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().PFAmountEmployer;
                            leaveEncashmentDays = payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().LeaveEncashmentDays;
                            leaveEncashmentAmount = payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().LeaveEncashmentAmount;
                            eobiAmount = payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().EOBIAmount;
                            eobiEmployerContribution = payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().EOBIEmployerContribution;
                            ssAmount = payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().SocialSecurityAmount;
                            benefits = payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().Benefits;
                            deductions = payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().Deductions;
                            loanDeduction = payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().LoanDeduction;
                            leaseDedution = payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().LeaseDeduction;
                            grossSalary = payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().GrossSalary;
                            taxableIncome = payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().TaxableIncome;
                            try
                            {
                                bonus = payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().Bonus;
                            }
                            catch { }
                        }

                        if (pfAmount.HasValue && pfAmountEmployer == null)
                        {
                            pfAmountEmployer = 0;
                        }

                        if (eobiAmount.HasValue && eobiEmployerContribution == null)
                        {
                            eobiEmployerContribution = 0;
                        }

                        var empSalarayDT = ExecuteSavePayrollSalarySP(model.userCode, payrollListEmp.ID,
                            model.fromDate, model.toDate, totalDays, WorkedOfDays,
                            basicPay, salary, monthlyTax, pfAmount, pfAmountEmployer, leaveEncashmentDays,
                            leaveEncashmentAmount, eobiAmount, eobiEmployerContribution, ssAmount,
                            benefits, deductions, loanDeduction, leaseDedution,
                            model.ProfitCenterCode, model.PayrollGroupCode, grossSalary, taxableIncome, bonus, true);

                        count++;
                        if (empSalarayDT == null)
                        {
                            continue;
                        }
                        else
                        {
                            // ALL THINGS ARE IN THIS SP NOW
                            // i.e. ExecuteSavePayrollSalarySP
                        }

                    }
                    //}


                    //now call SP of settlement that will update some data and will return Salary slip / or Salary disbursement report result set
                    //and also unprocess it....
                    return Request.CreateResponse(HttpStatusCode.OK, ExecuteFinalSettlementProcessSP(model), new JsonMediaTypeFormatter());

                }                
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }

        [HttpPost]
        [Route("~/Api/Payroll/Data")]
        public HttpResponseMessage GetPayrollData(PayrollProcessModel model)
        {
            try
            {
                DataTable getModel = ExecutePayrollSummarySP(model);
                
                if (getModel == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK, getModel, formatter);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }

        [HttpPost]
        [Route("~/Api/Payroll/Process")]
        public HttpResponseMessage SavePayroll(PayrollProcessModel model)
        {
            try
            {
                int count = 0;
                var msglist = new List<CustomMsg>();
                DataTable getModel = ExecutePayrollSummarySP(model);

                if (getModel == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }
                else
                {
                    // CONVERT datatable to LIST 
                    List<VM_PayrollEmployeeSummary> payrollSummary = getModel.DataTableToList<VM_PayrollEmployeeSummary>();


                    // ALREADY EXIST CHECK
                    var dataExistList = GetEmpSalaryExist(model.ProfitCenterCode, model.fromDate);

                    if (dataExistList != null && dataExistList.Count() > 0)
                    {
                        List<long> empCodesList = payrollSummary.Select(p => p.ID).ToList();
                        var finalList = dataExistList.Where(p => empCodesList.Contains(p.EmpCode));
                        if (finalList != null && finalList.Count() > 0)
                        {
                            msglist.Add(new CustomMsg
                            {
                                TotalRows = 0,
                                Msg = "Payroll is already processed"
                            });
                            return Request.CreateResponse(HttpStatusCode.OK, msglist, new JsonMediaTypeFormatter());
                        }
                    }

                    
                    decimal basicPay = 0;
                    decimal salary = 0;
                    decimal monthlyTax = 0;
                    int WorkedOfDays = 0;
                    int totalDays = 0;
                    decimal? pfAmount = null;
                    decimal? pfAmountEmployer = null;
                    decimal? leaveEncashmentDays = null;
                    decimal? leaveEncashmentAmount = null;
                    decimal? eobiAmount = null;
                    decimal? eobiEmployerContribution = null;
                    decimal? grossSalary = 0;
                    decimal? taxableIncome = 0;
                    decimal? ssAmount = null;
                    decimal benefits = 0;
                    decimal deductions = 0;
                    decimal loanDeduction = 0;
                    decimal leaseDedution = 0;
                    decimal? bonus = 0;

                    foreach (var payrollListEmp in payrollSummary)
                    {
                        //var empid = row["ID"].ToString();

                        if (payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault() != null)
                        {
                            basicPay = (decimal)payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().BasicPay;
                            salary = (decimal)payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().NetSalary;
                            monthlyTax = (decimal)payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().MonthlyTax;
                            WorkedOfDays = payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().TotalPresents;
                            totalDays = payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().TotalDays;
                            pfAmount = payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().PFAmount;
                            pfAmountEmployer = payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().PFAmountEmployer;
                            leaveEncashmentDays = payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().LeaveEncashmentDays;
                            leaveEncashmentAmount = payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().LeaveEncashmentAmount;
                            eobiAmount = payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().EOBIAmount;
                            eobiEmployerContribution = payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().EOBIEmployerContribution;
                            ssAmount = payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().SocialSecurityAmount;
                            benefits = payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().Benefits;
                            deductions = payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().Deductions;
                            loanDeduction = payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().LoanDeduction;
                            leaseDedution = payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().LeaseDeduction;
                            grossSalary = payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().GrossSalary;
                            taxableIncome = payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().TaxableIncome;
                            try
                            {
                                bonus = payrollSummary.Where(x => x.ID == payrollListEmp.ID).FirstOrDefault().Bonus;
                            }
                            catch { }
                        }

                        if (pfAmount.HasValue && pfAmountEmployer == null)
                        {
                            pfAmountEmployer = 0;
                        }
                        if (eobiAmount.HasValue && eobiEmployerContribution == null)
                        {
                            eobiEmployerContribution = 0;
                        }

                        
                        var empSalarayDT = ExecuteSavePayrollSalarySP(model.userCode, payrollListEmp.ID,
                            model.fromDate, model.toDate, totalDays, WorkedOfDays,
                            basicPay, salary, monthlyTax, pfAmount, pfAmountEmployer, leaveEncashmentDays, 
                            leaveEncashmentAmount, eobiAmount, eobiEmployerContribution, ssAmount,
                            benefits, deductions, loanDeduction, leaseDedution,
                            model.ProfitCenterCode, model.PayrollGroupCode, grossSalary, taxableIncome, bonus);

                        count++;
                        if (empSalarayDT == null)
                        {
                            continue;
                        }
                        else
                        {
                            // ALL THINGS ARE IN THIS SP NOW
                            // i.e. ExecuteSavePayrollSalarySP
                        }

                    }
                    //}
                }
                
                msglist.Add(new CustomMsg
                {
                    TotalRows = count,
                    Msg = "Payroll processed successfully"
                });
                return Request.CreateResponse(HttpStatusCode.OK, msglist, new JsonMediaTypeFormatter());
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }

        public List<BOEmployeeSalary> GetEmpSalaryExist(int profitCenterCode, DateTime DateFrom)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].[GetEmpSalaryExist]",
                    Parameters = new Dictionary<string, object>
                        {
                            { "DateFrom", DateFrom },
                            { "ProfitCenterCode", profitCenterCode }
                        }
                };

                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<BOEmployeeSalary>();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable ExecutePayrollSummarySP(PayrollProcessModel model)
        {
            var getModel = new DataTable();

            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].[procGetEmployeesSummary_Payroll]",
                    Parameters = new Dictionary<string, object>
                        {
                            { "dateFrom", model.fromDate },
                            { "dateTo", model.toDate },
                            { "profitCenterCode", model.ProfitCenterCode },
                            { "payrollGroupCode", model.PayrollGroupCode },
                            { "empCode", model.EmpCodes },
                            { "DeptCode", model.DeptCodes },
                            { "FinalSettlement", model.FinalSettlement }
                        }
                };

                getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return getModel;
        }

        public DataSet ExecutePayrollSummarySPFinalSettlement(PayrollProcessModel model)
        {
            var getModel = new DataSet();

            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].[procGetEmployeesSummary_Payroll]",
                    Parameters = new Dictionary<string, object>
                        {
                            { "dateFrom", model.fromDate },
                            { "dateTo", model.toDate },
                            { "profitCenterCode", model.ProfitCenterCode },
                            { "payrollGroupCode", model.PayrollGroupCode },
                            { "empCode", model.EmpCodes },
                            { "DeptCode", model.DeptCodes },
                            { "FinalSettlement", model.FinalSettlement }
                        }
                };

                getModel = new CommonRepository(ConStr).ExecStoreProcedureForAllDataSets(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return getModel;
        }

        public DataTable ExecuteFinalSettlementProcessSP(PayrollProcessModel model)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].[WebEmpFinalSettlementProcess]",
                    Parameters = new Dictionary<string, object>
                        {
                            { "EmpCode", model.EmpCodes },
                            { "StartDate", model.fromDate },
                            { "EndDate", model.toDate },
                            { "ProcessOrUnProcess", model.ProcessOrUnProcess },
                            { "EmpProfitCenterCode", model.ProfitCenterCode },
                            { "EmpPayrollGroupCode", model.PayrollGroupCode },
                            { "CompanyCode", model.CompanyCode },
                            { "userId", model.userCode }                                                    
                        }
                };

                var resp = new CommonRepository(ConStr).ExecStoreProcedure(data);


                // call SP for un-process it also now so that if user dont save the data and close the whole webpage 
                //as he/she cannot close the dialogue box but he/she can close the webpage from browser close button... 
                //so its process shud b roleback after getting values
                if (model.ProcessOrUnProcess == 1)
                {
                    SpData data2 = new SpData
                    {
                        SpName = "[HRM].[WebEmpFinalSettlementProcess]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "EmpCode", model.EmpCodes },
                            { "StartDate", model.fromDate },
                            { "EndDate", model.toDate },
                            { "ProcessOrUnProcess", 0 },
                            { "EmpProfitCenterCode", model.ProfitCenterCode },
                            { "EmpPayrollGroupCode", model.PayrollGroupCode },
                            { "CompanyCode", model.CompanyCode },
                            { "userId", model.userCode }
                        }
                    };

                    new CommonRepository(ConStr).ExecStoreProcedure(data2);
                }


                return resp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ExecuteSavePayrollSalarySP(int UserID, long EmpCode,
            DateTime DateFrom, DateTime DateTo, int TotalDays, int WorkedDays, decimal BasicPay, decimal Salary,
            decimal MonthlyTax, decimal? pfAmount, decimal? pfAmountEmployer,
            decimal? leaveEncashmentDays, decimal? leaveEncashmentAmount, 
            decimal? eobiAmount, decimal? EOBIEmployerContribution , decimal? ssAmount,
            decimal benefits, decimal deductions, decimal loanDeduction, decimal leaseDeduction, 
            int ProfitCenterCode, string PayrollGroupCode, decimal? GrossSalary, decimal? TaxableIncome,
            decimal? bonus, bool FinalSettlement = false)
        {
            var getModel = new DataTable();

            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].[WebProcSaveEmpSalary]",
                    Parameters = new Dictionary<string, object>
                    {
                        { "UserID", UserID },
                        { "EmpCode", EmpCode },
                        { "DateFrom", DateFrom },
                        { "DateTo", DateTo },
                        { "TotalDays", TotalDays },
                        { "WorkedDays", WorkedDays },
                        { "BasicPay", BasicPay },
                        { "Salary", Salary },
                        { "MonthlyTax", MonthlyTax },
                        { "LeaveEncashmentDays", leaveEncashmentDays },
                        { "LeaveEncashmentAmount", leaveEncashmentAmount },
                        { "EOBIAmount", eobiAmount },
                        { "SocialSecurityAmount", ssAmount },
                        { "Benefits", benefits },
                        { "Deductions", deductions },
                        { "LoanDeduction", loanDeduction },
                        { "LeaseDeduction", leaseDeduction },
                        { "ProfitCenterCode", ProfitCenterCode },
                        { "PayrollGroupCode", PayrollGroupCode },
                        { "FinalSettlement" , FinalSettlement },
                        { "EOBIEmployerContribution" , EOBIEmployerContribution },
                        { "TaxableIncome" , TaxableIncome },
                        { "GrossSalary" , GrossSalary },
                        { "Bonus" , bonus }

                    }
                };

                if (!pfAmount.HasValue)
                {
                    pfAmount = 0;
                }
                if (!pfAmountEmployer.HasValue)
                {
                    pfAmountEmployer = 0;
                }

                data.Parameters.Add("PFAmount", pfAmount);
                data.Parameters.Add("PFAmountEmployer", pfAmountEmployer);
                

                getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return getModel;
        }



        //public DataTable ExecuteProcessAttendanceDailyInfo(DateTime fromDate, DateTime toDate, string empCodes)
        //{
        //    var getModel = new DataTable();

        //    try
        //    {
        //        SpData data = new SpData
        //        {
        //            SpName = "[HRM].[ProcEmployeeDailyAttendanceInfo]",
        //            Parameters = new Dictionary<string, object>
        //                {
        //                    { "EmpCode", empCodes },
        //                    { "DateFrom", fromDate },
        //                    { "DateTo", toDate },
        //                }
        //        };

        //        getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //    return getModel;
        //}

    }
    public class PayrollProcessModel
    {
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public int ProfitCenterCode { get; set; }
        public string PayrollGroupCode { get; set; }
        public string DeptCodes { get; set; }
        public string EmpCodes { get; set; }
        public int userCode { get; set; }
        public int CompanyCode { get; set; }        
        public bool FinalSettlement { get; set; }
        public int ProcessOrUnProcess { get; set; }
    }

    public class VM_PayrollEmployeeSummary
    {
        public long ID { get; set; }

        public string Name { get; set; }

        public string EmpCode { get; set; }

        public string Location { get; set; }

        public string Shift { get; set; }

        public string Department { get; set; }
        public int DeptCode { get; set; }

        public string Designation { get; set; }

        public decimal BasicPay { get; set; }
        public decimal? TaxableIncome { get; set; }
        public decimal? GrossSalary { get; set; }

        public decimal Benefits { get; set; }

        public decimal Deductions { get; set; }

        public decimal LoanDeduction { get; set; }

        public decimal LeaseDeduction { get; set; }

        public decimal? Bonus { get; set; }

        public decimal NetSalary { get; set; }
        public decimal MonthlyTax { get; set; }

        public int TotalPresents { get; set; }
        public int TotalDays { get; set; }

        public decimal? PFAmount { get; set; }
        public decimal? PFAmountEmployer { get; set; }
        public decimal? LeaveEncashmentDays { get; set; }
        public decimal? LeaveEncashmentAmount { get; set; }
        public decimal? EOBIAmount { get; set; }
        public decimal? EOBIEmployerContribution { get; set; }
        public decimal? SocialSecurityAmount { get; set; }

    }

    public class VM_PayrollAttendance
    {
        public long ID { get; set; }

        //public string Name { get; set; }

        //public string EmpCode { get; set; }

        //public string Location { get; set; }

        //public string Shift { get; set; }

        //public string Department { get; set; }

        //public string Designation { get; set; }

        //public int WorkingDays { get; set; }

        //public int OffDays { get; set; }

        //public int WorkedDays { get; set; }

        //public int OverTimeHrs { get; set; }

        public decimal OvertimeHrs { get; set; }
        public decimal OvertimeAmnt { get; set; }
        public long OverTimeTypeCode { get; set; }

        //public decimal? TotalHours { get; set; }
        //public decimal? WorkedHours { get; set; }

    }
}

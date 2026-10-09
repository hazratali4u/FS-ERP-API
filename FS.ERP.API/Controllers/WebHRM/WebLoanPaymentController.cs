using CST.CCL.Helper;
using CST.CCL.Helper.Common;
using CST.CRY;
using FS.CAPI.BAL;
using FS.ERP.API.Models;
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
    public class WebLoanPaymentController : ApiController
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
        public LoanPaymentValidation ValidateLoanTransaction(LoanPayment obj)
        {

            decimal? DebitAmount = 0;
            decimal? CreditAmount = 0;
            LoanPaymentValidation validation = new LoanPaymentValidation();

            try
            {
                if (obj.Amount > 0 && obj.PaymentType == true)
                {
                    //Credit
                    CreditAmount = obj.Amount;

                    validation.transaction.Add(new VoucherTransaction
                    {
                        EmployeeID = obj.EmpCode,
                        Amount = obj.Amount,
                        COACode = obj.COACode,
                        Debit = false,
                    });

                    //Debit
                    var loan = GetLoanTypeCOACode(obj.EmployeeLoanCode);
                    if (loan != null && loan.Rows.Count > 0)
                    {
                        var loanCoaCode = Convert.ToInt64(loan.Rows[0]["LoanPaymentCOACode"].ToString());
                        if (loanCoaCode > 0)
                        {
                            DebitAmount = obj.Amount;

                            validation.transaction.Add(new VoucherTransaction
                            {
                                EmployeeID = obj.EmpCode,
                                Amount = obj.Amount,
                                COACode = loanCoaCode,
                                Debit = true,
                            });
                        }
                    }
                }
                else
                {
                    if (obj.LoanInstallments != null && obj.LoanInstallments.Count > 0)
                    {
                        //Debit
                        var writeOffAmount = obj.LoanInstallments.Sum(x => x.InstallmentAmount);
                        if (writeOffAmount > 0)
                        {
                            DebitAmount = writeOffAmount;

                            validation.transaction.Add(new VoucherTransaction
                            {
                                EmployeeID = obj.EmpCode,
                                Amount = writeOffAmount,
                                COACode = obj.COACode,
                                Debit = true,
                            });
                        }

                        //Credit
                        var loan = GetLoanTypeCOACode(obj.EmployeeLoanCode);
                        if (loan != null && loan.Rows.Count > 0)
                        {
                            var loanCoaCode = Convert.ToInt64(loan.Rows[0]["LoanPaymentCOACode"].ToString());
                            if (loanCoaCode > 0)
                            {
                                CreditAmount = writeOffAmount;

                                validation.transaction.Add(new VoucherTransaction
                                {
                                    EmployeeID = obj.EmpCode,
                                    Amount = writeOffAmount,
                                    COACode = loanCoaCode,
                                    Debit = false,
                                });
                            }
                        }
                    }
                }

                if (Math.Round(DebitAmount.Value) != Math.Round(CreditAmount.Value))
                {
                    validation.IsSuccess = false;
                    return validation;
                }

                return validation;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        [HttpPost]
        [Route("~/Api/LoanPayment/SaveOrUpdateLoanPayment")]
        public HttpResponseMessage SaveOrUpdateLoanPayment(LoanPayment loan)
        {
            try
            {
                DataTable dt = new DataTable();

                DataTable getModel = new DataTable();

                LoanPaymentValidation transactions = null;

                if (loan.COACode.HasValue)
                {
                    transactions = ValidateLoanTransaction(loan);

                    if (transactions.IsSuccess == false)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                        { IsAlert = true, Message = "Ledger Incomplete." }, formatter);
                    }
                }

                getModel = SaveLoanPayment(loan);
                var savedID = getModel.Rows[0]["ID"].ToString();

                if (loan.PaymentType == false)
                {
                    if (loan.LoanInstallments != null && loan.LoanInstallments.Count > 0)
                    {

                        foreach (var item in loan.LoanInstallments)
                        {
                            UpdateLoanInstallment(item, loan.CreatedByCode, savedID, loan.EmployeeLoanCode, loan.CompanyCode, loan.ReturnedByEmp);
                        }
                    }
                }

                if (transactions != null && transactions.IsSuccess == true && transactions.transaction.Count > 0)
                {
                    var savedVoucherID = processTransactions(transactions, loan);

                    if (!string.IsNullOrEmpty(savedVoucherID))
                        return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                        { IsSuccess = true, Message = "Data Saved", Data = savedVoucherID }, formatter);
                    else
                        return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                        { IsAlert = true, Message = "Voucher is not created," +
                            "please check Document Settings for Folio", Data = savedVoucherID
                        }, formatter);
                }

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
        public string processTransactions(LoanPaymentValidation obj, LoanPayment loan)
        {
            var idAfterSaving = "";
            if (obj.transaction != null && obj.transaction.Count > 0)
            {
                var count = 0;
                try
                {
                    var description = loan.PaymentType == true ? "Loan Payment Voucher, "
                      + loan.Employee + ", " + loan.LoanFolioNo : "Loan Adjustment Voucher, " + loan.Employee + ", " + loan.LoanFolioNo;
                    var RefNo = "Loan against salary " + loan.Employee;
                    var menuCode = 0;
                    var voucherTypeCode = "-1";

                    if (loan.PaymentMode == 1)
                    {
                        menuCode = 129;
                        voucherTypeCode = "Cash Payment Voucher";
                    }
                    else
                    {
                        menuCode = 131;
                        voucherTypeCode = "Bank Payment Voucher";
                    }

                    SpData data = new SpData
                    {
                        SpName = "[dbo].[WebGetNewFolioNo]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "menuCode", menuCode },
                            { "tableName", "tbl_TransactionMaster" },
                            { "colName", "TransactionCode" },
                            { "baseCode", -1 },
                            { "companyCode", loan.CompanyCode },
                            { "voucherTypeCode", voucherTypeCode },
                            { "IsHR" , false }
                        }
                    };

                    var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                    var transactionMaserFolio = getModel.Rows[0]["Folio"].ToString();


                    data = new SpData
                    {
                        SpName = "[FICO].WebSaveLoanVoucherMaster",
                        Parameters = new Dictionary<string, object>
                        {
                            { "PaymentMode", loan.PaymentMode },
                            { "PayeeName", loan.Employee },
                            { "LoanFolioNo", loan.LoanFolioNo },
                            { "Description", description },
                            { "LoanPaymentID", loan.ID },
                            { "CreatedByCode", loan.CreatedByCode },
                            { "CompanyCode", loan.CompanyCode },
                            { "TransactionCode", transactionMaserFolio },
                            { "RefNo", RefNo }

                        }
                    };

                    getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                    idAfterSaving = getModel.Rows[0]["ID"].ToString();

                    foreach (var item in obj.transaction)
                    {
                        count = count + 1;

                        data = new SpData
                        {
                            SpName = "[FICO].WebSaveLoanVoucherDetail",
                            Parameters = new Dictionary<string, object>
                        {
                            { "TransactionCode", idAfterSaving },
                            { "COACode", item.COACode },
                            { "TransactionLineNo", count },
                            { "DrAmount", item.Debit == true ? item.Amount : null },
                            { "CrAmount", item.Debit == false ? item.Amount : null },
                            { "CreatedByCode", loan.CreatedByCode },
                            { "CompanyCode", loan.CompanyCode }
                        }
                        };

                        getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return idAfterSaving;
        }
        public DataTable SaveLoanPayment(LoanPayment loan)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].[CreateOrUpdateLoanPayment]",
                    Parameters = new Dictionary<string, object>
                        {
                            { "ID", loan.ID },
                            { "PaymentType", loan.PaymentType },
                            { "EmpCode", loan.EmpCode },
                            { "EmployeeLoanCode", loan.EmployeeLoanCode },
                            { "PaymentMode", loan.PaymentMode },
                            { "Amount", loan.Amount },
                            { "ChequeNo", loan.ChequeNo },
                            { "Remarks", loan.Remarks },
                            { "ChequeRealizationDate", loan.ChequeRealizationDate },
                            { "ChequeIssuanceDate", loan.ChequeIssuanceDate },
                            { "COACode", loan.COACode },
                            { "CompanyCode", loan.CompanyCode },
                            { "CreatedByCode", loan.CreatedByCode }
                        }
                };

                var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                return getModel;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable UpdateLoanInstallment(VM_LoanInstallment loan, int createdByCode, string loanPaymentID, long employeeLoanCode, int companyCode, bool ReturnedByEmp)
        {
            try
            {
                //string remarks = "Loan Payment (";
                //if (ReturnedByEmp)
                //{
                //    remarks = remarks + "Employee Returned)";
                //}
                //else
                //{
                //    remarks = remarks + "Waived Off)";
                //}

                //remarks = remarks + " (Ref. Id = " + loanPaymentID + ")";

                SpData data = new SpData
                {
                    SpName = "[HRM].[WebUpdateLoanInstallment]",
                    Parameters = new Dictionary<string, object>
                    {
                        { "ID", loan.ID },
                        { "IsReceived", true },
                        { "EmployeeLoanCode",  employeeLoanCode},
                        { "ReceivedOn", loan.ReceivedOn ?? DateTime.Now },
                        { "ReceivedAmount", loan.ReceivedAmount },
                        { "ReturnedByEmp", ReturnedByEmp },
                        { "CreatedByCode", createdByCode },
                        {"CompanyCode", companyCode }
                    }
                };

                var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                return getModel;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetLoanTypeCOACode(long loanCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].[GetLoanTypeCOACode]",
                    Parameters = new Dictionary<string, object>
                        {
                            { "loanCode", loanCode },
                        }
                };

                var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                return getModel;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    public class LoanPayment
    {
        public string LoanFolioNo { get; set; }
        public string Employee { get; set; }
        public long ID { get; set; }
        public bool PaymentType { get; set; }
        public bool ReturnedByEmp { get; set; }
        public long EmpCode { get; set; }
        public long EmployeeLoanCode { get; set; }
        public int PaymentMode { get; set; }
        public decimal? Amount { get; set; }
        public string ChequeNo { get; set; }
        public string Remarks { get; set; }
        public DateTime? ChequeRealizationDate { get; set; }
        public DateTime? ChequeIssuanceDate { get; set; }
        public long? COACode { get; set; }
        public int CompanyCode { get; set; }
        public int CreatedByCode { get; set; }
        public List<VM_LoanInstallment> LoanInstallments { get; set; }
    }
    public class VM_LoanInstallment
    {
        public long ID { get; set; }
        public short? InstallmentNo { get; set; }
        public DateTime? InstallmentDueOn { get; set; }
        public decimal? InstallmentAmount { get; set; }
        public bool IsReceived { get; set; }
        public DateTime? ReceivedOn { get; set; }
        public decimal? ReceivedAmount { get; set; }
        public string Remarks { get; set; }
    }
    public class LoanPaymentValidation
    {
        public LoanPaymentValidation()
        {
            transaction = new List<VoucherTransaction>();
            IsSuccess = true;
        }
        public bool IsSuccess { get; set; }
        public List<VoucherTransaction> transaction { get; set; }
    }
    public class VoucherTransaction
    {
        public decimal? Amount { get; set; }
        public long? COACode { get; set; }
        public int? DeptCode { get; set; }
        public bool? Debit { get; set; }
        public long? EmployeeID { get; set; }
    }
}

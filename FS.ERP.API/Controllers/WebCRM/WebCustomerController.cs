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
    public class WebCustomerController : ApiController
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

        [HttpGet]
        [Route("~/Api/Company/GetCustomerDetails")]
        public HttpResponseMessage GetCustomerDetails(long ID)
        {
            try
            {
                CustomerModel model = new CustomerModel();
                //DataTable getModel = new DataTable();

                var customerData = GetCustomer(ID);

                if (customerData != null && customerData.Count > 0)
                {
                    model = customerData[0];
                    model.Contacts = GetCustomerContacts(ID);
                    model.Branches = GetCustomerBranches(ID);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "");
                }

                return Request.CreateResponse(HttpStatusCode.OK, model, formatter);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }
        public List<CustomerModel> GetCustomer(long customerCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[CRM].GetCustomerByID",
                    Parameters = new Dictionary<string, object> { { "customerCode", customerCode } }
                };
                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<CustomerModel>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<VM_CustomerContact> GetCustomerContacts(long customerCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[dbo].[ProcMobileCompOrCustContactList]",
                    Parameters = new Dictionary<string, object> { { "ID", customerCode } }
                };
                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<VM_CustomerContact>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<VM_CustomerBranch> GetCustomerBranches(long customerCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[CRM].[procGetPartyOrCustomerBranches]",
                    Parameters = new Dictionary<string, object> { { "BranchParentCode", customerCode } }
                };
                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<VM_CustomerBranch>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("~/Api/Company/SaveOrUpdateCustomer")]
        public HttpResponseMessage SaveOrUpdateCustomer(CustomerModel model)
        {
            try
            {
                DataTable getModel = new DataTable();

                var isDuplicate = CheckForDuplicateForPartyCustomer(model);

                if (isDuplicate > 0)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                    { IsAlert = true, Message = "Duplicate Record" }, formatter);
                }

                getModel = SaveCustomer(model);

                if (getModel != null && getModel.Rows.Count > 0)
                {
                   var savedID = getModel.Rows[0]["ID"].ToString();

                   var contacts = SaveCustomerContacts(model, savedID);

                   var branches = SaveCustomerBranches(model, savedID);
                }

                if (getModel == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                { IsSuccess = true, Message = "Data Saved", Data = getModel }, formatter);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }
        public DataTable SaveCustomer(CustomerModel model)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[CRM].[CreateOrUpdatePartyCustomer]",
                    Parameters = new Dictionary<string, object>
                        {
                            { "ID", model.ID },
                            { "ParentCode", model.ParentCode },
                            { "FullName", model.FullName },
                            { "RegistrationType", model.RegistrationType },
                            { "OfficialPhoneNo", model.OfficialPhoneNo },
                            { "OfficialEmail", model.OfficialEmail },
                            { "WhatsAppNo", model.WhatsAppNo },
                            { "URL_Name", model.URL_Name },
                            { "CityTownCode", model.CityTownCode },
                            { "OfficialAddress", model.OfficialAddress },
                            { "NTN_No", model.NTN_No },
                            { "GST_No", model.GST_No },
                            { "SNS_RegNo", model.SNS_RegNo },
                            { "CreditDays", model.CreditDays },
                            { "GraceDays", model.GraceDays },
                            { "CreditAmount", model.CreditAmount },
                            { "CompanyCode", model.CompanyCode },
                            { "CreatedByCode", model.CreatedByCode },
                            { "BillTo", model.BillTo },
                            { "DispatchTo", model.DispatchTo },
                            { "VerticalTypeCode", model.VerticalTypeCode },
                            { "CustomerGroupCode", model.CustomerGroupCode }

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
        public DataTable SaveCustomerContacts(CustomerModel model, string savedID)
        {
            try
            {
                var getModel = new DataTable();
                foreach (var item in model.Contacts)
                {
                    SpData data = new SpData
                    {
                        SpName = "[CRM].[procMobileSaveContactPerson]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "ContactPersonCode", item.ID },
                            { "Salutation", item.Salutation },
                            { "FirstName", item.FirstName },
                            { "LastName", item.LastName },
                            { "Designation", item.Designation },
                            { "ContactNumber", item.ContactNumber },
                            { "OfficialEmail", item.OfficialEmail },
                            { "CustomerCode", Convert.ToInt64(savedID) },
                            { "WhatsAppNo", item.WhatsAppNo },
                            { "LandLineNo", item.LandLineNo },
                            { "IsPrimaryContact", item.IsPrimaryContact },
                            { "CompanyCode", model.CompanyCode },
                            { "UserCode", model.CreatedByCode },
                            { "IsDeleted", item.IsDeleted }
                        }
                    };

                    getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                }
                
                return getModel;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SaveCustomerBranches(CustomerModel model, string savedID)
        {
            try
            {
                var getModel = new DataTable();
                foreach (var item in model.Branches)
                {
                    SpData data = new SpData
                    {
                        SpName = "[CRM].[procSavePartyOrCustomerBranch]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "ID", item.ID },
                            { "BranchParentCode", Convert.ToInt64(savedID) },
                            { "FullName", item.FullName },
                            { "Address", item.OfficialAddress },
                            { "CompanyCode", model.CompanyCode },
                            { "UserCode", model.CreatedByCode },
                            { "IsDeleted", item.IsDeleted }
                        }
                    };

                    getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                }

                return getModel;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int CheckForDuplicateForPartyCustomer(CustomerModel model)
        {
            try
            {
                
                var isDuplicate = 0;
                SpData data = new SpData
                {
                    SpName = "[CRM].[WebCheckDuplicateForPartyCustomer]",
                    Parameters = new Dictionary<string, object>
                        {
                            { "OfficialEmail", model.OfficialEmail != null ? model.OfficialEmail.Trim() : model.OfficialEmail },
                            { "FullName", model.FullName },
                            { "ID", model.ID }
                        }
                };

                var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                isDuplicate = Convert.ToInt32(getModel.Rows[0]["Duplicate"].ToString());

                return isDuplicate;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    public class CustomerModel
    {
        public long ID { get; set; }
        public long? ParentCode { get; set; }
        public string FullName { get; set; }
        public string RegistrationType { get; set; }
        public string OfficialPhoneNo { get; set; }
        public string OfficialEmail { get; set; }
        public string WhatsAppNo { get; set; }
        public string URL_Name { get; set; }
        public int? CityTownCode { get; set; }
        public int? CountryCode { get; set; }
        public string OfficialAddress { get; set; }
        public string NTN_No { get; set; }
        public string GST_No { get; set; }
        public string SNS_RegNo { get; set; }
        public int? CreditDays { get; set; }
        public int? GraceDays { get; set; }
        public string BillTo { get; set; }
        public string DispatchTo { get; set; }
        public int? VerticalTypeCode { get; set; }
        public decimal? CreditAmount { get; set; }
        public int CompanyCode { get; set; }
        public int CreatedByCode { get; set; }
        public string CustomerGroupCode { get; set; }
        public List<VM_CustomerContact> Contacts { get; set; }
        public List<VM_CustomerBranch> Branches { get; set; }
    }
    public class VM_CustomerContact
    {
        public int ID { get; set; }
        public long CustomerCode { get; set; }
        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string OfficialEmail { get; set; }
        public string LandLineNo { get; set; }
        public string Designation { get; set; }
        public string WhatsAppNo { get; set; }
        public bool IsPrimaryContact { get; set; }
        public bool IsDeleted { get; set; }
    }
    public class VM_CustomerBranch
    {
        public long ID { get; set; }
        public long BranchParentCode { get; set; }
        public string FullName { get; set; }
        public string OfficialAddress { get; set; }
        public bool IsDeleted { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Cors;
using FS.CAPI.BAL;
using CST.CCL.Helper;
using CST.CCL.Helper.Common;
using CST.CRY;
using FS.ERP.Business.IdentityManager;
using FS.ERP.EF.Db_Context;
using FS.ERP.EF.IdentityStore;
using FS.ERP.Models.BO;
using FS.ERP.Models.Custom;
using FS.ERP.Models.IdentityModel;
using Microsoft.AspNet.Identity;
using Newtonsoft.Json;
using PLINQO;
using FS.ERP.API.Filters;
using FS.BO.MultiTanent;
using System.Linq;

namespace FS.ERP.API.Controllers
{
    [Authorize]
    [EnableCors("*", "*", "*")]
    public class CommonController : ApiController
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
        [Route("~/Api/User/HashPassword/{password}")]
        public HttpResponseMessage HashPassword(string password)
        {
            try
            {
                var userManager = new ApplicationUserManager(new ApplicationUserStore(FsERPContext.Create(ConStr)));
                string hashedPassword = userManager.PasswordHasher.HashPassword(password);
                return Request.CreateResponse(HttpStatusCode.OK, hashedPassword, formatter);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }

        [HttpPost]
        [Route("~/Api/User/AddOrUpdateUser")]
        public HttpResponseMessage AddOrUpdateUser(AddUser user)
        {

            try
            {
                DataTable getModel = new DataTable();
                var result = "";
                string hashedPassword = "";

                if (user.LoginPWD != null && user.LoginPWD != "")
                {
                    var userManager = new ApplicationUserManager(new ApplicationUserStore(FsERPContext.Create(ConStr)));
                    hashedPassword = userManager.PasswordHasher.HashPassword(user.LoginPWD);
                }

                if (user.RecordID == 0)
                {
                    result = CheckForDuplicateAndValidUser(user.UserName, user.Email, user.DefaultEmpCode);
                }

                if (string.IsNullOrEmpty(result))
                {

                    SpData data = new SpData
                    {
                        SpName = "[UMS].[CreateOrUpdateUser]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "DefaultEmpCode", user.DefaultEmpCode },
                            { "DefaultCCorPCCode", user.DefaultCCorPCCode },
                            { "DefaultProfileGroupCode", user.DefaultProfileGroupCode },
                            { "DefaultMenuCode", user.DefaultMenuCode },
                            { "DefaultLocationCode", user.DefaultLocationCode },
                            { "UserName", user.UserName },
                            { "LoginPWD", user.LoginPWD },
                            { "FirstName", user.FirstName },
                            { "LastName", user.LastName },
                            { "IsRequiredPWDChange", user.IsRequiredPWDChange },
                            { "IsActive", user.IsActive },
                            { "IsSystemAdmin", user.IsSystemAdmin },
                            { "IsSuperAdmin", user.IsSuperAdmin },
                            { "PasswordHash", hashedPassword },
                            { "SecurityStamp", Guid.NewGuid().ToString("N") },
                            { "Email", user.Email },
                            { "SecondaryEmail", user.SecondaryEmail },
                            { "PhoneNumber", user.PhoneNumber },
                            { "ImagePath", user.ImagePath },
                            { "SecretQuestion", user.SecretQuestion },
                            { "SecretAnswer", user.SecretAnswer },
                            { "CompanyCode", user.CompanyCode },
                            { "CreatedByCode", user.CreatedByCode },
                            { "RecordID", user.RecordID },
                            { "IsRestricted", user.IsRestricted },
                            { "IsEnforcePassChange", user.IsEnforcePassChange }
                        }
                    };

                    getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                    if (getModel == null)
                    {
                        return Request.CreateResponse(HttpStatusCode.NotFound);
                    }
                    else
                    {
                        var insertedUserID = Convert.ToInt32(getModel.Rows[0]["Column1"].ToString());

                        var companyPermission = new string[10000];
                        var profitPermission = new string[10000];
                        var locationSitePermission = new string[10000];
                        var profileGroupPermission = new string[10000];

                        if (!string.IsNullOrEmpty(user.CompanyPermission))
                            companyPermission = user.CompanyPermission.Split(',');
                        else
                            Array.Resize(ref companyPermission, 0);

                        if (!string.IsNullOrEmpty(user.ProfitCenterPermission))
                            profitPermission = user.ProfitCenterPermission.Split(',');
                        else
                            Array.Resize(ref profitPermission, 0);

                        if (!string.IsNullOrEmpty(user.LocationSitePermission))
                            locationSitePermission = user.LocationSitePermission.Split(',');
                        else
                            Array.Resize(ref locationSitePermission, 0);

                        if (!string.IsNullOrEmpty(user.ProfileGroupPermission))
                            profileGroupPermission = user.ProfileGroupPermission.Split(',');
                        else
                            Array.Resize(ref profileGroupPermission, 0);

                        DeletePermissions(Convert.ToInt32(insertedUserID), user.CompanyCode);

                        //company permission
                        if (companyPermission.Length > 0)
                        {
                            foreach (var item in companyPermission)
                            {
                                data = new SpData
                                {
                                    SpName = "[UMS].SaveOrgCompanyPermission",
                                    Parameters = new Dictionary<string, object>
                        {
                            { "UserCode",  Convert.ToInt32(insertedUserID) },
                            { "CompanyPermissionCode", Convert.ToInt32(item) },
                            { "CompanyCode", user.CompanyCode },
                            { "CreatedByCode", user.CreatedByCode },
                        }
                                };

                                var getModel1 = new CommonRepository(ConStr).ExecStoreProcedure(data);
                            }
                        }

                        //profit center permission
                        if (profitPermission.Length > 0)
                        {
                            foreach (var item in profitPermission)
                            {
                                data = new SpData
                                {
                                    SpName = "[UMS].SaveOrgCompanyPermission",
                                    Parameters = new Dictionary<string, object>
                        {
                            { "UserCode",  Convert.ToInt32(insertedUserID) },
                            { "CompanyPermissionCode", Convert.ToInt32(item) },
                            { "CompanyCode", user.CompanyCode },
                            { "CreatedByCode", user.CreatedByCode },
                        }
                                };

                                var getModel1 = new CommonRepository(ConStr).ExecStoreProcedure(data);
                            }
                        }

                        //location Site permission
                        if (locationSitePermission.Length > 0)
                        {
                            foreach (var item in locationSitePermission)
                            {
                                data = new SpData
                                {
                                    SpName = "[UMS].SaveLocationSitePermission",
                                    Parameters = new Dictionary<string, object>
                        {
                            { "UserCode",  Convert.ToInt32(insertedUserID) },
                            { "LocationSiteCode", Convert.ToInt32(item) },
                            { "CompanyCode", user.CompanyCode },
                            { "CreatedByCode", user.CreatedByCode },
                        }
                                };

                                var getModel1 = new CommonRepository(ConStr).ExecStoreProcedure(data);
                            }
                        }

                        //Profie Group Permission
                        //location Site permission
                        if (profileGroupPermission.Length > 0)
                        {
                            foreach (var item in profileGroupPermission)
                            {
                                data = new SpData
                                {
                                    SpName = "[UMS].SaveProfileGroupPermission",
                                    Parameters = new Dictionary<string, object>
                        {
                            { "UserCode",  Convert.ToInt32(insertedUserID) },
                            { "ProfileGroupCode", Convert.ToInt32(item) },
                            { "CompanyCode", user.CompanyCode },
                            { "CreatedByCode", user.CreatedByCode },
                        }
                                };

                                var getModel1 = new CommonRepository(ConStr).ExecStoreProcedure(data);
                            }
                        }
                    }
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, result);
                }

                return Request.CreateResponse(HttpStatusCode.OK, getModel, formatter);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }

        public string CheckForDuplicateAndValidUser(string userName, string email, long? empCode)
        {
            SpData data = new SpData
            {
                SpName = "[UMS].[CheckDuplicateUserAndValidate]",
                Parameters = new Dictionary<string, object>
                        {
                            { "UserName", userName },
                            { "Email", email },
                            { "DefaultEmpCode", empCode }
                        }
            };

            var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
            return getModel.Rows[0]["Result"].ToString();
        }
        public void DeletePermissions(int userCode, int companyCode)
        {
            SpData data = new SpData
            {
                SpName = "[UMS].DeleteUserMappings",
                Parameters = new Dictionary<string, object> { { "userCode", userCode }, { "companyCode", companyCode } }
            };

            new CommonRepository(ConStr).ExecStoreProcedure(data);
        }

        [HttpPost]
        [Route("~/Api/User/ChangePassword")]
        public HttpResponseMessage ChangePassword(ChangePwdUserModel user)
        {
            try
            {
                var userManager = new ApplicationUserManager(new ApplicationUserStore(FsERPContext.Create(ConStr)));
                string hashedPassword = userManager.PasswordHasher.HashPassword(user.NewPassword);

                SpData data = new SpData
                {
                    SpName = "[HRM].[procMobileChangePassword]",
                    Parameters = new Dictionary<string, object>
                        {
                            { "UserCode", user.UserCode },
                            { "OldPassword", user.OldPassword },
                            { "NewPassword", user.NewPassword },
                            { "NewPasswordHash", hashedPassword },
                        }
                };

                var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                var ordModel = getModel;
                if (getModel == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }
                else
                {
                    //long orderCode = 0; // get from above model getModel

                    //foreach (DataRow row in getModel.Rows)
                    //{
                    //    orderCode = Convert.ToInt64(row[0].ToString());
                    //}

                }

                return Request.CreateResponse(HttpStatusCode.OK, getModel, formatter);
            }

            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }

        [HttpPost]
        [Route("~/Api/User/ChangePasswordFirst")]
        public HttpResponseMessage ChangePasswordFirst(ChangePwdUserModel user)
        {
            try
            {
                var userManager = new ApplicationUserManager(new ApplicationUserStore(FsERPContext.Create(ConStr)));
                string hashedPassword = userManager.PasswordHasher.HashPassword(user.NewPassword);

                SpData data = new SpData
                {
                    SpName = "[HRM].[procMobileChangePasswordFirst]",
                    Parameters = new Dictionary<string, object>
                        {
                            { "UserCode", user.UserCode },
                            //{ "OldPassword", user.OldPassword },
                            { "NewPassword", user.NewPassword },
                            { "NewPasswordHash", hashedPassword },
                        }
                };

                var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                var ordModel = getModel;
                if (getModel == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }
                else
                {
                    //long orderCode = 0; // get from above model getModel

                    //foreach (DataRow row in getModel.Rows)
                    //{
                    //    orderCode = Convert.ToInt64(row[0].ToString());
                    //}

                }

                return Request.CreateResponse(HttpStatusCode.OK, getModel, formatter);
            }

            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }

        [HttpPost]
        [Route("~/Api/Common/RunSimpleQuery")]
        public async Task<HttpResponseMessage> RunSimpleQuery([FromBody]string query)
        {
            try
            {
                bool val = false;
                var result = Task.Factory.StartNew(() =>
                {
                    val = new CommonRepository(ConStr).RunSimpleQuery(query);
                    return val;
                });
                await result;
                return Request.CreateResponse(HttpStatusCode.OK, result.Result, new JsonMediaTypeFormatter());
            }
            catch (Exception ex)
            {
                //LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetUserMenu", "tbl_Menu", "dbo.ProcGetUserMenu", ex, false, false);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, new JsonMediaTypeFormatter());
            }
        }

        [HttpPost]
        [Route("~/Api/Common/RunQuery")]
        public async Task<HttpResponseMessage> RunQuery([FromBody]string query)
        {
            try
            {
                DataTable data = null;
                var result = Task.Factory.StartNew(() =>
                {
                    data = new CommonRepository(ConStr).RunQuery(query);
                    return data;
                });
                await result;
                return Request.CreateResponse(HttpStatusCode.OK, result.Result, new JsonMediaTypeFormatter());
            }
            catch (Exception ex)
            {
                //LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetUserMenu", "tbl_Menu", "dbo.ProcGetUserMenu", ex, false, false);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, new JsonMediaTypeFormatter());
            }
        }

        [HttpGet]
        //[CacheFilter(TimeDuration = 60)]
        public HttpResponseMessage GetLookUpDataSet(string procedureName, string lpm)
        {
            try
            {
                List<ParameterList> lpmData = JsonHelper.DeserializeByNewtonSoftJson<List<ParameterList>>(lpm);
                var getModel = new CommonRepository(ConStr).GetLookUpDataSet(procedureName, lpmData);
                if (getModel == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK, getModel, new JsonMediaTypeFormatter());
            }
            catch (Exception ex)
            {
                //LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetUserMenu", "tbl_Menu", "dbo.ProcGetUserMenu", ex, false, false);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, new JsonMediaTypeFormatter());
            }
        }

        [HttpPost]
        public HttpResponseMessage IsValidateForDelete(IsValidateForDelete modal)
        {
            try
            {
                var getModel = new CommonRepository(ConStr).IsValidateForDelete(modal);
                if (getModel == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK, getModel, new JsonMediaTypeFormatter());
            }
            catch (Exception ex)
            {
                //LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetUserMenu", "tbl_Menu", "dbo.ProcGetUserMenu", ex, false, false);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, new JsonMediaTypeFormatter());
            }
        }

        [HttpGet]
        public HttpResponseMessage GetCodeValue(string strReturnType, string strTableName, string strColName, string strWhere, string strCompositeKey, string strCompositeValue)
        {
            try
            {
                var getModel = new CommonRepository(ConStr).GetCodeValue(strReturnType, strTableName, strColName, strWhere, strCompositeKey, strCompositeValue);
                if (getModel == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }
                return Request.CreateResponse(HttpStatusCode.OK, getModel, new JsonMediaTypeFormatter());

            }
            catch (Exception ex)
            {
                //LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetUserMenu", "tbl_Menu", "dbo.ProcGetUserMenu", ex, false, false);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, new JsonMediaTypeFormatter());
            }
        }

        [HttpPost]
        [Route("~/api/Common/ExecSp")]
        //[CacheFilter(TimeDuration = 60)]
        public HttpResponseMessage ExecSp(SpData data)
        {
            try
            {
                if (!string.IsNullOrEmpty(data.SpName) && data.SpName.Equals("[dbo].[procMobileMarkAttendance]")
                    && 
                    (
                      ConStr.ToLower().Contains("vertexmedical") || ConStr.ToLower().Contains("fastservices")
                      || ConStr.ToLower().Contains("stanleyfoods") || ConStr.ToLower().Contains("atlascopco")
                    )
                    )
                {
                    string latitude = data.Parameters["latitude"].ToString();
                    string longitude = data.Parameters["longitude"].ToString();

                    //const string apiKey = "AIzaSyBJ-eENydsrvESf0rl7ybznZTbfrQzl8wo"; //!!!!paste your API KEY HERE!!!!
                    const string apiKey = "AIzaSyB-_Z1iw3_Q6de-_58LTZSGcVyKiKsKKd8"; //!!!!paste your API KEY HERE!!!!

                    //following is a sample to check its working or not ... paste in browser and run
                    //https://maps.googleapis.com/maps/api/geocode/json?latlng=31.48100796417084,74.30970043736819&key=AIzaSyB-_Z1iw3_Q6de-_58LTZSGcVyKiKsKKd8&sensor=false

                    //string baseUrlGC = "https://maps.googleapis.com/maps/api/geocode/json?address="; // part1 of the URL for GeoCoding
                    string baseUrlRGC = "https://maps.googleapis.com/maps/api/geocode/json?latlng="; // part1 of the URL for Reverse GeoCoding
                    string plusUrl = "&key=" + apiKey + "&sensor=false"; // part2 of the URL

                    var json = new WebClient().DownloadString(baseUrlRGC + latitude.Replace(" ", "") + "," + longitude.Replace(" ", "") + plusUrl);//concatenate URL with the input lat/lng and downloads the requested resource
                    GoogleGeoCodeResponse jsonResult = JsonConvert.DeserializeObject<GoogleGeoCodeResponse>(json); //deserializing the result to GoogleGeoCodeResponse

                    string status = jsonResult.status; // get status

                    string addressDetails = String.Empty;
                    string address = String.Empty;

                    string[] type = null;

                    if (status == "OK") //check if status is OK
                    {
                        for (int i = 0; i < jsonResult.results.Length; i++) //loop throught the result for addresses
                        {
                            type = jsonResult.results[i].types;

                            if (i == 0)
                            {
                                address = type[0] + " : " + jsonResult.results[i].formatted_address + Environment.NewLine; //append the result addresses to every new line
                            }

                            if (i == 1 || i == 2)
                            {
                                addressDetails += type[0] + " : " + jsonResult.results[i].formatted_address + Environment.NewLine; //append the result addresses to every new line
                            }

                            //type = jsonResult.results[i].types;
                            //if (ContainsStreet(type))
                            //{
                            //    streetAddress = "" + jsonResult.results[i].formatted_address + Environment.NewLine; //append the result addresses to every new line
                            //}
                            //else
                            //{
                            //    if (i < 2)
                            //    {
                            //        geoLocation += type[0] + " : " + jsonResult.results[i].formatted_address + Environment.NewLine; //append the result addresses to every new line
                            //    }
                            //}
                        }
                        //return geoLocation; //return result
                    }
                    else
                    {
                        //status; //return status / error if not OK
                        string txt = status;
                        addressDetails = String.Empty;
                        address = String.Empty;

                    }

                    if (!string.IsNullOrEmpty(address))
                    {
                        data.Parameters.Add("GoogleAddress", address);
                    }

                    if (!string.IsNullOrEmpty(addressDetails))
                    {
                        data.Parameters.Add("GoogleAddressDetails", addressDetails);
                    }
                }

                var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                if (getModel == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }
                return Request.CreateResponse(HttpStatusCode.OK, getModel, new JsonMediaTypeFormatter());
            }
            catch (Exception ex)
            {
                //LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetUserMenu", "tbl_Menu", "dbo.ProcGetUserMenu", ex, false, false);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, new JsonMediaTypeFormatter());
            }
        }
        private bool ContainsStreet(string[] str)
        {
            foreach (var val in str)
            {
                if (val.Equals("street_address"))
                {
                    return true;
                }
            }
            return false;
        }
        [HttpPost]
        [Route("~/api/Common/ExecSpAllDataSets")]
        //[CacheFilter(TimeDuration = 60)]
        public HttpResponseMessage ExecSpAllDataSets(SpData data)
        {
            try
            {
                var getModel = new CommonRepository(ConStr).ExecStoreProcedureForAllDataSets(data);
                if (getModel == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }
                return Request.CreateResponse(HttpStatusCode.OK, getModel, new JsonMediaTypeFormatter());
            }
            catch (Exception ex)
            {
                //LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetUserMenu", "tbl_Menu", "dbo.ProcGetUserMenu", ex, false, false);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, new JsonMediaTypeFormatter());
            }
        }

        [HttpPost]
        [Route("~/api/Common/UploadEmployeesInBulk")]
        //[CacheFilter(TimeDuration = 60)]
        public HttpResponseMessage UploadEmployeesInBulk(EmployeeUploadModel employee)
        {
            try
            {
                EmpResponse resp = new EmpResponse();
                var empMsgsList = new List<EmpRespMsgs>();
                EmpRespMsgs eMsg;
                SpData data = new SpData();
                int rowCount = 0;
                foreach (var emp in employee.employees)
                {
                    if (employee.ForRptng == 0)
                    {
                        data = new SpData
                        {
                            SpName = "[HRM].[WebSaveEmployeeForBulk]",
                            Parameters = new Dictionary<string, object>
                            {
                                { "Salutation", emp.Salu },
                                { "FirstName", emp.FNm },
                                { "LastName", emp.LNm },
                                { "FatherName", emp.FthNm },
                                { "EmpCompanyCode", employee.CompanyCode },
                                { "Gender", emp.Gndr },
                                { "EmpCode", emp.ECd },
                                { "NCNIC", emp.CNIC },
                                { "NCNICExpiry", emp.CNXDt },
                                { "DOB", emp.DOB },
                                { "BloodGroup", emp.BldGr },
                                { "MaritalStatus", emp.MSt },
                                { "Religion", emp.Rlgn },
                                { "OfficialEmail", emp.OEml },
                                { "OfficialPhoneMobile", emp.OPh },
                                { "PersonalEmail", emp.PEml },
                                { "PersonalPhoneMobile", emp.PPh },
                                { "CurrentAddress", emp.CAdd },
                                { "PermanentAddress", emp.PAdd },
                                { "Country", emp.Cnty },
                                { "City", emp.Cty },
                                { "SocialSecurityNo", emp.SSN },
                                { "SocialSecurityDate", emp.SSDt },
                                { "EOBINo", emp.EBI },
                                { "EOBIStartDate", emp.EBDt },
                                { "PFNumber", emp.PF },
                                { "PFEffectiveDate", emp.PFDt },
                                { "AccountTitle", emp.AccT },
                                { "AccountNumber", emp.AccN },
                                { "BranchCode", emp.BrCd },
                                { "IBAN", emp.IBAN },
                                { "BasicPay", emp.BPay },
                                { "ProbationPeriod", emp.PbPrd },
                                { "NoticePeriod", emp.NPrd },
                                { "DOJ", emp.DOJ },
                                { "HireType", emp.HTyp },
                                //{ "ReportingEmployee", emp.RpEmp },
                                { "CurrentLocation", emp.Loc },
                                { "CostOrProfitCenterBusUnit", emp.BUnt },
                                { "NatureOfVacancy", emp.VNtr },
                                { "Dept", emp.Dpt },
                                { "Designation", emp.Dsg },
                                { "Shift", emp.Shf },
                                { "PayGrade", emp.Grd },
                                { "Salary", emp.Sal },
                                { "SalaryTransferMode", emp.STrMd },
                                { "LeavePolicy", emp.LvPol },
                                { "Zone", emp.Zone },

                                { "CompanyCode", employee.CompanyCode },
                                { "UserCode", employee.UserCode },

                            }
                        };
                    }
                    else if (employee.ForRptng == 1)
                    {
                        data = new SpData
                        {
                            SpName = "[HRM].[WebSaveEmployeeForBulkRptng]",
                            Parameters = new Dictionary<string, object>
                            {
                                { "EmpCode", emp.ECd },
                                { "RptngEmpCode", emp.RpEmp },
                            }
                        };
                    }

                    var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                    
                    if (getModel == null)
                    {
                        return Request.CreateResponse(HttpStatusCode.NotFound);
                    }
                    else
                    {
                        if (employee.ForRptng == 0)
                        {
                            foreach (DataRow row in getModel.Rows)
                            {
                                eMsg = new EmpRespMsgs();
                                eMsg.EmpCode = emp.ECd;

                                if (DBNull.Value == row["ID"])
                                {
                                    eMsg.Status = "Employee is not saved";
                                }
                                else
                                {
                                    if (Convert.ToInt32(row["ID"].ToString()) == 0)
                                    {
                                        eMsg.Status = "Employee is not saved";
                                    }
                                    else
                                    {
                                        eMsg.Status = "Employee is saved";
                                    }
                                }

                                if (DBNull.Value == row["NullColNames"] || row["NullColNames"].ToString().Length == 0)
                                {
                                    eMsg.Msg = "Ok";
                                }
                                else
                                {
                                    eMsg.Msg = row["NullColNames"].ToString();
                                }

                                empMsgsList.Add(eMsg);
                            }

                        }
                        else if (employee.ForRptng == 1)
                        {
                            foreach (DataRow row in getModel.Rows)
                            {
                                eMsg = new EmpRespMsgs();
                                eMsg.EmpCode = emp.ECd;
                                if (DBNull.Value == row["TotalRows"])
                                {
                                    eMsg.Status = "Employee reporting is not updated";
                                }
                                else
                                {
                                    if (Convert.ToInt32(row["TotalRows"].ToString()) > 0)
                                    {
                                        eMsg.Status = "Employee reporting is updated";
                                    }
                                    else
                                    {
                                        eMsg.Status = "Employee reporting is not updated";
                                    }
                                }
                            }
                        }
                        rowCount = rowCount++;
                    }
                }

                resp.IsSuccess = true;
                resp.EmpMsgs = empMsgsList;

                return Request.CreateResponse(HttpStatusCode.OK, resp, new JsonMediaTypeFormatter());
            }
            catch (Exception ex)
            {
                //LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetUserMenu", "tbl_Menu", "dbo.ProcGetUserMenu", ex, false, false);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, new JsonMediaTypeFormatter());
            }
        }
        [HttpPost]
        [Route("~/api/Common/TailorExpenses")]
        //[CacheFilter(TimeDuration = 60)]
        public HttpResponseMessage TailorExpenses(TailorPaymentModel paymentData)
        {
            try
            {
                DataTable respData = null;
                if (paymentData != null)
                {
                    // save expenses

                    SpData data = new SpData();
                    int rowCount = 0;
                    foreach (var det in paymentData.Expenses)
                    {
                        data = new SpData
                        {
                            SpName = "[VOG].[ProcMobileSaveExpenses]",
                            Parameters = new Dictionary<string, object>
                                {
                                    { "ExpenseCode", det.ExpenseCode },
                                    { "UserCode", det.UserCode },
                                    { "ExpenseHeadCode", det.ExpenseHeadCode },
                                    { "ExpenseDate ", det.ExpenseDate },
                                    { "PaymentModeCode", det.PaymentModeCode },
                                    { "Amount", det.Amount },
                                    { "Remarks", det.Remarks },
                                }
                        };

                        var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                        respData = getModel;
                        if (getModel == null)
                        {
                            return Request.CreateResponse(HttpStatusCode.NotFound);
                        }
                        else
                        {
                            foreach (DataRow row in getModel.Rows)
                            {
                                rowCount = rowCount + Convert.ToInt32(row[0].ToString());
                            }
                        }
                    }

                    try
                    {
                        if (respData != null)
                        {
                            foreach (DataRow row in respData.Rows)
                            {
                                row[0] = rowCount + "";
                                break;
                            }
                        }
                    }
                    catch { }


                    return Request.CreateResponse(HttpStatusCode.OK, respData, new JsonMediaTypeFormatter());
                }
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new JsonMediaTypeFormatter());
            }
            catch (Exception ex)
            {
                //LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetUserMenu", "tbl_Menu", "dbo.ProcGetUserMenu", ex, false, false);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, new JsonMediaTypeFormatter());
            }
        }

        [HttpPost]
        [Route("~/api/Common/TailorOrder")]
        //[CacheFilter(TimeDuration = 60)]
        public HttpResponseMessage TailorOrder(TailorOrderModel tailorData)
        {
            try
            {
                if (tailorData != null)
                {
                    // save order 1st

                    SpData data = new SpData
                    {
                        SpName = "[VOG].[ProcMobileSaveOrder]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "OrderCode", tailorData.Order.OrderCode },
                            { "CustomerCode", tailorData.Order.CustomerCode },
                            { "EmpCode", tailorData.Order.EmpCode },
                            { "UserCode", tailorData.Order.UserCode },
                            { "RecordStatusCode", tailorData.Order.RecordStatusCode }
                        }
                    };

                    var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                    var ordModel = getModel;
                    if (getModel == null)
                    {
                        return Request.CreateResponse(HttpStatusCode.NotFound);
                    }
                    else
                    {
                        List<DressTypeMeasurements> dressTypeMeasurementsByList = new List<DressTypeMeasurements>();
                        long orderCode = 0; // get from above model getModel

                        foreach (DataRow row in getModel.Rows)
                        {
                            orderCode = Convert.ToInt64(row[0].ToString());
                        }

                        foreach (var det in tailorData.OrderDetails)
                        {
                            data = new SpData
                            {
                                SpName = "[VOG].[ProcMobileSaveOrderDetail]",
                                Parameters = new Dictionary<string, object>
                                {
                                    { "OrderDetailCode", det.OrderDetailCode },
                                    { "OrderCode", orderCode },
                                    { "UserCode", tailorData.Order.UserCode },
                                    { "FabricCode", det.FabricCode },
                                    { "DressTypeCode", det.DressTypeCode },
                                    { "TryDate", det.TryDate },
                                    { "DeliveryDate", det.DeliveryDate },
                                    { "StitchingFee", det.StitchingFee },
                                    { "FabricQty", det.FabricQuantity },
                                    { "FabricPrice", det.FabricPrice },
                                    { "SizeNotes", det.SizeNotes },
                                    { "StyleNotes", det.StyleNotes },
                                    { "AddAmountRemarks", det.AddAmountRemarks },
                                    { "AdditionalAmount", det.AdditionalAmount },
                                    { "RecordStatusCode", det.RecordStatusCode }

                                }
                            };

                            getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                            if (getModel == null)
                            {
                                return Request.CreateResponse(HttpStatusCode.NotFound);
                            }
                            else
                            {
                                dressTypeMeasurementsByList.Add(new DressTypeMeasurements
                                {
                                    DressTypeCode = det.DressTypeCode.Value,
                                    MeasurementsBy = det.MeasurementsBy
                                });

                                long orderDetailCode = 0; // get from above model getModel

                                foreach (DataRow row in getModel.Rows)
                                {
                                    orderDetailCode = Convert.ToInt64(row[0].ToString());
                                }

                                foreach (var style in det.DressStyles)
                                {
                                    data = new SpData
                                    {
                                        SpName = "[VOG].[ProcMobileSaveOrderDetailStyle]",
                                        Parameters = new Dictionary<string, object>
                                        {
                                            { "OrderDetailStyleCode", style.OrderDetailStyleCode },
                                            { "OrderDetailCode", orderDetailCode },
                                            { "UserCode", tailorData.Order.UserCode },
                                            { "DressTypeStyleCategoryCode", style.DressTypeStyleCategoryCode },
                                            { "Style", style.Style },
                                            { "StyleValue", style.StyleValue },
                                            { "RecordStatusCode", style.RecordStatusCode }
                                        }
                                    };

                                    getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                                    if (getModel == null)
                                    {
                                        return Request.CreateResponse(HttpStatusCode.NotFound);
                                    }
                                }
                            }
                        }

                        foreach (var size in tailorData.OrderDressSizes)
                        {
                            foreach (var dtm in dressTypeMeasurementsByList)
                            {
                                if (dtm.DressTypeCode == size.DressTypeCode)
                                {
                                    size.MeasurementsBy = dtm.MeasurementsBy;
                                    break;
                                }
                            }
                            
                            data = new SpData
                            {
                                SpName = "[VOG].[ProcMobileSaveOrderDressSize]",
                                Parameters = new Dictionary<string, object>
                                {
                                    { "OrderDressSizeCode", size.OrderDressSizeCode},
                                    { "OrderCode", orderCode },
                                    { "DressTypeCode", size.DressTypeCode },
                                    { "UserCode", tailorData.Order.UserCode },
                                    { "EmpCode", size.MeasurementsBy },
                                    { "DressSizeCode", size.DressSizeCode },
                                    { "SizeValue", size.SizeValue },
                                    { "RecordStatusCode", size.RecordStatusCode }
                                }
                            };

                            getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                            if (getModel == null)
                            {
                                return Request.CreateResponse(HttpStatusCode.NotFound);
                            }
                        }
                    }


                    return Request.CreateResponse(HttpStatusCode.OK, ordModel, new JsonMediaTypeFormatter());
                }
                //var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);

                return Request.CreateResponse(HttpStatusCode.InternalServerError, new JsonMediaTypeFormatter());
            }
            catch (Exception ex)
            {
                //LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetUserMenu", "tbl_Menu", "dbo.ProcGetUserMenu", ex, false, false);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, new JsonMediaTypeFormatter());
            }
        }

        [HttpGet]
        [Route("~/api/Common/TailorOrder")]
        //[CacheFilter(TimeDuration = 60)]
        public HttpResponseMessage TailorOrder(long? orderNo, int? print)
        {
            TailorOrderModel tailorData = new TailorOrderModel();
            try
            {
                if (orderNo.HasValue)
                {
                    // save order 1st
                    OrderModel order = new OrderModel();


                    SpData data = new SpData
                    {
                        SpName = "[VOG].[ProcMobileOrderInformation]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "OrderNo", orderNo }
                        }
                    };

                    var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                    var ordModel = getModel;
                    if (getModel == null)
                    {
                        return Request.CreateResponse(HttpStatusCode.NotFound);
                    }
                    else
                    {

                        foreach (DataRow row in getModel.Rows)
                        {
                            order.OrderCode = Convert.ToInt64(row[0].ToString());
                            order.OrderDate = Convert.ToDateTime(row[2].ToString());
                            order.CustomerName = row[4].ToString();
                            order.CustomerCode = Convert.ToInt64(row[5].ToString());
                            order.TotalAmount = Convert.ToDecimal(row[6].ToString());
                            order.ReceivedAmount = Convert.ToDecimal(row[7].ToString());
                            order.OrderTakerEmpName = row[8].ToString();
                            order.EmpCode = Convert.ToInt64(row[9].ToString());
                            order.RecordStatusCode = Convert.ToInt32(row["RecordStatusCode"].ToString());
                        }

                        tailorData.Order = order;


                        data = new SpData
                        {
                            SpName = "[VOG].[ProcMobileOrderDetailInformation]",
                            Parameters = new Dictionary<string, object>
                                {
                                    { "OrderCode", order.OrderCode }
                                }
                        };

                        getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                        if (getModel == null)
                        {
                            return Request.CreateResponse(HttpStatusCode.NotFound);
                        }
                        else
                        {
                            OrderDetailModel det;
                            List<OrderDetailModel> detList = new List<OrderDetailModel>();

                            foreach (DataRow row in getModel.Rows)
                            {
                                det = new OrderDetailModel();
                                det.OrderDetailCode = Convert.ToInt64(row[0].ToString());
                                det.RecordStatusCode = Convert.ToInt32(row["RecordStatusCode"].ToString());
                                det.Status = row["DressStatus"].ToString();
                                det.ArticleCode = row["ArticleCode"].ToString();
                                det.StyleNotes = row[2].ToString();
                                det.SizeNotes = row[3].ToString();
                                if (!string.IsNullOrEmpty(row[4].ToString()))
                                {
                                    det.AdditionalAmount = Convert.ToDecimal(row[4].ToString());
                                }

                                det.AddAmountRemarks = row[5].ToString();

                                if (!string.IsNullOrEmpty(row[6].ToString()))
                                {
                                    det.FabricCode = Convert.ToInt64(row[6].ToString());
                                    det.FabricName = row[7].ToString();
                                }

                                det.DressTypeCode = Convert.ToInt64(row[8].ToString());
                                det.DressTypeName = row[9].ToString();

                                if (DBNull.Value == row["MeasurementsBy"])
                                {
                                    //do nothing
                                }
                                else
                                {
                                    det.MeasurementsBy = Convert.ToInt64(row["MeasurementsBy"].ToString());
                                }

                                if (DBNull.Value == row["MeasurementsByName"])
                                {
                                    //do nothing
                                }
                                else
                                {
                                    det.MeasurementsByName = row["MeasurementsByName"].ToString();
                                }
                                                                

                                if (!string.IsNullOrEmpty(row[10].ToString()))
                                {
                                    det.TryDate = Convert.ToDateTime(row[10].ToString());
                                }
                                if (!string.IsNullOrEmpty(row[11].ToString()))
                                {
                                    det.DeliveryDate = Convert.ToDateTime(row[11].ToString());
                                }
                                det.StitchingFee = Convert.ToDecimal(row[12].ToString());

                                if (!string.IsNullOrEmpty(row[13].ToString()))
                                {
                                    det.FabricQuantity = Convert.ToDecimal(row[13].ToString());
                                }
                                if (!string.IsNullOrEmpty(row[14].ToString()))
                                {
                                    det.FabricPrice = Convert.ToDecimal(row[14].ToString());
                                }

                                //now get its styles

                                data = new SpData
                                {
                                    SpName = "[VOG].[ProcMobileRptOrderStyle]",
                                    Parameters = new Dictionary<string, object>
                                        {
                                            { "OrderDetailCode", det.OrderDetailCode }
                                        }
                                };

                                getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                                if (getModel == null)
                                {
                                    return Request.CreateResponse(HttpStatusCode.NotFound);
                                }
                                else
                                {
                                    DressStyleModel style;
                                    List<DressStyleModel> stylesList = new List<DressStyleModel>();
                                    foreach (DataRow rowSt in getModel.Rows)
                                    {
                                        style = new DressStyleModel();

                                        style.OrderDetailStyleCode = Convert.ToInt64(rowSt[1].ToString());
                                        style.Style = rowSt[2].ToString();
                                        style.StyleValue = rowSt[3].ToString();
                                        style.GroupName = rowSt["GroupName"].ToString();

                                        if (DBNull.Value == rowSt["ParentID"])
                                        {
                                            style.ParentID = null;
                                        }
                                        else
                                        {
                                            style.ParentID = Convert.ToInt64(rowSt["ParentID"]);
                                        }
                                        style.DressTypeStyleCategoryCode = Convert.ToInt64(rowSt[4].ToString());
                                        style.DressTypeStyleCategoryName = rowSt[5].ToString();
                                        style.RecordStatusCode = Convert.ToInt32(rowSt["RecordStatusCode"].ToString());

                                        stylesList.Add(style);
                                    }

                                    det.DressStyles = stylesList;

                                    if (print.HasValue && print == 1)
                                    {
                                        DressStylePrintModel stylePrint;
                                        List<DressStylePrintModel> stylesPrintList = new List<DressStylePrintModel>();
                                        long dressTypeStyleCategoryCode = 0;
                                        long dressTypeStyleCategoryCode2ndLevelChild = 0;


                                        foreach (DataRow rowSt in getModel.Rows)
                                        {
                                            stylePrint = new DressStylePrintModel();

                                            dressTypeStyleCategoryCode = Convert.ToInt64(rowSt[4].ToString());

                                            if (DBNull.Value == rowSt["ParentID"])
                                            {
                                                stylePrint.val = rowSt[5].ToString();

                                                foreach (DataRow rowStChilds in getModel.Rows)
                                                {
                                                    if (DBNull.Value == rowStChilds["ParentID"])
                                                    {
                                                        //nothing
                                                    }
                                                    else
                                                    {
                                                        if (dressTypeStyleCategoryCode == Convert.ToInt64(rowStChilds["ParentID"]))
                                                        {
                                                            if (rowStChilds[3].ToString().Length > 0)
                                                            {
                                                                stylePrint.val = stylePrint.val + " " + rowStChilds[3].ToString();
                                                            }
                                                            else
                                                            {
                                                                stylePrint.val = stylePrint.val + " " + rowStChilds[5].ToString();
                                                            }

                                                            //start 2nd innner loop to get 3rd level of style's child
                                                            dressTypeStyleCategoryCode2ndLevelChild = Convert.ToInt64(rowStChilds[4].ToString());

                                                            foreach (DataRow row3rdLevelChild in getModel.Rows)
                                                            {
                                                                if (DBNull.Value == row3rdLevelChild["ParentID"])
                                                                {
                                                                    //nothing
                                                                }
                                                                else
                                                                {
                                                                    if (dressTypeStyleCategoryCode2ndLevelChild == Convert.ToInt64(row3rdLevelChild["ParentID"]))
                                                                    {
                                                                        if (row3rdLevelChild[3].ToString().Length > 0)
                                                                        {
                                                                            stylePrint.val = stylePrint.val + " " + row3rdLevelChild[3].ToString();
                                                                        }
                                                                        else
                                                                        {
                                                                            stylePrint.val = stylePrint.val + " " + row3rdLevelChild[5].ToString();
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            //end
                                                        }
                                                    }
                                                }

                                                stylesPrintList.Add(stylePrint);
                                            }
                                        }

                                        det.DressStylesPrint = stylesPrintList;
                                    }
                                }

                                detList.Add(det);
                            }

                            tailorData.OrderDetails = detList;

                            data = new SpData
                            {
                                SpName = "[VOG].[ProcMobileRptOrderSize]",
                                Parameters = new Dictionary<string, object>
                                {
                                    { "OrderCode", order.OrderCode }
                                }
                            };

                            getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                            if (getModel == null)
                            {
                                return Request.CreateResponse(HttpStatusCode.NotFound);
                            }
                            else
                            {
                                // now get dress sizes for
                                DressSizeModel size;
                                List<DressSizeModel> sizeList = new List<DressSizeModel>();
                                foreach (DataRow rowSt in getModel.Rows)
                                {
                                    size = new DressSizeModel();

                                    size.OrderDressSizeCode = Convert.ToInt64(rowSt[7].ToString());

                                    size.DressTypeCode = Convert.ToInt64(rowSt[1].ToString());
                                    size.DressTypeName = rowSt[2].ToString();
                                    size.Break = Convert.ToInt32(rowSt["PrintSizesLineBreak"].ToString());

                                    size.MeasurementsBy = Convert.ToInt64(rowSt["MeasurementsBy"].ToString());
                                    size.MeasurementsByName = rowSt["MeasurerEmpName"].ToString();

                                    if (!string.IsNullOrEmpty(rowSt[3].ToString()))
                                    {
                                        size.DressSizeCode = Convert.ToInt64(rowSt[3].ToString());
                                        size.DressSizeName = rowSt[4].ToString();
                                    }

                                    size.SizeValue = Convert.ToDecimal(rowSt[5].ToString());
                                    size.RecordStatusCode = Convert.ToInt32(rowSt["RecordStatusCode"].ToString());

                                    sizeList.Add(size);
                                }

                                tailorData.OrderDressSizes = sizeList;
                            }
                        }
                    }

                    return Request.CreateResponse(HttpStatusCode.OK, tailorData, new JsonMediaTypeFormatter());
                }
                //var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);

                return Request.CreateResponse(HttpStatusCode.InternalServerError, new JsonMediaTypeFormatter());
            }
            catch (Exception ex)
            {
                //LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetUserMenu", "tbl_Menu", "dbo.ProcGetUserMenu", ex, false, false);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, new JsonMediaTypeFormatter());
            }
        }
        [HttpPost]
        [Route("~/api/Common/TailorOrderSave")]
        //[CacheFilter(TimeDuration = 60)]
        public HttpResponseMessage TailorOrderSave(TailorOrderSaveModel tailorData)
        {
            try
            {
                if (tailorData != null)
                {
                    // save order 1st

                    SpData data = new SpData
                    {
                        SpName = "[VOG].[ProcMobileSaveOrder]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "OrderCode", tailorData.Order.OCde },
                            { "CustomerCode", tailorData.Order.CustCde },
                            { "EmpCode", tailorData.Order.ECde },
                            { "UserCode", tailorData.Order.UCde },
                            { "RecordStatusCode", 0 }
                        }
                    };

                    var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                    var ordModel = getModel;
                    if (getModel == null)
                    {
                        return Request.CreateResponse(HttpStatusCode.NotFound);
                    }
                    else
                    {
                        List<DressTypeMeasurements> dressTypeMeasurementsByList = new List<DressTypeMeasurements>();
                        long orderCode = 0; // get from above model getModel

                        foreach (DataRow row in getModel.Rows)
                        {
                            orderCode = Convert.ToInt64(row[0].ToString());
                        }

                        foreach (var det in tailorData.OrderDetails)
                        {
                            data = new SpData
                            {
                                SpName = "[VOG].[ProcMobileSaveOrderDetail]",
                                Parameters = new Dictionary<string, object>
                                {
                                    { "OrderDetailCode", det.ODetCde },
                                    { "OrderCode", orderCode },
                                    { "UserCode", tailorData.Order.UCde },
                                    { "FabricCode", det.FabCde },
                                    { "DressTypeCode", det.DrsTypCde},
                                    { "TryDate", det.TryDte },
                                    { "DeliveryDate", det.DelDte },
                                    { "StitchingFee", det.StitchFee },
                                    { "FabricQty", det.FabQty },
                                    { "FabricPrice", det.FabPrc },
                                    { "SizeNotes", det.SizNts },
                                    { "StyleNotes", det.StylNts },
                                    { "AddAmountRemarks", det.AddAmntRem },
                                    { "AdditionalAmount", det.AddAmnt },
                                    { "RecordStatusCode", 0 }

                                }
                            };

                            getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                            if (getModel == null)
                            {
                                return Request.CreateResponse(HttpStatusCode.NotFound);
                            }
                            else
                            {
                                dressTypeMeasurementsByList.Add(new DressTypeMeasurements
                                {
                                    DressTypeCode = det.DrsTypCde.Value,
                                    MeasurementsBy = det.MesureBy
                                });

                                long orderDetailCode = 0; // get from above model getModel

                                foreach (DataRow row in getModel.Rows)
                                {
                                    orderDetailCode = Convert.ToInt64(row[0].ToString());
                                }

                                foreach (var style in det.DressStyles)
                                {
                                    data = new SpData
                                    {
                                        SpName = "[VOG].[ProcMobileSaveOrderDetailStyle]",
                                        Parameters = new Dictionary<string, object>
                                        {
                                            { "OrderDetailStyleCode", style.OrDetStylCde },
                                            { "OrderDetailCode", orderDetailCode },
                                            { "UserCode", tailorData.Order.UCde },
                                            { "DressTypeStyleCategoryCode", style.DrsTypStylCatCde },
                                            { "Style", style.Styl },
                                            { "StyleValue", style.StylVal },
                                            { "RecordStatusCode", 0 }
                                        }
                                    };

                                    getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                                    if (getModel == null)
                                    {
                                        return Request.CreateResponse(HttpStatusCode.NotFound);
                                    }
                                }
                            }
                        }

                        foreach (var size in tailorData.OrderDressSizes)
                        {
                            foreach (var dtm in dressTypeMeasurementsByList)
                            {
                                if (dtm.DressTypeCode == size.DrsTypCde)
                                {
                                    size.MesureBy = dtm.MeasurementsBy;
                                    break;
                                }
                            }

                            data = new SpData
                            {
                                SpName = "[VOG].[ProcMobileSaveOrderDressSize]",
                                Parameters = new Dictionary<string, object>
                                {
                                    { "OrderDressSizeCode", size.ODrsSizCde},
                                    { "OrderCode", orderCode },
                                    { "DressTypeCode", size.DrsTypCde },
                                    { "UserCode", tailorData.Order.UCde },
                                    { "EmpCode", size.MesureBy },
                                    { "DressSizeCode", size.DrsSizCde },
                                    { "SizeValue", size.SizVal },
                                    { "RecordStatusCode", 0 }
                                }
                            };

                            getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                            if (getModel == null)
                            {
                                return Request.CreateResponse(HttpStatusCode.NotFound);
                            }
                        }
                    }


                    return Request.CreateResponse(HttpStatusCode.OK, ordModel, new JsonMediaTypeFormatter());
                }
                //var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);

                return Request.CreateResponse(HttpStatusCode.InternalServerError, new JsonMediaTypeFormatter());
            }
            catch (Exception ex)
            {
                //LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetUserMenu", "tbl_Menu", "dbo.ProcGetUserMenu", ex, false, false);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, new JsonMediaTypeFormatter());
            }
        }

        [HttpGet]
        //[CacheFilter(TimeDuration = 60)]
        public HttpResponseMessage GetDataWithJoin(string entityName, string whereClause)
        {
            try
            {
                var getModel = new CommonRepository(ConStr).GetDataWithJoin(entityName, whereClause);
                if (getModel == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }
                return Request.CreateResponse(HttpStatusCode.OK, getModel, new JsonMediaTypeFormatter());
            }
            catch (Exception ex)
            {
                //LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetUserMenu", "tbl_Menu", "dbo.ProcGetUserMenu", ex, false, false);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, new JsonMediaTypeFormatter());
            }
        }

        [HttpGet]
        public HttpResponseMessage SoftDelete(string id, string tableName)
        {
            try
            {
                var getModel = new CommonRepository(ConStr).SoftDelete(Convert.ToInt32(id), tableName);
                if (getModel == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK, getModel, new JsonMediaTypeFormatter());
            }
            catch (Exception ex)
            {
                //LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetUserMenu", "tbl_Menu", "dbo.ProcGetUserMenu", ex, false, false);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, new JsonMediaTypeFormatter());
            }
        }

        [HttpGet]
        //[CacheFilter(TimeDuration = 60)]
        public HttpResponseMessage GetToolBarRights(int userCode, int companyCode, int menuCode)
        {
            try
            {
                var getModel = new FS.CAPI.BAL.UserRepository(ConStr).GetToolBarRights(userCode, companyCode, menuCode);
                if (getModel == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK, getModel, new JsonMediaTypeFormatter());
            }
            catch (Exception ex)
            {
                //LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetUserMenu", "tbl_Menu", "dbo.ProcGetUserMenu", ex, false, false);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, new JsonMediaTypeFormatter());
            }
        }

        [HttpPost]
        [Route("~/Api/Permission/SaveOrUpdatePermission")]
        public HttpResponseMessage SaveOrUpdatePermission(List<Insert_ProfileGroupDetail> permission)
        {
            try
            {
                DataTable dt = new DataTable();

                var savedProfileGroupID = SaveOrUpdateProfileGroup(permission[0].ProfileGroupCode, permission[0].GroupRoleName,
                    permission[0].Description, permission[0].CreatedByCode, permission[0].CompanyCode);

                if (string.IsNullOrEmpty(savedProfileGroupID))
                    savedProfileGroupID = permission[0].ProfileGroupCode.ToString();

                dt.Columns.Add("ProfileGroupCode", typeof(int));
                dt.Columns.Add("MenuCode", typeof(int));
                dt.Columns.Add("SecurityRightCode", typeof(string));
                dt.Columns.Add("CompanyCode", typeof(int));
                dt.Columns.Add("CreatedByCode", typeof(int));

                foreach (var item in permission)
                {
                    dt.Rows.Add(Convert.ToInt32(savedProfileGroupID), item.MenuCode, item.SecurityRightCode, item.CompanyCode, item.CreatedByCode);
                }

                SpData data = new SpData
                {
                    SpName = "[MenuCNF].[Insert_ProfileGroupDetail]",
                    Parameters = new Dictionary<string, object>
                        {
                            { "tblProfileGroupDetail", dt }
                        }
                };

                var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                var ordModel = getModel;
                if (getModel == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }
                else
                {

                }

                return Request.CreateResponse(HttpStatusCode.OK, getModel, formatter);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }
        public string SaveOrUpdateProfileGroup(int groupRoleCode, string GroupRoleName, string descrip, int userCode, int companyCode)
        {
            SpData data = new SpData
            {
                SpName = "[MenuCNF].[CreateOrUpdateGroupRole]",
                Parameters = new Dictionary<string, object>
                        {
                            { "GroupRoleName", GroupRoleName },
                            { "Description", descrip },
                            { "CompanyCode", companyCode },
                            { "CreatedByCode", userCode },
                            { "RecordStatusCode", 2 },
                            { "RecordID", groupRoleCode}
                        }
            };

            var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
            return getModel.Rows[0]["Column1"].ToString();
        }

        [HttpPost]
        [Route("~/api/Common/GetReport")]
        public HttpResponseMessage GetReport(ReportModel model)
        {
            SpData data = new SpData
            {
                SpName = "[dbo].[WebRunReportSP]",
                Parameters = new Dictionary<string, object>
                        {
                            { "MenuCode", model.MenuCode },
                            { "UserCode", model.UserCode },
                            { "CompanyCode", model.CompanyCode },
                            { "FilterData", model.FilterData },
                            { "FromDate", model.FromDate },
                            { "ToDate", model.ToDate },
                            { "CurrentEmployees", model.CurrentEmployees },
                            { "intPageIndex", model.intPageIndex },
                            { "intPageSize", model.intPageSize },
                            { "LocationCode", model.LocationCode }
                        }
            };

            var getModel = new CommonRepository(ConStr).ExecStoreProcedureForAllDataSets(data);
            if (getModel == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            return Request.CreateResponse(HttpStatusCode.OK, getModel, new JsonMediaTypeFormatter());
        }


        // Define a method 'Test' that takes a string argument and returns a modified string
        public static string MakeFirstLetterCapitalOfEveryWordInSentence(string inputString)
        {
            // Split the input string into words, capitalize the first character of each word, and join them back into a string
            return string.Join(" ", inputString.Split(' ').Select(word => char.ToUpper(word[0]) + word.Substring(1)));
        }

        [HttpPost]
        [Route("~/Api/Common/AddNewTenant")]
        public HttpResponseMessage AddNewTenant(TenantModel request)
        {
            DataTable getModel = new DataTable();
            try
            {

                var dbname = MakeFirstLetterCapitalOfEveryWordInSentence(request.ClientName.Trim());
                dbname = dbname.Replace(" ", "");

                var dbInfo1 = "data source=TeamSuiteDBserver;initial catalog=";
                var dbInfo2 = ";user id=app;password=Fast12341234;MultipleActiveResultSets=True;App=EntityFramework";
                var dbInfoFinal = dbInfo1 + dbname + dbInfo2;

                var dbInfoEnc = Encryptor.Encrypt(AppSettings.PublicKey, dbInfoFinal);

                if (!string.IsNullOrEmpty(dbInfoFinal))
                {

                    SpData data = new SpData
                    {
                        SpName = "[AppCNF].[WebTenantClientSave]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "ClientName", request.ClientName.Trim() },
                            { "DBName", dbname },
                            { "PinCode", request.PinCode },
                            { "DBConInfo",   dbInfoEnc },
                            { "RegDate", request.RegDate },
                            { "ExpiryDate", request.ExpiryDate },
                            { "CustomerCode", request.CustomerCode },
                            { "DBFrom", request.DBFrom },
                            { "EmpCode", request.EmpCode },
                            { "UserCode", request.UserCode }
                        }
                    };

                    getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                    if (getModel == null)
                    {
                        return Request.CreateResponse(HttpStatusCode.NotFound);
                    }
                    else
                    {
                        //var insertedUserID = Convert.ToInt32(getModel.Rows[0]["ID"].ToString());
                    }
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Encryption string Error!!!");
                }

                return Request.CreateResponse(HttpStatusCode.OK, getModel, formatter);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }

    }
    public class Insert_ProfileGroupDetail
    {
        public int ProfileGroupCode { get; set; }
        public int MenuCode { get; set; }
        public string SecurityRightCode { get; set; }
        public int CompanyCode { get; set; }
        public int CreatedByCode { get; set; }
        public string GroupRoleName { get; set; }
        public string Description { get; set; }
    }

    public class ChangePwdUserModel
    {
        public int UserCode { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
    public class AddUser
    {
        public long? DefaultEmpCode { get; set; }

        public int? DefaultCCorPCCode { get; set; }

        public int? DefaultProfileGroupCode { get; set; }

        public int? DefaultMenuCode { get; set; }

        public int? DefaultLocationCode { get; set; }

        public string UserName { get; set; }

        public string LoginPWD { get; set; }
        public string ResetPasswordCode { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsRequiredPWDChange { get; set; }

        public bool IsActive { get; set; }

        public bool IsSystemAdmin { get; set; }

        public bool IsSuperAdmin { get; set; }

        public string PasswordHash { get; set; }

        public string SecurityStamp { get; set; }

        public string Email { get; set; }

        public string SecondaryEmail { get; set; }

        public string SecretQuestion { get; set; }

        public string SecretAnswer { get; set; }

        public string PhoneNumber { get; set; }

        public string ImagePath { get; set; }
        public int CompanyCode { get; set; }

        public int CreatedByCode { get; set; }

        public int RecordID { get; set; }
        public string CompanyPermission { get; set; }
        public string ProfitCenterPermission { get; set; }
        public string LocationSitePermission { get; set; }
        public string ProfileGroupPermission { get; set; }
        public bool? IsRestricted { get; set; }
        public bool? IsEnforcePassChange { get; set; }
    }
    public class ReportModel
    {
        public int UserCode { get; set; }
        public int MenuCode { get; set; }
        public int CompanyCode { get; set; }
        public string FilterData { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int CurrentEmployees { get; set; }
        public int intPageIndex { get; set; }
        public int intPageSize { get; set; }
        public int LocationCode { get; set; }
    }

    public class GoogleGeoCodeResponse
    {
        public string status { get; set; }
        public results[] results { get; set; }

    }
    public class results
    {
        public string formatted_address { get; set; }
        public geometry geometry { get; set; }
        public string[] types { get; set; }
        public address_component[] address_components { get; set; }
    }

    public class geometry
    {
        public string location_type { get; set; }
        public location location { get; set; }
    }

    public class location
    {
        public string lat { get; set; }
        public string lng { get; set; }
    }
    public class address_component
    {
        public string long_name { get; set; }
        public string short_name { get; set; }
        public string[] types { get; set; }
    }

    public class TenantModel
    {
        public long ID { get; set; }
        public string ClientName { get; set; }
        public string DBName { get; set; }
        public string PinCode { get; set; }
        public DateTime RegDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public long CustomerCode { get; set; }
        public long DBFrom { get; set; }
        public long EmpCode { get; set; }
        public int UserCode { get; set; }
    }
}

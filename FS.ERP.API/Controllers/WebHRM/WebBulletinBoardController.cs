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
using System.Text;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Cors;

namespace FS.ERP.API.Controllers
{
    [Authorize]
    [EnableCors("*", "*", "*")]
    public class WebBulletinBoardController : ApiController
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


        #region Bulletin Board

        [HttpGet]
        [Route("~/Api/Bulletin/GetEditBulletinDetails")]
        public HttpResponseMessage GetEditBulletinDetails(long ID)
        {
            try
            {
                var details = GetBulletinDetailsByID(ID);
                if (details == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                { IsSuccess = true, Message = "Success", Data = details }, formatter);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }

        public List<VM_PayrollInput> GetBulletinDetailsByID(long ID)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].WebGetBulletinBoardByID",
                    Parameters = new Dictionary<string, object> { { "ID", ID } }
                };
                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<VM_PayrollInput>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("~/Api/Bulletin/SaveOrUpdateBulletin")]
        public HttpResponseMessage SaveOrUpdateBulletin(VM_Bulletin model)
        {
            try
            {
                DataTable getModel = new DataTable();

                //Check Duplicates
                var isDuplicate = CheckForDuplicates(model);

                if (isDuplicate)
                    return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                    { IsAlert = true, IsSuccess = false, Message = "Duplicate Record" }, formatter);

                getModel = SaveBulletin(model);

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
        public DataTable SaveBulletin(VM_Bulletin model)
        {
            var getModel = new DataTable();

            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].[WebCreateOrUpdateBulletin]",
                    Parameters = new Dictionary<string, object>
                        {
                            { "Employee", model.Employee },
                            { "Title", model.Title },
                            { "Content", Encoding.ASCII.GetBytes(model.Content) },
                            { "StartDate", model.StartDate },
                            { "ExpiryDate", model.ExpiryDate },
                            { "Location", model.Location },
                            { "CompanyCode", model.CompanyCode },
                            { "CreatedByCode", model.CreatedByCode },
                            { "ID", model.ID },
                            { "IsMobileApp", model.IsMobileApp },
                            { "IsSMS", model.IsSMS },
                            { "Category", model.Category },
                            { "Department", model.Department },
                            { "EmpCode", model.EmpCode }
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
        public bool CheckForDuplicates(VM_Bulletin model)
        {
            try
            {
                var isDuplicate = false;
                
                    SpData data = new SpData
                    {
                        SpName = "[HRM].[WebCheckDuplicateBulletin]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "Title", model.Title },
                            { "StartDate", model.StartDate },
                            { "ExpiryDate", model.ExpiryDate },
                            { "ID", model.ID }
                        }
                    };

                    var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                    isDuplicate = Convert.ToBoolean(getModel.Rows[0]["Duplicate"].ToString());

                    if (isDuplicate == true)
                        return isDuplicate;

                return isDuplicate;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<VM_Bulletin> getBulletinBoardNotification(int companyCode, long empCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].[ProcMobileBulletin]",
                    Parameters = new Dictionary<string, object> {
                        { "companyCode", companyCode }, { "empCode", empCode } }
                };

                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<VM_Bulletin>();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion
    }
    public class VM_Bulletin
    {
        public long ID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool? IsSMS { get; set; }
        public bool? IsMobileApp { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Location { get; set; }
        public string Department { get; set; }
        public string Employee { get; set; }
        public long? EmpCode { get; set; }
        public string Category { get; set; }
        public int CompanyCode { get; set; }
        public int CreatedByCode { get; set; }
    }
}

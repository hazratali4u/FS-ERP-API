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
    public class WebLeadController : ApiController
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
        [Route("~/Api/Lead/GetLeadDetails")]
        public HttpResponseMessage GetLeadDetails(long ID)
        {
            try
            {
                LeadModel model = new LeadModel();
                var leadData = GetLead(ID);

                if (leadData != null && leadData.Count > 0)
                {
                    model = leadData[0];
                    model.LeadActivity = GetLeadActivities(ID);
                    model.LeadTasks = GetLeadTasks(ID);
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
        public List<LeadModel> GetLead(long ID)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[CRM].GetLeadByID",
                    Parameters = new Dictionary<string, object> { { "ID", ID } }
                };
                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<LeadModel>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<LeadActivityModel> GetLeadActivities(long LeadCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[CRM].WebGetLeadActivityByLeadCode",
                    Parameters = new Dictionary<string, object> { { "LeadCode", LeadCode } }
                };
                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<LeadActivityModel>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<LeadTaskModel> GetLeadTasks(long LeadCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[CRM].WebGetLeadTaskByLeadCode",
                    Parameters = new Dictionary<string, object> { { "LeadCode", LeadCode } }
                };
                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<LeadTaskModel>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("~/Api/Lead/SaveOrUpdateLead")]
        public HttpResponseMessage SaveOrUpdateLead(LeadModel model)
        {
            try
            {
                DataTable getModel = new DataTable();

                //var isDuplicate = CheckForDuplicateForPartyCustomer(model);

                //if (isDuplicate == true)
                //{
                //    return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                //    { IsAlert = true, Message = "Duplicate Record" }, formatter);
                //}

                getModel = SaveLead(model);

                if (getModel != null && getModel.Rows.Count > 0)
                {
                   var savedID = getModel.Rows[0]["ID"].ToString();

                   var leadActivity = SaveLeadActivity(model, savedID);

                   var leadTasks = SaveLeadTask(model, savedID);
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
        public DataTable SaveLead(LeadModel model)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[CRM].[procMobileSaveLead]",
                    Parameters = new Dictionary<string, object>
                        {
                            { "LeadCode", model.ID },
                            { "ContactCode", model.ContactCode },
                            { "ContactTypeCode", model.ContactTypeCode },
                            { "StatusCode", model.StatusCode },
                            { "MemberCode", model.MemberCode },
                            { "CustomerCode", model.CustomerCode },
                            { "LeadTitle", model.Name },
                            { "SourceCode", model.SourceCode },
                            { "TeamCode", model.Visibility },
                            { "Description", model.Description },
                            { "CompanyCode", model.CompanyCode },
                            { "UserCode", model.CreatedByCode }
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
        public DataTable SaveLeadActivity(LeadModel model, string savedID)
        {
            try
            {
                var getModel = new DataTable();
                foreach (var item in model.LeadActivity)
                {
                    SpData data = new SpData
                    {
                        SpName = "[CRM].[procMobileSaveLeadActivity]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "ID", item.ID },
                            { "LeadCode", Convert.ToInt64(savedID) },
                            { "ActivityTypeCode", item.ActivityTypeCode },
                            { "Description", item.Description },
                            { "Comments", item.CommentsBy },
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

        public DataTable SaveLeadTask(LeadModel model, string savedID)
        {
            try
            {
                var getModel = new DataTable();
                foreach (var item in model.LeadTasks)
                {
                    SpData data = new SpData
                    {
                        SpName = "[CRM].[procMobileSaveLeadTask]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "ID", item.ID },
                            { "LeadCode", Convert.ToInt64(savedID) },
                            { "Name", item.Name },
                            { "NotificationTime", item.NotificationTime },
                            { "Description", item.Description },
                            { "CompanyCode", model.CompanyCode },
                            { "UserCode", model.CreatedByCode },
                            { "IsDeleted", item.IsDeleted },
                            { "IsCompleted", item.IsCompleted }
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
        //public bool CheckForDuplicateForPartyCustomer(CustomerModel model)
        //{
        //    try
        //    {
        //        var isDuplicate = false;
        //        SpData data = new SpData
        //        {
        //            SpName = "[CRM].[WebCheckDuplicateForPartyCustomer]",
        //            Parameters = new Dictionary<string, object>
        //                {
        //                    { "OfficialEmail", model.OfficialEmail != null ? model.OfficialEmail.Trim() : model.OfficialEmail },
        //                    { "ID", model.ID }
        //                }
        //        };

        //        var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
        //        isDuplicate = Convert.ToBoolean(getModel.Rows[0]["Duplicate"].ToString());

        //        if (isDuplicate == true)
        //            return isDuplicate;

        //        return isDuplicate;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
    public class LeadModel
    {
        public int ID { get; set; }
        public long ContactCode { get; set; }
        public long ContactTypeCode { get; set; }
        public long? StatusCode { get; set; }
        public long CustomerCode { get; set; }
        public long? SourceCode { get; set; }
        public string Visibility { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string MemberCode { get; set; }
        public int CompanyCode { get; set; }
        public int CreatedByCode { get; set; }
        public List<LeadActivityModel> LeadActivity { get; set; }
        public List<LeadTaskModel> LeadTasks { get; set; }
    }
    public class LeadActivityModel
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string CommentsBy { get; set; }
        public long ActivityTypeCode { get; set; }
        public string ActivityType { get; set; }
        public int LeadCode { get; set; }
        public DateTime? TimeStamp { get; set; }
        public bool IsDeleted { get; set; }
    }
    public class LeadTaskModel
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public DateTime? NotificationTime { get; set; }
        public string Description { get; set; }
        public int LeadCode { get; set; }
        public bool? IsCompleted { get; set; }
        public bool IsDeleted { get; set; }
    }
}

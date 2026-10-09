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
    public class WebTeamController : ApiController
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


        #region Team Info

        [HttpGet]
        [Route("~/Api/Team/GetTeamDetails")]
        public HttpResponseMessage GetTeamDetails(int ID)
        {
            try
            {
                var details = GetTeamDetailsByID(ID);
                if (details == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }
                else
                {
                    if (details.Count > 0)
                    details.FirstOrDefault().TeamMembers = GetTeamMemberDetails(ID);

                    return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                    { IsSuccess = true, Message = "Success", Data = details }, formatter);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }

        public List<VM_TeamInfo> GetTeamDetailsByID(long ID)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[CRM].WebGetTeamInfoByID",
                    Parameters = new Dictionary<string, object>
                    {
                        { "ID ", ID }
                    }
                };
                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<VM_TeamInfo>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<VM_TeamMember> GetTeamMemberDetails(long ID)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[CRM].WebGetTeamMembersByTeamCode",
                    Parameters = new Dictionary<string, object>
                    {
                        { "TeamInfoCode ", ID }
                    }
                };
                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<VM_TeamMember>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("~/Api/Team/SaveOrUpdateTeam")]
        public HttpResponseMessage SaveOrUpdateTeam(VM_TeamInfo model)
        {
            try
            {
                DataTable getModel = new DataTable();

                //Check Duplicates
                var isDuplicate = CheckForDuplicates(model);

                if (isDuplicate)
                    return Request.CreateResponse(HttpStatusCode.OK, new JsonData()
                    { IsSuccess = false, Message = "Duplicate Record" }, formatter);

                getModel = SaveTeam(model);

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
        public DataTable SaveTeam(VM_TeamInfo model)
        {
            var getModel = new DataTable();

            try
            {
                SpData data = new SpData
                {
                    SpName = "[AppCNF].[WebSaveTeamInfo]",
                    Parameters = new Dictionary<string, object>
                        {
                            { "Name", model.Name },
                            { "IsActive", model.IsActive },
                            { "CompanyCode", model.CompanyCode },
                            { "UserCode", model.CreatedByCode },
                            { "ID", model.ID }
                        }
                };

                getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);

                if (getModel.Rows.Count > 0)
                {
                    int savedID = int.Parse(getModel.Rows[0]["ID"].ToString());

                    foreach (var item in model.TeamMembers)
                    {
                        data = new SpData
                        {
                            SpName = "[CRM].[WebCreateOrUpdateTeamMember]",
                            Parameters = new Dictionary<string, object>
                        {
                            { "IsActive", item.IsActive },
                            { "MemberCode", item.MemberCode },
                            { "PermissionTypeCode", item.PermissionTypeCode },
                            { "RoleTypeCode", item.RoleTypeCode },
                            { "TeamInfoCode", savedID },
                            { "CompanyCode", model.CompanyCode },
                            { "CreatedByCode", model.CreatedByCode },
                            { "ID", item.ID },
                            { "Description", item.Description },
                            { "IsDeleted", item.IsDeleted }
                        }
                        };

                        getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return getModel;
        }
        public bool CheckForDuplicates(VM_TeamInfo model)
        {
            try
            {
                var isDuplicate = false;

                SpData data = new SpData
                {
                    SpName = "[CRM].[WebCheckDuplicateTeam]",
                    Parameters = new Dictionary<string, object>
                        {
                            { "Name", model.Name },
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
        #endregion

    }
    public class VM_TeamInfo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByCode { get; set; }
        public int CompanyCode { get; set; }
        public List<VM_TeamMember> TeamMembers { get; set; }
    }
    public class VM_TeamMember
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public int TeamInfoCode { get; set; }
        public bool IsActive { get; set; }
        public int MemberCode { get; set; }
        public byte? RoleTypeCode { get; set; }
        public byte? PermissionTypeCode { get; set; }
        public bool IsDeleted { get; set; }
        public string TeamName { get; set; }
        public string RoleTypeName { get; set; }
        public string PermissionTypeName { get; set; }
        public string MemberName { get; set; }
    }
}

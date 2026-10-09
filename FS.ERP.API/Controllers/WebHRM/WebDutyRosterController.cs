using CST.CCL.Helper;
using CST.CCL.Helper.Common;
using CST.CRY;
using FS.CAPI.BAL;
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
    public class WebDutyRosterController : ApiController
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
        [Route("~/Api/DutyRoster/SaveOrUpdateDutyRoster")]
        public HttpResponseMessage SaveOrUpdateDutyRoster(List<Insert_DutyRoster> roster)
        {
            try
            {
                DataTable dt = new DataTable();

                dt.Columns.Add("ID", typeof(long));
                dt.Columns.Add("ShiftCode", typeof(Int16));
                dt.Columns.Add("StartDate", typeof(DateTime));
                dt.Columns.Add("EndDate", typeof(DateTime));
                dt.Columns.Add("CompanyCode", typeof(int));
                dt.Columns.Add("CreatedByCode", typeof(int));
                dt.Columns.Add("IsDeleted", typeof(bool));

                foreach (var item in roster)
                {
                    dt.Rows.Add(item.ID, item.ShiftCode, item.StartDate, item.EndDate, item.CompanyCode, item.CreatedByCode, item.IsDeleted);
                }

                SpData data = new SpData
                {
                    SpName = "[HRM].[InsertUpdate_DutyRoster]",
                    Parameters = new Dictionary<string, object>
                        {
                            { "tblDutyRoster", dt }
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
    }
    public class Insert_DutyRoster
    {
        public long ID { get; set; }
        public Int16 ShiftCode { get; set; }
        public int CompanyCode { get; set; }
        public int CreatedByCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}

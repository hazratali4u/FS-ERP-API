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
    public class ManualAttendanceController : ApiController
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
        [Route("~/api/ManualAtendance/SaveAttendance")]
        //[CacheFilter(TimeDuration = 60)]
        public HttpResponseMessage SaveAttendance(ManualAttendanceModel attData)
        {
            try
            {
                if (attData != null && attData.Attendances != null && attData.Attendances.Count > 0)
                {
                    int count = 0;
                    SpData data = null;
                    foreach (var att in attData.Attendances)
                    {
                        data = new SpData
                        {
                            SpName = "[dbo].[WebEmployeeRequestOrManualAttendance]",
                            Parameters = new Dictionary<string, object>
                            {
                                { "ID", 0},
                                { "CompanyCode", attData.CompanyCode },
                                { "UserID", attData.UserCode },
                                { "EmpCode", attData.EmpCode },
                                { "TYPE_ID", 2 },
                                { "AttendanceDate", att.AttendanceDate },
                                { "AttTimeIn", att.AttendanceTimeIn },
                                { "AttTimeOut", att.AttendanceTimeOut },
                                {"OutDuty", attData.OutDuty }
                            }
                        };

                        var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                        if (getModel != null && getModel.Rows.Count > 0)
                        {
                            count++;
                        }
                    }

                    var msglist = new List<CustomMsg>();

                    if (count == attData.Attendances.Count)
                    {
                        msglist.Add(new CustomMsg
                        {
                            TotalRows = count,
                            Msg = "Saved successfully"
                        });
                    }
                    else
                    {
                        msglist.Add(new CustomMsg
                        {
                            TotalRows = count,
                            Msg = "Saved some of records successfully"
                        });
                    }

                    return Request.CreateResponse(HttpStatusCode.OK, msglist, new JsonMediaTypeFormatter());

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
        [Route("~/api/ManualAtendance/ImportAttendance")]
        //[CacheFilter(TimeDuration = 60)]
        public HttpResponseMessage ImportAttendance(ImportAttendanceModel attData)
        {
            try
            {
                if (attData != null && attData.Attendances != null && attData.Attendances.Count > 0)
                {
                    SpData data = null;
                    int typeid = 2; // it means it will save like Manual Attendance of single employee - here it will be for multiple employees and can be for different days in excel file

                    if (attData.MachineFileOrExcelFile) 
                    {
                        typeid = 3; // it means its excel file is coming from machine export software - here EmpCode will be Machine ID from this machine excel file
                    }
                    int count = 0;
                    foreach (var att in attData.Attendances)
                    {

                        data = new SpData
                        {
                            SpName = "[dbo].[WebEmployeeRequestOrManualAttendance]",
                            Parameters = new Dictionary<string, object>
                            {
                                { "ID", 0},
                                { "CompanyCode", attData.CompanyCode },
                                { "UserID", attData.UserCode },
                                { "EmpCode", att.EmpCode },
                                { "TYPE_ID", typeid },
                                { "AttendanceDate", att.AttendanceDate },
                                { "AttTimeIn", att.AttendanceTimeIn },
                                { "AttTimeOut", att.AttendanceTimeOut },
                                { "CodeOrID" , "Code" }
                            }
                        };

                        var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                        if (getModel != null && getModel.Rows.Count > 0)
                        {
                            count++;
                        }
                        
                    }

                    var msglist = new List<CustomMsg>();

                    if (count == attData.Attendances.Count)
                    {
                        msglist.Add(new CustomMsg
                        {
                            TotalRows = count,
                            Msg = "Saved successfully"
                        });
                    }
                    else
                    {
                        msglist.Add(new CustomMsg
                        {
                            TotalRows = count,
                            Msg = "Saved some of records successfully"
                        });
                    }
                    
                    return Request.CreateResponse(HttpStatusCode.OK, msglist, new JsonMediaTypeFormatter());
                }

                return Request.CreateResponse(HttpStatusCode.InternalServerError, new JsonMediaTypeFormatter());
            }
            catch (Exception ex)
            {
                //LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetUserMenu", "tbl_Menu", "dbo.ProcGetUserMenu", ex, false, false);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, new JsonMediaTypeFormatter());
            }
        }
    }

    public class ManualAttendanceModel
    {
        public long EmpCode { get; set; }
        public int CompanyCode { get; set; }
        public int UserCode { get; set; }
        public bool OutDuty { get; set; }
        //public int TypeId { get; set; }
        public List<AttendanceInOut> Attendances { get; set; }
        //public ManualAttendanceModel()
        //{
        //    this.Attendances = new List<AttendanceInOut>()
        //    {
        //        new AttendanceInOut
        //        {
        //            AttendanceDate = DateTime.Now.Date,
        //            AttendanceTimeIn= DateTime.Now,
        //            AttendanceTimeOut = DateTime.Now

        //        },
        //    new AttendanceInOut
        //    {
        //        AttendanceDate = DateTime.Now.Date,
        //        AttendanceTimeIn = DateTime.Now,
        //        AttendanceTimeOut = DateTime.Now

        //    }
        //};
        //}
    }
    public class AttendanceInOut
    {
        public DateTime AttendanceDate { get; set; }
        public DateTime? AttendanceTimeIn { get; set; }
        public DateTime? AttendanceTimeOut { get; set; }
    }

    public class ImportAttendanceModel
    {
        public bool MachineFileOrExcelFile { get; set; }
        public int CompanyCode { get; set; }
        public int UserCode { get; set; }
        //public int TypeId { get; set; }
        public List<ImportAttendanceInOut> Attendances { get; set; }
        //public ImportAttendanceModel()
        //{
        //    this.MachineFileOrExcelFile = true;
        //    this.CompanyCode = 17;
        //    this.UserCode = 1;

        //    this.Attendances = new List<ImportAttendanceInOut>()
        //    {
        //        new ImportAttendanceInOut
        //        {
        //            EmpCode = 1,
        //            AttendanceDate = DateTime.Now.Date,
        //            AttendanceTimeIn= null,
        //            AttendanceTimeOut = DateTime.Now

        //        },
        //    new ImportAttendanceInOut
        //    {
        //        EmpCode = 2,
        //        AttendanceDate = DateTime.Now.Date,
        //        AttendanceTimeIn = DateTime.Now,
        //        AttendanceTimeOut = null

        //    }
        //};
        //}
    }
    public class ImportAttendanceInOut
    {
        public long EmpCode { get; set; }
        public DateTime AttendanceDate { get; set; }
        public DateTime? AttendanceTimeIn { get; set; }
        public DateTime? AttendanceTimeOut { get; set; }
    }
}

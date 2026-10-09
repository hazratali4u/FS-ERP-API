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
    public class WebShiftController : ApiController
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
        [Route("~/Api/HRM/AddOrUpdateShift")]
        public HttpResponseMessage AddOrUpdateShift(ShiftViewModel model)
        {
            try
            {
                DataTable getModel = new DataTable();

                getModel = SaveShift(model.Shift);
                var savedID = getModel.Rows[0]["ID"].ToString();

                if (!string.IsNullOrEmpty(savedID))
                {
                    if (model.ShiftDays != null && model.ShiftDays.Count > 0)
                    {
                        SaveShiftDays(model.ShiftDays, Convert.ToInt16(savedID));

                        SaveOvertimeCriteria(model.OvertimeCriteria, Convert.ToInt16(savedID));
                    }
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, savedID);
                }

                return Request.CreateResponse(HttpStatusCode.OK, getModel, formatter);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex, formatter);
            }
        }
        [HttpGet]
        [Route("~/Api/HRM/GetShiftDetails")]
        public HttpResponseMessage GetShiftDetails(int shiftCode)
        {
            try
            {
                ShiftViewModel model = new ShiftViewModel();
                DataTable getModel = new DataTable();

                var shiftData = GetShift(shiftCode);

                if (shiftData != null && shiftData.Count > 0)
                {
                    model.Shift = shiftData[0];
                    model.ShiftDays = GetShiftDays(shiftCode);
                    model.OvertimeCriteria = GetShiftOvertimeCriteria(shiftCode);
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
        public List<Shift> GetShift(int shiftCode)
        {
            try
            {
                SpData data = new SpData { SpName = "[HRM].GetShiftByID",
                    Parameters = new Dictionary<string, object> { { "shiftCode", shiftCode } } };
                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<Shift>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ShiftDay> GetShiftDays(int shiftCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].GetShiftDaysByShiftCode",
                    Parameters = new Dictionary<string, object> { { "shiftCode", shiftCode } }
                };
                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<ShiftDay>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ShiftOvertimeCriteria> GetShiftOvertimeCriteria(int shiftCode)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].GetShiftOvertimeCriteriaByShiftCode",
                    Parameters = new Dictionary<string, object> { { "shiftCode", shiftCode } }
                };
                return new CommonRepository(ConStr).ExecStoreProcedure(data).DataTableToList<ShiftOvertimeCriteria>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable SaveShift(Shift shift)
        {
            try
            {
                SpData data = new SpData
                {
                    SpName = "[HRM].[CreateOrUpdateShift]",
                    Parameters = new Dictionary<string, object>
                        {
                            { "ID", shift.ID },
                            { "ShiftName", shift.ShiftName },
                            { "DisplayName", shift.ShiftName },
                            { "ShiftCode", shift.ShiftCode },
                            { "ShiftStartTime", shift.ShiftStartTime },
                            { "ShiftEndTime", shift.ShiftEndTime },
                            { "ShiftInMinutes", shift.ShiftInMinutes },
                            { "OffDay1", shift.OffDay1 },
                            { "IsAlternateOffDay2", shift.IsAlternateOffDay2 },
                            { "OffDay2", shift.OffDay2 },
                            { "IsNightShift", shift.IsNightShift },
                            { "IsTemporaryShift", shift.IsTemporaryShift },
                            { "TempShiftStartDate", shift.TempShiftStartDate },
                            { "TempShiftEndDate", shift.TempShiftEndDate },
                            { "ShiftPreGraceStart", shift.ShiftPreGraceStart },
                            { "ShiftPostGraceStart", shift.ShiftPostGraceStart },
                            { "ShiftPreGraceEnd", shift.ShiftPreGraceEnd },
                            { "ShiftPostGraceEnd", shift.ShiftPostGraceEnd },
                            { "MaxLateInAllowedPerMonth", shift.MaxLateInAllowedPerMonth },
                            { "MaxEarlyLeftAllowedPerMonth", shift.MaxEarlyLeftAllowedPerMonth },
                            { "MarkLateTimeIn", shift.MarkLateTimeIn },
                            { "CompanyCode", shift.CompanyCode },
                            { "CreatedByCode", shift.CreatedByCode },
                            { "MarkEarlyTimeOut", shift.MarkEarlyTimeOut },
                            { "MarkHalfDayTimeIn", shift.MarkHalfDayTimeIn },
                            { "MarkHalfDayTimeOut", shift.MarkHalfDayTimeOut },
                            { "MarkAbsentTimeIn", shift.MarkAbsentTimeIn },
                            { "MarkAbsentTimeOut", shift.MarkAbsentTimeOut },
                            { "MarkEarlyOutWHLess", shift.MarkEarlyOutWHLess },
                            { "MarkHalfDayWHLess", shift.MarkHalfDayWHLess },
                            { "MarkHalfDayBHGreater", shift.MarkHalfDayBHGreater },
                            { "MarkAbsentWHLess", shift.MarkAbsentWHLess },
                            { "MarkAbsentBHGreater", shift.MarkAbsentBHGreater },
                            { "CalculateWHEmployeeTimeIn", shift.CalculateWHEmployeeTimeIn },
                            { "DeductBreakHoursfromWH", shift.DeductBreakHoursfromWH },
                            { "DeductBreakHoursfromOT", shift.DeductBreakHoursfromOT },
                            { "ShiftDescription", shift.ShiftDescription },
                            { "IsRestDaysAllowed", shift.IsRestDaysAllowed },
                            { "TotalPaidRestDays", shift.TotalPaidRestDays },
                            { "OTRatio", shift.OTRatio },
                            { "OTAmount", shift.OTAmount },
                            { "OTThresholdInMinutes", shift.OTThresholdInMinutes },
                            { "CanbeStartedAnytime", shift.CanbeStartedAnytime },
                            { "CheckInOutMissingFullDay", shift.CheckInOutMissingFullDay },
                            { "IsOvertimeEnabled", shift.IsOvertimeEnabled },
                            { "CalculateShortHours", shift.CalculateShortHours },
                            { "IsAttendanceNotNecessary", shift.IsAttendanceNotNecessary }

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
        public void SaveShiftDays(List<ShiftDay> days, short shiftCode)
        {
            try
            {

                SpData data = new SpData
                {
                    SpName = "[HRM].[ProcRemoveShiftDays]",
                    Parameters = new Dictionary<string, object>
                    {
                        { "ShiftCode", shiftCode }
                    }
                };

                var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);

                foreach (var item in days)
                {
                    data = new SpData
                    {
                        SpName = "[HRM].[CreateOrUpdateShiftDays]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "ShiftCode", shiftCode },
                            { "DayName", item.DayName },
                            { "MidShift", item.MidShift },
                            { "ShiftStartTime", item.ShiftStartTime },
                            { "ShiftEndTime", item.ShiftEndTime },
                            { "ShiftInMinutes", item.ShiftInMinutes },
                            { "IsBreakType", item.IsBreakType },
                            { "BreakHours", item.BreakHours },
                            { "BreakStart1", item.BreakStart1 },
                            { "BreakEnd1", item.BreakEnd1 },
                            { "BreakStart2", item.BreakStart2 },
                            { "BreakEnd2", item.BreakEnd2 },
                            { "CompanyCode", item.CompanyCode },
                            { "CreatedByCode", item.CreatedByCode },
                            { "ID", 0 } //always create new
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

        public void SaveOvertimeCriteria(List<ShiftOvertimeCriteria> overtimeList, short shiftCode)
        {
            try
            {
                foreach (var overtime in overtimeList)
                {
                    SpData data = new SpData
                    {
                        SpName = "[HRM].[CreateOrUpdateOvertimeCriteria]",
                        Parameters = new Dictionary<string, object>
                        {
                            { "ShiftCode", shiftCode },
                            { "DayTypeCode", overtime.DayTypeCode },
                            { "EligibleOTTimeOutAfter", overtime.EligibleOTTimeOutAfter },
                            { "EligibleOTTimeInBefore", overtime.EligibleOTTimeInBefore },
                            { "EligibleOTTimeOutAfterWH", overtime.EligibleOTTimeOutAfterWH },
                            { "EligibleOTTimeInBeforeWH", overtime.EligibleOTTimeInBeforeWH },
                            { "OTNotApplicable", overtime.OTNotApplicable },
                            { "OTAutoApproval", overtime.OTAutoApproval },
                            { "IsOnTimeCalculateOT", overtime.IsOnTimeCalculateOT },
                            { "IsLateInCalculateOT", overtime.IsLateInCalculateOT },
                            { "IsEarlyOutCalculateOT", overtime.IsEarlyOutCalculateOT },
                            { "IsHalfDayCalculateOT", overtime.IsHalfDayCalculateOT },
                            { "IsTimeInCalculateOT", overtime.IsTimeInCalculateOT },
                            { "EntitledOTPolicyTOAfter", overtime.EntitledOTPolicyTOAfter },
                            { "EntitledOTPolicyWHGreater", overtime.EntitledOTPolicyWHGreater },
                            { "OverTimeDescription", overtime.OverTimeDescription },
                            { "CompanyCode", overtime.CompanyCode },
                            { "CreatedByCode", overtime.CreatedByCode },
                            { "ID", overtime.ID }
                        }
                    };

                    var getModel = new CommonRepository(ConStr).ExecStoreProcedure(data);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    public class ShiftViewModel
    {
        public Shift Shift { get; set; }
        public List<ShiftDay> ShiftDays { get; set; }
        public List<ShiftOvertimeCriteria> OvertimeCriteria { get; set; }
    }
    public class Shift
    {
        public short ID { get; set; }
        public string ShiftName { get; set; }
        public string ShiftCode { get; set; }
        public TimeSpan ShiftStartTime { get; set; }
        public TimeSpan ShiftEndTime { get; set; }
        public decimal? ShiftInMinutes { get; set; }
        public decimal? TotalPaidRestDays { get; set; }
        public decimal? OTRatio { get; set; }
        public decimal? OTAmount { get; set; }
        public decimal? OTThresholdInMinutes { get; set; }
        public string OffDay1 { get; set; }
        public bool? IsAlternateOffDay2 { get; set; }
        public string OffDay2 { get; set; }
        public bool IsNightShift { get; set; }
        public bool IsTemporaryShift { get; set; }
        public DateTime? TempShiftStartDate { get; set; }
        public DateTime? TempShiftEndDate { get; set; }
        public TimeSpan? ShiftPreGraceStart { get; set; }
        public TimeSpan? ShiftPostGraceStart { get; set; }
        public TimeSpan? ShiftPreGraceEnd { get; set; }
        public TimeSpan? ShiftPostGraceEnd { get; set; }
        public byte? MaxLateInAllowedPerMonth { get; set; }
        public byte? MaxEarlyLeftAllowedPerMonth { get; set; }
        public TimeSpan MarkLateTimeIn { get; set; }
        public TimeSpan MarkEarlyTimeOut { get; set; }
        public TimeSpan MarkHalfDayTimeIn { get; set; }
        public TimeSpan MarkHalfDayTimeOut { get; set; }
        public TimeSpan MarkAbsentTimeIn { get; set; }
        public TimeSpan MarkAbsentTimeOut { get; set; }
        public TimeSpan MarkEarlyOutWHLess { get; set; }
        public TimeSpan MarkHalfDayWHLess { get; set; }
        public TimeSpan MarkHalfDayBHGreater { get; set; }
        public TimeSpan MarkAbsentWHLess { get; set; }
        public TimeSpan MarkAbsentBHGreater { get; set; }
        public bool? CanbeStartedAnytime { get; set; }
        public bool? CheckInOutMissingFullDay { get; set; }
        public bool CalculateWHEmployeeTimeIn { get; set; }
        public bool DeductBreakHoursfromWH { get; set; }
        public bool DeductBreakHoursfromOT { get; set; }
        public bool? IsRestDaysAllowed { get; set; }
        public string ShiftDescription { get; set; }
        public bool? IsOvertimeEnabled { get; set; }
        public bool CalculateShortHours { get; set; }
        public bool? IsAttendanceNotNecessary { get; set; }
        public int CompanyCode { get; set; }
        public int CreatedByCode { get; set; }
    }
    public class ShiftDay
    {
        public int ID { get; set; }
        public short ShiftCode { get; set; }
        public string DayName { get; set; }
        public TimeSpan? MidShift { get; set; }
        public bool? IsBreakType { get; set; }
        public decimal? BreakHours { get; set; }
        public TimeSpan? BreakStart1 { get; set; }
        public TimeSpan? BreakEnd1 { get; set; }
        public TimeSpan? BreakStart2 { get; set; }
        public TimeSpan? BreakEnd2 { get; set; }
        public TimeSpan? BreakStart3 { get; set; }
        public TimeSpan? BreakEnd3 { get; set; }
        public TimeSpan? BreakStart4 { get; set; }
        public TimeSpan? BreakEnd4 { get; set; }
        public int CompanyCode { get; set; }
        public int CreatedByCode { get; set; }
        public TimeSpan? ShiftStartTime { get; set; }
        public TimeSpan? ShiftEndTime { get; set; }
        public decimal? ShiftInMinutes { get; set; }
    }
    public class ShiftOvertimeCriteria
    {
        public long ID { get; set; }
        public short ShiftCode { get; set; }
        public byte DayTypeCode { get; set; }
        public TimeSpan EligibleOTTimeOutAfter { get; set; }
        public TimeSpan EligibleOTTimeInBefore { get; set; }
        public TimeSpan EligibleOTTimeOutAfterWH { get; set; }
        public TimeSpan EligibleOTTimeInBeforeWH { get; set; }
        public TimeSpan OTNotApplicable { get; set; }
        public TimeSpan OTAutoApproval { get; set; }
        public bool? IsOnTimeCalculateOT { get; set; }
        public bool? IsLateInCalculateOT { get; set; }
        public bool? IsEarlyOutCalculateOT { get; set; }
        public bool? IsHalfDayCalculateOT { get; set; }
        public bool? IsTimeInCalculateOT { get; set; }
        public TimeSpan? EntitledOTPolicyTOAfter { get; set; }
        public TimeSpan? EntitledOTPolicyWHGreater { get; set; }
        public string OverTimeDescription { get; set; }
        public int CompanyCode { get; set; }
        public int CreatedByCode { get; set; }
    }
}

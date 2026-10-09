using CST.CCL.Helper.Common;
using FS.DAL.HRM.AttendanceManagement;
using System;
using System.Collections.Generic;
using FS.ERP.Models.BO;

namespace FS.CAPI.BAL.HRM.AttendanceManagement
{
    public class EmployeeAttendanceRepository :CAPIBaseRepo
    {
        public EmployeeAttendanceRepository(string conStr) : base(conStr)
        {
            
        }
        public List<BOEmployeeInfo> GetEmployees(string procedureName, List<ParameterList> lpm)
        {
            try
            {
                return new EmployeeAttendanceProvider(ConStr).GetEmployees(procedureName, lpm);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<BOOrganizationCompany> GetProfitCenters(string procedureName, List<ParameterList> lpm)
        {
            try
            {
                return new EmployeeAttendanceProvider(ConStr).GetProfitCenters(procedureName, lpm);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }


}

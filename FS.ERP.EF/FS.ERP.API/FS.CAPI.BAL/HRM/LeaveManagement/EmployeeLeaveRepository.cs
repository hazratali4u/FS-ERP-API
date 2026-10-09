using CST.CCL.Helper.Common;
using FS.DAL.HRM.LeaveManagement;
using System;
using System.Collections.Generic;

namespace FS.CAPI.BAL.HRM.LeaveManagement
{
    public class EmployeeLeaveRepository : CAPIBaseRepo
    {
        public EmployeeLeaveRepository(string conStr) : base(conStr)
        {
            
        }
        public bool IsHR(List<ParameterList> lpm)
        {
            try
            {
                return new EmployeeLeaveProvider(ConStr).IsHR(lpm);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

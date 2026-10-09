using System;
using System.Collections.Generic;
using System.Data;
using CST.CCL.Helper.Common;
using FS.DAL.HRM;

namespace FS.CAPI.BAL.HRM
{
    public class EmployeeInfoRepositiry : CAPIBaseRepo
    {
        public EmployeeInfoRepositiry(string conStr) : base(conStr)
        {
            
        }
        public DataTable GetCompleteEmployeeInfo(int empId)
        {
            try
            {
                DataTable data = new EmployeeInfoProvider(ConStr).GetCompleteEmployeeInfo(empId);
                return data;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataSet GetEmployeeDDLs(int companyCode)
        {
            try
            {
                DataSet data = new EmployeeInfoProvider(ConStr).GetEmployeeDDLs(companyCode);
                return data;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

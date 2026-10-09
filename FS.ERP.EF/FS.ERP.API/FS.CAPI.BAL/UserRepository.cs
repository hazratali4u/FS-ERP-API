using System;
using System.Collections.Generic;
using System.Data;
using CST.CCL.Helper.Common;
using FS.DAL.MenuCNF;
using FS.DAL.UMS;
using FS.ERP.Models.BO;

namespace FS.CAPI.BAL
{
    public class UserRepository :CAPIBaseRepo
    {
        public UserRepository(string conStr) : base(conStr)
        {
            
        }
        public DataTable GetLocation(string loginName)
        {
            DataTable dt = new DataTable();
            try
            {
                List<ParameterList> lpm = new List<ParameterList>();
                lpm.Add(new ParameterList("LoginName", loginName));
                dt = new UserProvider(ConStr).GetLocation(lpm);
            }
            catch (Exception ex)
            {
                //LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetLocation", "tblUser", "dbo.ProcGetLocationSite", ex, false, false);
            }
            return dt;
        }

        public List<BOSecurityRight> GetToolBarRights(int userCode, int companyCode, int menuCode)
        {
            List<BOSecurityRight> lst = null;
            try
            {
                List<ParameterList> lpm = new List<ParameterList>();
                lpm.Add(new ParameterList("UserCode", userCode));
                lpm.Add(new ParameterList("CompanyCode", companyCode));
                lpm.Add(new ParameterList("MenuCode", menuCode));
                lst = new SecurityRightProvider(ConStr).GetAll(lpm);

            }
            catch (Exception ex)
            {

            }
            return lst;
        }

        public DataTable GetUserPermissionDataSet(string queryName, int userCode)
        {
            try
            {
                List<ParameterList> lpm = new List<ParameterList>();
                lpm.Add(new ParameterList("returnType", queryName));
                lpm.Add(new ParameterList("UserCode", userCode));

                return new UserProvider(ConStr).GetAllByUserCode(lpm);
            }
            catch (Exception ex)
            {
                //LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetLocation", "tblUser", "dbo.ProcGetLocationSite", ex, false, false);
            }
            return null;
        }
    }
}

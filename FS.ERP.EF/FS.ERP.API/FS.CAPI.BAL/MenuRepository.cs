using System;
using System.Collections.Generic;
using System.Data;
using CST.CCL.Helper.Common;
using FS.DAL.Common;
using FS.ERP.Models.BO;

namespace FS.CAPI.BAL
{
    public class MenuRepository : CAPIBaseRepo
    {
        public MenuRepository(string conStr) : base(conStr)
        {
            
        }
        public DataTable GetUserMenu(int userCode, int companyCode)
        {
            DataTable dt = new DataTable();
            try
            {
                List<ParameterList> lpm = new List<ParameterList>();
                lpm.Add(new ParameterList("UserCode", userCode));
                lpm.Add(new ParameterList("CompanyCode", companyCode));
                dt = new MenuProvider(ConStr).GetUserMenu(lpm);
            }
            catch (Exception ex)
            {
                //LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetUserMenu", "tbl_Menu", "dbo.ProcGetUserMenu", ex, false, false);
            }
            return dt;
        }

        public List<BOMenu> GetChildMenus(int menuCode)
        {
            List<BOMenu> menus = new List<BOMenu>();
            try
            {
                List<ParameterList> lpm = new List<ParameterList>();
                lpm.Add(new ParameterList("menuCode", menuCode));
                menus = new MenuProvider(ConStr).GetChildMenus(lpm).DataTableToList<BOMenu>();
            }
            catch (Exception ex)
            {
                //LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetUserMenu", "tbl_Menu", "dbo.ProcGetUserMenu", ex, false, false);
            }
            return menus;
        }

        public DataTable GetUserReportMenu(int userCode, int companyCode)
        {
            DataTable dt = new DataTable();
            try
            {
                List<ParameterList> lpm = new List<ParameterList>();
                lpm.Add(new ParameterList("UserCode", userCode));
                lpm.Add(new ParameterList("CompanyCode", companyCode));
                dt = new MenuProvider(ConStr).GetUserReportMenu(lpm);
            }
            catch (Exception ex)
            {
                //LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetUserMenu", "tbl_Menu", "dbo.ProcGetUserMenu", ex, false, false);
            }
            return dt;
        }
    }
}

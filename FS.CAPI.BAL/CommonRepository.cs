using System;
using System.Collections.Generic;
using System.Data;
using CST.CCL.Helper.Common;
using FS.DAL.Common;
using FS.ERP.Models.Custom;

namespace FS.CAPI.BAL
{
    public class CommonRepository :CAPIBaseRepo
    {
        public CommonRepository(string conStr) : base(conStr)
        {
            
        }
        public DataTable RunQuery(string query)
        {
            try
            {
                return new CommonProvider(ConStr).GetFilterData(query);
            }
            catch (Exception ex)
            {
                //LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetUserMenu", "tbl_Menu", "dbo.ProcGetUserMenu", ex, false, false);
            }
            return null;
        }

        public bool RunSimpleQuery(string query)
        {
            try
            {
                return new CommonProvider(ConStr).RunSimpleQuery(query);
            }
            catch (Exception ex)
            {
                //LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetUserMenu", "tbl_Menu", "dbo.ProcGetUserMenu", ex, false, false);
            }
            return false;
        }

        public DataSet GetLookUpDataSet(string procedureName, List<ParameterList> lpm)
        {
            try
            {
                return new MenuProvider(ConStr).GetLookUpDatSet(procedureName, lpm);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable GetCodeValue(string strReturnType, string strTableName, string strColName, string strWhere, string strCompositeKey, string strCompositeValue)
        {
            try
            {
                DataTable dt = new DataTable();
                List<ParameterList> lpm = new List<ParameterList>();
                lpm.Add(new ParameterList("strReturnType", strReturnType));
                lpm.Add(new ParameterList("strTableName", strTableName));
                lpm.Add(new ParameterList("strColName", strColName));
                lpm.Add(new ParameterList("strWhere", strWhere));
                lpm.Add(new ParameterList("strCompositeKeyColumns", strCompositeKey));
                lpm.Add(new ParameterList("strCompositeValue", strCompositeValue));
                
                dt = new CommonProvider(ConStr).GetCodeValue(lpm);
                return dt;
            }
            catch (Exception ex)
            {
                //LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetLocation", "tblUser", "dbo.ProcGetLocationSite", ex, false, false);
                return null;
            }
        }

        public DataTable ExecStoreProcedure(SpData data)
        {
            try
            {
                return new CommonProvider(ConStr).ExecStoreProcedure(data);
            }
            catch (Exception ex)
            {
                //LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetLocation", "tblUser", "dbo.ProcGetLocationSite", ex, false, false);
                throw;
            }
        }
        public DataSet ExecStoreProcedureForAllDataSets(SpData data)
        {
            try
            {
                return new CommonProvider(ConStr).ExecStoreProcedureForAllDataSets(data);
            }
            catch (Exception ex)
            {
                //LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetLocation", "tblUser", "dbo.ProcGetLocationSite", ex, false, false);
                throw;
            }
        }

        public DataTable GetDataWithJoin(string entityName, string whereClause)
        {
            try
            {
                DataTable dt = new DataTable();
                List<ParameterList> lpm = new List<ParameterList>();
                lpm.Add(new ParameterList("tableName", entityName));
                lpm.Add(new ParameterList("where", whereClause));

                dt = new CommonProvider(ConStr).GetDataWithJoin(lpm);
                return dt;
            }
            catch (Exception ex)
            {
                //LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetLocation", "tblUser", "dbo.ProcGetLocationSite", ex, false, false);
                return null;
            }
        }

        public List<FsToolBar> GetToolBar(object id, object menuId)
        {
            try
            {
                List<ParameterList> lpm = new List<ParameterList>();
                lpm.Add(new ParameterList("intCode", id));
                lpm.Add(new ParameterList("intMenuID", menuId));
                return new CommonProvider(ConStr).GetAllToolBar(lpm);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public FsToolBar GetToolBarById(object Id)
        {
            List<FsToolBar> lst = null;
            try
            {
                List<ParameterList> lpm = new List<ParameterList>();
                lpm.Add(new ParameterList("intCode", Id));
                lst = new CommonProvider(ConStr).GetAllToolBar(lpm);

            }
            catch (Exception)
            {

                throw;
            }
            return lst[0];
        }

        public List<FsToolBar> GetToolbar()
        {
            try
            {
                return new CommonProvider(ConStr).GetAllToolBar();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<IsValidateForDeleteResponse> IsValidateForDelete(IsValidateForDelete modal)
        {
            try
            {
                List<ParameterList> lpm = new List<ParameterList>
                {
                    new ParameterList("IntMenuCode", modal.IntMenuCode),
                    new ParameterList("strPKCode", modal.StrPkCode),
                    new ParameterList("IntPKValue", modal.IntPkValue),
                    new ParameterList("IsExcludeDeleted", modal.IsExcludeDeleted),
                    new ParameterList("strWhereClause", modal.StrWhereClause)
                };

                return new CommonProvider(ConStr).IsValidateForDelete(lpm);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string SoftDelete(int id, string tableName)
        {
            try
            {
                List<ParameterList> lpm = new List<ParameterList>
                {
                    new ParameterList("ID", id),
                    new ParameterList("TableName", tableName)
                };
                return new CommonProvider(ConStr).SoftDelete(lpm);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using FS.DAL.Common;

namespace FS.DAL.HRM
{
    public class EmployeeInfoProvider : BaseProvider
    {
        public EmployeeInfoProvider(string conStr) : base(conStr)
        {
            
        }
        public DataTable GetCompleteEmployeeInfo(int empId)
        {
            SqlConnection con = null;
            try
            {
                using (con = Connection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "HRM.procGetCompleteEmployeeInfo";
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@empId", empId);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    return ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                // LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetLocation", "tblUser", "dbo.ProcGetLocationSite", ex, false, false);
                return null;
            }
            finally
            {
                if (con != null && con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
        }
    }
}

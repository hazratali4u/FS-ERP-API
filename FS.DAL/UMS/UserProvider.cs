using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CST.CCL.Helper.Common;
using FS.DAL.Common;

namespace FS.DAL.UMS
{
    public class UserProvider : BaseProvider
    {
        public UserProvider(string conStr) : base(conStr)
        {
            
        }

        public DataTable GetLocation(List<ParameterList> lpm = null)
        {
            SqlConnection con = null;
            try
            {
                using (con = Connection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.ProcGetLocationSite";
                    cmd.Connection = con;
                    if (lpm != null && lpm.Count > 0)
                    {
                        foreach (var item in lpm)
                            cmd.Parameters.AddWithValue("@" + item.Parameter, item.Value);
                    }
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

        public DataTable GetAllByUserCode(List<ParameterList> lpm = null)
        {
            DataSet ds = null;
            try
            {
                SqlConnection con = null;
                using (con = Connection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[dbo].[ProcGetDataByUserCode]";
                    cmd.Connection = con;
                    if (lpm != null && lpm.Count > 0)
                    {
                        foreach (var item in lpm)
                            cmd.Parameters.AddWithValue("@" + item.Parameter, item.Value);
                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                   // SqlDataReader dr = cmd.ExecuteReader();
                    ds = new DataSet();
                    da.Fill(ds);
                    con.Close();
                    da.Dispose();  
                }
            }
            catch (Exception ex)
            {
                //LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetAll", "tblUser", "dbo.ProcValidateLogin", ex, false, false);
            }
            return ds.Tables[0];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CST.CCL.Helper.Common;
using FS.ERP.Models.Custom;

namespace FS.DAL.Common
{
    public class CommonProvider : BaseProvider
    {
        public CommonProvider(string conStr) : base(conStr)
        {
            
        }
        public DataTable GetFilterData(string strQuery)
        {
            DataTable dt = null;

            try
            {
                SqlConnection con = null;
                using (con = Connection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = strQuery;

                    cmd.Connection = con;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    // this will query your database and return the result to your datatable
                    da.Fill(dt);
                    con.Close();
                    da.Dispose();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        public bool RunSimpleQuery(string strQuery)
        {
            try
            {
                SqlConnection con = null;
                using (con = Connection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = strQuery;

                    cmd.Connection = con;

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
            return false;
        }

        public List<FsToolBar> GetAllToolBar(List<ParameterList> lpm = null)
        {
            List<FsToolBar> lst = null;
            try
            {
                SqlConnection con = null;
                using (con = Connection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.procGetToolBar";
                    cmd.Connection = con;
                    if (lpm != null && lpm.Count > 0)
                    {
                        foreach (var item in lpm)
                            cmd.Parameters.AddWithValue("@" + item.Parameter, item.Value);
                    }
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        lst = new List<FsToolBar>();
                        while (dr.Read())
                        {
                            FsToolBar obj = new FsToolBar();
                            obj.intCode = Convert.ToInt32(dr["intCode"]);
                            obj.strName = Convert.ToString(dr["strName"]);
                            obj.strType = Convert.ToString(dr["strType"]);
                            obj.strImageURL = Convert.ToString(dr["strImageURL"]);
                            lst.Add(obj);
                        }
                        lst.TrimExcess();
                    }
                    dr.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return lst;
        }

        public DataTable ExecStoreProcedure(SpData data)
        {
            try
            {
                SqlConnection con = null;
                using (con = Connection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = data.SpName;
                    cmd.Connection = con;
                    if (!data.Parameters.IsNullOrEmpty())
                    {
                        foreach (var item in data.Parameters)
                            cmd.Parameters.AddWithValue("@" + item.Key, item.Value);
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    return ds.Tables[0];
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string SoftDelete(List<ParameterList> lpm = null)
        {

            try
            {
                SqlConnection con = null;
                using (con = Connection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "[dbo].[procSoftDelete]";
                    if (lpm != null && lpm.Count > 0)
                    {
                        foreach (var item in lpm)
                        {
                            cmd.Parameters.AddWithValue("@" + item.Parameter, item.Value);
                        }
                    }
                    cmd.Connection = con;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {


                    }

                    dr.Close();
                }
            }

            catch (Exception)
            {
                throw;
            }
            return "Deleted";
        }

        public List<IsValidateForDeleteResponse> IsValidateForDelete(List<ParameterList> lpm = null)
        {
            List<IsValidateForDeleteResponse> lst = null;
            try
            {
                SqlConnection con = null;
                using (con = Connection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "[dbo].[procIsValidateForDelete]";
                    if (lpm != null && lpm.Count > 0)
                    {
                        foreach (var item in lpm)
                        {
                            cmd.Parameters.AddWithValue("@" + item.Parameter, item.Value);
                        }
                    }
                    cmd.Connection = con;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        lst = new List<IsValidateForDeleteResponse>();

                        while (dr.Read())
                        {
                            IsValidateForDeleteResponse obj = new IsValidateForDeleteResponse();
                            if (dr["ERROR"] != DBNull.Value)
                                obj.Error = Convert.ToString(dr["ERROR"]);
                            obj.IsValid = Convert.ToBoolean(dr["ISVALID"]);
                            lst.Add(obj);
                        }
                        lst.TrimExcess();
                    }
                    dr.Close();
                }

            }
            catch (Exception)
            {
                throw;
                return null;
            }
            return lst;
        }

        public DataTable GetCodeValue(List<ParameterList> lpm = null)
        {
            SqlConnection con = null;
            try
            {
                using (con = Connection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.procGetCodeValue";
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

        public DataTable GetDataWithJoin(List<ParameterList> lpm = null)
        {
            SqlConnection con = null;
            try
            {
                using (con = Connection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.procSelectWithJoin";
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
    }
}

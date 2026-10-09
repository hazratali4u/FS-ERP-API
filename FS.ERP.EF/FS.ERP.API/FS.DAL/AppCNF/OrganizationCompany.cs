using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CST.CCL.Helper.Common;
using FS.DAL.Common;

namespace FS.DAL.AppCNF
{
    public class OrganizationCompany : BaseProvider
    {
        public OrganizationCompany(string conStr) : base(conStr)
        {
            
        }
        public DataTable GetChildOrganizations(List<ParameterList> lpm = null)
        {
            SqlConnection con = null;
            try
            {
                using (con = Connection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "AppCNF.procGetAllChildCompanies";
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

        public DataTable GetGeoupProfitCenter(List<ParameterList> lpm = null)
        {
            SqlConnection con = null;
            try
            {
                using (con = Connection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "AppCNF.procGetGroupProfitCenter";
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

        public DataTable CheckDuplicateOrganization(List<ParameterList> lpm = null)
        {
            SqlConnection con = null;
            try
            {
                using (con = Connection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "AppCNF.procCheckDuplicateForOrganization";
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

        public DataTable GetParentOrganizations(List<ParameterList> lpm = null)
        {
            SqlConnection con = null;
            try
            {
                using (con = Connection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "AppCNF.procGetParentCompany";
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

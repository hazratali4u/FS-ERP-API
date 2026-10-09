using CST.CCL.Helper.Common;
using FS.DAL.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace FS.DAL.AppCNF.Geography
{
    public class CityTownProvider : BaseProvider
    {
        public CityTownProvider(string conStr) : base(conStr)
        {
            
        }
        public DataTable GetCityTowns(List<ParameterList> lpm = null)
        {
            try
            {
                SqlConnection con = null;
                using (con = Connection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AppCNF].[procGetCityTownCombo]";
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
                throw;
            }
        }
    }
}

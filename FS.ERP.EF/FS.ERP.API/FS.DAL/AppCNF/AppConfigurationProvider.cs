using CST.CCL.Helper.Common;
using FS.DAL.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace FS.DAL.AppCNF
{
    public class AppConfigurationProvider : BaseProvider
    {
        public AppConfigurationProvider(string conStr) : base(conStr)
        {
            
        }
        public int GetDocumentModuleCode(List<ParameterList> lpm = null)
        {
            int moduleCode = -1;
            try
            {
                SqlConnection con = null;
                using (con = Connection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AppCNF].[procGetDocumentModuleCode]";
                    cmd.Connection = con;
                    if (lpm!=null)
                    {
                        foreach (var item in lpm)
                            cmd.Parameters.AddWithValue("@"+item.Parameter,item.Value);
                    }
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            moduleCode = Convert.ToInt32(dr["ModuleCode"]);
                        }
                    }
                    dr.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return moduleCode;
        }
    }
}

using CST.CCL.Helper.Common;
using FS.DAL.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace FS.DAL.HRM.LeaveManagement
{
    public class EmployeeLeaveProvider : BaseProvider
    {
        public EmployeeLeaveProvider(string conStr) : base(conStr)
        {
            
        }
        public bool IsHR(List<ParameterList> lpm)
        {
            bool isHR = false;
            try
            {
                SqlConnection con = null;
                using (con = Connection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AppCNF].[procHRCheck]";
                    cmd.Connection = con;
                    if (lpm != null && lpm.Count > 0)
                    {
                        foreach (var item in lpm)
                            cmd.Parameters.AddWithValue("@" + item.Parameter, item.Value);
                    }

                    var returnParameter = cmd.Parameters.Add("@isHR", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    var result = returnParameter.Value;

                    isHR = Convert.ToBoolean(result);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return isHR;
        }
    }
}

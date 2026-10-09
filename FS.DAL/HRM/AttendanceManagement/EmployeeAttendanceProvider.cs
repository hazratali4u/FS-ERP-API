using CST.CCL.Helper.Common;
using FS.DAL.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using FS.ERP.Models.BO;

namespace FS.DAL.HRM.AttendanceManagement
{
    public class EmployeeAttendanceProvider : BaseProvider
    {
        public EmployeeAttendanceProvider(string conStr) : base(conStr)
        {
            
        }
        public List<BOEmployeeInfo> GetEmployees(string procedureName, List<ParameterList> lpm)
        {
            List<BOEmployeeInfo> lst = null;
            try
            {
                SqlConnection con = null;
                using (con = Connection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = procedureName;
                    cmd.Connection = con;
                    if (lpm != null && lpm.Count > 0)
                    {
                        foreach (var item in lpm)
                            cmd.Parameters.AddWithValue("@" + item.Parameter, item.Value);
                    }
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        lst = new List<BOEmployeeInfo>();
                        while (dr.Read())
                        {
                            BOEmployeeInfo obj = new BOEmployeeInfo();
                            obj.ID = Convert.ToInt64(dr["ID"]);
                            obj.FirstName = Convert.ToString(dr["FirstName"]);
                            obj.MiddleName = Convert.ToString(dr["MiddleName"] ?? "");
                            obj.LastName = Convert.ToString(dr["LastName"]);                           
                            obj.DeptCode = Convert.ToInt32(dr["DeptCode"]);
                            obj.DesignationCode = Convert.ToInt32(dr["DesignationCode"]);                           
                            lst.Add(obj);
                        }
                        lst.TrimExcess();
                    }
                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return lst;
        }

        public List<BOOrganizationCompany> GetProfitCenters(string procedureName, List<ParameterList> lpm)
        {
            List<BOOrganizationCompany> lst = null;
            try
            {
                SqlConnection con = null;
                using (con = Connection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = procedureName;
                    cmd.Connection = con;
                    if (lpm != null && lpm.Count > 0)
                    {
                        foreach (var item in lpm)
                            cmd.Parameters.AddWithValue("@" + item.Parameter, item.Value);
                    }
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        lst = new List<BOOrganizationCompany>();
                        while (dr.Read())
                        {
                            BOOrganizationCompany obj = new BOOrganizationCompany();
                            obj.ID = Convert.ToInt32(dr["ID"]);
                            obj.DisplayName = Convert.ToString(dr["DisplayName"]);
                            obj.LevelCode = Convert.ToByte(dr["LevelCode"] ?? 0);
                            lst.Add(obj);
                        }
                        lst.TrimExcess();
                    }
                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return lst;
        }
    }
}

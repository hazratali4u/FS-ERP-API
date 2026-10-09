using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CST.CCL.Helper.Common;
using FS.DAL.Common;
using FS.ERP.Models.BO;

namespace FS.DAL.MenuCNF
{
    public class SecurityRightProvider : BaseProvider
    {
        public SecurityRightProvider(string conStr) : base(conStr)
        {
            
        }
        public List<BOSecurityRight> GetAll(List<ParameterList> lpm=null)
        {
            List<BOSecurityRight> lst = null;
            try
            {
                SqlConnection con = null;
                using (con = Connection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.ProcGetToolBarRights";
                    cmd.Connection = con;
                    if (lpm!=null && lpm.Count>0)
                    {
                        foreach (var item in lpm)
                            cmd.Parameters.AddWithValue("@"+item.Parameter,item.Value);
                    }
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        lst = new List<BOSecurityRight>();
                        while (dr.Read())
                        {
                            BOSecurityRight obj = new BOSecurityRight();
                            obj.CanNew = Convert.ToBoolean(dr["CanNew"]);
                            obj.CanFind = Convert.ToBoolean(dr["CanFind"]);
                            obj.CanEdit = Convert.ToBoolean(dr["CanEdit"]);
                            obj.CanDelete = Convert.ToBoolean(dr["CanDelete"]);
                            obj.CanVoid = Convert.ToBoolean(dr["CanVoid"]);
                            obj.CanPrint = Convert.ToBoolean(dr["CanPrint"]);
                            obj.CanPreview = Convert.ToBoolean(dr["CanPreview"]);
                            obj.CanExport = Convert.ToBoolean(dr["CanExport"]);
                            obj.CanEmail = Convert.ToBoolean(dr["CanEmail"]);
                            obj.CanCall = Convert.ToBoolean(dr["CanCall"]);
                            obj.CanFax = Convert.ToBoolean(dr["CanFax"]);
                            obj.CanSMS = Convert.ToBoolean(dr["CanSMS"]);
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

        //public List<SecurityRight> GetAllRights(List<ParameterList> lpm = null)
        //{
        //    List<SecurityRight> lst = null;
        //    try
        //    {
        //        SqlConnection con = null;
        //        using (con = UtillConnection.GetConnection())
        //        {
        //            con.Open();
        //            SqlCommand cmd = new SqlCommand();
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.CommandText = "[MenuCNF].[ctprtbl_SecurityRight_SelectAll]";
        //            cmd.Connection = con;
        //            if (lpm != null && lpm.Count > 0)
        //            {
        //                foreach (var item in lpm)
        //                    cmd.Parameters.AddWithValue("@" + item.Parameter, item.Value);
        //            }
        //            SqlDataReader dr = cmd.ExecuteReader();
        //            if (dr.HasRows)
        //            {
        //                lst = new List<SecurityRight>();
        //                while (dr.Read())
        //                {
        //                    SecurityRight obj = new SecurityRight();
        //                    obj.ID = Convert.ToInt32(dr["ID"]);
        //                    obj.CanNew = Convert.ToBoolean(dr["CanNew"]);
        //                    obj.CanFind = Convert.ToBoolean(dr["CanFind"]);
        //                    obj.CanEdit = Convert.ToBoolean(dr["CanEdit"]);
        //                    obj.CanDelete = Convert.ToBoolean(dr["CanDelete"]);
        //                    obj.CanVoid = Convert.ToBoolean(dr["CanVoid"]);
        //                    obj.CanPrint = Convert.ToBoolean(dr["CanPrint"]);
        //                    obj.CanPreview = Convert.ToBoolean(dr["CanPreview"]);
        //                    obj.CanExport = Convert.ToBoolean(dr["CanExport"]);
        //                    obj.CanEmail = Convert.ToBoolean(dr["CanEmail"]);
        //                    obj.CanCall = Convert.ToBoolean(dr["CanCall"]);
        //                    obj.CanFax = Convert.ToBoolean(dr["CanFax"]);
        //                    obj.CanSMS = Convert.ToBoolean(dr["CanSMS"]);
        //                    lst.Add(obj);
        //                }
        //                lst.TrimExcess();
        //            }
        //            dr.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }
        //    return lst;
        //}
    }
}

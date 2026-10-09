using FS.DAL.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CST.CCL.Helper.Common;
using FS.ERP.Models.Custom;

namespace FS.DAL.UMS
{
    public class GroupRolesProvider : BaseProvider
    {
        public GroupRolesProvider(string conStr) : base(conStr)
        {
            
        }
        public List<ProfileGroupDetails> GetAllProfileData(List<ParameterList> lpm = null)
        {
            List<ProfileGroupDetails> lst = null;
            try
            {
                SqlConnection con = null;
                using (con = Connection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "MenuCNF.ctprtbl_Menu_SelectProfileMenu";
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
                        lst = new List<ProfileGroupDetails>();

                        while (dr.Read())
                        {
                            ProfileGroupDetails obj = new ProfileGroupDetails();



                            obj.ShortName = Convert.ToString(dr["ShortName"]);
                            obj.FullName = Convert.ToString(dr["FullName"]);
                            obj.DisplayName = Convert.ToString(dr["DisplayName"]);
                            obj.Description = Convert.ToString(dr["Description"]);
                            // obj.IsDisabled = Convert.ToBoolean(dr["IsDisabled"]);


                            obj.CanNew = Convert.ToBoolean(dr["CanNew"]);
                            obj.CanCall = Convert.ToBoolean(dr["CanCall"]);
                            obj.CanDelete = Convert.ToBoolean(dr["CanDelete"]);
                            obj.CanEdit = Convert.ToBoolean(dr["CanEdit"]);
                            obj.CanEmail = Convert.ToBoolean(dr["CanEmail"]);
                            obj.CanExport = Convert.ToBoolean(dr["CanExport"]);
                            obj.CanFax = Convert.ToBoolean(dr["CanFax"]);
                            obj.CanFind = Convert.ToBoolean(dr["CanFind"]);
                            obj.CanPreview = Convert.ToBoolean(dr["CanPreview"]);
                            obj.CanPrint = Convert.ToBoolean(dr["CanPrint"]);
                            obj.CanSMS = Convert.ToBoolean(dr["CanSMS"]);
                            obj.CanVoid = Convert.ToBoolean(dr["CanVoid"]);
                            obj.MenuCaption = Convert.ToString(dr["MenuCaption"]);

                            obj.MenuLevelCode = Convert.ToString(dr["MenuLevelCode"]);
                            obj.MenuName = Convert.ToString(dr["MenuName"]);
                            obj.MenuTitle = Convert.ToString(dr["MenuTitle"]);
                            obj.MenuType = Convert.ToString(dr["MenuType"]);
                            obj.ParentMenuCode = Convert.ToString(dr["ParentMenuCode"]);
                            obj.RightCaption = Convert.ToString(dr["RightCaption"]);
                            obj.RightSummary = Convert.ToString(dr["RightSummary"]);
                            obj.SecurityRightCode = Convert.ToString(dr["SecurityRightCode"]);
                            obj.MenuCode = Convert.ToInt32(dr["MenuCode"]);
                            obj.ProfileGroupCode = Convert.ToInt32(dr["ProfileGroupCode"]);
                            obj.ProfileGroupDetailID = Convert.ToInt32(dr["ProfileGroupDetailID"]);
                            obj.IsDisabled = Convert.ToBoolean(dr["IsDisabled"]);
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


        //public List<UserProfileGroup> GetProfileGroupId(List<ParameterList> lpm = null)
        //{
        //    List<UserProfileGroup> lst = null;
        //    try
        //    {
        //        SqlConnection con = null;
        //        using (con = UtillConnection.GetConnection())
        //        {
        //            con.Open();
        //            SqlCommand cmd = new SqlCommand();
        //            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //            cmd.CommandText = "dbo.ProcGetUserProfileID";
        //            if (lpm != null && lpm.Count > 0)
        //            {
        //                foreach (var item in lpm)
        //                {
        //                    cmd.Parameters.AddWithValue("@" + item.Parameter, item.Value);
        //                }
        //            }
        //            cmd.Connection = con;
        //            SqlDataReader dr = cmd.ExecuteReader();
        //            if (dr.HasRows)
        //            {
        //                lst = new List<UserProfileGroup>();

        //                while (dr.Read())
        //                {
        //                    UserProfileGroup obj = new UserProfileGroup();



        //                    obj.CompanyCode = Convert.ToInt32(dr["CompanyCode"]);
        //                    obj.ProfileGroupCode = Convert.ToInt32(dr["ProfileGroupCode"]);
        //                    lst.Add(obj);
        //                }
        //                lst.TrimExcess();
        //            }
        //            dr.Close();
        //        }

        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    return lst;
        //}

        //public List<GroupRolesDetail> Update(List<ParameterList> lpm = null)
        //{
        //    List<ProfileGroupDetails> lst = null;
        //    try
        //    {
        //        SqlConnection con = null;
        //        using (con = UtillConnection.GetConnection())
        //        {
        //            con.Open();
        //            SqlCommand cmd = new SqlCommand();
        //            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //            cmd.CommandText = "MenuCNF.ctprtbl_Menu_UpdateProfileMenu";
        //            if (lpm != null && lpm.Count > 0)
        //            {
        //                foreach (var item in lpm)
        //                {
        //                    cmd.Parameters.AddWithValue("@" + item.Parameter, item.Value);
        //                }
        //            }
        //            cmd.Connection = con;
        //            SqlDataReader dr = cmd.ExecuteReader();
        //            if (dr.HasRows)
        //            {
        //                lst = new List<ProfileGroupDetails>();

        //                while (dr.Read())
        //                {
        //                    ProfileGroupDetails obj = new ProfileGroupDetails();
        //                    obj.ShortName = Convert.ToString(dr["ShortName"]);
        //                    obj.CanNew = Convert.ToBoolean(dr["CanNew"]);
        //                    obj.CanCall = Convert.ToBoolean(dr["CanCall"]);
        //                    obj.CanDelete = Convert.ToBoolean(dr["CanDelete"]);
        //                    obj.CanEdit = Convert.ToBoolean(dr["CanEdit"]);
        //                    obj.CanEmail = Convert.ToBoolean(dr["CanEmail"]);
        //                    obj.CanExport = Convert.ToBoolean(dr["CanExport"]);
        //                    obj.CanFax = Convert.ToBoolean(dr["CanFax"]);
        //                    obj.CanFind = Convert.ToBoolean(dr["CanFind"]);
        //                    obj.CanPreview = Convert.ToBoolean(dr["CanPreview"]);
        //                    obj.CanPrint = Convert.ToBoolean(dr["CanPrint"]);
        //                    obj.CanSMS = Convert.ToBoolean(dr["CanSMS"]);
        //                    obj.CanVoid = Convert.ToBoolean(dr["CanVoid"]);
        //                    //obj.ID = Convert.ToInt32(dr["ID"]);
        //                    obj.MenuCaption = Convert.ToString(dr["MenuCaption"]);
        //                    obj.MenuCode = Convert.ToInt32(dr["MenuCode"]);
        //                    obj.MenuLevelCode = Convert.ToString(dr["MenuLevelCode"]);
        //                    obj.MenuName = Convert.ToString(dr["MenuName"]);
        //                    obj.MenuTitle = Convert.ToString(dr["MenuTitle"]);
        //                    obj.MenuType = Convert.ToString(dr["MenuType"]);
        //                    obj.ParentMenuCode = Convert.ToString(dr["ParentMenuCode"]);
        //                    obj.RightCaption = Convert.ToString(dr["RightCaption"]);
        //                    obj.RightSummary = Convert.ToString(dr["RightSummary"]);
        //                    obj.SecurityRightCode = Convert.ToInt32(dr["SecurityRightCode"]);
        //                    lst.Add(obj);
        //                }
        //                lst.TrimExcess();
        //            }
        //            dr.Close();
        //        }

        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    GroupRolesDetail lstdetail = new GroupRolesDetail();
        //    lstdetail.ProfileMenuDetails = lst;
        //    return null;
        //}

        public List<GroupRolesDetail> Delete(List<ParameterList> lpm = null)
        {
            List<GroupRolesDetail> lst = null;
            try
            {
                SqlConnection con = null;
                using (con = Connection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "MenuCNF.ctprtbl_Menu_DeleteProfileMenu";
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
                        lst = new List<GroupRolesDetail>();

                        while (dr.Read())
                        {

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


        public List<GroupRolesDetail> DeleteProfileDetails(List<ParameterList> lpm = null)
        {
            List<GroupRolesDetail> lst = null;
            try
            {
                SqlConnection con = null;
                using (con = Connection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "MenuCNF.ctprtbl_Menu_DeleteProfileMenuDetails";
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
                        lst = new List<GroupRolesDetail>();

                        while (dr.Read())
                        {

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

        //public List<ProfileGroup> CreateInProfileGroup(List<ParameterList> lpm = null)
        //{
        //    List<ProfileGroup> lst2 = new List<ProfileGroup>();
        //    List<ProfileGroup> lst = null;
        //    try
        //    {
        //        SqlConnection con = null;
        //        using (con = UtillConnection.GetConnection())
        //        {
        //            con.Open();
        //            SqlCommand cmd = new SqlCommand();
        //            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //            cmd.CommandText = "MenuCNF.ctprtbl_ProfileGroup_InsertRecord";
        //            if (lpm != null && lpm.Count > 0)
        //            {
        //                foreach (var item in lpm)
        //                {
        //                    cmd.Parameters.AddWithValue("@" + item.Parameter, item.Value);

        //                }
        //                cmd.Parameters.Add("@ID", SqlDbType.Int);
        //                cmd.Parameters["@ID"].Direction = ParameterDirection.Output;


        //            }
        //            cmd.Connection = con;
        //            SqlDataReader dr = cmd.ExecuteReader();
        //            if (dr.HasRows)
        //            {
        //                lst = new List<ProfileGroup>();

        //                while (dr.Read())
        //                {
        //                    // UserProfileGroup obj = new UserProfileGroup();

        //                    //obj.ShortName = Convert.ToString(dr["@ShortName"]);
        //                    //obj.FullName = Convert.ToString(dr["@FullName"]);
        //                    //obj.DisplayName = Convert.ToString(dr["@DisplayName"]);
        //                    //obj.IsDisabled = Convert.ToBoolean(dr["@IsDisabled"]);
        //                    //obj.ID = Convert.ToInt32(dr["@ID"]);

        //                    //lst.Add(obj);
        //                }
        //                // lst.TrimExcess();
        //            }
        //            ProfileGroup obj = new ProfileGroup();

        //            obj.ID = (int)cmd.Parameters["@ID"].Value;
        //            lst2.Add(obj);

        //            dr.Close();
        //        }

        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    return lst2;
        //}



        //public List<ProfileGroup> UpdateInProfileGroup(int GroupID, List<ParameterList> lpm = null)
        //{
        //    List<ProfileGroup> lst2 = new List<ProfileGroup>();
        //    List<ProfileGroup> lst = null;
        //    try
        //    {
        //        SqlConnection con = null;
        //        using (con = UtillConnection.GetConnection())
        //        {
        //            con.Open();
        //            SqlCommand cmd = new SqlCommand();
        //            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //            cmd.CommandText = "MenuCNF.ctprtbl_ProfileGroup_RecordUpdate";
        //            if (lpm != null && lpm.Count > 0)
        //            {
        //                foreach (var item in lpm)
        //                {
        //                    cmd.Parameters.AddWithValue("@" + item.Parameter, item.Value);

        //                }
        //                SqlParameter parm = new SqlParameter("@ID", SqlDbType.Int);
        //                parm.Value = GroupID;
        //                parm.Direction = ParameterDirection.Input;
        //                cmd.Parameters.Add(parm);


        //            }
        //            cmd.Connection = con;
        //            SqlDataReader dr = cmd.ExecuteReader();
        //            if (dr.HasRows)
        //            {
        //                lst = new List<ProfileGroup>();

        //                while (dr.Read())
        //                {
        //                    // UserProfileGroup obj = new UserProfileGroup();

        //                    //obj.ShortName = Convert.ToString(dr["@ShortName"]);
        //                    //obj.FullName = Convert.ToString(dr["@FullName"]);
        //                    //obj.DisplayName = Convert.ToString(dr["@DisplayName"]);
        //                    //obj.IsDisabled = Convert.ToBoolean(dr["@IsDisabled"]);
        //                    //obj.ID = Convert.ToInt32(dr["@ID"]);

        //                    //lst.Add(obj);
        //                }
        //                // lst.TrimExcess();
        //            }
        //            ProfileGroup obj = new ProfileGroup();

        //            obj.ID = Convert.ToInt16(cmd.Parameters["@ID"].Value);
        //            lst2.Add(obj);

        //            dr.Close();
        //        }

        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    return lst2;
        //}

        public List<ProfileGroupDetails> UpdateInProfileGroupDetail(List<ParameterList> lpm = null)
        {
            List<ProfileGroupDetails> lst = null;

            ProfileGroupDetails obj = new ProfileGroupDetails();

            try
            {
                SqlConnection con = null;
                using (con = Connection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "[MenuCNF].[ctprtbl_ProfileGroupDetail_UpdateRecord]";
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


                        while (dr.Read())
                        {
                            //lst = new List<ProfileGroupDetails>();
                            //obj.ID =Convert.ToInt32(dr["ID"]);
                            //lst.Add(obj);
                        }
                    }

                    //lst.TrimExcess();
                    dr.Close();
                }

            }
            catch (Exception)
            {
                throw;
            }
            return lst;
        }
        public List<ProfileGroupDetails> CreateInProfileGroupDetail(int menuCode, int securityCode, List<ParameterList> lpm = null)
        {
            List<ProfileGroupDetails> lst = null;

            ProfileGroupDetails obj = new ProfileGroupDetails();

            try
            {
                SqlConnection con = null;
                using (con = Connection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "MenuCNF.ctprtbl_ProfileGroupDetail_InsertRecord";
                    if (lpm != null && lpm.Count > 0)
                    {
                        foreach (var item in lpm)
                        {
                            cmd.Parameters.AddWithValue("@" + item.Parameter, item.Value);
                        }



                        SqlParameter parm = new SqlParameter("@MenuCode", SqlDbType.Int);
                        parm.Value = menuCode;
                        parm.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(parm);

                        SqlParameter parm1 = new SqlParameter("@SecurityRightCode", SqlDbType.Int);
                        parm1.Value = securityCode;
                        parm1.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(parm1);

                        cmd.Parameters.Add("@ID", SqlDbType.Int);
                        cmd.Parameters["@ID"].Direction = ParameterDirection.Output;


                        //cmd.Parameters.Add("@MenuCode", SqlDbType.Int);

                        //cmd.Parameters["@MenuCode"].Direction = ParameterDirection.Output;
                        //cmd.Parameters.Add("@SecurityRightCode", SqlDbType.Int);
                        //cmd.Parameters["@SecurityRightCode"].Direction = ParameterDirection.Output;
                        //cmd.Parameters.Add("@ID", SqlDbType.Int);
                        //cmd.Parameters["@ID"].Direction = ParameterDirection.Output;



                    }
                    cmd.Connection = con;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {


                        while (dr.Read())
                        {
                            //ProfileGroupDetail obj = new ProfileGroupDetail();
                            //obj.MenuCode = Convert.ToInt32(dr["@MenuCode"]);
                            //obj.SecurityRightCode = Convert.ToInt32(dr["@SecurityRightCode"]);
                            //obj.CompanyCode = Convert.ToInt32(dr["@CompanyCode"]);                      
                            //obj.ID = Convert.ToInt32(dr["@ID"]);

                            //lst.Add(obj);
                        }
                    }
                    lst = new List<ProfileGroupDetails>();
                    obj.ID = (int)cmd.Parameters["@ID"].Value;
                    obj.MenuCode = (int)cmd.Parameters["@MenuCode"].Value;
                    obj.SecurityRightCode = (string)cmd.Parameters["@SecurityRightCode"].Value;
                    lst.Add(obj);
                    lst.TrimExcess();
                    dr.Close();
                }

            }
            catch (Exception)
            {
                throw;
            }
            return lst;
        }

        //public List<SecurityRight> GetIdSecurityRights(List<ParameterList> lpm = null)
        //{
        //    List<SecurityRight> lst = null;
        //    try
        //    {
        //        SqlConnection con = null;
        //        using (con = UtillConnection.GetConnection())
        //        {
        //            con.Open();
        //            SqlCommand cmd = new SqlCommand();
        //            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //            cmd.CommandText = "[MenuCNF].[ctprtbl_SecurityRight_GetMappingSecurityRightId]";
        //            if (lpm != null && lpm.Count > 0)
        //            {
        //                foreach (var item in lpm)
        //                {
        //                    cmd.Parameters.AddWithValue("@" + item.Parameter, item.Value);
        //                }
        //            }
        //            cmd.Connection = con;
        //            SqlDataReader dr = cmd.ExecuteReader();
        //            if (dr.HasRows)
        //            {

        //                lst = new List<SecurityRight>();
        //                SecurityRight obj = new SecurityRight();
        //                while (dr.Read())
        //                {
        //                    obj.ID = Convert.ToInt32(dr["ID"]);
        //                    lst.Add(obj);
        //                }

        //                lst.TrimExcess();
        //            }
        //            dr.Close();
        //        }

        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    return lst;
        //}



        //public List<SecurityRight> UpdateInSecurityRights(int SecurityRightCode, List<ParameterList> lpm = null)
        //{
        //    List<SecurityRight> lst = null;

        //    SecurityRight obj = new SecurityRight();

        //    try
        //    {
        //        SqlConnection con = null;
        //        using (con = UtillConnection.GetConnection())
        //        {
        //            con.Open();
        //            SqlCommand cmd = new SqlCommand();
        //            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //            cmd.CommandText = "[MenuCNF].[ctprtbl_SecurityRight_UpdateOne]";
        //            if (lpm != null && lpm.Count > 0)
        //            {
        //                foreach (var item in lpm)
        //                {
        //                    cmd.Parameters.AddWithValue("@" + item.Parameter, item.Value);
        //                }

        //                SqlParameter parm = new SqlParameter("@ID", SqlDbType.Int);
        //                parm.Value = SecurityRightCode;
        //                parm.Direction = ParameterDirection.Input;
        //                cmd.Parameters.Add(parm);

        //                cmd.Parameters.Add("@MenuCode", SqlDbType.Int);

        //                cmd.Parameters["@MenuCode"].Direction = ParameterDirection.Output;
        //                cmd.Parameters.Add("@SecurityRightCode", SqlDbType.Int);
        //                cmd.Parameters["@SecurityRightCode"].Direction = ParameterDirection.Output;
        //                cmd.Parameters.Add("@ID", SqlDbType.Int);
        //                cmd.Parameters["@ID"].Direction = ParameterDirection.Output;


        //            }
        //            cmd.Connection = con;
        //            SqlDataReader dr = cmd.ExecuteReader();
        //            if (dr.HasRows)
        //            {


        //                while (dr.Read())
        //                {
        //                    ProfileGroupDetail obj = new ProfileGroupDetail();
        //                    obj.MenuCode = Convert.ToInt32(dr["@MenuCode"]);
        //                    obj.SecurityRightCode = Convert.ToInt32(dr["@SecurityRightCode"]);
        //                    obj.CompanyCode = Convert.ToInt32(dr["@CompanyCode"]);
        //                    obj.ID = Convert.ToInt32(dr["@ID"]);

        //                    lst.Add(obj);
        //                }
        //            }
        //            lst = new List<SecurityRight>();
        //            obj.ID = (int)cmd.Parameters["@ID"].Value;
        //            lst.Add(obj);
        //            lst.TrimExcess();
        //            dr.Close();
        //        }

        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    return lst;
        //}


        //public List<SecurityRight> CreateInSecurityRights(List<ParameterList> lpm = null)
        //{
        //    List<SecurityRight> lst = null;

        //    SecurityRight obj = new SecurityRight();

        //    try
        //    {
        //        SqlConnection con = null;
        //        using (con = UtillConnection.GetConnection())
        //        {
        //            con.Open();
        //            SqlCommand cmd = new SqlCommand();
        //            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //            cmd.CommandText = "MenuCNF.ctprtbl_SecurityRight_InsertOne";
        //            if (lpm != null && lpm.Count > 0)
        //            {
        //                foreach (var item in lpm)
        //                {
        //                    cmd.Parameters.AddWithValue("@" + item.Parameter, item.Value);
        //                }
        //                cmd.Parameters.Add("@ID", SqlDbType.Int);
        //                cmd.Parameters["@ID"].Direction = ParameterDirection.Output;


        //                cmd.Parameters.Add("@MenuCode", SqlDbType.Int);

        //                cmd.Parameters["@MenuCode"].Direction = ParameterDirection.Output;
        //                cmd.Parameters.Add("@SecurityRightCode", SqlDbType.Int);
        //                cmd.Parameters["@SecurityRightCode"].Direction = ParameterDirection.Output;
        //                cmd.Parameters.Add("@ID", SqlDbType.Int);
        //                cmd.Parameters["@ID"].Direction = ParameterDirection.Output;


        //            }
        //            cmd.Connection = con;
        //            SqlDataReader dr = cmd.ExecuteReader();
        //            if (dr.HasRows)
        //            {


        //                while (dr.Read())
        //                {
        //                    ProfileGroupDetail obj = new ProfileGroupDetail();
        //                    obj.MenuCode = Convert.ToInt32(dr["@MenuCode"]);
        //                    obj.SecurityRightCode = Convert.ToInt32(dr["@SecurityRightCode"]);
        //                    obj.CompanyCode = Convert.ToInt32(dr["@CompanyCode"]);
        //                    obj.ID = Convert.ToInt32(dr["@ID"]);

        //                    lst.Add(obj);
        //                }
        //            }
        //            lst = new List<SecurityRight>();
        //            obj.ID = (int)cmd.Parameters["@ID"].Value;
        //            lst.Add(obj);
        //            lst.TrimExcess();
        //            dr.Close();
        //        }

        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    return lst;
        //}



        //public List<SecurityRight> UpdateInSecurityRights(int SecurityRightCode, List<ParameterList> lpm = null)
        //{
        //    List<SecurityRight> lst = null;

        //    SecurityRight obj = new SecurityRight();

        //    try
        //    {
        //        SqlConnection con = null;
        //        using (con = UtillConnection.GetConnection())
        //        {
        //            con.Open();
        //            SqlCommand cmd = new SqlCommand();
        //            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //            cmd.CommandText = "[MenuCNF].[ctprtbl_SecurityRight_UpdateOne]";
        //            if (lpm != null && lpm.Count > 0)
        //            {
        //                foreach (var item in lpm)
        //                {
        //                    cmd.Parameters.AddWithValue("@" + item.Parameter, item.Value);
        //                }

        //                SqlParameter parm = new SqlParameter("@ID", SqlDbType.Int);
        //                parm.Value = SecurityRightCode;
        //                parm.Direction = ParameterDirection.Input;
        //                cmd.Parameters.Add(parm);

        //                cmd.Parameters.Add("@MenuCode", SqlDbType.Int);

        //                cmd.Parameters["@MenuCode"].Direction = ParameterDirection.Output;
        //                cmd.Parameters.Add("@SecurityRightCode", SqlDbType.Int);
        //                cmd.Parameters["@SecurityRightCode"].Direction = ParameterDirection.Output;
        //                cmd.Parameters.Add("@ID", SqlDbType.Int);
        //                cmd.Parameters["@ID"].Direction = ParameterDirection.Output;


        //            }
        //            cmd.Connection = con;
        //            SqlDataReader dr = cmd.ExecuteReader();
        //            if (dr.HasRows)
        //            {


        //                while (dr.Read())
        //                {
        //                    ProfileGroupDetail obj = new ProfileGroupDetail();
        //                    obj.MenuCode = Convert.ToInt32(dr["@MenuCode"]);
        //                    obj.SecurityRightCode = Convert.ToInt32(dr["@SecurityRightCode"]);
        //                    obj.CompanyCode = Convert.ToInt32(dr["@CompanyCode"]);
        //                    obj.ID = Convert.ToInt32(dr["@ID"]);

        //                    lst.Add(obj);
        //                }
        //            }
        //            lst = new List<SecurityRight>();
        //            obj.ID = (int)cmd.Parameters["@ID"].Value;
        //            lst.Add(obj);
        //            lst.TrimExcess();
        //            dr.Close();
        //        }

        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    return lst;
        //}



        public DataTable GetDataSet()
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
                    cmd.CommandText = "MenuCNF.ctprtbl_Menu_SelectProfileMenu";

                    cmd.Connection = con;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    // this will query your database and return the result to your datatable
                    da.Fill(ds);
                    con.Close();
                    da.Dispose();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return ds.Tables[0];
        }
    }
}

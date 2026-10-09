using System;
using System.Collections.Generic;
using CST.CCL.Helper.Common;
using FS.DAL.UMS;
using FS.ERP.Models.Custom;

namespace FS.CAPI.BAL
{
    public class GroupRolesRepository:CAPIBaseRepo
    {
        public GroupRolesRepository(string conStr) : base(conStr)
        {
            
        }
        public List<ProfileGroupDetails> GetAll(int id)
        {
            try
            {
                List<ParameterList> lpm = new List<ParameterList>();
                List<ParameterList> lpm2 = new List<ParameterList>();
                //    lpm.Add(new ParameterList("UserCode", id));


                //var list =new  ProfileGroupMenuProvider().GetProfileGroupId(lpm);
                //    if(list.Count>0)
                //    {


                // lpm2.Add(new ParameterList("ID", list.First().ProfileGroupCode));
                lpm2.Add(new ParameterList("ID", id));

                // }
                return new GroupRolesProvider(ConStr).GetAllProfileData(lpm2);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

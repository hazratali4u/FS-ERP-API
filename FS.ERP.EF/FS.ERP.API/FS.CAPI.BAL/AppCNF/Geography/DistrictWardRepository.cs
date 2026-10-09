using CST.CCL.Helper.Common;
using FS.DAL.AppCNF.Geography;
using System;
using System.Collections.Generic;
using System.Data;

namespace FS.CAPI.BAL.AppCNF.Geography
{
    public class DistrictWardRepository :CAPIBaseRepo
    {
        public DistrictWardRepository(string conStr) : base(conStr)
        {
            
        }
        public DataTable GetDistrictWards(List<ParameterList> lpm)
        {
            try
            {
                return new DistrictWardProvider(ConStr).GetDistrictWards(lpm);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

using CST.CCL.Helper.Common;
using FS.DAL.AppCNF.Geography;
using System;
using System.Collections.Generic;
using System.Data;

namespace FS.CAPI.BAL.AppCNF.Geography
{
    public class StateProvinceRepository : CAPIBaseRepo
    {
        public StateProvinceRepository(string conStr) : base(conStr)
        {

        }
        public DataTable GetStateProvinces(List<ParameterList> lpm)
        {
            try
            {
                return new StateProvinceProvider(ConStr).GetStateProvinces(lpm);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

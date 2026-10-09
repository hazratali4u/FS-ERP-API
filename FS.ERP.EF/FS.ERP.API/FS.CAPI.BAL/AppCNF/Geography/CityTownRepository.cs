using CST.CCL.Helper.Common;
using FS.DAL.AppCNF.Geography;
using System;
using System.Collections.Generic;
using System.Data;

namespace FS.CAPI.BAL.AppCNF.Geography
{
    public class CityTownRepository : CAPIBaseRepo
    {
        public CityTownRepository(string conStr) : base(conStr)
        {
            
        }
        public DataTable GetCityTowns(List<ParameterList> lpm)
        {
            try
            {
                return new CityTownProvider(ConStr).GetCityTowns(lpm);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

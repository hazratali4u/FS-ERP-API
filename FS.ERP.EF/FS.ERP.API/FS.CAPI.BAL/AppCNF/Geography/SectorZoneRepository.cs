using FS.DAL.AppCNF.Geography;
using System;
using System.Collections.Generic;
using System.Data;
using CST.CCL.Helper.Common;

namespace FS.CAPI.BAL.AppCNF.Geography
{
    public class SectorZoneRepository :CAPIBaseRepo
    {
        public SectorZoneRepository(string conStr) : base(conStr)
        {
            
        }
        public DataTable GetSectorZones()
        {
            try
            {
                return new SectorZoneProvider(ConStr).GetSectorZones();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

using CST.CCL.Helper.Common;
using FS.DAL.AppCNF;
using System;
using System.Collections.Generic;

namespace FS.CAPI.BAL.AppCNF
{
    public class AppConfigurationRepository : CAPIBaseRepo
    {
        public AppConfigurationRepository(string conStr) : base(conStr)
        {
            
        }
        public int GetDocumentModuleCode(List<ParameterList> lpm)
        {
            int moduleCode = 0;
            try
            {               
                moduleCode = new AppConfigurationProvider(ConStr).GetDocumentModuleCode(lpm);
            }
            catch (Exception)
            {

                throw;
            }
            return moduleCode;
        }
    }
}

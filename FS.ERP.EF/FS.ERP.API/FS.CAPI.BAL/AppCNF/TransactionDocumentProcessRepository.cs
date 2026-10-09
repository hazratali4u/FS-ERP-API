using CST.CCL.Helper.Common;
using FS.DAL.AppCNF;
using System;
using System.Collections.Generic;
using System.Data;

namespace FS.CAPI.BAL.AppCNF
{
    public class TransactionDocumentProcessRepository :CAPIBaseRepo
    {
        public TransactionDocumentProcessRepository(string conStr) : base(conStr)
        {
            
        }
        public DataTable GetDocumentsProcesses(List<ParameterList> lpm)
        {
            try
            {
                return new TransactionDocumentProcessProvider(ConStr).GetDocumentsProcesses(lpm);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

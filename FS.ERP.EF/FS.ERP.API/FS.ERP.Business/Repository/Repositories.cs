using PLINQO;
using FS.ERP.EF.Db_Context;
using FS.ERP.TenantDal;

namespace FS.ERP.Business.Repository
{
    public class FsErpRepository<T> : Repository<T, FsERP_Context, int> where T : class
    {
        public FsErpRepository(string connectionString)
            : base(connectionString, false, false)
        {
        }
    }

    public class FsErpTanentRepository<T> : Repository<T, TenantContext, long> where T : class
    {
        public FsErpTanentRepository(string connectionString)
            : base(connectionString, false, false)
        {
        }
    }
}

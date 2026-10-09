using System.Data.SqlClient;

namespace FS.DAL.Common
{
    public class BaseProvider
    {
        private string _conStr;

        public BaseProvider(string conStr)
        {
            this._conStr = conStr;
        }

        public SqlConnection Connection()
        {
            return UtillConnection.GetConnection(_conStr);
        }
    }
}

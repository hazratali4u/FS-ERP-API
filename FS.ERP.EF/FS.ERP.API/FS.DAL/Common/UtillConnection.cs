using System.Data.SqlClient;
namespace FS.DAL.Common
{
    public static class UtillConnection
    {
        public static SqlConnection GetConnection(string conStr)
        {
            try
            {
                //Initializer objConnection = new Initializer();
                //objConnection.Initialize(conStr);
                //return objConnection.connection;

                return new SqlConnection(conStr);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
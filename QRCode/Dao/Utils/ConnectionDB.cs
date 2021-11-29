using System.Data.SqlClient;

namespace QRCode.Dao.Utils
{
    public class ConnectionDB
    {
        public static SqlConnection getConnection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = ".";
            builder.UserID = "sa";
            builder.Password = "***";
            builder.InitialCatalog = "QRCode";           
            SqlConnection conn = new SqlConnection(builder.ConnectionString);
            return conn;
        }
        public SqlConnection con = getConnection();
    }
}

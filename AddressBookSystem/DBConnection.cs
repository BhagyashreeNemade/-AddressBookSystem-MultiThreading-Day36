namespace AddressBookSystem
{
    using System;
    using System.Data.SqlClient;

    /// <summary>
    /// Returns DataBase Connection
    /// </summary>
    public class DBConnection
    {
        /// <summary>
        /// Gets the connection.
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnection()
        {
            string connectionString = "Data Source = BHAGYASHREE; Initial Catalog = address_book_service; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PocGraphicQL.Repositories
{
    public class Repository
    {
        protected string ConnectionString { get; }

        protected IDbConnection Connection;

        public Repository(IConfiguration configuration) => ConnectionString = configuration.GetConnectionString("SqlServerDatabase");

        protected IDbConnection CreateConnection()
        {
            Connection = new SqlConnection(ConnectionString);
            return Connection;
        }
    }
}

using Microsoft.Data.SqlClient;
using System.Data;

namespace SeidorApi.Infra.Data
{
    public class Connection : IConnection
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public Connection(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetSection("ConnectionStrings:DbContext").Value;
        }

        public SqlConnection ObterConexao()
        {
            return new SqlConnection(_connectionString);
        }       
    }
}

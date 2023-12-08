using Microsoft.Data.SqlClient;

namespace SeidorApi.Infra.Data;

public interface IConnection
{
    SqlConnection ObterConexao();
}

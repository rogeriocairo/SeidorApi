using Microsoft.Data.SqlClient;

namespace SeidorApi.Core.Interfaces
{
    public interface IDapperRepository
    {
        SqlConnection GetConnection();
    }
}

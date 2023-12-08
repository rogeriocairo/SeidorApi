using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SeidorApi.Core.Entities;
using SeidorApi.Core.Interfaces;
using SeidorApi.Infra.Data;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SeidorApi.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IConnection _conexao;

        public UserRepository(IConnection conexao)
        {
            _conexao = conexao;
        }

        public async Task<IEnumerable<UserEntity>> ListarUsuarioAsync()
        {
            using var db = _conexao.ObterConexao();
            await db.OpenAsync();
            var _procedure = "sp_GetUsers";            
            var _results = db.Query<UserEntity>(
                                    _procedure,                                    
                                    commandType: CommandType.StoredProcedure);

            return _results;
        }


        public async Task<UserEntity> ObterUsuarioAsync(string email, string senha)
        {
            using var db = _conexao.ObterConexao();
            await db.OpenAsync();
            var _procedure = "sp_GetUsers";
            var _values = new { email = email, senha = senha };
            var _results =  db.Query<UserEntity>(
                                    _procedure,
                                    _values,
                                    commandType: CommandType.StoredProcedure);

            return _results.ElementAt(0);
        }
    }
}

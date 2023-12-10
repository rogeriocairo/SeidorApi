using Dapper;
using SeidorApi.Core.Entities;
using SeidorApi.Core.Interfaces;
using SeidorApi.Infra.Data;
using System.Data;

namespace SeidorApi.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IConnection _conexao;

        public UserRepository(IConnection conexao)
        {
            _conexao = conexao;
        }

        public async Task<int> EditarUsuariosAsync(UserEntity userEntity)
        {
            using var db = _conexao.ObterConexao();
            await db.OpenAsync();
            var _procedure = "sp_EditUsers";
            var _results = await db.ExecuteAsync(
                                    _procedure,
                                    userEntity,
                                    commandType: CommandType.StoredProcedure);

            return _results;
        }

        public async Task<int> InserirUsuariosAsync(UserEntity userEntity)
        {
            using var db = _conexao.ObterConexao();
            await db.OpenAsync();
            var _procedure = "sp_InsertUsers";
            var _results = await db.ExecuteAsync(
                                    _procedure,
                                    userEntity,
                                    commandType: CommandType.StoredProcedure);

            return _results;
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


        public async Task<UserEntity?> ObterUsuarioAsync(string email, string senha)
        {
            using var db = _conexao.ObterConexao();
            await db.OpenAsync();
            var _procedure = "sp_GetUsers";
            var _values = new { email = email, senha = senha };
            var _results = await db.QueryAsync<UserEntity>(
                            _procedure, _values, commandType: CommandType.StoredProcedure);

            return _results.FirstOrDefault();
        }
    }
}

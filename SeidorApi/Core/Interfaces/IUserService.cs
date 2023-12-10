using SeidorApi.Core.Entities;

namespace SeidorApi.Core.Interfaces
{
    public interface IUserService
    {
        Task<UserEntity?> ObterUsuarioAsync(string nome, string senha);

        Task<IEnumerable<UserEntity>> ListarUsuariosAsync();

        Task<int> InserirUsuariosAsync(UserEntity userEntity);

        Task<int> EditarUsuariosAsync(UserEntity userEntity);
    }
}

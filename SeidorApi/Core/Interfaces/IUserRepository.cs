using SeidorApi.Core.Entities;

namespace SeidorApi.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<UserEntity> ObterUsuario(string nome, string senha);
    }
}

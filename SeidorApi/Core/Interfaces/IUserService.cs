using SeidorApi.Core.Entities;

namespace SeidorApi.Core.Interfaces
{
    public interface IUserService
    {
        Task<UserEntity?> ObterUsuario(string nome, string senha);
    }
}

using SeidorApi.Core.Entities;
using SeidorApi.Core.Interfaces;

namespace SeidorApi.Core.Services;

public class UserServices : IUserService
{
    public Task<UserEntity> ObterUsuario(string nome, string senha)
    {
        throw new NotImplementedException();
    }
}

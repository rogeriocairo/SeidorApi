using SeidorApi.Core.Entities;
using SeidorApi.Core.Interfaces;

namespace SeidorApi.Core.Services;

public class UserServices : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserServices(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<UserEntity?> ObterUsuario(string email, string senha)
    {
        ArgumentNullException.ThrowIfNull(email);
        ArgumentNullException.ThrowIfNull(senha);

        var _usuario = await _userRepository.ObterUsuarioAsync(email, senha);

        return _usuario;
    }
}

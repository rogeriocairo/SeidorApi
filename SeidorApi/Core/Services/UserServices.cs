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

    public async Task<int> EditarUsuariosAsync(UserEntity userEntity)
    {
        return await _userRepository.EditarUsuariosAsync(userEntity);
    }

    public async Task<int> InserirUsuariosAsync(UserEntity userEntity)
    {
        return await _userRepository.InserirUsuariosAsync(userEntity);
    }

    public async Task<IEnumerable<UserEntity>> ListarUsuariosAsync()
    {
        return await _userRepository.ListarUsuarioAsync();
    }

    public async Task<UserEntity?> ObterUsuarioAsync(string email, string senha)
    {
        ArgumentNullException.ThrowIfNull(email);
        ArgumentNullException.ThrowIfNull(senha);

        var _usuario = await _userRepository.ObterUsuarioAsync(email, senha);

        return _usuario ?? throw new Exception("Usuário/senha inválidos");
    }
}

﻿using SeidorApi.Core.Entities;

namespace SeidorApi.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<UserEntity?> ObterUsuarioAsync(string nome, string senha);

        Task<IEnumerable<UserEntity>> ListarUsuarioAsync();
    }
}

using SeidorApi.Core.Interfaces;
using SeidorApi.Core.Services;
using SeidorApi.Infra.Data;
using SeidorApi.Infra.Repositories;

namespace SeidorApi.Configuration;

public static class ConfigureCoreServices
{
    public static IServiceCollection AddCoreServices(
        this IServiceCollection services)
    {
        #region Serviços       

        services.AddScoped<IUserService, UserServices>();
        services.AddScoped<IConnection, Connection>();

        #endregion

        #region Repository

        services.AddScoped<IUserRepository, UserRepository>();

        #endregion

        return services;
    }
}

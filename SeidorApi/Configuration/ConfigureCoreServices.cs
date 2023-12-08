using SeidorApi.Core.Interfaces;
using SeidorApi.Core.Services;

namespace SeidorApi.Configuration;

public static class ConfigureCoreServices
{
    public static IServiceCollection AddCoreServices(
        this IServiceCollection services)
    {
        #region Serviços

        services.AddScoped<IUserService, UserServices>();

        #endregion

        #region Repository

        //services.AddScoped<IMegaSenaRepository, MegaSenaRepository>();

        #endregion

        return services;
    }
}

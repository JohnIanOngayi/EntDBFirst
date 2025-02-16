using srx.Contracts;
using srx.Repository;

namespace srx.ServiceExtensions;

public static class RepositoryExtension
{
    public static void ConfigureRepositoryWrapper(this IServiceCollection services)
    {
        services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
    }
}

using srx.Contracts;
using srx.Repository;

namespace srx.ServiceExtensions;

public static class RepositoryExtension
{
    public static void ConfigureRepositoryWraapper(this IServiceCollection services)
    {
        services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
    }
}

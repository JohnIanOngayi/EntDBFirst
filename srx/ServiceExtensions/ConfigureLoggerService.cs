using srx.LoggerService;
using srx.Contracts;

namespace srx.ServiceExtensions;

public static class ServiceExtensions
{
    public static void ConfigureLoggerService(this IServiceCollection services)
    {
        services.AddSingleton<ILoggerManager, LoggerManager>();
    }
}

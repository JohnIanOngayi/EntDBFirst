using Microsoft.EntityFrameworkCore;
using srx.Entities;

namespace srx.ServiceExtensions;

public static class DBExtensions
{
    public static void ConfigureSqlite(this IServiceCollection services, IConfiguration config)
    {
        services.AddDbContext<RepositoryContext>(options =>
            options.UseSqlite(config.GetConnectionString("DefaultConnection"))
        );
    }
}

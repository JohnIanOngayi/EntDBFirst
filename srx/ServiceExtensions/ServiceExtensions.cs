using Microsoft.EntityFrameworkCore;
using srx.Entities;

namespace ServiceExtensions;

public static class DBExtensions
{
    public static void ConfigureSqlite(this IServiceCollection services, IConfiguration config)
    {
        services.AddDbContext<RepositoryContext>(options =>
            options.UseSqlite(config.GetConnectionString("DefaultConnection"))
        );
    }
}

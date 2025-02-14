using Microsoft.EntityFrameworkCore;
using srx.Entities.Models;

namespace srx.Entities;

public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions options)
        : base(options) { }

    public DbSet<Owner>? Owners { get; set; }
    public DbSet<Account>? Accounts { get; set; }
}

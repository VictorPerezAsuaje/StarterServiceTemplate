using Microsoft.EntityFrameworkCore;


namespace StarterService.Infrastructure;

public class StarterServiceDbContext : DbContext
{
    public StarterServiceDbContext(DbContextOptions<StarterServiceDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}

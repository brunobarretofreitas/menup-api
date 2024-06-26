using MenupApi.Domain;
using Microsoft.EntityFrameworkCore;

namespace MenupApi.Infrastructure;

public class MenupDbContext : DbContext
{
    public MenupDbContext(DbContextOptions<MenupDbContext> options)
        : base(options)
    {
    }

    public DbSet<Restaurant> Restaurants{ get; set; }
    public DbSet<Schedule> Schedules{ get; set; }
    public DbSet<OpeningHours> OpeningHours { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Restaurant>()
            .ToTable("restaurants");

        modelBuilder.Entity<Schedule>()
            .ToTable("schedules");
        
        modelBuilder.Entity<OpeningHours>()
            .ToTable("opening_hours");
    }
}

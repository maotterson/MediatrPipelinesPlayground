using MediatrPipelinesPlayground.Domain;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace MediatrPipelinesPlayground.Database;

public class WeatherDbContext : DbContext
{
    public DbSet<WeatherForecast> WeatherForecasts { get; set; }
    public WeatherDbContext(DbContextOptions<WeatherDbContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<WeatherForecast>()
            .HasKey(wf => wf.Id);
    }
}

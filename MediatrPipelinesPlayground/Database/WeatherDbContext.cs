using MediatrPipelinesPlayground.Domain;
using Microsoft.EntityFrameworkCore;

namespace MediatrPipelinesPlayground.Database;

public class WeatherDbContext : DbContext
{
    public DbSet<WeatherForecast> WeatherForecasts { get; set; }
    public WeatherDbContext(DbContextOptions<WeatherDbContext> options) : base(options)
    {
    }

}

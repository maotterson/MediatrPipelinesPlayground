using MediatrPipelinesPlayground.Database;
using MediatrPipelinesPlayground.Domain;
using Microsoft.EntityFrameworkCore;

namespace MediatrPipelinesPlayground.Repositories;

public class WeatherForecastPostgresRepository : IWeatherForecastRepository
{
    private readonly WeatherDbContext _weatherDbContext;
    public WeatherForecastPostgresRepository(WeatherDbContext weatherDbContext)
    {
        _weatherDbContext = weatherDbContext;
    }
    public async Task<List<WeatherForecast>> GetWeatherForecasts()
    {
        return await _weatherDbContext.WeatherForecasts.ToListAsync();
    }
}

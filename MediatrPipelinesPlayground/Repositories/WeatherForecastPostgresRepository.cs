using MediatrPipelinesPlayground.Database;
using MediatrPipelinesPlayground.Domain;

namespace MediatrPipelinesPlayground.Repositories;

public class WeatherForecastPostgresRepository : IWeatherForecastRepository
{
    private readonly WeatherDbContext _weatherDbContext;
    public WeatherForecastPostgresRepository(WeatherDbContext weatherDbContext)
    {
        _weatherDbContext = weatherDbContext;
    }
    public Task<List<WeatherForecast>> GetWeatherForecasts()
    {
        throw new NotImplementedException();
    }
}

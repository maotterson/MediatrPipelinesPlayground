using MediatrPipelinesPlayground.Domain;

namespace MediatrPipelinesPlayground.Repositories;

public class WeatherForecastPostgresRepository : IWeatherForecastRepository
{
    public Task<List<WeatherForecast>> GetWeatherForecasts()
    {
        throw new NotImplementedException();
    }
}

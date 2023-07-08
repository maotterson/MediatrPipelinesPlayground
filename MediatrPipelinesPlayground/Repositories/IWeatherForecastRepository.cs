using MediatrPipelinesPlayground.Domain;

namespace MediatrPipelinesPlayground.Repositories;

public interface IWeatherForecastRepository
{
    Task<List<WeatherForecast>> GetWeatherForecasts();
    Task<WeatherForecast> GenerateWeatherForecast();
}

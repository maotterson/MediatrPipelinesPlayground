using MediatrPipelinesPlayground.Contracts.GenerateWeatherForecast;
using MediatrPipelinesPlayground.Contracts.Models;
using MediatrPipelinesPlayground.Domain;

namespace MediatrPipelinesPlayground.Contracts.GetWeatherForecast;

public static class GenerateWeatherForecastExtensions
{
    public static GenerateWeatherForecastResponse ToDto(this WeatherForecast weatherForecast)
    {
        return new GenerateWeatherForecastResponse
        {
            Forecast = weatherForecast.AsDto(),
            Timestamp = DateTime.Now
        };
    }
}

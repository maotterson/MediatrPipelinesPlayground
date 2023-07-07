using MediatrPipelinesPlayground.Domain;

namespace MediatrPipelinesPlayground.Contracts.Models;

public static class DtoExtensions
{
    public static WeatherForecastDto AsDto(this WeatherForecast forecast)
    {
        return new WeatherForecastDto
        {
            Date = forecast.Date,
            Summary = forecast.Summary,
            TemperatureC = forecast.TemperatureC,
            TemperatureF = forecast.TemperatureF
        };
    }

    public static IEnumerable<WeatherForecastDto> AsDto(this IEnumerable<WeatherForecast> forecasts)
    {
        return forecasts.Select(f => f.AsDto());
    }
}

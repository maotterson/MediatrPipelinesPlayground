using MediatrPipelinesPlayground.Contracts.Models;
using System.Text.Json.Serialization;

namespace MediatrPipelinesPlayground.Contracts.GenerateWeatherForecast;

public class GenerateWeatherForecastResponse
{
    [JsonPropertyName("timestamp")]
    public DateTimeOffset Timestamp { get; set; } = default!;
    [JsonPropertyName("forecast")]
    public WeatherForecastDto Forecast { get; set; } = default!;
}

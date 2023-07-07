using System.Text.Json.Serialization;
using MediatrPipelinesPlayground.Contracts.Models;
using MediatrPipelinesPlayground.Domain;

namespace MediatrPipelinesPlayground.Contracts.GetWeatherForecast;

public class GetWeatherForecastResponse
{
    [JsonPropertyName("timestamp")]
    public DateTimeOffset Timestamp { get; set; } = default!;
    [JsonPropertyName("forecasts")]
    public List<WeatherForecastDto> Forecasts { get; set; } = default!;
}

using System.Text.Json.Serialization;

namespace MediatrPipelinesPlayground.Contracts.GetWeatherForecast;

public class GetWeatherForecastResponse
{
    [JsonPropertyName("timestamp")]
    public DateTimeOffset Timestamp { get; set; } = default!;
    [JsonPropertyName("forecasts")]
    public List<WeatherForecast> Forecasts { get; set; } = default!;
}

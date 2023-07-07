using System.Text.Json.Serialization;

namespace MediatrPipelinesPlayground.Contracts.GetWeatherForecast;

public class GetWeatherForecastResponse
{
    [JsonPropertyName("forecasts")]
    List<WeatherForecast> Forecasts { get; set; } = default!;
}

using System.Text.Json.Serialization;

namespace MediatrPipelinesPlayground.Contracts.GetWeatherForecast;

public class GetWeatherForecastResponse
{
    [JsonPropertyName("forecasts")]
    public List<WeatherForecast> Forecasts { get; set; } = default!;
}

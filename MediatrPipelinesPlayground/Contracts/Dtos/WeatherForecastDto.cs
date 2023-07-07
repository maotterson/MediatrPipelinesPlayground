using System.Text.Json.Serialization;

namespace MediatrPipelinesPlayground.Contracts.Models;

public class WeatherForecastDto
{
    [JsonPropertyName("date")]
    public DateTime Date { get; set; }

    [JsonPropertyName("temperature_c")]
    public int TemperatureC { get; set; }

    [JsonPropertyName("temperature_f")]
    public int TemperatureF { get; set; }

    [JsonPropertyName("summary")]
    public string? Summary { get; set; }
}

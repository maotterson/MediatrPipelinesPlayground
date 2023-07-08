using MediatrPipelinesPlayground.Domain;

namespace MediatrPipelinesPlayground.Helpers;

public static class ForecastGenerator
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
    public static WeatherForecast GenerateWeatherForecast(DateTime generatedDate)
    {
        var forecast = new WeatherForecast
        {
            Date = generatedDate,
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        };
        return forecast;
    }
}

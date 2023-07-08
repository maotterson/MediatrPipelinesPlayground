using MediatrPipelinesPlayground.Database;
using MediatrPipelinesPlayground.Domain;
using MediatrPipelinesPlayground.Helpers;
using Microsoft.EntityFrameworkCore;

namespace MediatrPipelinesPlayground.Repositories;

public class WeatherForecastPostgresRepository : IWeatherForecastRepository
{
    private readonly WeatherDbContext _weatherDbContext;
    public WeatherForecastPostgresRepository(WeatherDbContext weatherDbContext)
    {
        _weatherDbContext = weatherDbContext;
    }
    public async Task<List<WeatherForecast>> GetWeatherForecasts()
    {
        return await _weatherDbContext.WeatherForecasts.ToListAsync();
    }
    public async Task<WeatherForecast> GenerateWeatherForecast()
    {
        var mostRecentForecast = await _weatherDbContext.WeatherForecasts.LastAsync();
        var generatedDate = DateTime.Now.AddDays(1);
        if(mostRecentForecast is not null) 
        {
            generatedDate = mostRecentForecast.Date.AddDays(1);
        }
        var addedEntry = await _weatherDbContext.WeatherForecasts.AddAsync(ForecastGenerator.GenerateWeatherForecast(generatedDate));
        return addedEntry.Entity;
    }
}

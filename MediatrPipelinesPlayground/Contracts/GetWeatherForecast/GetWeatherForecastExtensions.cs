﻿using MediatrPipelinesPlayground.Contracts.Models;
using MediatrPipelinesPlayground.Domain;

namespace MediatrPipelinesPlayground.Contracts.GetWeatherForecast;

public static class GetWeatherForecastExtensions
{
    public static GetWeatherForecastResponse ToDto(this List<WeatherForecast> weatherForecasts)
    {
        return new GetWeatherForecastResponse
        {
            Forecasts = weatherForecasts.AsDto().ToList(),
            Timestamp = DateTime.Now
        };
    }
}

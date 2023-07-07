using MediatR;
using MediatrPipelinesPlayground.Contracts.GetWeatherForecast;
using MediatrPipelinesPlayground.Repositories;

namespace MediatrPipelinesPlayground.Handlers;

public class GetWeatherForecastHandler : IRequestHandler<GetWeatherForecastRequest, GetWeatherForecastResponse>
{
    private readonly WeatherForecastRepository _weatherForecastRepository;
    public GetWeatherForecastHandler(WeatherForecastRepository weatherForecastRepository)
    {
        _weatherForecastRepository = weatherForecastRepository;
    }
    public async Task<GetWeatherForecastResponse> Handle(GetWeatherForecastRequest request, CancellationToken cancellationToken)
    {
        var weatherForecasts = await _weatherForecastRepository.GetWeatherForecasts();
        return weatherForecasts.ToDto();
    }

}

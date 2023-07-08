using MediatR;
using MediatrPipelinesPlayground.Contracts.GenerateWeatherForecast;
using MediatrPipelinesPlayground.Contracts.GetWeatherForecast;
using MediatrPipelinesPlayground.Repositories;

namespace MediatrPipelinesPlayground.Handlers;

public class GenerateWeatherForecastHandler : IRequestHandler<GenerateWeatherForecastRequest, GenerateWeatherForecastResponse>
{
    private readonly IWeatherForecastRepository _weatherForecastRepository;
    public GenerateWeatherForecastHandler(IWeatherForecastRepository weatherForecastRepository)
    {
        _weatherForecastRepository = weatherForecastRepository;
    }
    public async Task<GenerateWeatherForecastResponse> Handle(GenerateWeatherForecastRequest request, CancellationToken cancellationToken)
    {
        var weatherForecast = await _weatherForecastRepository.GenerateWeatherForecast();
        return weatherForecast.ToDto();
    }
}

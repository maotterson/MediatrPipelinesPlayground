using MediatR;
using MediatrPipelinesPlayground.Contracts.GenerateWeatherForecast;
using MediatrPipelinesPlayground.Contracts.GetWeatherForecast;

namespace MediatrPipelinesPlayground.Handlers;

public class GenerateWeatherForecastHandler : IRequestHandler<GenerateWeatherForecastRequest, GenerateWeatherForecastResponse>
{
}

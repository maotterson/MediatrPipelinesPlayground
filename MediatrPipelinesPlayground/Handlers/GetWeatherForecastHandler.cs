using MediatR;
using MediatrPipelinesPlayground.Contracts.GetWeatherForecast;

namespace MediatrPipelinesPlayground.Handlers;

public class GetWeatherForecastHandler : IRequestHandler<GetWeatherForecastRequest, GetWeatherForecastResponse>
{
    public Task<GetWeatherForecastResponse> Handle(GetWeatherForecastRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

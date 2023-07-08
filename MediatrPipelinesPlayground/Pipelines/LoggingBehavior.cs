using MediatR;
using System.Diagnostics;

namespace MediatrPipelinesPlayground.Pipelines;

public class LoggingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : class, IRequest<TResponse>
{
    private readonly ILogger<LoggingBehavior<TRequest, TResponse>> _logger;
    public LoggingBehavior(ILogger<LoggingBehavior<TRequest, TResponse>> logger)
    {
        _logger = logger;
    }
    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        var stopwatch = Stopwatch.StartNew();
        _logger.LogInformation($"{typeof(TRequest).Name} handled");
        var response = await next();
        stopwatch.Stop();
        _logger.LogInformation($"{typeof(TResponse).Name} created in {stopwatch.ElapsedMilliseconds} ms.");
        return response;
    }
}

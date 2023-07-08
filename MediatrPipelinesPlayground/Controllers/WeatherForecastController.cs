using MediatR;
using MediatrPipelinesPlayground.Contracts.GenerateWeatherForecast;
using MediatrPipelinesPlayground.Contracts.GetWeatherForecast;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace MediatrPipelinesPlayground.Controllers;
[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IMediator _mediator;

    public WeatherForecastController(
        ILogger<WeatherForecastController> logger,
        IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<ActionResult<GetWeatherForecastResponse>> Get()
    {
        var response = await _mediator.Send(new GetWeatherForecastRequest());
        return Ok(response);
    }

    [HttpPost(Name = "GenerateWeatherForecast")]
    public async Task<ActionResult<GenerateWeatherForecastResponse>> Generate()
    {
        var response = await _mediator.Send(new GenerateWeatherForecastRequest());
        var url = Request.GetDisplayUrl();
        return Created(url, response);
    }
}

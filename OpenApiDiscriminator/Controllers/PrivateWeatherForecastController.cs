using Microsoft.AspNetCore.Mvc;

namespace OpenApiDiscriminator.Controllers;

[ApiController]
[Route("[controller]")]
public class PrivateWeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<PrivateWeatherForecastController> _logger;

    public PrivateWeatherForecastController(ILogger<PrivateWeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetPrivateWeatherForecast")]
    [ApiExplorerSettings(GroupName = "private")]
    public IEnumerable<WeatherForecast> Get()
    {
        return WeatherForecaster.GiveMe(10);
    }
}
using Microsoft.AspNetCore.Mvc;

namespace OpenApiDiscriminator.Controllers;

/// <summary>
/// Separate public API endpoints into their own classes to accommodate framework limitations.
/// Name the classes appropriately for their intended API group.
/// Add the ApiExplorerSettingsAttribute to identify the group to which this operation belongs.
/// </summary>
[ApiController]
[Route("[controller]")]
[ApiExplorerSettings(GroupName = "private")]
public class PrivateWeatherForecastController : ControllerBase
{
    private readonly ILogger<PrivateWeatherForecastController> _logger;

    public PrivateWeatherForecastController(ILogger<PrivateWeatherForecastController> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Name the endpoints appropriately for their intended API group.
    /// By convention, using the same name in different controllers with Swashbuckle will produce a runtime error.
    /// </summary>
    [HttpGet(Name = "GetPrivateWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return WeatherForecaster.GiveMe(10);
    }
}
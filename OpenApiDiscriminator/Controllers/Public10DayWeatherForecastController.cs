using Microsoft.AspNetCore.Mvc;

namespace OpenApiDiscriminator.Controllers;

/// <summary>
/// Separate public API endpoints into their own classes to accommodate framework limitations.
/// Name the classes appropriately for their intended API group.
/// Add the ApiExplorerSettingsAttribute to identify the group to which this operation belongs.
/// </summary>
[ApiController]
[Route("[controller]")]
[ApiExplorerSettings(GroupName = "public")]
public class Public10DayWeatherForecastController : ControllerBase
{
    private readonly ILogger<Public10DayWeatherForecastController> _logger;

    public Public10DayWeatherForecastController(ILogger<Public10DayWeatherForecastController> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Name the endpoints appropriately for their intended API group.
    /// By convention, using the same name in different controllers with Swashbuckle will produce a runtime error.
    /// </summary>
    [HttpGet(Name = "GetPublic10DayWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        // Call common domain logic to fulfill the request.
        return WeatherForecaster.GiveMe(10);
    }
}
using Microsoft.AspNetCore.Mvc;

namespace hello_copilot.Controllers;

[ApiController]
[Route("[controller]")]
public class ConvertController : ControllerBase
{
    private readonly ILogger<ConvertController> _logger;

    public ConvertController(ILogger<ConvertController> logger)
    {
        _logger = logger;
    }

    [HttpGet("heartbeat")]
    public string Heartbeat() { return "ConvertController"; }

    #region Feet to Meters

    [HttpGet("feet/meters/{value:double}")]
    public double FeetMeters(double value) { return value / 3.281; }

    [HttpGet("feet/decimeters/{value:double}")]
    public double FeetDecimeters(double value) { return value * 3.048; }

    [HttpGet("feet/centimeters/{value:double}")]
    public double FeetCentimeters(double value) { return value / 30.48; }

    [HttpGet("feet/millimeters/{value:double}")]
    public double FeetMillimeters(double value) { return value * 304.8; }

    [HttpGet("feet/kilometers/{value:double}")]
    public double FeetKilometers(double value) { return value / 3280.84; }

    #endregion

    #region Meters to Feet

    [HttpGet("meters/feet/{value:double}")]
    public double MetersFeet(double value) { return value * 3.281; }

    [HttpGet("decimeters/feet/{value:double}")] 
    public double DecimetersFeet(double value) { return value / 3.048; }

    [HttpGet("centimeters/feet/{value:double}")]
    public double CentimetersFeet(double value) { return value / 30.48; }

    [HttpGet("millimeters/feet/{value:double}")]
    public double MillimetersFeet(double value) { return value / 304.8; }

    [HttpGet("kilometers/feet/{value:double}")]
    public double KilometersFeet(double value) { return value * 3280.84; }

    #endregion

    #region Miles to Meters

    [HttpGet("miles/meters/{value:double}")]
    public double MilesMeters(double value) { return value * 1609.34; }

    [HttpGet("miles/decimeters/{value:double}")]
    public double MilesDecimeters(double value) { return value * 16093.4; }

    [HttpGet("miles/centimeters/{value:double}")]
    public double MilesCentimeters(double value) { return value * 160934; }

    [HttpGet("miles/millimeters/{value:double}")]
    public double MilesMillimeters(double value) { return value * 1.609e6; }

    [HttpGet("miles/kilometers/{value:double}")]
    public double MilesKilometers(double value) { return value * 1.609; }

    #endregion

    #region Meters to Miles

    [HttpGet("meters/miles/{value:double}")]
    public double MetersMiles(double value) { return value / 1609.34; }

    [HttpGet("decimeters/miles/{value:double}")]
    public double DecimetersMiles(double value) { return value / 16093; }

    [HttpGet("centimeters/miles/{value:double}")]
    public double CentimetersMiles(double value) { return value / 160934; }

    [HttpGet("millimeters/miles/{value:double}")]
    public double MillimetersMiles(double value) { return value / 1.609e6; }

    [HttpGet("kilometers/miles/{value:double}")]
    public double KilometersMiles(double value) { return value * 1.609; }

    #endregion

    #region Feet to Miles and Miles to Feet

    [HttpGet("feet/miles/{value:double}")]
    public double FeetMiles(double value) { return value / 5280.0; }

    [HttpGet("miles/feet/{value:double}")]
    public double MilesFeet(double value) { return value * 5280.0; }

    #endregion
}

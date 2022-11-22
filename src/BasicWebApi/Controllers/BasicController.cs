using Microsoft.AspNetCore.Mvc;

namespace BasicWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class BasicController : ControllerBase
{
    private readonly ILogger<BasicController> _logger;

    public BasicController(ILogger<BasicController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}

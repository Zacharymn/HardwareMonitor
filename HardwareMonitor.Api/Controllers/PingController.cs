using Microsoft.AspNetCore.Mvc;

namespace HardwareMonitor.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class PingController : ControllerBase
{
  [HttpGet]
  public string Get()
  {
    return "Pong from HardwareMonitor";
  }
}

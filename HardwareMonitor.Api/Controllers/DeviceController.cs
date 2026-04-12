using HardwareMonitor.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace HardwareMonitor.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class DeviceController : ControllerBase
{
  [HttpGet]
  public List<Device> Get()
  {
    var devices = new List<Device>
      {
        new Device { Id = 1, Name = "Thermostat", Location = "Living Room", DeviceId = Guid.NewGuid(), Value = 72.5, Timestamp = DateTime.UtcNow },
        new Device { Id = 2, Name = "Humidity Sensor", Location = "Basement", DeviceId = Guid.NewGuid(), Value = 45.0, Timestamp = DateTime.UtcNow }
      };

    return devices;
  } 
}
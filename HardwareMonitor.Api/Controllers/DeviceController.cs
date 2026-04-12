using HardwareMonitor.Api.Data;
using HardwareMonitor.Shared.DTOs;
using HardwareMonitor.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace HardwareMonitor.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class DeviceController : ControllerBase
{
  private readonly AppDbContext _db;

  public DeviceController(AppDbContext db)
  {
    _db = db;
  }
  [HttpGet]
  public List<Device> Get()
  {
    return _db.Devices.ToList();
  }

  [HttpPost]
  public Device Create(CreateDeviceDto deviceDto)
  {
    var device = new Device
    {
      Name = deviceDto.Name,
      Location = deviceDto.Location,
      Value = deviceDto.Value,
      Description = deviceDto.Description,
    };

    _db.Devices.Add(device);
    _db.SaveChanges();
    return device;
  }
}
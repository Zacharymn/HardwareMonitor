using HardwareMonitor.Api.Data;
using HardwareMonitor.Shared.DTOs;
using HardwareMonitor.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HardwareMonitor.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class SensorReadingController : ControllerBase
{
  private readonly AppDbContext _db;

  public SensorReadingController(AppDbContext db)
  {
    _db = db;
  }
  [HttpGet]
  public List<SensorReading> Get()
  {
    return _db.SensorReadings.Include(r => r.Device).ToList();
  }

  [HttpPost]
  public SensorReading Create(SensorReadingDto sensorReadingDto)
  {
    var sensorReading = new SensorReading
    {
      DeviceId = sensorReadingDto.DeviceId,
      Value = sensorReadingDto.Value,
    };
    

    _db.SensorReadings.Add(sensorReading);
    _db.SaveChanges();
    return sensorReading;
  }
}
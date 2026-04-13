namespace HardwareMonitor.Shared.DTOs;

public class SensorReadingDto
{
  public Guid DeviceId {get; set;}
  public string? Value {get; set;}
  public double Reading {get; set;}
}

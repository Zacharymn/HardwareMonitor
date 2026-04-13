namespace HardwareMonitor.Shared.DTOs;

public class SensorReadingDto
{
  public Guid DeviceId {get; set;}
  public double? Value {get; set;}
}

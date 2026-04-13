namespace HardwareMonitor.Shared.Models;

public class SensorReading
{
  public int Id {get; set;}
  public Guid DeviceId {get; set;}
  public Device? Device { get; set; }
  public double? Value {get; set;}
  public DateTime Timestamp {get; set;} = DateTime.UtcNow;
}

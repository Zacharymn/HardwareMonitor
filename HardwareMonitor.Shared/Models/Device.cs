namespace HardwareMonitor.Shared.Models;

public class Device
{
  public int Id {get; set;}
  public string? Name {get; set;}
  public string? Location {get; set;}
  public Guid DeviceId {get; set;}
  public double Value {get; set;}
  public DateTime Timestamp {get; set;}
}
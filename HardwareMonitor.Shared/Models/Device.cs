namespace HardwareMonitor.Shared.Models;

public class Device
{
  public int Id {get; set;}
  public string? Name {get; set;}
  public string? Location {get; set;}
  public Guid DeviceId {get; set;} = Guid.NewGuid();
  public string? Value {get; set;}
  public string? Description {get; set;}
  public DateTime Timestamp {get; set;} = DateTime.UtcNow;
}
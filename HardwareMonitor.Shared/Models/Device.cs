using System.ComponentModel.DataAnnotations;

namespace HardwareMonitor.Shared.Models;

public class Device
{
  public int Id {get; set;}
  public string? Name {get; set;} // Name it
  public string? Type {get; set;} // Reed Switch
  public string? Measurement {get; set;} // Degrees, Open, Humidity, wind speed, etc
  [MaxLength(20)]
  public string? Unit {get; set;} // Unit of measurement: Farenheight, celsius, meters, boolean, mph, etc...
  public string? Location {get; set;} // Where is this (House)
  public string? SubLocation {get; set;} // Where is this (kitchen)
  public Guid DeviceId {get; set;} = Guid.NewGuid(); 
  public string? Description {get; set;} // optional description: Pantry Door
  public DateTime Timestamp {get; set;} = DateTime.UtcNow;
}

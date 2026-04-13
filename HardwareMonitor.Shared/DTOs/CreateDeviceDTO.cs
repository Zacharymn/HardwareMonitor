namespace HardwareMonitor.Shared.DTOs;

public class CreateDeviceDto
{
  public string? Name {get; set;}
  public string? Type {get; set;}
  public string? Measurement {get; set;} // Degrees, Open, Humidity, wind speed, etc
  public string? Unit {get; set;} // Unit of measurement: Farenheight, celsius, meters, boolean, mph, etc...
  public string? Location {get; set;} // Where is this (House)
  public string? SubLocation {get; set;} // Where is this (kitchen)
  public string? Description {get; set;} // optional description: Pantry Door

}
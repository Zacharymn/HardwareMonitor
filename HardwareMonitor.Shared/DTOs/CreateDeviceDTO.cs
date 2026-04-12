namespace HardwareMonitor.Shared.DTOs;

public class CreateDeviceDto
{
  public required string Name {get; set;}
  public required string Location {get; set;}
  public required string Value {get; set;}
  public string? Description {get; set;}

}
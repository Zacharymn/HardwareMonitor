using HardwareMonitor.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace HardwareMonitor.Api.Data;

public class AppDbContext : DbContext
{
  public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
  
  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {

    modelBuilder.Entity<SensorReading>()
      .HasOne(r => r.Device)
      .WithMany()
      .HasForeignKey(r => r.DeviceId)
      .HasPrincipalKey(d => d.DeviceId);

    foreach (var entity in modelBuilder.Model.GetEntityTypes())
    {
        entity.SetTableName(ToSnakeCase(entity.GetTableName()!));

        foreach (var property in entity.GetProperties())
        {
            property.SetColumnName(ToSnakeCase(property.GetColumnName()));
        }
    }
  }

  private static string ToSnakeCase(string name)
  {
      return string.Concat(name.Select((c, i) => i > 0 && char.IsUpper(c) ? "_" + c : c.ToString())).ToLower();
  }

  public DbSet<Device> Devices {get; set;}
  public DbSet<SensorReading> SensorReadings {get; set;}
}

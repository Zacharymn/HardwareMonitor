using HardwareMonitor.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace HardwareMonitor.Api.Data;

public class AppDbContext : DbContext
{
  public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
  
  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
      foreach (var entity in modelBuilder.Model.GetEntityTypes())
      {
          entity.SetTableName(entity.GetTableName()!.ToLower());

          foreach (var property in entity.GetProperties())
          {
              property.SetColumnName(property.GetColumnName().ToLower());
          }
      }
  }

  public DbSet<Device> Devices {get; set;}
}

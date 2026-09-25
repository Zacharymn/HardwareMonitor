using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HardwareMonitor.Shared.Models;

namespace HardwareMonitor.Web.Pages
{
    public class SensorReadingsModel : PageModel
    {
      private readonly IHttpClientFactory _httpClientFactory;
      public List<SensorReading> SensorReadings { get; set; } = new();

      public SensorReadingsModel(IHttpClientFactory httpClientFactory)
      {
        _httpClientFactory = httpClientFactory;
      }

      public async Task OnGetAsync()
      {
        var client = _httpClientFactory.CreateClient("HardwareMonitorApi");
        SensorReadings = await client.GetFromJsonAsync<List<SensorReading>>("sensor-readings") ?? new();
      }

    }
}

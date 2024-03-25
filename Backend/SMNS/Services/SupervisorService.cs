using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Linq;
using SMNS.Models;
using System.Collections.Generic;

namespace SMNS.Services
{
    public class SupervisorService : ISupervisorService
    {
        private readonly HttpClient _httpClient;

        public SupervisorService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<string>> GetSupervisorsAsync()
        {
            var response = await _httpClient.GetStringAsync("https://o3m5qixdng.execute-api.us-east-1.amazonaws.com/api/managers");
            var supervisors = JsonSerializer.Deserialize<List<Supervisor>>(response);

            return supervisors
                .Where(s => !int.TryParse(s.Jurisdiction, out _))
                .OrderBy(s => s.Jurisdiction)
                .ThenBy(s => s.LastName)
                .ThenBy(s => s.FirstName)
                .Select(s => $"{s.Jurisdiction} - {s.LastName}, {s.FirstName}");
        }
    }
}

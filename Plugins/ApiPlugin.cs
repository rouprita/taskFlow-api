using System.Net.Http;
using System.Text;
using System.Text.Json;
using SystemMonitorApp.Interfaces;
using SystemMonitorApp.Models;

namespace SystemMonitorApp.Plugins
{
    public class ApiPlugin : IMonitorPlugin
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly string _endpoint;

        public ApiPlugin(string endpoint)
        {
            _endpoint = endpoint;
        }

        public async void OnDataReceived(SystemInfo info)
        {
            var json = JsonSerializer.Serialize(info);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await _httpClient.PostAsync(_endpoint, content);
        }
    }
}

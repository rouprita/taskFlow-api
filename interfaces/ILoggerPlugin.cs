using SystemMonitorApp.Models;

namespace SystemMonitorApp.Interfaces
{
    public interface IMonitorPlugin
    {
        void OnDataReceived(SystemInfo info);
    }
}

using System;
using System.IO;
using SystemMonitorApp.Models;
using SystemMonitorApp.Interfaces;

namespace SystemMonitorApp.Plugins
{
    public class FileLoggerPlugin : IMonitorPlugin
    {
        private readonly string _logFile = "log.txt";

        public void OnDataReceived(SystemInfo info)
        {
            string log = $"{DateTime.Now}: CPU: {info.Cpu}%, RAM: {info.RamUsed}MB, Disk: {info.DiskUsed}MB";
            File.AppendAllText(_logFile, log + Environment.NewLine);
        }
    }
}

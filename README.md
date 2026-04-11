<<<<<<< HEAD
# SystemMonitorApp

## 📦 Description
A console-based system resource monitoring app using .NET. It tracks CPU, memory, and disk usage and logs it using a plugin system, which allows easy extensibility for custom logging or integrations.

## ⚙️ Features
- Monitors system resources (CPU, memory, disk usage).
- Plugin-based logging (e.g., File Logger).
- Configurable via `appsettings.json`.
- Cross-platform compatibility (Windows, macOS, Linux).

## 🚀 How to Run

1. Install [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0).
2. Clone or unzip this repo to your local machine.
3. Open the folder in Visual Studio Code.
4. Run the following command in the terminal:
    ```
    dotnet run
    ```

## 🧩 Plugins
The app loads plugins based on the settings in `appsettings.json`. Example:

```json
{
  "Plugins": {
    "Enabled": [ "FileLoggerPlugin" ]
  }
}
=======
# taskFlow-api
Full stack task management system built with ASP.NET Core 8, React, and SQL Server
>>>>>>> 0518b7f54c3ae532cec6c5b9393cab7131dc3796

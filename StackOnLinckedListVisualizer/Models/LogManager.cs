using System.Text;

namespace StackOnLinckedListVisualizer.Models;

public enum LogLevel
{
    INFO,
    WARNING,
    ERROR,
    DEBUG
}

public static class LogManager
{
    private static readonly object _lock = new object();
    private static string _logFilePath = "algorithm_log.txt";

    public static void Log(LogLevel level, string message)
    {
        lock (_lock)
        {
            try
            {
                var logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{level}] {message}";
                File.AppendAllText(_logFilePath, logEntry + Environment.NewLine, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Failed to write log: {ex.Message}");
            }
        }
    }


}

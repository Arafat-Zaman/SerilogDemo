using Serilog;
using System;

namespace SerilogDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Configure Serilog
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console() // Logs to the console
                .WriteTo.File("logs/log.txt", rollingInterval: RollingInterval.Day) // Logs to a file, daily rolling
                .CreateLogger();

            // 2. Log different levels of messages
            Log.Verbose("This is a Verbose log message.");
            Log.Debug("This is a Debug log message.");
            Log.Information("This is an Information log message.");
            Log.Warning("This is a Warning log message.");
            Log.Error("This is an Error log message.");
            Log.Fatal("This is a Fatal log message.");

            // 3. End of program
            Console.WriteLine("Logging with Serilog is complete. Check the console and logs/log.txt file.");

            // 4. Flush and close the logger
            Log.CloseAndFlush();
        }
    }
}

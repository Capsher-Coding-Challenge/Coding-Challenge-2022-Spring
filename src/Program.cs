using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;
using System.IO;
using System.Reflection;

namespace IntegrationManager
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            InitializeLogger();
            host.Run();
        }

        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        private static void InitializeLogger()
        {
            var logDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "/logs";

            Directory.CreateDirectory(logDirectory);
            
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .Enrich.FromLogContext()
                .WriteTo.RollingFile(logDirectory + "/log-{Date}.log", outputTemplate: "{Level:u3} | {Timestamp:MM/dd/yyyy HH:mm:ss.fff zzz} | {SourceContext} | {Message}{NewLine}{Exception}{NewLine}", retainedFileCountLimit: 14)
                .WriteTo.Console()
                .CreateLogger();
        }
    }
}

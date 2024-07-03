using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using WinFormsApp7;


namespace ProjectAirFighter
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            ServiceCollection services = new();
            ConfigureServices(services);
            using ServiceProvider serviceProvider = services.BuildServiceProvider();
            Application.Run(serviceProvider.GetRequiredService<Form1>());
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            string[] path = Directory.GetCurrentDirectory().Split('\\');
            string pathNeed = "";
            for (int i = 0; i < path.Length - 3; i++)
            {
                pathNeed += path[i] + "\\";
            }
            services.AddSingleton<Form1>()
                .AddLogging(option =>
                {
                    option.SetMinimumLevel(LogLevel.Information);
                    option.AddSerilog(new LoggerConfiguration()
                        .ReadFrom.Configuration(new ConfigurationBuilder()
                            .SetBasePath(pathNeed)
                            .AddJsonFile("serilog.json")
                            .Build())
                        .CreateLogger());
                });
        }
    }
}
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PharmacyManagementSystem.Models;
using static Guna.UI2.Native.WinApi;
using System.IO;
using PharmacyManagementSystem.Services;
using PharmacyManagementSystem.View;


namespace PharmacyManagementSystem
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; } = null;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Load configuration
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfiguration configuration = builder.Build();

            var services = new ServiceCollection();

            // Configure services and get the service provider
            ServiceProvider = ServiceConfigurator.ConfigureServices(services, configuration);

            // Resolve MainForm through DI
            var mainForm = ServiceProvider.GetRequiredService<MainForm>();

            // Run application
            //Application.Run(mainForm);
            Application.Run(new Sell());
        }
    }
}
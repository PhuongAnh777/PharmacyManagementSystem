using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PharmacyManagementSystem.Models;
using static Guna.UI2.Native.WinApi;

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

            //ApplicationConfiguration.Initialize();
            //var builder = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            //IConfiguration configuration = builder.Build();

            //var services = new ServiceCollection();

            //ServiceProvider = services.BuildServiceProvider();

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            //// Configure services
            //var serviceProvider = ServiceConfigurator.ConfigureServices(services, configuration);

            //// Resolve the MainForm with DI

            //var mainForm = serviceProvider.GetRequiredService<CustomerForm>();


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}
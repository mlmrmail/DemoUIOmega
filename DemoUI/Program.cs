using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IConfigurationRoot config = null;
            //Read Configuration from appSettings
            if(string.IsNullOrEmpty(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")))
            {
                config = new ConfigurationBuilder()
                    .AddJsonFile($"appsettings.json", optional: false, reloadOnChange: true)
                    .Build();
            }
            else
            {
                config = new ConfigurationBuilder()
                    .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", optional: false, reloadOnChange: true)
                    .Build();
            }


            //Initialize Logger
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(config)
                // .WriteTo.File("log.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
            // Log.Debug(JsonConvert.SerializeObject(config, Formatting.Indented));
            try
            {
                Log.Information("Starting Demo UI App.");
                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "The API Application failed to start.");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

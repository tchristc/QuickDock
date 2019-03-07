using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using BlazorTest.WebApplication1.App.Services;
using Microsoft.Extensions.Logging;
using Blazor.Extensions.Logging;

namespace BlazorTest.WebApplication1.App
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Example of a data service
            services.AddSingleton<WeatherForecastService>();

            //services.AddLogging(builder => builder
            //    .AddBrowserConsole() // Add Blazor.Extensions.Logging.BrowserConsoleLogger
            //    .SetMinimumLevel(LogLevel.Trace)
            //);
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}

using WebApiDotNet9.Models;

namespace WebApiDotNet9.Endpoints;

public static class EndPointExtensions
{
    public static WebApplication? AddMappedEndpoints(this WebApplication? app)
    {
        if (app is null) return app;
        
        string[] summaries =
            ["Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"];

        app.MapGet("/weatherforecast", () =>
            {
                var forecast = Enumerable.Range(1, 5).Select(index =>
                        new WeatherForecast
                        (
                            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                            Random.Shared.Next(-20, 55),
                            summaries[Random.Shared.Next(summaries.Length)]
                        ))
                    .ToArray();
                return forecast;
            })
            .WithName("GetWeatherForecast");
        return app;
    }
}
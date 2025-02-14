using NLog;
using Scalar.AspNetCore;
using ServiceExtensions;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Configure NLog
        LogManager
            .Setup()
            .LoadConfigurationFromFile(
                string.Concat(Directory.GetCurrentDirectory(), "/nlog.config")
            );
        builder.Services.ConfigureLoggerService();

        // Add services to the container.
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        app.UseSwagger(opt =>
        {
            opt.RouteTemplate = "openapi/{documentName}.json";
        });
        app.MapScalarApiReference(opt =>
        {
            opt.Title = "Code Maze";
            opt.Theme = ScalarTheme.Mars;
            opt.DefaultHttpClient = new(ScalarTarget.Http, ScalarClient.Http11);
        });

        // app.UseHttpsRedirection();

        app.MapControllers();
        app.Run();
    }
}

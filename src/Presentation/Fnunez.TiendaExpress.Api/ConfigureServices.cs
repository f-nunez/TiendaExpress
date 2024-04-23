using Fnunez.TiendaExpress.Api.Middlewares;
using Fnunez.TiendaExpress.Api.Services;
using Fnunez.TiendaExpress.Api.Settings;
using Fnunez.TiendaExpress.Application.Common.Interfaces;
using Fnunez.TiendaExpress.Infrastructure.Persistence.Contexts;

namespace Microsoft.Extensions.DependencyInjection;

public static class ConfigureServices
{
    public static IServiceCollection AddWebServices(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddHttpContextAccessor();

        services.AddSingleton<ICurrentUserService, CurrentUserService>();

        services.AddRouting(options => options.LowercaseUrls = true);

        services.AddControllers();

        services.AddEndpointsApiExplorer();

        services.AddSwaggerGen();

        var corsPolicySettings = configuration
            .GetSection(typeof(CorsPolicySettings).Name)
            .Get<CorsPolicySettings>();

        if (corsPolicySettings is null)
            throw new ArgumentNullException(
                nameof(corsPolicySettings), $"{nameof(corsPolicySettings)} is required.");

        services.AddCors(corsOptions =>
        {
            corsOptions.AddPolicy(typeof(CorsPolicySettings).Name, corsPolicyBuilder =>
            {
                corsPolicyBuilder.AllowAnyHeader();

                corsPolicyBuilder.AllowAnyMethod();

                if (corsPolicySettings.WithOrigins is not null)
                    corsPolicyBuilder.WithOrigins(corsPolicySettings.WithOrigins);
                else
                    corsPolicyBuilder.AllowAnyOrigin();
            });
        });

        return services;
    }

    public static WebApplication AddWebApplicationBuilder(this WebApplication app)
    {
        app.UseMiddleware<GlobalExceptionHandlerMiddleware>();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
            Task.Run(() => SeedDataAsync(app));
        }

        app.UseHttpsRedirection();

        app.UseCors(typeof(CorsPolicySettings).Name);

        app.MapControllers();

        return app;
    }

    private static async void SeedDataAsync(WebApplication app)
    {
        using var scope = app.Services.CreateScope();

        var dbContextSeeder = scope.ServiceProvider
            .GetRequiredService<ApplicationDbContextSeeder>();

        await dbContextSeeder.MigrateAsync();

        await dbContextSeeder.SeedDataAsync();
    }
}
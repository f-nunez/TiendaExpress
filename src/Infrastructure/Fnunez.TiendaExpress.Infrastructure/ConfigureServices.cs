using Fnunez.TiendaExpress.Application.Common.Interfaces;
using Fnunez.TiendaExpress.Domain.BasketAggregate;
using Fnunez.TiendaExpress.Domain.BrandAggregate;
using Fnunez.TiendaExpress.Domain.CategoryAggregate;
using Fnunez.TiendaExpress.Domain.CustomerAggregate;
using Fnunez.TiendaExpress.Domain.OrderAggregate;
using Fnunez.TiendaExpress.Domain.ProductAggregate;
using Fnunez.TiendaExpress.Infrastructure.Persistence.Contexts;
using Fnunez.TiendaExpress.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection;

public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureServices(
        this IServiceCollection services,
        IConfiguration configuration)
    {

        services.AddDatabase(configuration);

        return services;
    }

    private static IServiceCollection AddDatabase(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(
                configuration.GetConnectionString("DefaultConnection"),
                builder => builder.MigrationsAssembly(
                    typeof(ApplicationDbContext).Assembly.FullName
                )
            )
        );

        services.AddScoped<ApplicationDbContextSeeder>();

        services.AddScoped<IRepository<Basket>, Repository<Basket>>();

        services.AddScoped<IRepository<Brand>, Repository<Brand>>();

        services.AddScoped<IRepository<Category>, Repository<Category>>();

        services.AddScoped<IRepository<Customer>, Repository<Customer>>();

        services.AddScoped<IRepository<Order>, Repository<Order>>();

        services.AddScoped<IRepository<Product>, Repository<Product>>();

        return services;
    }
}
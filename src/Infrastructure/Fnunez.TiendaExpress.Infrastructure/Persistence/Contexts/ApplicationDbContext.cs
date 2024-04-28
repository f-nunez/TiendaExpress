using System.Reflection;
using Fnunez.TiendaExpress.Domain.BasketAggregate;
using Fnunez.TiendaExpress.Domain.BasketAggregate.Entities;
using Fnunez.TiendaExpress.Domain.BrandAggregate;
using Fnunez.TiendaExpress.Domain.CategoryAggregate;
using Fnunez.TiendaExpress.Domain.CustomerAggregate;
using Fnunez.TiendaExpress.Domain.CustomerAggregate.Entities;
using Fnunez.TiendaExpress.Domain.OrderAggregate;
using Fnunez.TiendaExpress.Domain.OrderAggregate.Entities;
using Fnunez.TiendaExpress.Domain.ProductAggregate;
using Microsoft.EntityFrameworkCore;

namespace Fnunez.TiendaExpress.Infrastructure.Persistence.Contexts;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Basket> Baskets => Set<Basket>();
    public DbSet<BasketItem> BasketItems => Set<BasketItem>();
    public DbSet<Brand> Brands => Set<Brand>();
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<CustomerPaymentMethod> CustomerPaymentMethods => Set<CustomerPaymentMethod>();
    public DbSet<CustomerShippingAddress> CustomerShippingAddresses => Set<CustomerShippingAddress>();
    public DbSet<Order> Orders => Set<Order>();
    public DbSet<OrderItem> OrderItems => Set<OrderItem>();
    public DbSet<Product> Products => Set<Product>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(builder);
    }
}
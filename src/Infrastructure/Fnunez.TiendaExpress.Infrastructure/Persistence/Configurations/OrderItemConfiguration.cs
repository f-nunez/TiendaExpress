using Fnunez.TiendaExpress.Domain.OrderAggregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fnunez.TiendaExpress.Infrastructure.Persistence.Configurations;

public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem> builder)
    {
        builder.HasKey(oi => oi.Id);

        builder.Property(oi => oi.OrderId)
            .HasMaxLength(450)
            .IsRequired();

        builder.Property(oi => oi.Price)
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(oi => oi.Quantity)
            .IsRequired();

        builder.OwnsOne(oi => oi.ItemOrdered, oi =>
        {
            oi.WithOwner();

            oi.Property(io => io.ProductId)
                .HasMaxLength(450)
                .IsRequired();

            oi.Property(io => io.Name)
                .HasMaxLength(200)
                .IsRequired();

            oi.Property(io => io.PictureUri)
                .HasMaxLength(255)
                .IsRequired();
        });
    }
}
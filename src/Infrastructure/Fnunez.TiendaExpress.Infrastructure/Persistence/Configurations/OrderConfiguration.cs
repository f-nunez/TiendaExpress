using Fnunez.TiendaExpress.Domain.OrderAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fnunez.TiendaExpress.Infrastructure.Persistence.Configurations;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(o => o.Id);

        builder.Property(o => o.CustomerId)
            .HasMaxLength(450)
            .IsRequired();

        builder.Property(o => o.OrderDate)
            .IsRequired();

        builder.Property(o => o.OrderStatus)
            .IsRequired();

        builder.Property(o => o.SubTotal)
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(o => o.DeliveryFee)
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(o => o.PaymentIntentId)
            .HasMaxLength(450)
            .IsRequired();

        builder.OwnsOne(o => o.ShippingAddress, o =>
        {
            o.WithOwner();

            o.Property(sa => sa.FirstName)
                .HasMaxLength(256)
                .IsRequired();

            o.Property(sa => sa.LastName)
                .HasMaxLength(256)
                .IsRequired();

            o.Property(sa => sa.Address)
                .HasMaxLength(200)
                .IsRequired();

            o.Property(sa => sa.City)
                .HasMaxLength(100)
                .IsRequired();

            o.Property(sa => sa.State)
                .HasMaxLength(100)
                .IsRequired();

            o.Property(sa => sa.Country)
                .HasMaxLength(100)
                .IsRequired();

            o.Property(sa => sa.ZipCode)
                .HasMaxLength(18)
                .IsRequired();

            o.Property(sa => sa.PhoneCountryCode)
                .HasMaxLength(10)
                .IsRequired();

            o.Property(sa => sa.PhoneNumber)
                .HasMaxLength(16)
                .IsRequired();

            o.Property(sa => sa.PhoneExtension)
                .HasMaxLength(10);
        });

        builder.HasMany(o => o.OrderItems)
            .WithOne()
            .HasForeignKey(oi => oi.OrderId);
    }
}
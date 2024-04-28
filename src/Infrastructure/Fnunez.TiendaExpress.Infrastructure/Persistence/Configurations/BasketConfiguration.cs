using Fnunez.TiendaExpress.Domain.BasketAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fnunez.TiendaExpress.Infrastructure.Persistence.Configurations;

public class BasketConfiguration : IEntityTypeConfiguration<Basket>
{
    public void Configure(EntityTypeBuilder<Basket> builder)
    {
        builder.HasKey(b => b.Id);

        builder.Property(b => b.CustomerId)
            .HasMaxLength(450)
            .IsRequired();

        builder.Property(b => b.PaymentIntentId)
            .HasMaxLength(450)
            .IsRequired();

        builder.Property(b => b.ClientSecret)
            .HasMaxLength(450)
            .IsRequired();

        builder.HasMany(b => b.Items)
            .WithOne()
            .HasForeignKey(bi => bi.BasketId);
    }
}
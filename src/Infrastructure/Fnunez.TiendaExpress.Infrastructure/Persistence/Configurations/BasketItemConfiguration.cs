using Fnunez.TiendaExpress.Domain.BasketAggregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fnunez.TiendaExpress.Infrastructure.Persistence.Configurations;

public class BasketItemConfiguration : IEntityTypeConfiguration<BasketItem>
{
    public void Configure(EntityTypeBuilder<BasketItem> builder)
    {
        builder.HasKey(bi => bi.Id);

        builder.Property(bi => bi.BasketId)
            .HasMaxLength(450)
            .IsRequired();

        builder.Property(bi => bi.ProductId)
            .HasMaxLength(450)
            .IsRequired();

        builder.Property(bi => bi.Price)
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(bi => bi.Quantity)
            .IsRequired();
    }
}
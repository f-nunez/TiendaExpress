using Fnunez.TiendaExpress.Domain.ProductAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fnunez.TiendaExpress.Infrastructure.Persistence.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.CategoryId)
            .HasMaxLength(450)
            .IsRequired();

        builder.Property(p => p.BrandId)
            .HasMaxLength(450)
            .IsRequired();

        builder.Property(p => p.Name)
            .HasMaxLength(250)
            .IsRequired();

        builder.Property(p => p.Description)
            .HasMaxLength(3000)
            .IsRequired();

        builder.Property(p => p.SKU)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(p => p.Price)
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(p => p.PictureUri)
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(p => p.QuantityInStock)
            .IsRequired();

        builder.HasOne(p => p.Category)
            .WithMany()
            .HasForeignKey(p => p.CategoryId);

        builder.HasOne(p => p.Brand)
            .WithMany()
            .HasForeignKey(p => p.BrandId);
    }
}
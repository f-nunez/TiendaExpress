using Fnunez.TiendaExpress.Domain.CustomerAggregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fnunez.TiendaExpress.Infrastructure.Persistence.Configurations;

public class CustomerShippingAddressConfiguration : IEntityTypeConfiguration<CustomerShippingAddress>
{
    public void Configure(EntityTypeBuilder<CustomerShippingAddress> builder)
    {
        builder.HasKey(csa => csa.Id);

        builder.Property(csa => csa.CustomerId)
            .HasMaxLength(450)
            .IsRequired();

        builder.Property(csa => csa.FirstName)
                .HasMaxLength(256)
                .IsRequired();

        builder.Property(csa => csa.LastName)
            .HasMaxLength(256)
            .IsRequired();

        builder.Property(csa => csa.Address)
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(csa => csa.City)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(csa => csa.State)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(csa => csa.Country)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(csa => csa.ZipCode)
            .HasMaxLength(18)
            .IsRequired();

        builder.Property(csa => csa.PhoneCountryCode)
            .HasMaxLength(10)
            .IsRequired();

        builder.Property(csa => csa.PhoneNumber)
            .HasMaxLength(16)
            .IsRequired();

        builder.Property(csa => csa.PhoneExtension)
            .HasMaxLength(10);
    }
}
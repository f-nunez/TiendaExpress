using Fnunez.TiendaExpress.Domain.CustomerAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fnunez.TiendaExpress.Infrastructure.Persistence.Configurations;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.IdentityId)
            .HasMaxLength(450)
            .IsRequired();

        builder.Property(c => c.FirstName)
                .HasMaxLength(256)
                .IsRequired();

        builder.Property(c => c.LastName)
            .HasMaxLength(256)
            .IsRequired();

        builder.Property(c => c.Email)
            .HasMaxLength(256)
            .IsRequired();

        builder.HasMany(c => c.PaymentMethods)
            .WithOne()
            .HasForeignKey(pm => pm.CustomerId);

        builder.HasMany(c => c.ShippingAddresses)
            .WithOne()
            .HasForeignKey(pm => pm.CustomerId);
    }
}
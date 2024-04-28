using Fnunez.TiendaExpress.Domain.CustomerAggregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fnunez.TiendaExpress.Infrastructure.Persistence.Configurations;

public class CustomerPaymentMethodConfiguration : IEntityTypeConfiguration<CustomerPaymentMethod>
{
    public void Configure(EntityTypeBuilder<CustomerPaymentMethod> builder)
    {
        builder.HasKey(cpm => cpm.Id);

        builder.Property(cpm => cpm.Alias)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(cpm => cpm.CardId)
            .HasMaxLength(450)
            .IsRequired();

        builder.Property(cpm => cpm.LastCardNumbers)
            .HasMaxLength(4)
            .IsRequired();
    }
}
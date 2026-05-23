using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Orders.Web.Entities;

namespace Orders.Web.Data.EntityTypeConfiguration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(result => result.Id);
            builder.Property(o => o.OrderNum).ValueGeneratedOnAdd();
            builder.Property(o => o.SenderCity).HasMaxLength(100).IsRequired();
            builder.Property(o => o.SenderAddress).HasMaxLength(500).IsRequired();
            builder.Property(o => o.RecipientCity).HasMaxLength(100).IsRequired();
            builder.Property(o => o.RecipientAddress).HasMaxLength(500).IsRequired();
            builder.Property(o => o.CargoWeightKg).HasPrecision(18, 2);
        }
    }
}

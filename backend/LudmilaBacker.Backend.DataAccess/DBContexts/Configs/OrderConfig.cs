using LudmilaBacker.Backend.DataAccess.Models;
using LudmilaBacker.Backend.DataAccess.Models.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LudmilaBacker.Backend.DataAccess.DBContexts.Configs;

public class OrderConfig : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(order => order.Id);

        builder.HasOne<PaymentDetails>(order => order.PaymentDetails);

        builder.HasMany<OrderProduct>(order => order.OrderProducts);
    }
}
using LudmilaBacker.Backend.DataAccess.Models;
using LudmilaBacker.Backend.DataAccess.Models.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LudmilaBacker.Backend.DataAccess.DBContexts.Configs;

public class OrderProductConfig : IEntityTypeConfiguration<OrderProduct>
{
    public void Configure(EntityTypeBuilder<OrderProduct> builder)
    {
        builder.HasKey(product => product.Id);

        builder
            .HasOne<Order>(product => product.Order)
            .WithMany(order => order.OrderProducts);

        builder.HasOne<Product>(orderProduct => orderProduct.Product);
    }
}
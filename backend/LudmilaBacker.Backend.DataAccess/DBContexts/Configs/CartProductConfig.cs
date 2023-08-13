using LudmilaBacker.Backend.DataAccess.Models;
using LudmilaBacker.Backend.DataAccess.Models.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LudmilaBacker.Backend.DataAccess.DBContexts.Configs;

public class CartProductConfig : IEntityTypeConfiguration<CartProduct>
{
    public void Configure(EntityTypeBuilder<CartProduct> builder)
    {
        builder.HasKey(product => product.Id);

        builder
            .HasOne<Cart>(product => product.Cart)
            .WithMany(cart => cart.CartProducts);

        builder.HasOne<Product>(cartProduct => cartProduct.Product);
    }
}
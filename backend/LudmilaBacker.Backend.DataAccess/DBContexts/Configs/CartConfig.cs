using LudmilaBacker.Backend.DataAccess.Models;
using LudmilaBacker.Backend.DataAccess.Models.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LudmilaBacker.Backend.DataAccess.DBContexts.Configs;

public class CartConfig : IEntityTypeConfiguration<Cart>
{
    public void Configure(EntityTypeBuilder<Cart> builder)
    {
        builder.HasKey(cart => cart.Id);

        builder.HasMany<CartProduct>(cart => cart.CartProducts);
    }
}
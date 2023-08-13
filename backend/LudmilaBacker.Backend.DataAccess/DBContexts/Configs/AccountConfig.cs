using LudmilaBacker.Backend.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LudmilaBacker.Backend.DataAccess.DBContexts.Configs;

public class AccountConfig : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.HasKey(account => account.Id);

        builder.HasOne<Cart>(account => account.Cart);

        builder.HasMany<Order>(account => account.Orders);
    }
}
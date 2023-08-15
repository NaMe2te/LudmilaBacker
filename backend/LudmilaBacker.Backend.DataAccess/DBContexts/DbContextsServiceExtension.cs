using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace LudmilaBacker.Backend.DataAccess.DBContexts;

public static class DbContextsServiceExtension
{
    public static IServiceCollection AddDatabaseContext(this IServiceCollection collection,
        Action<DbContextOptionsBuilder> options)
    {
        collection.AddDbContext<DatabaseContext>(options);
        return collection;
    }
}
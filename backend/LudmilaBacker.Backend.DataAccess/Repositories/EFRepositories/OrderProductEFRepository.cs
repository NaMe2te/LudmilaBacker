using LudmilaBacker.Backend.DataAccess.DBContexts;
using LudmilaBacker.Backend.DataAccess.Models.Products;

namespace LudmilaBacker.Backend.DataAccess.Repositories.EFRepositories;

public class OrderProductEFRepository : BaseRepository<OrderProduct>
{
    public OrderProductEFRepository(DatabaseContext databaseContext) 
        : base(databaseContext)
    {
    }
}
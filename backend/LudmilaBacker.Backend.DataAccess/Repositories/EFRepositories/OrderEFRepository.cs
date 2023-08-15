using LudmilaBacker.Backend.DataAccess.DBContexts;
using LudmilaBacker.Backend.DataAccess.Models;

namespace LudmilaBacker.Backend.DataAccess.Repositories.EFRepositories;

public class OrderEFRepository : BaseRepository<Order>
{
    public OrderEFRepository(DatabaseContext databaseContext) 
        : base(databaseContext)
    {
    }
}
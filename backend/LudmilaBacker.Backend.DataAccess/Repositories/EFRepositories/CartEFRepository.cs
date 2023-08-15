using LudmilaBacker.Backend.DataAccess.DBContexts;
using LudmilaBacker.Backend.DataAccess.Models;

namespace LudmilaBacker.Backend.DataAccess.Repositories.EFRepositories;

public class CartEFRepository : BaseRepository<Cart>
{
    public CartEFRepository(DatabaseContext databaseContext) 
        : base(databaseContext)
    {
    }
}
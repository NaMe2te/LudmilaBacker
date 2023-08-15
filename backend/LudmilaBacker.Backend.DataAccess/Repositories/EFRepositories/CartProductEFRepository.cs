using LudmilaBacker.Backend.DataAccess.DBContexts;
using LudmilaBacker.Backend.DataAccess.Models.Products;

namespace LudmilaBacker.Backend.DataAccess.Repositories.EFRepositories;

public class CartProductEFRepository : BaseRepository<CartProduct>
{
    public CartProductEFRepository(DatabaseContext databaseContext) 
        : base(databaseContext)
    {
    }
}
using LudmilaBacker.Backend.DataAccess.DBContexts;
using LudmilaBacker.Backend.DataAccess.Models.Products;

namespace LudmilaBacker.Backend.DataAccess.Repositories.EFRepositories;

public class ProductEFRepository : BaseRepository<Product>
{
    public ProductEFRepository(DatabaseContext databaseContext) 
        : base(databaseContext)
    {
    }
}
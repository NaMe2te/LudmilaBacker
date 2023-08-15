using LudmilaBacker.Backend.DataAccess.DBContexts;
using LudmilaBacker.Backend.DataAccess.Models;

namespace LudmilaBacker.Backend.DataAccess.Repositories.EFRepositories;

public class AccountEFRepository : BaseRepository<Account>
{
    public AccountEFRepository(DatabaseContext databaseContext) 
        : base(databaseContext)
    {
    }
}
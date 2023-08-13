using LudmilaBacker.Backend.DataAccess.DBContexts;

namespace LudmilaBacker.Backend.DataAccess.Repositories;

public class BaseRepository<TModel, TId> : IBaseRepository<TModel, TId>
{
    private readonly DatabaseContext _databaseContext;

    public BaseRepository(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
    }
}
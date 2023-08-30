using System.Linq.Expressions;
using LudmilaBacker.Backend.DataAccess.DBContexts;
using Microsoft.EntityFrameworkCore;

namespace LudmilaBacker.Backend.DataAccess.Repositories;

public class BaseRepository<TModel> : IBaseRepository<TModel> where TModel : class
{
    protected readonly DatabaseContext _databaseContext;

    public BaseRepository(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
    }

    public TModel Add(TModel model)
    {
        return _databaseContext.Set<TModel>().Add(model).Entity;
    }

    public async Task<TModel> AddAsync(TModel model)
    {
        return (await _databaseContext.Set<TModel>().AddAsync(model)).Entity;
    }

    public TModel Update(TModel model)
    {
        return _databaseContext.Set<TModel>().Update(model).Entity;
    }

    public void Delete(TModel model)
    {
        _databaseContext.Set<TModel>().Remove(model);
    }

    public TModel Get(Expression<Func<TModel, bool>> predicate)
    {
        return _databaseContext.Set<TModel>().First(predicate);
    }

    public Task<TModel> GetAsync(Expression<Func<TModel, bool>> predicate)
    {
        return _databaseContext.Set<TModel>().FirstAsync(predicate);
    }

    public IQueryable<TModel> GetAll()
    {
        return _databaseContext.Set<TModel>();
    }

    public async Task<IQueryable<TModel>> GetAllAsync()
    {
        var models = _databaseContext.Set<TModel>();
        return await Task.FromResult(models);
    }

    public IQueryable<TModel> GetAll(Expression<Func<TModel, bool>> predicate)
    {
        return _databaseContext.Set<TModel>().Where(predicate);
    }
}
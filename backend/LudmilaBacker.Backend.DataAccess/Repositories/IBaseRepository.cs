using System.Linq.Expressions;

namespace LudmilaBacker.Backend.DataAccess.Repositories;

public interface IBaseRepository<TModel>
{
    TModel Add(TModel model);
    Task<TModel> AddAsync(TModel model);

    TModel Update(TModel model);

    void Delete(TModel model);
    
    TModel Get(Expression<Func<TModel, bool>> predicate);
    Task<TModel> GetAsync(Expression<Func<TModel, bool>> predicate);
    
    IEnumerable<TModel> GetAll();
    Task<IEnumerable<TModel>> GetAllAsync();
    IEnumerable<TModel> GetAll(Expression<Func<TModel, bool>> predicate);
}
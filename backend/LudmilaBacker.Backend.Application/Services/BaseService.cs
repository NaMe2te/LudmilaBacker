using System.Linq.Expressions;
using LudmilaBacker.Backend.DataAccess.Repositories;

namespace LudmilaBacker.Backend.Application.Services;

public class BaseService<TModel, TDto> : IBaseService<TModel, TDto>
    where TModel : class where TDto : class
{
    protected readonly IBaseRepository<TModel> _repository;

    public BaseService(IBaseRepository<TModel> repository)
    {
        _repository = repository;
    }

    public Task<TDto> AddAsync(TDto dto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<TDto> UpdateAsync(TDto dtos)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<TDto> GetAll(Expression<Func<TDto, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public Task<TDto> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<TDto> GetFirstAsync(Expression<Func<TDto, bool>> expression)
    {
        throw new NotImplementedException();
    }
}
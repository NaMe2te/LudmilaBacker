using System.Linq.Expressions;

namespace LudmilaBacker.Backend.Application.Services;

public interface IBaseService<TModel, TDto> where TModel : class where TDto : class 
{
    Task<TDto> AddAsync(TDto dto);
    Task DeleteAsync(Guid id);
    Task<TDto> UpdateAsync(TDto dtos);

    IEnumerable<TDto> GetAll(Expression<Func<TDto, bool>> expression);
    Task<TDto> GetByIdAsync(Guid id);
    Task<TDto> GetFirstAsync(Expression<Func<TDto, bool>> expression);
}
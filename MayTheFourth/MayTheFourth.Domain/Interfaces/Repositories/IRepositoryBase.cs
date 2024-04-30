using System.Linq.Expressions;

namespace MayTheFourth.Domain.Interfaces.Repositories;

public interface IRepositoryBase<T>
{
    Task<T?> GetAsync(Expression<Func<T, bool>> filter);
    Task CreateAsync(T entity);
    void Remove(T entity);
    Task SaveAsync();
    Task<IEnumerable<T>> ListAsync(Expression<Func<T, bool>>? filter = null);
}


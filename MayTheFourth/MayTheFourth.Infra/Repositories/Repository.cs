using MayTheFourth.Domain.Interfaces.Repositories;
using MayTheFourth.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MayTheFourth.Infra.Repositories;

public class Repository<T> : IRepositoryBase<T> where T : class
{
    private readonly MayTheFourthDataContext _context;
    internal DbSet<T> _dbSet;

    public Repository(MayTheFourthDataContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public async Task CreateAsync(T entity) => await _dbSet.AddAsync(entity);
    public async Task<T?> GetAsync(Expression<Func<T, bool>> filter) => await _dbSet.FirstOrDefaultAsync(filter);
    public void Remove(T entity) =>  _dbSet.Remove(entity);   
    public async Task SaveAsync() => await _context.SaveChangesAsync();
    public async Task<IEnumerable<T>> ListAsync(Expression<Func<T, bool>>? filter = null)
    {
        IQueryable<T> query = _dbSet;

        if (filter != null)
        {
            query = query.Where(filter);
        }

        return await query.ToListAsync();
    }
}

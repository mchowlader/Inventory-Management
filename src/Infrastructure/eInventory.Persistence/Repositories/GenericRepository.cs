using eInventory.Application.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;

namespace eInventory.Persistence.Repositories;

public class GenericRepository<T>(InventoryDbContext dbContext)
    : IGenericRepository<T> where T : class
{
    private readonly InventoryDbContext _dbContext = dbContext;

    public async Task<T> AddAsync(T entity, CancellationToken cancellationToken = default)
    {
        await _dbContext.Set<T>().AddAsync(entity, cancellationToken)
            .ConfigureAwait(false);

        await _dbContext.SaveChangesAsync(cancellationToken)
            .ConfigureAwait(false);

        return entity;
    }

    public async Task DeleteAsync(T entity, CancellationToken cancellationToken = default)
    {
        _dbContext.Set<T>().Remove(entity);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task<bool> ExitsAsync(long id, CancellationToken cancellationToken = default)
    {
        var entity = await GetAsync(id, cancellationToken).ConfigureAwait(false);
        return entity != null;
    }

    public async Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await _dbContext.Set<T>()
            .ToListAsync(cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<T?> GetAsync(long id, CancellationToken cancellationToken = default)
    {
        var entity = await _dbContext.Set<T>()
           .FindAsync(id, cancellationToken)
           .ConfigureAwait(false);

        return entity;
    }

    public async Task UpdateAsync(T entity, CancellationToken cancellationToken = default)
    {
        _dbContext.Entry(entity).State = EntityState.Modified;
        await _dbContext.SaveChangesAsync(cancellationToken)
            .ConfigureAwait(false);
    }
}
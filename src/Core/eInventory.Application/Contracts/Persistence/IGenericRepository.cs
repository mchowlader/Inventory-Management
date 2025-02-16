namespace eInventory.Application.Contracts.Persistence;

public interface IGenericRepository<T> where T: class 
{
    Task<T?> GetAsync(long id, CancellationToken cancellationToken);
    Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken);
    Task<T> AddAsync(T entity, CancellationToken cancellationToken);
    Task UpdateAsync(T entity, CancellationToken cancellationToken);
    Task DeleteAsync(T entity, CancellationToken cancellationToken);
    Task<bool> ExitsAsync(long id, CancellationToken cancellationToken);
}

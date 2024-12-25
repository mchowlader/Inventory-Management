namespace eInventory.Domain.Entities;

public interface IGenericRepository<T> where T: class 
{
    Task<T> GetAsync(int id, CancellationToken cancellationToken);
    Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken);
    Task<T> AddAsync(T entity, CancellationToken cancellationToken);
    Task<T> UpdateAsync(T entity, CancellationToken cancellationToken);
    Task<T> DeleteAsync(int id, CancellationToken cancellationToken);
}

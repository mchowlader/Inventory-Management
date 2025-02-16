using eInventory.Application.Contracts.Persistence;
using eInventory.Domain.Entities;

namespace eInventory.Persistence.Repositories;

public class ProductRepository(InventoryDbContext dbContext)
    : GenericRepository<Product>(dbContext), IProductRepository
{
    private readonly InventoryDbContext _dbContext = dbContext;
}

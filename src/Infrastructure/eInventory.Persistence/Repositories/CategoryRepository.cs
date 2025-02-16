using eInventory.Application.Contracts.Persistence;
using eInventory.Domain.Entities;

namespace eInventory.Persistence.Repositories;

public class CategoryRepository(InventoryDbContext dbContext)
    : GenericRepository<Category>(dbContext), ICategoryRepository
{
    private readonly InventoryDbContext _dbContext = dbContext;
}
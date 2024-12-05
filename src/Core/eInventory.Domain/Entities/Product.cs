using eInventory.Domain.Common;

namespace eInventory.Domain.Entities;

public class Product : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public double Price { get; set; }
    public Category Category { get; set; } = new();
}

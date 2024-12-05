using eInventory.Domain.Common;

namespace eInventory.Domain.Entities;

public class Category : BaseEntity
{
    public string Name { get; set; } = string.Empty;
}

using eInventory.Application.DTOs.Category;
using eInventory.Application.DTOs.Common;

namespace eInventory.Application.DTOs.Product;

public class UpdateProductDTO : BaseDTO, IProductDTO
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public double Price { get; set; }
    public required CategoryDTO Category { get; set; }
    public long? CreateBy { get; set; }
    public DateTime? CreatedDate { get; set; }
    public long? UpdateBy { get; set; }
    public DateTime? UpdateDate { get; set; }
    public long CategoryId { get; set; }
}

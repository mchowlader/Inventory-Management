using eInventory.Application.DTOs.Common;

namespace eInventory.Application.DTOs.ProductDTO;

public class ProductListDTO : BaseDTO
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public double Price { get; set; }
    public CategoryDTO Category { get; set; } = new();
    public long? CreateBy { get; set; }
    public DateTime? CreatedDate { get; set; }
    public long? UpdateBy { get; set; }
    public DateTime? UpdateDate { get; set; }
}

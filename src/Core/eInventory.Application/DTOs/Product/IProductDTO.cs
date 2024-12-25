using eInventory.Application.DTOs.Category;

namespace eInventory.Application.DTOs.Product;

public interface IProductDTO
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public double Price { get; set; }
    public long CategoryId { get; set; }
    public CategoryDTO Category { get; set; }
    public long? CreateBy { get; set; }
    public DateTime? CreatedDate { get; set; }
    public long? UpdateBy { get; set; }
    public DateTime? UpdateDate { get; set; }
}

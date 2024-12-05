namespace eInventory.Domain.Common;

public class BaseEntity
{
    public long Id { get; set; }
    public  long? CreateBy { get; set; }
    public DateTime? CreatedDate { get; set; }
    public  long? UpdateBy { get; set; }
    public DateTime? UpdateDate { get; set; }
}

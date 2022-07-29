namespace Core.Entities;

public interface IDto
{
    public EnumIsDeleted? IsDeleted { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? ModifiedAt { get; set; }
}

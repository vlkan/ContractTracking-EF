namespace Core.Entities.Concrete;

public class OperationClaim : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public DateTime? ModifiedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int IsDeleted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}

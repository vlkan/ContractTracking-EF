using Core.Entities;

namespace Entities.DTOs;

public class UserForRegisterDto : IDto
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Id { get; set; }
    public EnumIsDeleted IsDeleted { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
}

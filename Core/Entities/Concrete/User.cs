using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete;

public class User : IEntity
{
    public DateTime CreatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public DateTime? ModifiedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int IsDeleted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }
    public bool Status { get; set; }
}

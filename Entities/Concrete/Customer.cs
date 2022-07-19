using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete;

public class Customer : IEntity
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public int Type { get; set; }
    public string? Phone { get; set; }
    public int IsDeleted { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? ModifiedAt { get; set; }
}

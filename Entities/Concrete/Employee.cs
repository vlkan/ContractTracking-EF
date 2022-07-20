using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete;

public class Employee : IEntity
{
    public int EmployeeId { get; set; }
    public string NameSurname { get; set; }
    public string EmployeeEmail { get; set; }
    public string JobTitle { get; set; }
    public DateTime? StartDate { get; set; }
}

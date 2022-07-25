using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete;

[Keyless]
public class WorkList : IEntity
{
    public int Id { get; set; }
    public string EmployeeName { get; set; }
    public string EmployeeSurname { get; set; }
    public string ProjectName { get; set; }
    public int NumberOfDaysWorked { get; set; }
    public DateTime? WorkingDate { get; set; }
    public int IsDeleted { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? ModifiedAt { get; set; }
}

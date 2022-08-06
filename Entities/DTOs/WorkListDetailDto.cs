using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs;

public class WorkListDetailDto : IDto
{
    public int Id { get; set; }
    public string EmployeeName { get; set; }
    public string EmployeeSurName { get; set; }
    public string ProjectName { get; set; }
    public int WorkingHours { get; set; }
    public DateTime? WorkingDate { get; set; }
    public EnumIsDeleted? IsDeleted { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? ModifiedAt { get; set; }
}

using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs;

public class CustomerDetailDto : IDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public DateTime CreateAt { get; set; }
    public string ProjectName { get; set; }
    public string ProjectType { get; set; }
    public string ProjectDescription { get; set; }
    public decimal? ContractBudget { get; set; }
    public int? ContractTerm { get; set; }
    public DateTime? ContractStartDate { get; set; }
    public EnumIsDeleted IsDeleted { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
}

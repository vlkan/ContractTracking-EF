using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete;

[Keyless]
public class Payment : IEntity
{
    public string EmployeeNameSurname { get; set; }
    public string ProjectName { get; set; }
    public Decimal FeePaid { get; set; }
    public Decimal RemainingBudget { get; set; }
    public string PaymentDescription { get; set; }
}

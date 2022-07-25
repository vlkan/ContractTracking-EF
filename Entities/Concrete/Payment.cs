using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete;

[Keyless]
public class Payment : IEntity
{
    public string EmployeeNameSurname { get; set; }
    public string ProjectName { get; set; }
    [Column(TypeName = "money")]
    public Decimal FeePaid { get; set; }
    [Column(TypeName = "money")]
    public Decimal RemainingBudget { get; set; }
    public string PaymentDescription { get; set; }
}

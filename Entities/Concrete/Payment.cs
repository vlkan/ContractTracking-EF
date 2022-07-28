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
    public int Id { get; set; }
    public string EmployeeName { get; set; }
    public string EmployeeSurname { get; set; }
    public string ProjectName { get; set; }
    [Column(TypeName = "money")]
    public Decimal FeePaid { get; set; }
    [Column(TypeName = "money")]
    public Decimal RemainingBudget { get; set; }
    public string PaymentDescription { get; set; }
    public int IsDeleted { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }

}

using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete;

public class Project : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public string Description { get; set; }
    public decimal? ContractBudget { get; set; }
    public int? ContractTerm { get; set; }
    public DateTime? ContractStartDate { get; set; }
    public int? WorkerDay { get; set; }
    public int? WorkerHour { get; set; }
}

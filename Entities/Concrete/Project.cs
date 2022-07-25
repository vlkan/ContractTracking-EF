using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete;

public class Project : IEntity
{
    public int ProjectId { get; set; }
    public string ProjectName { get; set; }
    public string ProjectType { get; set; }
    public string ProjectOwner { get; set; }
    public string ProjectDescription { get; set; }
    [Column(TypeName = "money")]
    public decimal? ContractBudget { get; set; }
    public int? ContractTerm { get; set; }
    public DateTime? ContractStartDate { get; set; }
    public int? WorkerDay { get; set; }
    public int? WorkerHour { get; set; }
}

﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete;

public class Project : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ProjectType Type { get; set; }
    public string SubType { get; set; }
    public int EmployeeOwnerId { get; set; }
    public int CustomerOwnerId { get; set; }
    public string Description { get; set; }
    public int? ContractBudget { get; set; }
    public CurrencyTypeE? CurrencyType { get; set; }
    public int? ContractTerm { get; set; }
    public DateTime? ContractStartDate { get; set; }
    public int? WorkerDay { get; set; }
    public int? WorkerHour { get; set; }
    public EnumIsDeleted? IsDeleted { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? ModifiedAt { get; set; }

}

public enum ProjectType 
{
    System = 1,
    Software = 2,
    SystemAndSoftware = 3,
}

public enum CurrencyTypeE
{
    TurkishLira = 1,
    Dollar = 2,
    Euro = 3,
    Pound = 4,
}
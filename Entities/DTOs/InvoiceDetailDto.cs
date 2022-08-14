using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs;

public class InvoiceDetailDto : IDto
{
    public int Id { get; set; }
    public string ProjectName { get; set; }
    public Decimal FeePaid { get; set; }
    public string Description { get; set; }
    public DateTime TransactionDate { get; set; }
    public EnumIsDeleted? IsDeleted { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? ModifiedAt { get; set; }
}

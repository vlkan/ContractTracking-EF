using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework;

public class EfInvoicingDal : EfEntityRepositoryBase<Invoice, ContractTrackingContext>, IInvoicingDal
{
    public List<InvoiceDetailDto> GetInvoiceDetails()
    {
        using (ContractTrackingContext context = new ContractTrackingContext())
        {
            var result = from i in context.Invoicings
                         join p in context.Projects on i.ProjectId equals p.Id
                         select new InvoiceDetailDto
                         {
                             Id = i.Id,
                             ProjectName = p.Name,
                             FeePaid = i.FeePaid,
                             Description = i.Description,
                             TransactionDate = i.TransactionDate,
                             IsDeleted = i.IsDeleted,
                             CreatedAt = i.CreatedAt,
                             ModifiedAt = i.ModifiedAt,
                         };
            return result.ToList();
        }
    }

    public List<InvoiceDetailDto> SearchDateRange(DateTime start, DateTime end)
    {
        using (ContractTrackingContext context = new ContractTrackingContext())
        {
            var result = from i in context.Invoicings
                         join p in context.Projects on i.ProjectId equals p.Id
                         select new InvoiceDetailDto
                         {
                             Id = i.Id,
                             ProjectName = p.Name,
                             FeePaid = i.FeePaid,
                             Description = i.Description,
                             TransactionDate = i.TransactionDate,
                             IsDeleted = i.IsDeleted,
                             CreatedAt = i.CreatedAt,
                             ModifiedAt = i.ModifiedAt,
                         };
            return result.Where(i => i.TransactionDate >= start && i.TransactionDate <= end).ToList();
        }
    }
}

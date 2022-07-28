using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework;

public class EfCustomerDal : EfEntityRepositoryBase<Customer, ContractTrackingContext>, ICustomerDal
{
    public List<CustomerDetailDto> GetCustomerDetails()
    {
        using (ContractTrackingContext context = new ContractTrackingContext())
        {
            var result = from c in context.Customers
                         join p in context.Projects
                         on c.Id equals p.CustomerOwnerId
                         select new CustomerDetailDto 
                         { 
                             Id = c.Id, Email = c.Email, Phone = c.Phone, CreateAt = c.CreatedAt,
                             ProjectName = p.Name, ProjectType = p.Type, ProjectDescription = p.Description,
                             ContractBudget = p.ContractBudget, ContractTerm = p.ContractTerm, ContractStartDate = p.ContractStartDate
                         };
            return result.ToList();
        }
    }
}

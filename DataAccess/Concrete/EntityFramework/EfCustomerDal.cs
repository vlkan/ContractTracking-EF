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

public class EfCustomerDal : EfEntityRepositoryBase<Customer, ProjectAndEmployeeTrackContext>, ICustomerDal
{
    public List<CustomerDetailDto> GetCustomerDetails()
    {
        using (ProjectAndEmployeeTrackContext context = new ProjectAndEmployeeTrackContext())
        {
            var result = from c in context.Customers
                         join p in context.Projects
                         on c.Name equals p.ProjectOwner
                         select new CustomerDetailDto 
                         { 
                             Name = c.Name, Email = c.Email, Phone = c.Phone, CreateAt = c.CreatedAt,
                             ProjectName = p.ProjectName, ProjectType = p.ProjectType, ProjectDescription = p.ProjectDescription,
                             ContractBudget = p.ContractBudget, ContractTerm = p.ContractTerm, ContractStartDate = p.ContractStartDate
                         };
            return result.ToList();
        }
    }
}

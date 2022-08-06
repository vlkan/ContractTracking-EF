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

public class EfProjectDal : EfEntityRepositoryBase<Project, ContractTrackingContext>, IProjectDal
{
    public List<ProjectDetailDto> GetProjectDetails() 
    {
        using (ContractTrackingContext context = new ContractTrackingContext())
        {
            var result = from p in context.Projects
                         join c in context.Customers on p.CustomerOwnerId equals c.Id
                         join e in context.Employees on p.EmployeeOwnerId equals e.Id
                         select new ProjectDetailDto
                         {
                             Id = p.Id, Name = p.Name, Type = (Entities.DTOs.ProjectType)p.Type, SubType = p.SubType,
                             EmployeeOwnerName = e.Name, EmployeeOwnerSurName = e.Surname, CustomerOwnerName = c.Name,
                             Description = p.Description, ContractBudget = p.ContractBudget, CurrencyType = (Entities.DTOs.CurrencyTypeE)p.CurrencyType,
                             ContractTerm = p.ContractTerm, ContractStartDate = p.ContractStartDate, WorkerDay = p.WorkerDay, WorkerHour = p.WorkerHour,
                             RemainingContractBudget = p.RemainingContractBudget, RemainingWorkerHour = p.RemainingWorkerHour,
                             IsDeleted = p.IsDeleted, CreatedAt = p.CreatedAt, ModifiedAt = p.ModifiedAt,

                         };
            return result.ToList();
        }
    }
}

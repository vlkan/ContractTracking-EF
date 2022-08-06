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

public class EfWorkListDal : EfEntityRepositoryBase<WorkList, ContractTrackingContext>, IWorkListDal
{
    public List<WorkListDetailDto> GetWorkListDetails() 
    {
        using (ContractTrackingContext context = new ContractTrackingContext()) 
        {
            var result = from w in context.WorkLists
                         join e in context.Employees on w.EmployeeId equals e.Id
                         join p in context.Projects on w.ProjectId equals p.Id
                         select new WorkListDetailDto
                         {
                             Id = w.Id,
                             EmployeeName = e.Name,
                             EmployeeSurName = e.Surname,
                             ProjectName = p.Name,
                             WorkingHours = w.WorkingHours,
                             WorkingDate = w.WorkingDate,
                             IsDeleted = w.IsDeleted,
                             CreatedAt = w.CreatedAt,
                             ModifiedAt = w.ModifiedAt,
                         };
            return result.ToList();
        }
    }
}

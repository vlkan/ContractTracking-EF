using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework;

public class EfProjectDal : IProjectDal
{
    public void Add(Project entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Project entity)
    {
        throw new NotImplementedException();
    }

    public Project Get(Expression<Func<Project, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public List<Project> GetAll(Expression<Func<Project, bool>> filter = null)
    {
        throw new NotImplementedException();
    }

    public void Update(Project entity)
    {
        throw new NotImplementedException();
    }
}

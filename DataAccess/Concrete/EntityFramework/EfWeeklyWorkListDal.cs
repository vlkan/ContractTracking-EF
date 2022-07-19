using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfWeeklyWorkListDal : IWeeklyWorkListDal
    {
        public void Add(WeeklyWorkList entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(WeeklyWorkList entity)
        {
            throw new NotImplementedException();
        }

        public WeeklyWorkList Get(Expression<Func<WeeklyWorkList, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<WeeklyWorkList> GetAll(Expression<Func<WeeklyWorkList, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(WeeklyWorkList entity)
        {
            throw new NotImplementedException();
        }
    }
}

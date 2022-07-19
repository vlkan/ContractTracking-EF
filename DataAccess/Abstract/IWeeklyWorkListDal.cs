using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IWeeklyWorkListDal
    {
        List<WeeklyWorkList> GetAll();
        void Add(WeeklyWorkList weeklyWorkList);
        void Delete(WeeklyWorkList weeklyWorkList);
        void Update(WeeklyWorkList weeklyWorkList);
    }
}

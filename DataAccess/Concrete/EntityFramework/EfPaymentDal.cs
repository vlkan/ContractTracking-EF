using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPaymentDal : IPaymentDal
    {
        public void Add(IPaymentDal entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IPaymentDal entity)
        {
            throw new NotImplementedException();
        }

        public IPaymentDal Get(Expression<Func<IPaymentDal, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<IPaymentDal> GetAll(Expression<Func<IPaymentDal, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(IPaymentDal entity)
        {
            throw new NotImplementedException();
        }
    }
}

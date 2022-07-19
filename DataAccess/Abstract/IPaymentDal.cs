using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IPaymentDal
    {
        List<Payment> GetAll();
        List<Payment> GetAllByProjectName(string name);
        List<Payment> GetAllByEmployeeName(string name);
        void Add(Payment payment);
        void Update(Payment payment);
        void Delete(Payment payment);
    }
}
